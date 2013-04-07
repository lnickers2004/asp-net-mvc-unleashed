﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]

// Original file name:
// Generation date: 2/26/2009 1:07:41 PM
namespace MvcApplication1.Models
{
    
    /// <summary>
    /// There are no comments for ProductsDBEntities in the schema.
    /// </summary>
    public partial class ProductsDBEntities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new ProductsDBEntities object using the connection string found in the 'ProductsDBEntities' section of the application configuration file.
        /// </summary>
        public ProductsDBEntities() : 
                base("name=ProductsDBEntities", "ProductsDBEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new ProductsDBEntities object.
        /// </summary>
        public ProductsDBEntities(string connectionString) : 
                base(connectionString, "ProductsDBEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new ProductsDBEntities object.
        /// </summary>
        public ProductsDBEntities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "ProductsDBEntities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for ProductSet in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<Product> ProductSet
        {
            get
            {
                if ((this._ProductSet == null))
                {
                    this._ProductSet = base.CreateQuery<Product>("[ProductSet]");
                }
                return this._ProductSet;
            }
        }
        private global::System.Data.Objects.ObjectQuery<Product> _ProductSet;
        /// <summary>
        /// There are no comments for ProductSet in the schema.
        /// </summary>
        public void AddToProductSet(Product product)
        {
            base.AddObject("ProductSet", product);
        }
    }
    /// <summary>
    /// There are no comments for Models.Product in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="Models", Name="Product")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Product : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new Product object.
        /// </summary>
        /// <param name="id">Initial value of Id.</param>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="description">Initial value of Description.</param>
        /// <param name="price">Initial value of Price.</param>
        public static Product CreateProduct(int id, string name, string description, decimal price)
        {
            Product product = new Product();
            product.Id = id;
            product.Name = name;
            product.Description = description;
            product.Price = price;
            return product;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this.ReportPropertyChanging("Id");
                this._Id = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Id");
                this.OnIdChanged();
            }
        }
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this.ReportPropertyChanging("Name");
                this._Name = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Name");
                this.OnNameChanged();
            }
        }
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this.ReportPropertyChanging("Description");
                this._Description = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Description");
                this.OnDescriptionChanged();
            }
        }
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property Price in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price
        {
            get
            {
                return this._Price;
            }
            set
            {
                this.OnPriceChanging(value);
                this.ReportPropertyChanging("Price");
                this._Price = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Price");
                this.OnPriceChanged();
            }
        }
        private decimal _Price;
        partial void OnPriceChanging(decimal value);
        partial void OnPriceChanged();
    }
}
