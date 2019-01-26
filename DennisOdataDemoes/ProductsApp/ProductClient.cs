//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 1/26/2019 11:15:16 PM
namespace ProductsApp.DennisOdataDemoes
{
    /// <summary>
    /// There are no comments for ProductSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProductSingle")]
    public partial class ProductSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Product>
    {
        /// <summary>
        /// Initialize a new ProductSingle object.
        /// </summary>
        public ProductSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductSingle object.
        /// </summary>
        public ProductSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductSingle object.
        /// </summary>
        public ProductSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Product> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for Product in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Product")]
    public partial class Product : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Product object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        /// <param name="price">Initial value of Price.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
        public static Product CreateProduct(int ID, decimal price)
        {
            Product product = new Product();
            product.Id = ID;
            product.Price = price;
            return product;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Id")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property Price in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Price")]
        public decimal Price
        {
            get
            {
                return this._Price;
            }
            set
            {
                this.OnPriceChanging(value);
                this._Price = value;
                this.OnPriceChanged();
                this.OnPropertyChanged("Price");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
        private decimal _Price;
        partial void OnPriceChanging(decimal value);
        partial void OnPriceChanged();
        /// <summary>
        /// There are no comments for Property Category in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Category")]
        public string Category
        {
            get
            {
                return this._Category;
            }
            set
            {
                this.OnCategoryChanging(value);
                this._Category = value;
                this.OnCategoryChanged();
                this.OnPropertyChanged("Category");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
        private string _Category;
        partial void OnCategoryChanging(string value);
        partial void OnCategoryChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// Class containing all extension methods
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Get an entity of type global::ProductsApp.DennisOdataDemoes.Product as global::ProductsApp.DennisOdataDemoes.ProductSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::ProductsApp.DennisOdataDemoes.ProductSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::ProductsApp.DennisOdataDemoes.Product> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::ProductsApp.DennisOdataDemoes.ProductSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::ProductsApp.DennisOdataDemoes.Product as global::ProductsApp.DennisOdataDemoes.ProductSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::ProductsApp.DennisOdataDemoes.ProductSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::ProductsApp.DennisOdataDemoes.Product> source,
            int id)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::ProductsApp.DennisOdataDemoes.ProductSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
    }
}
namespace ProductsApp.DennisOdataDemoes.Models
{
    /// <summary>
    /// There are no comments for EmployeeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("EmployeeSingle")]
    public partial class EmployeeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Employee>
    {
        /// <summary>
        /// Initialize a new EmployeeSingle object.
        /// </summary>
        public EmployeeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EmployeeSingle object.
        /// </summary>
        public EmployeeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EmployeeSingle object.
        /// </summary>
        public EmployeeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Employee> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for Employee in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Employee")]
    public partial class Employee : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Employee object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
        public static Employee CreateEmployee(int ID)
        {
            Employee employee = new Employee();
            employee.Id = ID;
            return employee;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Id")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// Class containing all extension methods
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Get an entity of type global::ProductsApp.DennisOdataDemoes.Models.Employee as global::ProductsApp.DennisOdataDemoes.Models.EmployeeSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::ProductsApp.DennisOdataDemoes.Models.EmployeeSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::ProductsApp.DennisOdataDemoes.Models.Employee> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::ProductsApp.DennisOdataDemoes.Models.EmployeeSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::ProductsApp.DennisOdataDemoes.Models.Employee as global::ProductsApp.DennisOdataDemoes.Models.EmployeeSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::ProductsApp.DennisOdataDemoes.Models.EmployeeSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::ProductsApp.DennisOdataDemoes.Models.Employee> source,
            int id)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::ProductsApp.DennisOdataDemoes.Models.EmployeeSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
    }
}
namespace ProductsApp.Default
{
    /// <summary>
    /// There are no comments for Container in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("Container")]
    public partial class Container : global::Microsoft.OData.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new Container object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
        public Container(global::System.Uri serviceRoot) : 
                base(serviceRoot, global::Microsoft.OData.Client.ODataProtocolVersion.V4)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
            this.Format.LoadServiceModel = GeneratedEdmModel.GetInstance;
            this.Format.UseJson();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            global::System.Type resolvedType = this.DefaultResolveType(typeName, "DennisOdataDemoes.Models", "ProductsApp.DennisOdataDemoes.Models");
            if ((resolvedType != null))
            {
                return resolvedType;
            }
            resolvedType = this.DefaultResolveType(typeName, "DennisOdataDemoes", "ProductsApp.DennisOdataDemoes");
            if ((resolvedType != null))
            {
                return resolvedType;
            }
            resolvedType = this.DefaultResolveType(typeName, "Default", "ProductsApp.Default");
            if ((resolvedType != null))
            {
                return resolvedType;
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            global::Microsoft.OData.Client.OriginalNameAttribute originalNameAttribute = (global::Microsoft.OData.Client.OriginalNameAttribute)global::System.Linq.Enumerable.SingleOrDefault(global::Microsoft.OData.Client.Utility.GetCustomAttributes(clientType, typeof(global::Microsoft.OData.Client.OriginalNameAttribute), true));
            if (clientType.Namespace.Equals("ProductsApp.DennisOdataDemoes.Models", global::System.StringComparison.Ordinal))
            {
                if (originalNameAttribute != null)
                {
                    return string.Concat("DennisOdataDemoes.Models.", originalNameAttribute.OriginalName);
                }
                return string.Concat("DennisOdataDemoes.Models.", clientType.Name);
            }
            if (clientType.Namespace.Equals("ProductsApp.DennisOdataDemoes", global::System.StringComparison.Ordinal))
            {
                if (originalNameAttribute != null)
                {
                    return string.Concat("DennisOdataDemoes.", originalNameAttribute.OriginalName);
                }
                return string.Concat("DennisOdataDemoes.", clientType.Name);
            }
            if (clientType.Namespace.Equals("ProductsApp.Default", global::System.StringComparison.Ordinal))
            {
                if (originalNameAttribute != null)
                {
                    return string.Concat("Default.", originalNameAttribute.OriginalName);
                }
                return string.Concat("Default.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for Products in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Products")]
        public global::Microsoft.OData.Client.DataServiceQuery<global::ProductsApp.DennisOdataDemoes.Product> Products
        {
            get
            {
                if ((this._Products == null))
                {
                    this._Products = base.CreateQuery<global::ProductsApp.DennisOdataDemoes.Product>("Products");
                }
                return this._Products;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::ProductsApp.DennisOdataDemoes.Product> _Products;
        /// <summary>
        /// There are no comments for Employees in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Employees")]
        public global::Microsoft.OData.Client.DataServiceQuery<global::ProductsApp.DennisOdataDemoes.Models.Employee> Employees
        {
            get
            {
                if ((this._Employees == null))
                {
                    this._Employees = base.CreateQuery<global::ProductsApp.DennisOdataDemoes.Models.Employee>("Employees");
                }
                return this._Employees;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::ProductsApp.DennisOdataDemoes.Models.Employee> _Employees;
        /// <summary>
        /// There are no comments for Products in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
        public void AddToProducts(global::ProductsApp.DennisOdataDemoes.Product product)
        {
            base.AddObject("Products", product);
        }
        /// <summary>
        /// There are no comments for Employees in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
        public void AddToEmployees(global::ProductsApp.DennisOdataDemoes.Models.Employee employee)
        {
            base.AddObject("Employees", employee);
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
        private abstract class GeneratedEdmModel
        {
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
            private static global::Microsoft.OData.Edm.IEdmModel ParsedModel = LoadModelFromString();
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
            private const string Edmx = @"<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""DennisOdataDemoes"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EntityType Name=""Product"">
        <Key>
          <PropertyRef Name=""Id"" />
        </Key>
        <Property Name=""Id"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""Name"" Type=""Edm.String"" />
        <Property Name=""Price"" Type=""Edm.Decimal"" Nullable=""false"" />
        <Property Name=""Category"" Type=""Edm.String"" />
      </EntityType>
    </Schema>
    <Schema Namespace=""DennisOdataDemoes.Models"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EntityType Name=""Employee"">
        <Key>
          <PropertyRef Name=""Id"" />
        </Key>
        <Property Name=""Id"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""Name"" Type=""Edm.String"" />
      </EntityType>
    </Schema>
    <Schema Namespace=""Default"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EntityContainer Name=""Container"">
        <EntitySet Name=""Products"" EntityType=""DennisOdataDemoes.Product"" />
        <EntitySet Name=""Employees"" EntityType=""DennisOdataDemoes.Models.Employee"" />
      </EntityContainer>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
            public static global::Microsoft.OData.Edm.IEdmModel GetInstance()
            {
                return ParsedModel;
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
            private static global::Microsoft.OData.Edm.IEdmModel LoadModelFromString()
            {
                global::System.Xml.XmlReader reader = CreateXmlReader(Edmx);
                try
                {
                    global::System.Collections.Generic.IEnumerable<global::Microsoft.OData.Edm.Validation.EdmError> errors;
                    global::Microsoft.OData.Edm.IEdmModel edmModel;
                    
                    if (!global::Microsoft.OData.Edm.Csdl.CsdlReader.TryParse(reader, true, out edmModel, out errors))
                    {
                        global::System.Text.StringBuilder errorMessages = new System.Text.StringBuilder();
                        foreach (var error in errors)
                        {
                            errorMessages.Append(error.ErrorMessage);
                            errorMessages.Append("; ");
                        }
                        throw new global::System.InvalidOperationException(errorMessages.ToString());
                    }

                    return edmModel;
                }
                finally
                {
                    ((global::System.IDisposable)(reader)).Dispose();
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "7.5.1")]
            private static global::System.Xml.XmlReader CreateXmlReader(string edmxToParse)
            {
                return global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(edmxToParse));
            }
        }
    }
}
