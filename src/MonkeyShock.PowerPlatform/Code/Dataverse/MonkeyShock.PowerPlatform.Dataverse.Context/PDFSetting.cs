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
	public enum PDFSettingState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// PDF Settings to save enabled pdf entities
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("pdfsetting")]
	public partial class PDFSetting : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string entityname = "entityname";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ispdfsettingenabled = "ispdfsettingenabled";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string PDFSettingId = "pdfsettingid";
			public const string Id = "pdfsettingid";
			public const string pdfsettingsjson = "pdfsettingsjson";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string business_unit_pdfsetting = "business_unit_pdfsetting";
			public const string lk_pdfsetting_createdby = "lk_pdfsetting_createdby";
			public const string lk_pdfsetting_createdonbehalfby = "lk_pdfsetting_createdonbehalfby";
			public const string lk_pdfsetting_modifiedby = "lk_pdfsetting_modifiedby";
			public const string lk_pdfsetting_modifiedonbehalfby = "lk_pdfsetting_modifiedonbehalfby";
			public const string team_pdfsetting = "team_pdfsetting";
			public const string user_pdfsetting = "user_pdfsetting";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public PDFSetting() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "pdfsetting";
		
		public const string EntitySchemaName = "PDFSetting";
		
		public const string PrimaryIdAttribute = "pdfsettingid";
		
		public const string PrimaryNameAttribute = "entityname";
		
		public const string EntityLogicalCollectionName = "pdfsettings";
		
		public const string EntitySetName = "pdfsettings";
		
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
		/// The name of the entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityname")]
		public string entityname
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("entityname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("entityname");
				this.SetAttributeValue("entityname", value);
				this.OnPropertyChanged("entityname");
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
		/// Contains true or false for enabled and disabled entities respectively
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ispdfsettingenabled")]
		public System.Nullable<bool> ispdfsettingenabled
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("ispdfsettingenabled");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ispdfsettingenabled");
				this.SetAttributeValue("ispdfsettingenabled", value);
				this.OnPropertyChanged("ispdfsettingenabled");
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
		/// Owner Id
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
		/// Unique identifier for the business unit that owns the record
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
		/// Unique identifier for the team that owns the record.
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
		/// Unique identifier for the user that owns the record.
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
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pdfsettingid")]
		public System.Nullable<System.Guid> PDFSettingId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("pdfsettingid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PDFSettingId");
				this.SetAttributeValue("pdfsettingid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("PDFSettingId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pdfsettingid")]
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
				this.PDFSettingId = value;
			}
		}
		
		/// <summary>
		/// Column to save PDF Settings in Json
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pdfsettingsjson")]
		public string pdfsettingsjson
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("pdfsettingsjson");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("pdfsettingsjson");
				this.SetAttributeValue("pdfsettingsjson", value);
				this.OnPropertyChanged("pdfsettingsjson");
			}
		}
		
		/// <summary>
		/// Status of the pdfsetting
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<MonkeyShock.PowerPlatform.Dataverse.Context.PDFSettingState> StateCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((MonkeyShock.PowerPlatform.Dataverse.Context.PDFSettingState)(System.Enum.ToObject(typeof(MonkeyShock.PowerPlatform.Dataverse.Context.PDFSettingState), optionSet.Value)));
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
		/// Reason for the status of the pdfsetting
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
		/// 1:N pdfsetting_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("pdfsetting_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.AsyncOperation> pdfsetting_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.AsyncOperation>("pdfsetting_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("pdfsetting_AsyncOperations");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.AsyncOperation>("pdfsetting_AsyncOperations", null, value);
				this.OnPropertyChanged("pdfsetting_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N pdfsetting_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("pdfsetting_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.BulkDeleteFailure> pdfsetting_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.BulkDeleteFailure>("pdfsetting_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("pdfsetting_BulkDeleteFailures");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.BulkDeleteFailure>("pdfsetting_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("pdfsetting_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N pdfsetting_MailboxTrackingFolders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("pdfsetting_MailboxTrackingFolders")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.MailboxTrackingFolder> pdfsetting_MailboxTrackingFolders
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.MailboxTrackingFolder>("pdfsetting_MailboxTrackingFolders", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("pdfsetting_MailboxTrackingFolders");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.MailboxTrackingFolder>("pdfsetting_MailboxTrackingFolders", null, value);
				this.OnPropertyChanged("pdfsetting_MailboxTrackingFolders");
			}
		}
		
		/// <summary>
		/// 1:N pdfsetting_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("pdfsetting_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.PrincipalObjectAttributeAccess> pdfsetting_PrincipalObjectAttributeAccesses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.PrincipalObjectAttributeAccess>("pdfsetting_PrincipalObjectAttributeAccesses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("pdfsetting_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.PrincipalObjectAttributeAccess>("pdfsetting_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("pdfsetting_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N pdfsetting_ProcessSession
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("pdfsetting_ProcessSession")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.ProcessSession> pdfsetting_ProcessSession
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.ProcessSession>("pdfsetting_ProcessSession", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("pdfsetting_ProcessSession");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.ProcessSession>("pdfsetting_ProcessSession", null, value);
				this.OnPropertyChanged("pdfsetting_ProcessSession");
			}
		}
		
		/// <summary>
		/// 1:N pdfsetting_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("pdfsetting_SyncErrors")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.SyncError> pdfsetting_SyncErrors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.SyncError>("pdfsetting_SyncErrors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("pdfsetting_SyncErrors");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.SyncError>("pdfsetting_SyncErrors", null, value);
				this.OnPropertyChanged("pdfsetting_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N pdfsetting_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("pdfsetting_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.UserEntityInstanceData> pdfsetting_UserEntityInstanceDatas
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.UserEntityInstanceData>("pdfsetting_UserEntityInstanceDatas", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("pdfsetting_UserEntityInstanceDatas");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.UserEntityInstanceData>("pdfsetting_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("pdfsetting_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_pdfsetting
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_pdfsetting")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.BusinessUnit business_unit_pdfsetting
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.BusinessUnit>("business_unit_pdfsetting", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_pdfsetting_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_pdfsetting_createdby")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser lk_pdfsetting_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_pdfsetting_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_pdfsetting_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_pdfsetting_createdonbehalfby")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser lk_pdfsetting_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_pdfsetting_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_pdfsetting_createdonbehalfby");
				this.SetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_pdfsetting_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_pdfsetting_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_pdfsetting_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_pdfsetting_modifiedby")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser lk_pdfsetting_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_pdfsetting_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_pdfsetting_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_pdfsetting_modifiedonbehalfby")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser lk_pdfsetting_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_pdfsetting_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_pdfsetting_modifiedonbehalfby");
				this.SetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_pdfsetting_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_pdfsetting_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 team_pdfsetting
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_pdfsetting")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.Team team_pdfsetting
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.Team>("team_pdfsetting", null);
			}
		}
		
		/// <summary>
		/// N:1 user_pdfsetting
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_pdfsetting")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser user_pdfsetting
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("user_pdfsetting", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public PDFSetting(object anonymousType) : 
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
                        Attributes["pdfsettingid"] = base.Id;
                        break;
                    case "pdfsettingid":
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