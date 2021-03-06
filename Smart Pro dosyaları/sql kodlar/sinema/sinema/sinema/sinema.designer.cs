﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sinema
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="sinema")]
	public partial class sinemaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSalon(Salon instance);
    partial void UpdateSalon(Salon instance);
    partial void DeleteSalon(Salon instance);
    partial void InsertFilmYayin(FilmYayin instance);
    partial void UpdateFilmYayin(FilmYayin instance);
    partial void DeleteFilmYayin(FilmYayin instance);
    partial void InsertFilm(Film instance);
    partial void UpdateFilm(Film instance);
    partial void DeleteFilm(Film instance);
    #endregion
		
		public sinemaDataContext() : 
				base(global::sinema.Properties.Settings.Default.sinemaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public sinemaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public sinemaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public sinemaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public sinemaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Salon> Salons
		{
			get
			{
				return this.GetTable<Salon>();
			}
		}
		
		public System.Data.Linq.Table<FilmYayin> FilmYayins
		{
			get
			{
				return this.GetTable<FilmYayin>();
			}
		}
		
		public System.Data.Linq.Table<Film> Films
		{
			get
			{
				return this.GetTable<Film>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Salon")]
	public partial class Salon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _SalonID;
		
		private string _SalonAdi;
		
		private EntitySet<FilmYayin> _FilmYayins;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSalonIDChanging(string value);
    partial void OnSalonIDChanged();
    partial void OnSalonAdiChanging(string value);
    partial void OnSalonAdiChanged();
    #endregion
		
		public Salon()
		{
			this._FilmYayins = new EntitySet<FilmYayin>(new Action<FilmYayin>(this.attach_FilmYayins), new Action<FilmYayin>(this.detach_FilmYayins));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalonID", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string SalonID
		{
			get
			{
				return this._SalonID;
			}
			set
			{
				if ((this._SalonID != value))
				{
					this.OnSalonIDChanging(value);
					this.SendPropertyChanging();
					this._SalonID = value;
					this.SendPropertyChanged("SalonID");
					this.OnSalonIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalonAdi", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string SalonAdi
		{
			get
			{
				return this._SalonAdi;
			}
			set
			{
				if ((this._SalonAdi != value))
				{
					this.OnSalonAdiChanging(value);
					this.SendPropertyChanging();
					this._SalonAdi = value;
					this.SendPropertyChanged("SalonAdi");
					this.OnSalonAdiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Salon_FilmYayin", Storage="_FilmYayins", ThisKey="SalonID", OtherKey="SalonID")]
		public EntitySet<FilmYayin> FilmYayins
		{
			get
			{
				return this._FilmYayins;
			}
			set
			{
				this._FilmYayins.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_FilmYayins(FilmYayin entity)
		{
			this.SendPropertyChanging();
			entity.Salon = this;
		}
		
		private void detach_FilmYayins(FilmYayin entity)
		{
			this.SendPropertyChanging();
			entity.Salon = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.FilmYayin")]
	public partial class FilmYayin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _FYID;
		
		private string _FilmID;
		
		private string _SalonID;
		
		private string _FYZaman;
		
		private EntityRef<Salon> _Salon;
		
		private EntityRef<Film> _Film;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFYIDChanging(string value);
    partial void OnFYIDChanged();
    partial void OnFilmIDChanging(string value);
    partial void OnFilmIDChanged();
    partial void OnSalonIDChanging(string value);
    partial void OnSalonIDChanged();
    partial void OnFYZamanChanging(string value);
    partial void OnFYZamanChanged();
    #endregion
		
		public FilmYayin()
		{
			this._Salon = default(EntityRef<Salon>);
			this._Film = default(EntityRef<Film>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FYID", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string FYID
		{
			get
			{
				return this._FYID;
			}
			set
			{
				if ((this._FYID != value))
				{
					this.OnFYIDChanging(value);
					this.SendPropertyChanging();
					this._FYID = value;
					this.SendPropertyChanged("FYID");
					this.OnFYIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FilmID", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string FilmID
		{
			get
			{
				return this._FilmID;
			}
			set
			{
				if ((this._FilmID != value))
				{
					if (this._Film.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnFilmIDChanging(value);
					this.SendPropertyChanging();
					this._FilmID = value;
					this.SendPropertyChanged("FilmID");
					this.OnFilmIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalonID", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string SalonID
		{
			get
			{
				return this._SalonID;
			}
			set
			{
				if ((this._SalonID != value))
				{
					if (this._Salon.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSalonIDChanging(value);
					this.SendPropertyChanging();
					this._SalonID = value;
					this.SendPropertyChanged("SalonID");
					this.OnSalonIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FYZaman", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string FYZaman
		{
			get
			{
				return this._FYZaman;
			}
			set
			{
				if ((this._FYZaman != value))
				{
					this.OnFYZamanChanging(value);
					this.SendPropertyChanging();
					this._FYZaman = value;
					this.SendPropertyChanged("FYZaman");
					this.OnFYZamanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Salon_FilmYayin", Storage="_Salon", ThisKey="SalonID", OtherKey="SalonID", IsForeignKey=true)]
		public Salon Salon
		{
			get
			{
				return this._Salon.Entity;
			}
			set
			{
				Salon previousValue = this._Salon.Entity;
				if (((previousValue != value) 
							|| (this._Salon.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Salon.Entity = null;
						previousValue.FilmYayins.Remove(this);
					}
					this._Salon.Entity = value;
					if ((value != null))
					{
						value.FilmYayins.Add(this);
						this._SalonID = value.SalonID;
					}
					else
					{
						this._SalonID = default(string);
					}
					this.SendPropertyChanged("Salon");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Film_FilmYayin", Storage="_Film", ThisKey="FilmID", OtherKey="FilmID", IsForeignKey=true)]
		public Film Film
		{
			get
			{
				return this._Film.Entity;
			}
			set
			{
				Film previousValue = this._Film.Entity;
				if (((previousValue != value) 
							|| (this._Film.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Film.Entity = null;
						previousValue.FilmYayins.Remove(this);
					}
					this._Film.Entity = value;
					if ((value != null))
					{
						value.FilmYayins.Add(this);
						this._FilmID = value.FilmID;
					}
					else
					{
						this._FilmID = default(string);
					}
					this.SendPropertyChanged("Film");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Film")]
	public partial class Film : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _FilmID;
		
		private string _FilmAdi;
		
		private EntitySet<FilmYayin> _FilmYayins;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFilmIDChanging(string value);
    partial void OnFilmIDChanged();
    partial void OnFilmAdiChanging(string value);
    partial void OnFilmAdiChanged();
    #endregion
		
		public Film()
		{
			this._FilmYayins = new EntitySet<FilmYayin>(new Action<FilmYayin>(this.attach_FilmYayins), new Action<FilmYayin>(this.detach_FilmYayins));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FilmID", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string FilmID
		{
			get
			{
				return this._FilmID;
			}
			set
			{
				if ((this._FilmID != value))
				{
					this.OnFilmIDChanging(value);
					this.SendPropertyChanging();
					this._FilmID = value;
					this.SendPropertyChanged("FilmID");
					this.OnFilmIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FilmAdi", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string FilmAdi
		{
			get
			{
				return this._FilmAdi;
			}
			set
			{
				if ((this._FilmAdi != value))
				{
					this.OnFilmAdiChanging(value);
					this.SendPropertyChanging();
					this._FilmAdi = value;
					this.SendPropertyChanged("FilmAdi");
					this.OnFilmAdiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Film_FilmYayin", Storage="_FilmYayins", ThisKey="FilmID", OtherKey="FilmID")]
		public EntitySet<FilmYayin> FilmYayins
		{
			get
			{
				return this._FilmYayins;
			}
			set
			{
				this._FilmYayins.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_FilmYayins(FilmYayin entity)
		{
			this.SendPropertyChanging();
			entity.Film = this;
		}
		
		private void detach_FilmYayins(FilmYayin entity)
		{
			this.SendPropertyChanging();
			entity.Film = null;
		}
	}
}
#pragma warning restore 1591
