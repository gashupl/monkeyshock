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
	/// Callback Registration that stores configuration.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("callbackregistration")]
	public partial class CallbackRegistration : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string CallbackRegistrationId = "callbackregistrationid";
			public const string Id = "callbackregistrationid";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string EntityName = "entityname";
			public const string FilterExpression = "filterexpression";
			public const string FilteringAttributes = "filteringattributes";
			public const string Message = "message";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string PostponeUntil = "postponeuntil";
			public const string RunAs = "runas";
			public const string RuntimeIntegrationProperties = "runtimeintegrationproperties";
			public const string Scope = "scope";
			public const string SdkMessageName = "sdkmessagename";
			public const string Url = "url";
			public const string Version = "version";
			public const string businessunit_callbackregistration = "businessunit_callbackregistration";
			public const string lk_callbackregistration_createdby = "lk_callbackregistration_createdby";
			public const string lk_callbackregistration_createdonbehalfby = "lk_callbackregistration_createdonbehalfby";
			public const string lk_callbackregistration_modifiedby = "lk_callbackregistration_modifiedby";
			public const string lk_callbackregistration_modifiedonbehalfby = "lk_callbackregistration_modifiedonbehalfby";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public CallbackRegistration() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "callbackregistration";
		
		public const string EntitySchemaName = "CallbackRegistration";
		
		public const string PrimaryIdAttribute = "callbackregistrationid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const string EntityLogicalCollectionName = "callbackregistrations";
		
		public const string EntitySetName = "callbackregistrations";
		
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
		/// Unique identifier of the callback registration.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("callbackregistrationid")]
		public System.Nullable<System.Guid> CallbackRegistrationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("callbackregistrationid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CallbackRegistrationId");
				this.SetAttributeValue("callbackregistrationid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("CallbackRegistrationId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("callbackregistrationid")]
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
				this.CallbackRegistrationId = value;
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
		/// Date and time when the callback registration was created.
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
		/// Shows who created the record on behalfÂ of another user.
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
		/// Entity Name.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityname")]
		public string EntityName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("entityname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EntityName");
				this.SetAttributeValue("entityname", value);
				this.OnPropertyChanged("EntityName");
			}
		}
		
		/// <summary>
		/// condition represented with OData $filter syntax
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filterexpression")]
		public string FilterExpression
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("filterexpression");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FilterExpression");
				this.SetAttributeValue("filterexpression", value);
				this.OnPropertyChanged("FilterExpression");
			}
		}
		
		/// <summary>
		/// Comma-separated list of attributes. If at least one of these attributes is modified, the callback url should be called.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filteringattributes")]
		public string FilteringAttributes
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("filteringattributes");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FilteringAttributes");
				this.SetAttributeValue("filteringattributes", value);
				this.OnPropertyChanged("FilteringAttributes");
			}
		}
		
		/// <summary>
		/// Specifies the message type
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("message")]
		public Microsoft.Xrm.Sdk.OptionSetValue Message
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("message");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Message");
				this.SetAttributeValue("message", value);
				this.OnPropertyChanged("Message");
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
		/// Date and time when the callback registration was last modified.
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
		/// Shows who last updated the record on behalf of another user.
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
		/// Name of callback registration.
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
		/// Unique identifier of the user or team who owns the callback registration.
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
		/// Unique identifier of the business unit that owns the callback registration.
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
		/// Unique identifier of the team who owns the callback registration.
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
		/// Unique identifier of the user who owns the callback registration.
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
		/// delay represented with OData expression
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postponeuntil")]
		public string PostponeUntil
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("postponeuntil");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PostponeUntil");
				this.SetAttributeValue("postponeuntil", value);
				this.OnPropertyChanged("PostponeUntil");
			}
		}
		
		/// <summary>
		/// Specifies the user context under which the callback will run
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("runas")]
		public Microsoft.Xrm.Sdk.OptionSetValue RunAs
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("runas");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RunAs");
				this.SetAttributeValue("runas", value);
				this.OnPropertyChanged("RunAs");
			}
		}
		
		/// <summary>
		/// For internal use only. Holds miscellaneous properties related to runtime integration.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("runtimeintegrationproperties")]
		public string RuntimeIntegrationProperties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("runtimeintegrationproperties");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RuntimeIntegrationProperties");
				this.SetAttributeValue("runtimeintegrationproperties", value);
				this.OnPropertyChanged("RuntimeIntegrationProperties");
			}
		}
		
		/// <summary>
		/// Specifies the Scope
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scope")]
		public Microsoft.Xrm.Sdk.OptionSetValue Scope
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("scope");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Scope");
				this.SetAttributeValue("scope", value);
				this.OnPropertyChanged("Scope");
			}
		}
		
		/// <summary>
		/// Name of the SDK message the subscriber is interested in
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagename")]
		public string SdkMessageName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("sdkmessagename");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SdkMessageName");
				this.SetAttributeValue("sdkmessagename", value);
				this.OnPropertyChanged("SdkMessageName");
			}
		}
		
		/// <summary>
		/// Full callback registration Url.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("url")]
		public string Url
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("url");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Url");
				this.SetAttributeValue("url", value);
				this.OnPropertyChanged("Url");
			}
		}
		
		/// <summary>
		/// Specifies the Callback registration version type
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("version")]
		public Microsoft.Xrm.Sdk.OptionSetValue Version
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("version");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Version");
				this.SetAttributeValue("version", value);
				this.OnPropertyChanged("Version");
			}
		}
		
		/// <summary>
		/// N:1 businessunit_callbackregistration
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("businessunit_callbackregistration")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.BusinessUnit businessunit_callbackregistration
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.BusinessUnit>("businessunit_callbackregistration", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_callbackregistration_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_callbackregistration_createdby")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser lk_callbackregistration_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_callbackregistration_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_callbackregistration_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_callbackregistration_createdonbehalfby")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser lk_callbackregistration_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_callbackregistration_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_callbackregistration_createdonbehalfby");
				this.SetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_callbackregistration_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_callbackregistration_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_callbackregistration_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_callbackregistration_modifiedby")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser lk_callbackregistration_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_callbackregistration_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_callbackregistration_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_callbackregistration_modifiedonbehalfby")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser lk_callbackregistration_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_callbackregistration_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_callbackregistration_modifiedonbehalfby");
				this.SetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_callbackregistration_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_callbackregistration_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public CallbackRegistration(object anonymousType) : 
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
                        Attributes["callbackregistrationid"] = base.Id;
                        break;
                    case "callbackregistrationid":
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