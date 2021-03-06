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
	/// To provide master data for the card types list. For internal use only
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("cardtype")]
	public partial class CardType : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string Actions = "actions";
			public const string AdaptiveCardTemplate = "adaptivecardtemplate";
			public const string BoolCardOption = "boolcardoption";
			public const string CardName = "cardname";
			public const string CardType1 = "cardtype";
			public const string CardTypeIcon = "cardtypeicon";
			public const string CardTypeId = "cardtypeid";
			public const string Id = "cardtypeid";
			public const string ClientAvailability = "clientavailability";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string ExchangeRate = "exchangerate";
			public const string GroupCategory = "groupcategory";
			public const string GroupType = "grouptype";
			public const string HasSnoozeDismiss = "hassnoozedismiss";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string IntCardOption = "intcardoption";
			public const string IsBaseCard = "isbasecard";
			public const string IsEnabled = "isenabled";
			public const string IsLiveOnly = "isliveonly";
			public const string IsPreviewCard = "ispreviewcard";
			public const string LastSyncTime = "lastsynctime";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string Priority = "priority";
			public const string PublisherName = "publishername";
			public const string ScheduleTime = "scheduletime";
			public const string SoftTitle = "softtitle";
			public const string StringCardOption = "stringcardoption";
			public const string SummaryText = "summarytext";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string VersionNumber = "versionnumber";
			public const string lk_cardtype_createdby = "lk_cardtype_createdby";
			public const string lk_cardtype_createdonbehalfby = "lk_cardtype_createdonbehalfby";
			public const string lk_cardtype_modifiedby = "lk_cardtype_modifiedby";
			public const string lk_cardtype_modifiedonbehalfby = "lk_cardtype_modifiedonbehalfby";
			public const string transactioncurrency_cardtype = "transactioncurrency_cardtype";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public CardType() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "cardtype";
		
		public const string EntitySchemaName = "CardType";
		
		public const string PrimaryIdAttribute = "cardtypeid";
		
		public const string PrimaryNameAttribute = "cardname";
		
		public const string EntityLogicalCollectionName = "cardtypes";
		
		public const string EntitySetName = "cardtype";
		
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
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actions")]
		public string Actions
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("actions");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Actions");
				this.SetAttributeValue("actions", value);
				this.OnPropertyChanged("Actions");
			}
		}
		
		/// <summary>
		/// AdaptiveCard template.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adaptivecardtemplate")]
		public string AdaptiveCardTemplate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("adaptivecardtemplate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AdaptiveCardTemplate");
				this.SetAttributeValue("adaptivecardtemplate", value);
				this.OnPropertyChanged("AdaptiveCardTemplate");
			}
		}
		
		/// <summary>
		/// Bolean option for a cardtype.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("boolcardoption")]
		public System.Nullable<bool> BoolCardOption
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("boolcardoption");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("BoolCardOption");
				this.SetAttributeValue("boolcardoption", value);
				this.OnPropertyChanged("BoolCardOption");
			}
		}
		
		/// <summary>
		/// The name of the custom entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("cardname")]
		public string CardName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("cardname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CardName");
				this.SetAttributeValue("cardname", value);
				this.OnPropertyChanged("CardName");
			}
		}
		
		/// <summary>
		/// The CardType ENUM value.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("cardtype")]
		public System.Nullable<int> CardType1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("cardtype");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CardType1");
				this.SetAttributeValue("cardtype", value);
				this.OnPropertyChanged("CardType1");
			}
		}
		
		/// <summary>
		/// The CardTypeIcon of the card.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("cardtypeicon")]
		public string CardTypeIcon
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("cardtypeicon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CardTypeIcon");
				this.SetAttributeValue("cardtypeicon", value);
				this.OnPropertyChanged("CardTypeIcon");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("cardtypeid")]
		public System.Nullable<System.Guid> CardTypeId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("cardtypeid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CardTypeId");
				this.SetAttributeValue("cardtypeid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("CardTypeId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("cardtypeid")]
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
				this.CardTypeId = value;
			}
		}
		
		/// <summary>
		/// Determines on which client is this card available on.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("clientavailability")]
		public Microsoft.Xrm.Sdk.OptionSetValue ClientAvailability
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("clientavailability");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ClientAvailability");
				this.SetAttributeValue("clientavailability", value);
				this.OnPropertyChanged("ClientAvailability");
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
		/// Exchange rate for the currency associated with the CardType with respect to the base currency.
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
		/// GroupCategory dictates the grouping of cards in the Assistant.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("groupcategory")]
		public System.Nullable<int> GroupCategory
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("groupcategory");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("GroupCategory");
				this.SetAttributeValue("groupcategory", value);
				this.OnPropertyChanged("GroupCategory");
			}
		}
		
		/// <summary>
		/// Specifies the card group type
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("grouptype")]
		public string GroupType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("grouptype");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("GroupType");
				this.SetAttributeValue("grouptype", value);
				this.OnPropertyChanged("GroupType");
			}
		}
		
		/// <summary>
		/// Specifies if the card type has snooze dismiss
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("hassnoozedismiss")]
		public System.Nullable<bool> HasSnoozeDismiss
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("hassnoozedismiss");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("HasSnoozeDismiss");
				this.SetAttributeValue("hassnoozedismiss", value);
				this.OnPropertyChanged("HasSnoozeDismiss");
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
		/// Any int option for a cardtype.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("intcardoption")]
		public System.Nullable<int> IntCardOption
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("intcardoption");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IntCardOption");
				this.SetAttributeValue("intcardoption", value);
				this.OnPropertyChanged("IntCardOption");
			}
		}
		
		/// <summary>
		/// IsBaseCard
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isbasecard")]
		public System.Nullable<bool> IsBaseCard
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isbasecard");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsBaseCard");
				this.SetAttributeValue("isbasecard", value);
				this.OnPropertyChanged("IsBaseCard");
			}
		}
		
		/// <summary>
		/// IsEnabled
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isenabled")]
		public System.Nullable<bool> IsEnabled
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isenabled");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsEnabled");
				this.SetAttributeValue("isenabled", value);
				this.OnPropertyChanged("IsEnabled");
			}
		}
		
		/// <summary>
		/// IsLiveOnly
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isliveonly")]
		public System.Nullable<bool> IsLiveOnly
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isliveonly");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsLiveOnly");
				this.SetAttributeValue("isliveonly", value);
				this.OnPropertyChanged("IsLiveOnly");
			}
		}
		
		/// <summary>
		/// IsPreviewCard
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ispreviewcard")]
		public System.Nullable<bool> IsPreviewCard
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("ispreviewcard");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsPreviewCard");
				this.SetAttributeValue("ispreviewcard", value);
				this.OnPropertyChanged("IsPreviewCard");
			}
		}
		
		/// <summary>
		/// This column is updated by the Plugin based on the last fetched data.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastsynctime")]
		public System.Nullable<System.DateTime> LastSyncTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastsynctime");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("LastSyncTime");
				this.SetAttributeValue("lastsynctime", value);
				this.OnPropertyChanged("LastSyncTime");
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
		/// The Priority of the CardType
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("priority")]
		public System.Nullable<int> Priority
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("priority");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Priority");
				this.SetAttributeValue("priority", value);
				this.OnPropertyChanged("Priority");
			}
		}
		
		/// <summary>
		/// The publisher name of card type
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publishername")]
		public string PublisherName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("publishername");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PublisherName");
				this.SetAttributeValue("publishername", value);
				this.OnPropertyChanged("PublisherName");
			}
		}
		
		/// <summary>
		/// This column is updated by the Plugin based on the last fetched data.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduletime")]
		public System.Nullable<System.DateTime> ScheduleTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduletime");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ScheduleTime");
				this.SetAttributeValue("scheduletime", value);
				this.OnPropertyChanged("ScheduleTime");
			}
		}
		
		/// <summary>
		/// The soft title of the card.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("softtitle")]
		public string SoftTitle
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("softtitle");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SoftTitle");
				this.SetAttributeValue("softtitle", value);
				this.OnPropertyChanged("SoftTitle");
			}
		}
		
		/// <summary>
		/// Any string option for a cardtype.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stringcardoption")]
		public string StringCardOption
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("stringcardoption");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StringCardOption");
				this.SetAttributeValue("stringcardoption", value);
				this.OnPropertyChanged("StringCardOption");
			}
		}
		
		/// <summary>
		/// The summary text of the card.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("summarytext")]
		public string SummaryText
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("summarytext");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SummaryText");
				this.SetAttributeValue("summarytext", value);
				this.OnPropertyChanged("SummaryText");
			}
		}
		
		/// <summary>
		/// Exchange rate for the currency associated with the CardType with respect to the base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TransactionCurrencyId");
				this.SetAttributeValue("transactioncurrencyid", value);
				this.OnPropertyChanged("TransactionCurrencyId");
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
		/// 1:N cardtype_actioncard
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("cardtype_actioncard")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.ActionCard> cardtype_actioncard
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.ActionCard>("cardtype_actioncard", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("cardtype_actioncard");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.ActionCard>("cardtype_actioncard", null, value);
				this.OnPropertyChanged("cardtype_actioncard");
			}
		}
		
		/// <summary>
		/// 1:N cardtype_actioncardusersettings
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("cardtype_actioncardusersettings")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.ActionCardUserSettings> cardtype_actioncardusersettings
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.ActionCardUserSettings>("cardtype_actioncardusersettings", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("cardtype_actioncardusersettings");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.ActionCardUserSettings>("cardtype_actioncardusersettings", null, value);
				this.OnPropertyChanged("cardtype_actioncardusersettings");
			}
		}
		
		/// <summary>
		/// N:1 lk_cardtype_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_cardtype_createdby")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser lk_cardtype_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_cardtype_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_cardtype_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_cardtype_createdonbehalfby")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser lk_cardtype_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_cardtype_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_cardtype_createdonbehalfby");
				this.SetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_cardtype_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_cardtype_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_cardtype_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_cardtype_modifiedby")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser lk_cardtype_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_cardtype_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_cardtype_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_cardtype_modifiedonbehalfby")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser lk_cardtype_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_cardtype_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_cardtype_modifiedonbehalfby");
				this.SetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_cardtype_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_cardtype_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 transactioncurrency_cardtype
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_cardtype")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.TransactionCurrency transactioncurrency_cardtype
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.TransactionCurrency>("transactioncurrency_cardtype", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("transactioncurrency_cardtype");
				this.SetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.TransactionCurrency>("transactioncurrency_cardtype", null, value);
				this.OnPropertyChanged("transactioncurrency_cardtype");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public CardType(object anonymousType) : 
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
                        Attributes["cardtypeid"] = base.Id;
                        break;
                    case "cardtypeid":
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