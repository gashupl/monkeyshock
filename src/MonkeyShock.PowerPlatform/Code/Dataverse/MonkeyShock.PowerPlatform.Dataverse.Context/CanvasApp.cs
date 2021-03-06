//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace MonkeyShock.PowerPlatform.Dataverse.Context
{
	
	/// <summary>
	/// An application built through a canvas-based editing experience.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("canvasapp")]
	public partial class CanvasApp : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string AADCreatedById = "aadcreatedbyid";
			public const string AADLastModifiedById = "aadlastmodifiedbyid";
			public const string AADLastPublishedById = "aadlastpublishedbyid";
			public const string AdminControlBypassConsent = "admincontrolbypassconsent";
			public const string AppComponentDependencies = "appcomponentdependencies";
			public const string AppComponents = "appcomponents";
			public const string AppOpenUri = "appopenuri";
			public const string AppVersion = "appversion";
			public const string Assets_Name = "assets_name";
			public const string AuthorizationReferences = "authorizationreferences";
			public const string BackgroundColor = "backgroundcolor";
			public const string BackgroundImage_Name = "backgroundimage_name";
			public const string BypassConsent = "bypassconsent";
			public const string CanConsumeAppPass = "canconsumeapppass";
			public const string CanvasAppId = "canvasappid";
			public const string CanvasAppRowId = "canvasapprowid";
			public const string CanvasAppType = "canvasapptype";
			public const string CdsDependencies = "cdsdependencies";
			public const string CommitMessage = "commitmessage";
			public const string ComponentState = "componentstate";
			public const string ConnectionReferences = "connectionreferences";
			public const string CreatedByClientVersion = "createdbyclientversion";
			public const string CreatedTime = "createdtime";
			public const string DatabaseReferences = "databasereferences";
			public const string Description = "description";
			public const string DisplayName = "displayname";
			public const string Document_Name = "document_name";
			public const string EmbeddedApp = "embeddedapp";
			public const string GalleryItemId = "galleryitemid";
			public const string IntroducedVersion = "introducedversion";
			public const string IsCdsUpgraded = "iscdsupgraded";
			public const string IsCustomizable = "iscustomizable";
			public const string IsFeaturedApp = "isfeaturedapp";
			public const string IsHeroApp = "isheroapp";
			public const string IsHidden = "ishidden";
			public const string IsManaged = "ismanaged";
			public const string LargeIcon_Name = "largeicon_name";
			public const string LastModifiedTime = "lastmodifiedtime";
			public const string LastPublishTime = "lastpublishtime";
			public const string MediumIcon_Name = "mediumicon_name";
			public const string MinClientVersion = "minclientversion";
			public const string Name = "name";
			public const string OverwriteTime = "overwritetime";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string Publisher = "publisher";
			public const string SmallIcon_Name = "smallicon_name";
			public const string SolutionId = "solutionid";
			public const string Status = "status";
			public const string Tags = "tags";
			public const string TeamsIcon_Name = "teamsicon_name";
			public const string VersionNumber = "versionnumber";
			public const string WideIcon_Name = "wideicon_name";
			public const string businessunit_canvasapp = "businessunit_canvasapp";
			public const string FK_CanvasApp_Solution = "FK_CanvasApp_Solution";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public CanvasApp() : 
				base(EntityLogicalName)
		{
		}
		
		public const string AlternateKeys = "componentstate,name,overwritetime";
		
		public const string EntityLogicalName = "canvasapp";
		
		public const string EntitySchemaName = "CanvasApp";
		
		public const string PrimaryIdAttribute = "canvasappid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const string EntityLogicalCollectionName = "canvasapps";
		
		public const string EntitySetName = "canvasapps";
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the canvas app.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aadcreatedbyid")]
		public string AADCreatedById
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("aadcreatedbyid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AADCreatedById");
				this.SetAttributeValue("aadcreatedbyid", value);
				this.OnPropertyChanged("AADCreatedById");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the application.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aadlastmodifiedbyid")]
		public string AADLastModifiedById
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("aadlastmodifiedbyid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AADLastModifiedById");
				this.SetAttributeValue("aadlastmodifiedbyid", value);
				this.OnPropertyChanged("AADLastModifiedById");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last published the application.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aadlastpublishedbyid")]
		public string AADLastPublishedById
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("aadlastpublishedbyid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AADLastPublishedById");
				this.SetAttributeValue("aadlastpublishedbyid", value);
				this.OnPropertyChanged("AADLastPublishedById");
			}
		}
		
		/// <summary>
		/// Indicates whether the canvas app was marked for bypass consent by an admin.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("admincontrolbypassconsent")]
		public System.Nullable<bool> AdminControlBypassConsent
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("admincontrolbypassconsent");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AdminControlBypassConsent");
				this.SetAttributeValue("admincontrolbypassconsent", value);
				this.OnPropertyChanged("AdminControlBypassConsent");
			}
		}
		
		/// <summary>
		/// The app component dependencies.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("appcomponentdependencies")]
		public string AppComponentDependencies
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("appcomponentdependencies");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AppComponentDependencies");
				this.SetAttributeValue("appcomponentdependencies", value);
				this.OnPropertyChanged("AppComponentDependencies");
			}
		}
		
		/// <summary>
		/// The app components.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("appcomponents")]
		public string AppComponents
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("appcomponents");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AppComponents");
				this.SetAttributeValue("appcomponents", value);
				this.OnPropertyChanged("AppComponents");
			}
		}
		
		/// <summary>
		/// The app open URI.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("appopenuri")]
		public string AppOpenUri
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("appopenuri");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AppOpenUri");
				this.SetAttributeValue("appopenuri", value);
				this.OnPropertyChanged("AppOpenUri");
			}
		}
		
		/// <summary>
		/// The application version.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("appversion")]
		public string AppVersion
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("appversion");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AppVersion");
				this.SetAttributeValue("appversion", value);
				this.OnPropertyChanged("AppVersion");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("assets_name")]
		public string Assets_Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("assets_name");
			}
		}
		
		/// <summary>
		/// The authorization references of the application.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("authorizationreferences")]
		public string AuthorizationReferences
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("authorizationreferences");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AuthorizationReferences");
				this.SetAttributeValue("authorizationreferences", value);
				this.OnPropertyChanged("AuthorizationReferences");
			}
		}
		
		/// <summary>
		/// The background image color.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("backgroundcolor")]
		public string BackgroundColor
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("backgroundcolor");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("BackgroundColor");
				this.SetAttributeValue("backgroundcolor", value);
				this.OnPropertyChanged("BackgroundColor");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("backgroundimage_name")]
		public string BackgroundImage_Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("backgroundimage_name");
			}
		}
		
		/// <summary>
		/// Indicates whether the canvas app should bypass consent from consumers.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bypassconsent")]
		public System.Nullable<bool> BypassConsent
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("bypassconsent");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("BypassConsent");
				this.SetAttributeValue("bypassconsent", value);
				this.OnPropertyChanged("BypassConsent");
			}
		}
		
		/// <summary>
		/// The type of the canvas app.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("canconsumeapppass")]
		public System.Nullable<bool> CanConsumeAppPass
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("canconsumeapppass");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CanConsumeAppPass");
				this.SetAttributeValue("canconsumeapppass", value);
				this.OnPropertyChanged("CanConsumeAppPass");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("canvasappid")]
		public System.Nullable<System.Guid> CanvasAppId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("canvasappid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CanvasAppId");
				this.SetAttributeValue("canvasappid", value);
				this.OnPropertyChanged("CanvasAppId");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("canvasapprowid")]
		public System.Nullable<System.Guid> CanvasAppRowId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("canvasapprowid");
			}
		}
		
		/// <summary>
		/// The type of the canvas app.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("canvasapptype")]
		public Microsoft.Xrm.Sdk.OptionSetValue CanvasAppType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("canvasapptype");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CanvasAppType");
				this.SetAttributeValue("canvasapptype", value);
				this.OnPropertyChanged("CanvasAppType");
			}
		}
		
		/// <summary>
		/// Internal use. The app dependency details.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("cdsdependencies")]
		public string CdsDependencies
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("cdsdependencies");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CdsDependencies");
				this.SetAttributeValue("cdsdependencies", value);
				this.OnPropertyChanged("CdsDependencies");
			}
		}
		
		/// <summary>
		/// The commit message of the app.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("commitmessage")]
		public string CommitMessage
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("commitmessage");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CommitMessage");
				this.SetAttributeValue("commitmessage", value);
				this.OnPropertyChanged("CommitMessage");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
		public Microsoft.Xrm.Sdk.OptionSetValue ComponentState
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("componentstate");
			}
		}
		
		/// <summary>
		/// The connection references of the application.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("connectionreferences")]
		public string ConnectionReferences
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("connectionreferences");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ConnectionReferences");
				this.SetAttributeValue("connectionreferences", value);
				this.OnPropertyChanged("ConnectionReferences");
			}
		}
		
		/// <summary>
		/// The version of the client that was used to author the application.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdbyclientversion")]
		public string CreatedByClientVersion
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("createdbyclientversion");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedByClientVersion");
				this.SetAttributeValue("createdbyclientversion", value);
				this.OnPropertyChanged("CreatedByClientVersion");
			}
		}
		
		/// <summary>
		/// Date and time when the application was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdtime")]
		public System.Nullable<System.DateTime> CreatedTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdtime");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedTime");
				this.SetAttributeValue("createdtime", value);
				this.OnPropertyChanged("CreatedTime");
			}
		}
		
		/// <summary>
		/// The database references of the application.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("databasereferences")]
		public string DatabaseReferences
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("databasereferences");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DatabaseReferences");
				this.SetAttributeValue("databasereferences", value);
				this.OnPropertyChanged("DatabaseReferences");
			}
		}
		
		/// <summary>
		/// The description of the app.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// The display name of the app.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("displayname")]
		public string DisplayName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("displayname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DisplayName");
				this.SetAttributeValue("displayname", value);
				this.OnPropertyChanged("DisplayName");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("document_name")]
		public string Document_Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("document_name");
			}
		}
		
		/// <summary>
		/// Internal use. The embedded app information.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("embeddedapp")]
		public string EmbeddedApp
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("embeddedapp");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EmbeddedApp");
				this.SetAttributeValue("embeddedapp", value);
				this.OnPropertyChanged("EmbeddedApp");
			}
		}
		
		/// <summary>
		/// The gallery item identifier.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("galleryitemid")]
		public string GalleryItemId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("galleryitemid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("GalleryItemId");
				this.SetAttributeValue("galleryitemid", value);
				this.OnPropertyChanged("GalleryItemId");
			}
		}
		
		/// <summary>
		/// Version in which the canvas app is introduced.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("introducedversion")]
		public string IntroducedVersion
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("introducedversion");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IntroducedVersion");
				this.SetAttributeValue("introducedversion", value);
				this.OnPropertyChanged("IntroducedVersion");
			}
		}
		
		/// <summary>
		/// Indicates whether the canvas app contains CDS 1.0 references.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscdsupgraded")]
		public System.Nullable<bool> IsCdsUpgraded
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("iscdsupgraded");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsCdsUpgraded");
				this.SetAttributeValue("iscdsupgraded", value);
				this.OnPropertyChanged("IsCdsUpgraded");
			}
		}
		
		/// <summary>
		/// Information that specifies whether this component can be customized.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscustomizable")]
		public Microsoft.Xrm.Sdk.BooleanManagedProperty IsCustomizable
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("iscustomizable");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsCustomizable");
				this.SetAttributeValue("iscustomizable", value);
				this.OnPropertyChanged("IsCustomizable");
			}
		}
		
		/// <summary>
		/// Indicates whether the canvas app is a featured app.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isfeaturedapp")]
		public System.Nullable<bool> IsFeaturedApp
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isfeaturedapp");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsFeaturedApp");
				this.SetAttributeValue("isfeaturedapp", value);
				this.OnPropertyChanged("IsFeaturedApp");
			}
		}
		
		/// <summary>
		/// Indicates whether the canvas app is a hero app.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isheroapp")]
		public System.Nullable<bool> IsHeroApp
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isheroapp");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsHeroApp");
				this.SetAttributeValue("isheroapp", value);
				this.OnPropertyChanged("IsHeroApp");
			}
		}
		
		/// <summary>
		/// Indicates whether the canvas app is hidden from a user's list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ishidden")]
		public System.Nullable<bool> IsHidden
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("ishidden");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsHidden");
				this.SetAttributeValue("ishidden", value);
				this.OnPropertyChanged("IsHidden");
			}
		}
		
		/// <summary>
		/// Indicates whether the solution component is part of a managed solution.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
		public System.Nullable<bool> IsManaged
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("ismanaged");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("largeicon_name")]
		public string LargeIcon_Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("largeicon_name");
			}
		}
		
		/// <summary>
		/// Date and time when the application was last modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastmodifiedtime")]
		public System.Nullable<System.DateTime> LastModifiedTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastmodifiedtime");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("LastModifiedTime");
				this.SetAttributeValue("lastmodifiedtime", value);
				this.OnPropertyChanged("LastModifiedTime");
			}
		}
		
		/// <summary>
		/// Date and time when the application was last published.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastpublishtime")]
		public System.Nullable<System.DateTime> LastPublishTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastpublishtime");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("LastPublishTime");
				this.SetAttributeValue("lastpublishtime", value);
				this.OnPropertyChanged("LastPublishTime");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mediumicon_name")]
		public string MediumIcon_Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("mediumicon_name");
			}
		}
		
		/// <summary>
		/// The version of the client that was used to author the application.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("minclientversion")]
		public string MinClientVersion
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("minclientversion");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MinClientVersion");
				this.SetAttributeValue("minclientversion", value);
				this.OnPropertyChanged("MinClientVersion");
			}
		}
		
		/// <summary>
		/// Name of the CanvasApp
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
		public System.Nullable<System.DateTime> OverwriteTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user or team who owns the canvas app.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the business unit that owns the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier of the team who owns the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who owns the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// The publisher of the app.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publisher")]
		public string Publisher
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("publisher");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Publisher");
				this.SetAttributeValue("publisher", value);
				this.OnPropertyChanged("Publisher");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("smallicon_name")]
		public string SmallIcon_Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("smallicon_name");
			}
		}
		
		/// <summary>
		/// Unique identifier of the associated solution.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
		public System.Nullable<System.Guid> SolutionId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("solutionid");
			}
		}
		
		/// <summary>
		/// A value indicating whether the application is ready for consumption.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("status")]
		public string Status
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("status");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Status");
				this.SetAttributeValue("status", value);
				this.OnPropertyChanged("Status");
			}
		}
		
		/// <summary>
		/// The metadata tags of the application.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("tags")]
		public string Tags
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("tags");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Tags");
				this.SetAttributeValue("tags", value);
				this.OnPropertyChanged("Tags");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamsicon_name")]
		public string TeamsIcon_Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("teamsicon_name");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("wideicon_name")]
		public string WideIcon_Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("wideicon_name");
			}
		}
		
		/// <summary>
		/// 1:N canvasapp_appelement_canvasappid
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("canvasapp_appelement_canvasappid")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.AppElement> canvasapp_appelement_canvasappid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.AppElement>("canvasapp_appelement_canvasappid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("canvasapp_appelement_canvasappid");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.AppElement>("canvasapp_appelement_canvasappid", null, value);
				this.OnPropertyChanged("canvasapp_appelement_canvasappid");
			}
		}
		
		/// <summary>
		/// 1:N canvasappextendedmetadata
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("canvasappextendedmetadata")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.CanvasAppExtendedMetadata> canvasappextendedmetadata
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.CanvasAppExtendedMetadata>("canvasappextendedmetadata", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("canvasappextendedmetadata");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.CanvasAppExtendedMetadata>("canvasappextendedmetadata", null, value);
				this.OnPropertyChanged("canvasappextendedmetadata");
			}
		}
		
		/// <summary>
		/// N:1 businessunit_canvasapp
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("businessunit_canvasapp")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.BusinessUnit businessunit_canvasapp
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.BusinessUnit>("businessunit_canvasapp", null);
			}
		}
		
		/// <summary>
		/// N:1 FK_CanvasApp_Solution
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("FK_CanvasApp_Solution")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.Solution FK_CanvasApp_Solution
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.Solution>("FK_CanvasApp_Solution", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public CanvasApp(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int) value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["canvasappid"] = base.Id;
                        break;
                    case "canvasappid":
                        var id = (System.Nullable<System.Guid>) value;
                        if(id == null){ continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
		}
	}
}