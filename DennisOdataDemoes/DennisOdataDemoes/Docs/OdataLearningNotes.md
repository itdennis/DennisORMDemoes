### 什么是EDM？
An EDM is an abstract model of the data. 
The EDM is used to create the service metadata document. The ODataConventionModelBuilder class creates an EDM by using default naming conventions. 
This approach requires the least code. If you want more control over the EDM, you can use the ODataModelBuilder class to create the EDM by adding properties, keys, and navigation properties explicitly.
If your application has multiple OData endpoints, `create a separate route for each. Give each route a unique route name and prefix.`

### Odata Controller
A controller is a class that handles HTTP requests. You create a separate controller for each entity set in your OData service.
The controller uses the `ProductsContext` class to access the database using EF. 
Notice that the controller overrides the `Dispose` method to dispose of the ProductsContext.

### [EnableQuery] attribute
The [EnableQuery] attribute enables clients to modify the query, by using query options such as $filter, $sort, and $page. 
For more information, see Supporting [OData Query Options](https://docs.microsoft.com/en-us/aspnet/web-api/overview/odata-support-in-aspnet-web-api/supporting-odata-query-options).

### Updating an Entity
OData supports two different semantics for updating an entity, PATCH and PUT.

- PATCH performs a partial update. The client specifies just the properties to update.
- PUT replaces the entire entity.

The disadvantage of PUT is that the client must send values for all of the properties in the entity, including values that are not changing. 
The OData spec states that PATCH is preferred.

### EDM Security
You can exclude a property from the EDM and it will not be visible to the query. For example, suppose your model includes an Employee type with a Salary property. 
You might want to exclude this property from the EDM to hide it from clients.
There are two ways to exlude a property from the EDM. 
- You can set the `[IgnoreDataMember]` attribute on the property in the model class:
```csharp
public class Employee
{
    public string Name { get; set; }
    public string Title { get; set; }
    [IgnoreDataMember]
    public decimal Salary { get; set; } // Not visible in the EDM
}
```
- You can also remove the property from the EDM programmatically:
```csharp
var employees = modelBuilder.EntitySet<Employee>("Employees");
employees.EntityType.Ignore(emp => emp.Salary);
```

### Query Security
The [Queryable] attribute is an action filter that parses, validates, and applies the query. 
For more information about using OData query options in ASP.NET Web API, see Supporting [OData Query Options](https://docs.microsoft.com/en-us/aspnet/web-api/overview/odata-support-in-aspnet-web-api/supporting-odata-query-options).
If you know that all clients are trusted (for example, in an enterprise environment), or if your dataset is small, query performance might not be an issue. 
Otherwise, you should consider the following recommendations.
- Test your service with various queries and profile the DB.
- Enable server-driven paging, to avoid returning a large data set in one query. For more information, see [Server-Driven Paging](https://docs.microsoft.com/en-us/aspnet/web-api/overview/odata-support-in-aspnet-web-api/supporting-odata-query-options#server-paging).
```
// Enable server-driven paging.
[Queryable(PageSize=10)]
```
- Do you need $filter and $orderby? Some applications might allow client paging, using $top and $skip, but disable the other query options.
```
// Allow client paging but no other query options.
[Queryable(AllowedQueryOptions=AllowedQueryOptions.Skip | 
                               AllowedQueryOptions.Top)]
```
- Consider restricting $orderby to properties in a clustered index. Sorting large data without a clustered index is slow.
```
// Set the allowed $orderby properties.
[Queryable(AllowedOrderByProperties="Id,Name")] // Comma separated list
```
- Maximum node count: The MaxNodeCount property on [Queryable] sets the maximum number nodes allowed in the $filter syntax tree. 
The default value is 100, but you may want to set a lower value, because a large number of nodes can be slow to compile. 
This is particularly true if you are using LINQ to Objects 
(i.e., LINQ queries on a collection in memory, without the use of an intermediate LINQ provider).
```
// Set the maximum node count.
[Queryable(MaxNodeCount=20)]
```
- Consider disabling the any() and all() functions, as these can be slow.
```
// Disable any() and all() functions.
[Queryable(AllowedFunctions= AllowedFunctions.AllFunctions & 
    ~AllowedFunctions.All & ~AllowedFunctions.Any)]
```
- If any string properties contain large strings—for example, a product description or a blog entry—consider disabling the string functions.
```
// Disable string functions.
[Queryable(AllowedFunctions=AllowedFunctions.AllFunctions & 
    ~AllowedFunctions.AllStringFunctions)]
```
- Consider disallowing filtering on navigation properties. Filtering on navigation properties can result in a join, 
which might be slow, depending on your database schema. The following code shows a query validator that prevents filtering on navigation properties. 
For more information about query validators, see[Query Validation](https://docs.microsoft.com/en-us/aspnet/web-api/overview/odata-support-in-aspnet-web-api/supporting-odata-query-options#query-validation).
```
// Validator to prevent filtering on navigation properties.
public class MyFilterQueryValidator : FilterQueryValidator
{
    public override void ValidateNavigationPropertyNode(
        Microsoft.Data.OData.Query.SemanticAst.QueryNode sourceNode, 
        Microsoft.Data.Edm.IEdmNavigationProperty navigationProperty, 
        ODataValidationSettings settings)
    {
        throw new ODataException("No navigation properties");
    }
}
```
- Consider restricting $filter queries by writing a validator that is customized for your database. For example, consider these two queries:
 - All movies with actors whose last name starts with ‘A'.
 - All movies released in 1994.
 Unless movies are indexed by actors, the first query might require the DB engine to scan the entire list of movies. 
 Whereas the second query might be acceptable, assuming movies are indexed by release year.

The following code shows a validator that allows filtering on the "ReleaseYear" and "Title" properties but no other properties.
```csharp
// Validator to restrict which properties can be used in $filter expressions.
public class MyFilterQueryValidator : FilterQueryValidator
{
    static readonly string[] allowedProperties = { "ReleaseYear", "Title" };

    public override void ValidateSingleValuePropertyAccessNode(
        SingleValuePropertyAccessNode propertyAccessNode,
        ODataValidationSettings settings)
    {
        string propertyName = null;
        if (propertyAccessNode != null)
        {
            propertyName = propertyAccessNode.Property.Name;
        }

        if (propertyName != null && !allowedProperties.Contains(propertyName))
        {
            throw new ODataException(
                String.Format("Filter on {0} not allowed", propertyName));
        }
        base.ValidateSingleValuePropertyAccessNode(propertyAccessNode, settings);
    }
}
```
- In general, consider which $filter functions you need. 
If your clients do not need the full expressiveness of $filter, you can limit the allowed functions.