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
	/// Developers can register plug-ins on a data provider to enable data access for virtual entities in the system.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("entitydataprovider")]
	public partial class EntityDataProvider : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string ComponentState = "componentstate";
			public const string CreateMultiplePlugin = "createmultipleplugin";
			public const string CreatePlugin = "createplugin";
			public const string DataSourceLogicalName = "datasourcelogicalname";
			public const string DeletePlugin = "deleteplugin";
			public const string Description = "description";
			public const string EntityDataProviderId = "entitydataproviderid";
			public const string Id = "entitydataproviderid";
			public const string EntityDataProviderIdUnique = "entitydataprovideridunique";
			public const string IntroducedVersion = "introducedversion";
			public const string IsCustomizable = "iscustomizable";
			public const string IsManaged = "ismanaged";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OverwriteTime = "overwritetime";
			public const string RetrieveEntityChangesPlugin = "retrieveentitychangesplugin";
			public const string RetrieveMultiplePlugin = "retrievemultipleplugin";
			public const string RetrievePlugin = "retrieveplugin";
			public const string SolutionId = "solutionid";
			public const string UpdateMultiplePlugin = "updatemultipleplugin";
			public const string UpdatePlugin = "updateplugin";
			public const string UpsertMultiplePlugin = "upsertmultipleplugin";
			public const string UpsertPlugin = "upsertplugin";
			public const string organization_entitydataprovider = "organization_entitydataprovider";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public EntityDataProvider() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "entitydataprovider";
		
		public const string EntitySchemaName = "EntityDataProvider";
		
		public const string PrimaryIdAttribute = "entitydataproviderid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const string EntityLogicalCollectionName = "entitydataproviders";
		
		public const string EntitySetName = "entitydataproviders";
		
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
		/// Contains the createmultipleplugin id that should be run when CreateMultiple is invoked
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createmultipleplugin")]
		public System.Nullable<System.Guid> CreateMultiplePlugin
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("createmultipleplugin");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreateMultiplePlugin");
				this.SetAttributeValue("createmultipleplugin", value);
				this.OnPropertyChanged("CreateMultiplePlugin");
			}
		}
		
		/// <summary>
		/// Create Plugin
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createplugin")]
		public System.Nullable<System.Guid> CreatePlugin
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("createplugin");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatePlugin");
				this.SetAttributeValue("createplugin", value);
				this.OnPropertyChanged("CreatePlugin");
			}
		}
		
		/// <summary>
		/// When creating a Data Provider, the end user must select the name of the Data Source entity that will be created for the provider.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("datasourcelogicalname")]
		public string DataSourceLogicalName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("datasourcelogicalname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DataSourceLogicalName");
				this.SetAttributeValue("datasourcelogicalname", value);
				this.OnPropertyChanged("DataSourceLogicalName");
			}
		}
		
		/// <summary>
		/// Delete Plugin
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("deleteplugin")]
		public System.Nullable<System.Guid> DeletePlugin
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("deleteplugin");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DeletePlugin");
				this.SetAttributeValue("deleteplugin", value);
				this.OnPropertyChanged("DeletePlugin");
			}
		}
		
		/// <summary>
		/// What is this Data Provider used for and data store technologies does it target?
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
		/// Unique identifier of the data provider.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitydataproviderid")]
		public System.Nullable<System.Guid> EntityDataProviderId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("entitydataproviderid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EntityDataProviderId");
				this.SetAttributeValue("entitydataproviderid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("EntityDataProviderId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitydataproviderid")]
		public override System.Guid Id
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return base.Id;
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.EntityDataProviderId = value;
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitydataprovideridunique")]
		public System.Nullable<System.Guid> EntityDataProviderIdUnique
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("entitydataprovideridunique");
			}
		}
		
		/// <summary>
		/// Version in which the form is introduced.
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
		/// The name of this Data Provider. This is the name that appears in the dropdown when creating a new entity.
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
		/// Unique identifier for the organization.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public System.Nullable<System.Guid> OrganizationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("organizationid");
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
		/// Contains the retrieveentitychangesplugin id that should be run when RetrieveEntityChanges is invoked
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("retrieveentitychangesplugin")]
		public System.Nullable<System.Guid> RetrieveEntityChangesPlugin
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("retrieveentitychangesplugin");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RetrieveEntityChangesPlugin");
				this.SetAttributeValue("retrieveentitychangesplugin", value);
				this.OnPropertyChanged("RetrieveEntityChangesPlugin");
			}
		}
		
		/// <summary>
		/// MultipleRetrieve Plugin
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("retrievemultipleplugin")]
		public System.Nullable<System.Guid> RetrieveMultiplePlugin
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("retrievemultipleplugin");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RetrieveMultiplePlugin");
				this.SetAttributeValue("retrievemultipleplugin", value);
				this.OnPropertyChanged("RetrieveMultiplePlugin");
			}
		}
		
		/// <summary>
		/// Retrieve Plugin
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("retrieveplugin")]
		public System.Nullable<System.Guid> RetrievePlugin
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("retrieveplugin");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RetrievePlugin");
				this.SetAttributeValue("retrieveplugin", value);
				this.OnPropertyChanged("RetrievePlugin");
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
		/// Contains the updatemultipleplugin id that should be run when UpdateMultiple is invoked
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("updatemultipleplugin")]
		public System.Nullable<System.Guid> UpdateMultiplePlugin
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("updatemultipleplugin");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UpdateMultiplePlugin");
				this.SetAttributeValue("updatemultipleplugin", value);
				this.OnPropertyChanged("UpdateMultiplePlugin");
			}
		}
		
		/// <summary>
		/// Update Plugin
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("updateplugin")]
		public System.Nullable<System.Guid> UpdatePlugin
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("updateplugin");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UpdatePlugin");
				this.SetAttributeValue("updateplugin", value);
				this.OnPropertyChanged("UpdatePlugin");
			}
		}
		
		/// <summary>
		/// Contains the upsertmultipleplugin id that should be run when UpsertMultiple is invoked
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("upsertmultipleplugin")]
		public System.Nullable<System.Guid> UpsertMultiplePlugin
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("upsertmultipleplugin");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UpsertMultiplePlugin");
				this.SetAttributeValue("upsertmultipleplugin", value);
				this.OnPropertyChanged("UpsertMultiplePlugin");
			}
		}
		
		/// <summary>
		/// Contains the upsertplugin id that should be run when Upsert is invoked
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("upsertplugin")]
		public System.Nullable<System.Guid> UpsertPlugin
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("upsertplugin");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UpsertPlugin");
				this.SetAttributeValue("upsertplugin", value);
				this.OnPropertyChanged("UpsertPlugin");
			}
		}
		
		/// <summary>
		/// 1:N entitydataprovider_datasource
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitydataprovider_datasource")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.EntityDataSource> entitydataprovider_datasource
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.EntityDataSource>("entitydataprovider_datasource", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("entitydataprovider_datasource");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.EntityDataSource>("entitydataprovider_datasource", null, value);
				this.OnPropertyChanged("entitydataprovider_datasource");
			}
		}
		
		/// <summary>
		/// N:1 organization_entitydataprovider
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_entitydataprovider")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.Organization organization_entitydataprovider
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.Organization>("organization_entitydataprovider", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public EntityDataProvider(object anonymousType) : 
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
                        Attributes["entitydataproviderid"] = base.Id;
                        break;
                    case "entitydataproviderid":
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