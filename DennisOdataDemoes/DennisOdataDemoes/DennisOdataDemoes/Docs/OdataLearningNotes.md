###什么是EDM？
An EDM is an abstract model of the data. 
The EDM is used to create the service metadata document. The ODataConventionModelBuilder class creates an EDM by using default naming conventions. 
This approach requires the least code. If you want more control over the EDM, you can use the ODataModelBuilder class to create the EDM by adding properties, keys, and navigation properties explicitly.
If your application has multiple OData endpoints, `create a separate route for each. Give each route a unique route name and prefix.`

###Odata Controller
A controller is a class that handles HTTP requests. You create a separate controller for each entity set in your OData service.
The controller uses the `ProductsContext` class to access the database using EF. 
Notice that the controller overrides the `Dispose` method to dispose of the ProductsContext.

###[EnableQuery] attribute
The [EnableQuery] attribute enables clients to modify the query, by using query options such as $filter, $sort, and $page. 
For more information, see Supporting [OData Query Options](https://docs.microsoft.com/en-us/aspnet/web-api/overview/odata-support-in-aspnet-web-api/supporting-odata-query-options).

###Updating an Entity
OData supports two different semantics for updating an entity, PATCH and PUT.

- PATCH performs a partial update. The client specifies just the properties to update.
- PUT replaces the entire entity.

The disadvantage of PUT is that the client must send values for all of the properties in the entity, including values that are not changing. 
The OData spec states that PATCH is preferred.
