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
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum solutioncomponentconfigurationState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("solutioncomponentconfiguration")]
	public partial class solutioncomponentconfiguration : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string ComponentIdUnique = "componentidunique";
			public const string ComponentState = "componentstate";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string EntityId = "entityid";
			public const string FileFormat = "fileformat";
			public const string FileScope = "filescope";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string IsCustomizable = "iscustomizable";
			public const string isdisplayable = "isdisplayable";
			public const string IsManaged = "ismanaged";
			public const string IsSoftDeleteEnabled = "issoftdeleteenabled";
			public const string KeepActiveCustomizationAfterConversion = "keepactivecustomizationafterconversion";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string name = "name";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OverwriteTime = "overwritetime";
			public const string solutioncomponentconfigurationId = "solutioncomponentconfigurationid";
			public const string Id = "solutioncomponentconfigurationid";
			public const string SolutionId = "solutionid";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string lk_solutioncomponentconfiguration_createdby = "lk_solutioncomponentconfiguration_createdby";
			public const string lk_solutioncomponentconfiguration_createdonbehalfby = "lk_solutioncomponentconfiguration_createdonbehalfby";
			public const string lk_solutioncomponentconfiguration_modifiedby = "lk_solutioncomponentconfiguration_modifiedby";
			public const string lk_solutioncomponentconfiguration_modifiedonbehalfby = "lk_solutioncomponentconfiguration_modifiedonbehalfby";
			public const string organization_solutioncomponentconfiguration = "organization_solutioncomponentconfiguration";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public solutioncomponentconfiguration() : 
				base(EntityLogicalName)
		{
		}
		
		public const string AlternateKeys = "componentstate,entityid,overwritetime";
		
		public const string EntityLogicalName = "solutioncomponentconfiguration";
		
		public const string EntitySchemaName = "solutioncomponentconfiguration";
		
		public const string PrimaryIdAttribute = "solutioncomponentconfigurationid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const string EntityLogicalCollectionName = "solutioncomponentconfigurations";
		
		public const string EntitySetName = "solutioncomponentconfigurations";
		
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
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentidunique")]
		public System.Nullable<System.Guid> ComponentIdUnique
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("componentidunique");
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
		/// Unique identifier of the user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOnBehalfBy");
				this.SetAttributeValue("createdonbehalfby", value);
				this.OnPropertyChanged("CreatedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Unique identifier for Entity associated with Solution Component Configuration.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityid")]
		public Microsoft.Xrm.Sdk.EntityReference EntityId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("entityid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EntityId");
				this.SetAttributeValue("entityid", value);
				this.OnPropertyChanged("EntityId");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fileformat")]
		public Microsoft.Xrm.Sdk.OptionSetValue FileFormat
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("fileformat");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FileFormat");
				this.SetAttributeValue("fileformat", value);
				this.OnPropertyChanged("FileFormat");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filescope")]
		public Microsoft.Xrm.Sdk.OptionSetValue FileScope
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("filescope");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FileScope");
				this.SetAttributeValue("filescope", value);
				this.OnPropertyChanged("FileScope");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// For internal use only.
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
		/// Boolean that indicates if the component has user interface enabled.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdisplayable")]
		public System.Nullable<bool> isdisplayable
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isdisplayable");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("isdisplayable");
				this.SetAttributeValue("isdisplayable", value);
				this.OnPropertyChanged("isdisplayable");
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
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("issoftdeleteenabled")]
		public System.Nullable<bool> IsSoftDeleteEnabled
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("issoftdeleteenabled");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsSoftDeleteEnabled");
				this.SetAttributeValue("issoftdeleteenabled", value);
				this.OnPropertyChanged("IsSoftDeleteEnabled");
			}
		}
		
		/// <summary>
		/// Boolean that indicates if the component should retain its unmanaged customization after conversion.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("keepactivecustomizationafterconversion")]
		public System.Nullable<bool> KeepActiveCustomizationAfterConversion
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("keepactivecustomizationafterconversion");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("KeepActiveCustomizationAfterConversion");
				this.SetAttributeValue("keepactivecustomizationafterconversion", value);
				this.OnPropertyChanged("KeepActiveCustomizationAfterConversion");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOnBehalfBy");
				this.SetAttributeValue("modifiedonbehalfby", value);
				this.OnPropertyChanged("ModifiedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// The name of the custom entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("name");
			}
		}
		
		/// <summary>
		/// Unique identifier for the organization
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
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
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutioncomponentconfigurationid")]
		public System.Nullable<System.Guid> solutioncomponentconfigurationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("solutioncomponentconfigurationid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("solutioncomponentconfigurationId");
				this.SetAttributeValue("solutioncomponentconfigurationid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("solutioncomponentconfigurationId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutioncomponentconfigurationid")]
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
				this.solutioncomponentconfigurationId = value;
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
		/// Status of the Solution Component Configuration
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<MonkeyShock.PowerPlatform.Dataverse.Context.solutioncomponentconfigurationState> StateCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((MonkeyShock.PowerPlatform.Dataverse.Context.solutioncomponentconfigurationState)(System.Enum.ToObject(typeof(MonkeyShock.PowerPlatform.Dataverse.Context.solutioncomponentconfigurationState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StateCode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("StateCode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the Solution Component Configuration
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StatusCode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("StatusCode");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Version Number
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
		/// 1:N solutioncomponentconfig_solutioncomponentattrconfig
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("solutioncomponentconfig_solutioncomponentattrconfig")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.solutioncomponentattributeconfiguration> solutioncomponentconfig_solutioncomponentattrconfig
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.solutioncomponentattributeconfiguration>("solutioncomponentconfig_solutioncomponentattrconfig", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("solutioncomponentconfig_solutioncomponentattrconfig");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.solutioncomponentattributeconfiguration>("solutioncomponentconfig_solutioncomponentattrconfig", null, value);
				this.OnPropertyChanged("solutioncomponentconfig_solutioncomponentattrconfig");
			}
		}
		
		/// <summary>
		/// 1:N solutioncomponentconfiguration_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("solutioncomponentconfiguration_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.AsyncOperation> solutioncomponentconfiguration_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.AsyncOperation>("solutioncomponentconfiguration_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("solutioncomponentconfiguration_AsyncOperations");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.AsyncOperation>("solutioncomponentconfiguration_AsyncOperations", null, value);
				this.OnPropertyChanged("solutioncomponentconfiguration_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N solutioncomponentconfiguration_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("solutioncomponentconfiguration_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.BulkDeleteFailure> solutioncomponentconfiguration_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.BulkDeleteFailure>("solutioncomponentconfiguration_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("solutioncomponentconfiguration_BulkDeleteFailures");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.BulkDeleteFailure>("solutioncomponentconfiguration_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("solutioncomponentconfiguration_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N solutioncomponentconfiguration_DuplicateBaseRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("solutioncomponentconfiguration_DuplicateBaseRecord")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.DuplicateRecord> solutioncomponentconfiguration_DuplicateBaseRecord
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.DuplicateRecord>("solutioncomponentconfiguration_DuplicateBaseRecord", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("solutioncomponentconfiguration_DuplicateBaseRecord");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.DuplicateRecord>("solutioncomponentconfiguration_DuplicateBaseRecord", null, value);
				this.OnPropertyChanged("solutioncomponentconfiguration_DuplicateBaseRecord");
			}
		}
		
		/// <summary>
		/// 1:N solutioncomponentconfiguration_DuplicateMatchingRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("solutioncomponentconfiguration_DuplicateMatchingRecord")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.DuplicateRecord> solutioncomponentconfiguration_DuplicateMatchingRecord
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.DuplicateRecord>("solutioncomponentconfiguration_DuplicateMatchingRecord", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("solutioncomponentconfiguration_DuplicateMatchingRecord");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.DuplicateRecord>("solutioncomponentconfiguration_DuplicateMatchingRecord", null, value);
				this.OnPropertyChanged("solutioncomponentconfiguration_DuplicateMatchingRecord");
			}
		}
		
		/// <summary>
		/// 1:N solutioncomponentconfiguration_MailboxTrackingFolders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("solutioncomponentconfiguration_MailboxTrackingFolders")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.MailboxTrackingFolder> solutioncomponentconfiguration_MailboxTrackingFolders
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.MailboxTrackingFolder>("solutioncomponentconfiguration_MailboxTrackingFolders", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("solutioncomponentconfiguration_MailboxTrackingFolders");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.MailboxTrackingFolder>("solutioncomponentconfiguration_MailboxTrackingFolders", null, value);
				this.OnPropertyChanged("solutioncomponentconfiguration_MailboxTrackingFolders");
			}
		}
		
		/// <summary>
		/// 1:N solutioncomponentconfiguration_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("solutioncomponentconfiguration_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.PrincipalObjectAttributeAccess> solutioncomponentconfiguration_PrincipalObjectAttributeAccesses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.PrincipalObjectAttributeAccess>("solutioncomponentconfiguration_PrincipalObjectAttributeAccesses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("solutioncomponentconfiguration_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.PrincipalObjectAttributeAccess>("solutioncomponentconfiguration_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("solutioncomponentconfiguration_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N solutioncomponentconfiguration_ProcessSession
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("solutioncomponentconfiguration_ProcessSession")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.ProcessSession> solutioncomponentconfiguration_ProcessSession
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.ProcessSession>("solutioncomponentconfiguration_ProcessSession", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("solutioncomponentconfiguration_ProcessSession");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.ProcessSession>("solutioncomponentconfiguration_ProcessSession", null, value);
				this.OnPropertyChanged("solutioncomponentconfiguration_ProcessSession");
			}
		}
		
		/// <summary>
		/// 1:N solutioncomponentconfiguration_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("solutioncomponentconfiguration_SyncErrors")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.SyncError> solutioncomponentconfiguration_SyncErrors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.SyncError>("solutioncomponentconfiguration_SyncErrors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("solutioncomponentconfiguration_SyncErrors");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.SyncError>("solutioncomponentconfiguration_SyncErrors", null, value);
				this.OnPropertyChanged("solutioncomponentconfiguration_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N solutioncomponentconfiguration_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("solutioncomponentconfiguration_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.UserEntityInstanceData> solutioncomponentconfiguration_UserEntityInstanceDatas
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.UserEntityInstanceData>("solutioncomponentconfiguration_UserEntityInstanceDatas", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("solutioncomponentconfiguration_UserEntityInstanceDatas");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.UserEntityInstanceData>("solutioncomponentconfiguration_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("solutioncomponentconfiguration_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// N:1 lk_solutioncomponentconfiguration_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_solutioncomponentconfiguration_createdby")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser lk_solutioncomponentconfiguration_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_solutioncomponentconfiguration_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_solutioncomponentconfiguration_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_solutioncomponentconfiguration_createdonbehalfby")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser lk_solutioncomponentconfiguration_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_solutioncomponentconfiguration_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_solutioncomponentconfiguration_createdonbehalfby");
				this.SetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_solutioncomponentconfiguration_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_solutioncomponentconfiguration_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_solutioncomponentconfiguration_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_solutioncomponentconfiguration_modifiedby")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser lk_solutioncomponentconfiguration_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_solutioncomponentconfiguration_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_solutioncomponentconfiguration_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_solutioncomponentconfiguration_modifiedonbehalfby")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser lk_solutioncomponentconfiguration_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_solutioncomponentconfiguration_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_solutioncomponentconfiguration_modifiedonbehalfby");
				this.SetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_solutioncomponentconfiguration_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_solutioncomponentconfiguration_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 organization_solutioncomponentconfiguration
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_solutioncomponentconfiguration")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.Organization organization_solutioncomponentconfiguration
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.Organization>("organization_solutioncomponentconfiguration", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public solutioncomponentconfiguration(object anonymousType) : 
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
                        Attributes["solutioncomponentconfigurationid"] = base.Id;
                        break;
                    case "solutioncomponentconfigurationid":
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