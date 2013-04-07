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
// Generation date: 4/19/2009 11:34:41 AM
namespace MvcApplication1.Models
{
    
    /// <summary>
    /// There are no comments for MoviesDBEntities in the schema.
    /// </summary>
    public partial class MoviesDBEntities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new MoviesDBEntities object using the connection string found in the 'MoviesDBEntities' section of the application configuration file.
        /// </summary>
        public MoviesDBEntities() : 
                base("name=MoviesDBEntities", "MoviesDBEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new MoviesDBEntities object.
        /// </summary>
        public MoviesDBEntities(string connectionString) : 
                base(connectionString, "MoviesDBEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new MoviesDBEntities object.
        /// </summary>
        public MoviesDBEntities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "MoviesDBEntities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for MovieSet in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<Movie> MovieSet
        {
            get
            {
                if ((this._MovieSet == null))
                {
                    this._MovieSet = base.CreateQuery<Movie>("[MovieSet]");
                }
                return this._MovieSet;
            }
        }
        private global::System.Data.Objects.ObjectQuery<Movie> _MovieSet;
        /// <summary>
        /// There are no comments for MovieSet in the schema.
        /// </summary>
        public void AddToMovieSet(Movie movie)
        {
            base.AddObject("MovieSet", movie);
        }
    }
    /// <summary>
    /// There are no comments for MvcApplication1.Models.Movie in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="MvcApplication1.Models", Name="Movie")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Movie : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new Movie object.
        /// </summary>
        /// <param name="id">Initial value of Id.</param>
        /// <param name="title">Initial value of Title.</param>
        /// <param name="director">Initial value of Director.</param>
        /// <param name="dateReleased">Initial value of DateReleased.</param>
        public static Movie CreateMovie(int id, string title, string director, global::System.DateTime dateReleased)
        {
            Movie movie = new Movie();
            movie.Id = id;
            movie.Title = title;
            movie.Director = director;
            movie.DateReleased = dateReleased;
            return movie;
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
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this.ReportPropertyChanging("Title");
                this._Title = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Title");
                this.OnTitleChanged();
            }
        }
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property Director in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Director
        {
            get
            {
                return this._Director;
            }
            set
            {
                this.OnDirectorChanging(value);
                this.ReportPropertyChanging("Director");
                this._Director = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Director");
                this.OnDirectorChanged();
            }
        }
        private string _Director;
        partial void OnDirectorChanging(string value);
        partial void OnDirectorChanged();
        /// <summary>
        /// There are no comments for Property DateReleased in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.DateTime DateReleased
        {
            get
            {
                return this._DateReleased;
            }
            set
            {
                this.OnDateReleasedChanging(value);
                this.ReportPropertyChanging("DateReleased");
                this._DateReleased = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("DateReleased");
                this.OnDateReleasedChanged();
            }
        }
        private global::System.DateTime _DateReleased;
        partial void OnDateReleasedChanging(global::System.DateTime value);
        partial void OnDateReleasedChanged();
    }
}
