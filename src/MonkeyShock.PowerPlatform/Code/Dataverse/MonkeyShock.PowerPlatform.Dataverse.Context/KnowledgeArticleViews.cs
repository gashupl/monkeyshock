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
	public enum KnowledgeArticleViewsState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// No of times an article is viewed per day
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("knowledgearticleviews")]
	public partial class KnowledgeArticleViews : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string ExchangeRate = "exchangerate";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string KnowledgeArticleId = "knowledgearticleid";
			public const string KnowledgeArticleView = "knowledgearticleview";
			public const string KnowledgeArticleViewsId = "knowledgearticleviewsid";
			public const string Id = "knowledgearticleviewsid";
			public const string Location = "location";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningUser = "owninguser";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string ViewDate = "viewdate";
			public const string knowledgearticle_views = "knowledgearticle_views";
			public const string lk_knowledgearticleviews_createdby = "lk_knowledgearticleviews_createdby";
			public const string lk_knowledgearticleviews_createdonbehalfby = "lk_knowledgearticleviews_createdonbehalfby";
			public const string lk_knowledgearticleviews_modifiedby = "lk_knowledgearticleviews_modifiedby";
			public const string lk_knowledgearticleviews_modifiedonbehalfby = "lk_knowledgearticleviews_modifiedonbehalfby";
			public const string transactioncurrency_knowledgearticleviews = "transactioncurrency_knowledgearticleviews";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public KnowledgeArticleViews() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "knowledgearticleviews";
		
		public const string EntitySchemaName = "KnowledgeArticleViews";
		
		public const string PrimaryIdAttribute = "knowledgearticleviewsid";
		
		public const string PrimaryNameAttribute = "knowledgearticleidname";
		
		public const string EntityLogicalCollectionName = "knowledgearticleviews";
		
		public const string EntitySetName = "knowledgearticleviews";
		
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
		/// Shows who created the record.
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
		/// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
		
		/// <summary>
		/// Unique identifier of the data import or data migration that created this record.
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
		/// Choose the Knowledge Article.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("knowledgearticleid")]
		public Microsoft.Xrm.Sdk.EntityReference KnowledgeArticleId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("knowledgearticleid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("KnowledgeArticleId");
				this.SetAttributeValue("knowledgearticleid", value);
				this.OnPropertyChanged("KnowledgeArticleId");
			}
		}
		
		/// <summary>
		/// Number of Knowledge Article Views visited per day
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("knowledgearticleview")]
		public System.Nullable<int> KnowledgeArticleView
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("knowledgearticleview");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("KnowledgeArticleView");
				this.SetAttributeValue("knowledgearticleview", value);
				this.OnPropertyChanged("KnowledgeArticleView");
			}
		}
		
		/// <summary>
		/// Unique identifier of the Knowledge Article Views
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("knowledgearticleviewsid")]
		public System.Nullable<System.Guid> KnowledgeArticleViewsId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("knowledgearticleviewsid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("KnowledgeArticleViewsId");
				this.SetAttributeValue("knowledgearticleviewsid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("KnowledgeArticleViewsId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("knowledgearticleviewsid")]
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
				this.KnowledgeArticleViewsId = value;
			}
		}
		
		/// <summary>
		/// Shows where the knowledge was used
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("location")]
		public Microsoft.Xrm.Sdk.OptionSetValue Location
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("location");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Location");
				this.SetAttributeValue("location", value);
				this.OnPropertyChanged("Location");
			}
		}
		
		/// <summary>
		/// Shows who last updated the record.
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
		/// Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
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
		/// Unique identifier of the user or team who owns the knowledge article views.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the business unit that owns the knowledge article views.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public System.Nullable<System.Guid> OwningBusinessUnit
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who owns the knowledge article views.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public System.Nullable<System.Guid> OwningUser
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("owninguser");
			}
		}
		
		/// <summary>
		/// Status of the Knowledge Article Views
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<MonkeyShock.PowerPlatform.Dataverse.Context.KnowledgeArticleViewsState> StateCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((MonkeyShock.PowerPlatform.Dataverse.Context.KnowledgeArticleViewsState)(System.Enum.ToObject(typeof(MonkeyShock.PowerPlatform.Dataverse.Context.KnowledgeArticleViewsState), optionSet.Value)));
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
		/// Reason for the status of the Knowledge Article Views
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
		/// Choose the local currency for the record to make sure budgets are reported in the correct currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
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
		/// Information about the Day
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("viewdate")]
		public System.Nullable<System.DateTime> ViewDate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("viewdate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ViewDate");
				this.SetAttributeValue("viewdate", value);
				this.OnPropertyChanged("ViewDate");
			}
		}
		
		/// <summary>
		/// 1:N knowledgearticleview_principalobjectattributeaccess
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("knowledgearticleview_principalobjectattributeaccess")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.PrincipalObjectAttributeAccess> knowledgearticleview_principalobjectattributeaccess
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.PrincipalObjectAttributeAccess>("knowledgearticleview_principalobjectattributeaccess", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("knowledgearticleview_principalobjectattributeaccess");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.PrincipalObjectAttributeAccess>("knowledgearticleview_principalobjectattributeaccess", null, value);
				this.OnPropertyChanged("knowledgearticleview_principalobjectattributeaccess");
			}
		}
		
		/// <summary>
		/// 1:N KnowledgeArticleViews_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KnowledgeArticleViews_SyncErrors")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.SyncError> KnowledgeArticleViews_SyncErrors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.SyncError>("KnowledgeArticleViews_SyncErrors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("KnowledgeArticleViews_SyncErrors");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.SyncError>("KnowledgeArticleViews_SyncErrors", null, value);
				this.OnPropertyChanged("KnowledgeArticleViews_SyncErrors");
			}
		}
		
		/// <summary>
		/// N:1 knowledgearticle_views
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("knowledgearticleid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("knowledgearticle_views")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.KnowledgeArticle knowledgearticle_views
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.KnowledgeArticle>("knowledgearticle_views", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("knowledgearticle_views");
				this.SetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.KnowledgeArticle>("knowledgearticle_views", null, value);
				this.OnPropertyChanged("knowledgearticle_views");
			}
		}
		
		/// <summary>
		/// N:1 lk_knowledgearticleviews_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_knowledgearticleviews_createdby")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser lk_knowledgearticleviews_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_knowledgearticleviews_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_knowledgearticleviews_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_knowledgearticleviews_createdonbehalfby")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser lk_knowledgearticleviews_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_knowledgearticleviews_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_knowledgearticleviews_createdonbehalfby");
				this.SetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_knowledgearticleviews_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_knowledgearticleviews_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_knowledgearticleviews_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_knowledgearticleviews_modifiedby")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser lk_knowledgearticleviews_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_knowledgearticleviews_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_knowledgearticleviews_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_knowledgearticleviews_modifiedonbehalfby")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser lk_knowledgearticleviews_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_knowledgearticleviews_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_knowledgearticleviews_modifiedonbehalfby");
				this.SetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_knowledgearticleviews_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_knowledgearticleviews_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 transactioncurrency_knowledgearticleviews
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_knowledgearticleviews")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.TransactionCurrency transactioncurrency_knowledgearticleviews
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.TransactionCurrency>("transactioncurrency_knowledgearticleviews", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public KnowledgeArticleViews(object anonymousType) : 
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
                        Attributes["knowledgearticleviewsid"] = base.Id;
                        break;
                    case "knowledgearticleviewsid":
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