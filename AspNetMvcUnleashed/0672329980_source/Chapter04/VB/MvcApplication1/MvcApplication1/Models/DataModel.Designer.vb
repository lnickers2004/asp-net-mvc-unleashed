﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.3053
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

<Assembly: Global.System.Data.Objects.DataClasses.EdmSchemaAttribute("be4b5958-6e4c-4f9a-af4f-954fb5063e07")> 

'Original file name:
'Generation date: 2/21/2009 9:04:16 PM
'''<summary>
'''There are no comments for ToyStoreDBEntities in the schema.
'''</summary>
Partial Public Class ToyStoreDBEntities
    Inherits Global.System.Data.Objects.ObjectContext
    '''<summary>
    '''Initializes a new ToyStoreDBEntities object using the connection string found in the 'ToyStoreDBEntities' section of the application configuration file.
    '''</summary>
    Public Sub New()
        MyBase.New("name=ToyStoreDBEntities", "ToyStoreDBEntities")
        Me.OnContextCreated
    End Sub
    '''<summary>
    '''Initialize a new ToyStoreDBEntities object.
    '''</summary>
    Public Sub New(ByVal connectionString As String)
        MyBase.New(connectionString, "ToyStoreDBEntities")
        Me.OnContextCreated
    End Sub
    '''<summary>
    '''Initialize a new ToyStoreDBEntities object.
    '''</summary>
    Public Sub New(ByVal connection As Global.System.Data.EntityClient.EntityConnection)
        MyBase.New(connection, "ToyStoreDBEntities")
        Me.OnContextCreated
    End Sub
    Partial Private Sub OnContextCreated()
        End Sub
    '''<summary>
    '''There are no comments for ProductSet in the schema.
    '''</summary>
    Public ReadOnly Property ProductSet() As Global.System.Data.Objects.ObjectQuery(Of Product)
        Get
            If (Me._ProductSet Is Nothing) Then
                Me._ProductSet = MyBase.CreateQuery(Of Product)("[ProductSet]")
            End If
            Return Me._ProductSet
        End Get
    End Property
    Private _ProductSet As Global.System.Data.Objects.ObjectQuery(Of Product)
    '''<summary>
    '''There are no comments for ProductSet in the schema.
    '''</summary>
    Public Sub AddToProductSet(ByVal product As Product)
        MyBase.AddObject("ProductSet", product)
    End Sub
End Class
'''<summary>
'''There are no comments for Models.Product in the schema.
'''</summary>
'''<KeyProperties>
'''Id
'''</KeyProperties>
<Global.System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName:="Models", Name:="Product"),  _
 Global.System.Runtime.Serialization.DataContractAttribute(IsReference:=true),  _
 Global.System.Serializable()>  _
Partial Public Class Product
    Inherits Global.System.Data.Objects.DataClasses.EntityObject
    '''<summary>
    '''Create a new Product object.
    '''</summary>
    '''<param name="id">Initial value of Id.</param>
    '''<param name="name">Initial value of Name.</param>
    '''<param name="description">Initial value of Description.</param>
    '''<param name="price">Initial value of Price.</param>
    Public Shared Function CreateProduct(ByVal id As Integer, ByVal name As String, ByVal description As String, ByVal price As Decimal) As Product
        Dim product As Product = New Product
        product.Id = id
        product.Name = name
        product.Description = description
        product.Price = price
        Return product
    End Function
    '''<summary>
    '''There are no comments for Property Id in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property Id() As Integer
        Get
            Return Me._Id
        End Get
        Set
            Me.OnIdChanging(value)
            Me.ReportPropertyChanging("Id")
            Me._Id = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
            Me.ReportPropertyChanged("Id")
            Me.OnIdChanged
        End Set
    End Property
    Private _Id As Integer
    Partial Private Sub OnIdChanging(ByVal value As Integer)
        End Sub
    Partial Private Sub OnIdChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property Name in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property Name() As String
        Get
            Return Me._Name
        End Get
        Set
            Me.OnNameChanging(value)
            Me.ReportPropertyChanging("Name")
            Me._Name = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false)
            Me.ReportPropertyChanged("Name")
            Me.OnNameChanged
        End Set
    End Property
    Private _Name As String
    Partial Private Sub OnNameChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnNameChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property Description in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property Description() As String
        Get
            Return Me._Description
        End Get
        Set
            Me.OnDescriptionChanging(value)
            Me.ReportPropertyChanging("Description")
            Me._Description = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false)
            Me.ReportPropertyChanged("Description")
            Me.OnDescriptionChanged
        End Set
    End Property
    Private _Description As String
    Partial Private Sub OnDescriptionChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnDescriptionChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property Price in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property Price() As Decimal
        Get
            Return Me._Price
        End Get
        Set
            Me.OnPriceChanging(value)
            Me.ReportPropertyChanging("Price")
            Me._Price = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
            Me.ReportPropertyChanged("Price")
            Me.OnPriceChanged
        End Set
    End Property
    Private _Price As Decimal
    Partial Private Sub OnPriceChanging(ByVal value As Decimal)
        End Sub
    Partial Private Sub OnPriceChanged()
        End Sub
End Class