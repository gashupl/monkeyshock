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
	/// Trace and exception information generated by plug-ins and custom workflow activities.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("plugintracelog")]
	public partial class PluginTraceLog : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string Configuration = "configuration";
			public const string CorrelationId = "correlationid";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Depth = "depth";
			public const string ExceptionDetails = "exceptiondetails";
			public const string IsSystemCreated = "issystemcreated";
			public const string MessageBlock = "messageblock";
			public const string MessageName = "messagename";
			public const string Mode = "mode";
			public const string OperationType = "operationtype";
			public const string OrganizationId = "organizationid";
			public const string PerformanceConstructorDuration = "performanceconstructorduration";
			public const string PerformanceConstructorStartTime = "performanceconstructorstarttime";
			public const string PerformanceExecutionDuration = "performanceexecutionduration";
			public const string PerformanceExecutionStartTime = "performanceexecutionstarttime";
			public const string PersistenceKey = "persistencekey";
			public const string PluginStepId = "pluginstepid";
			public const string PluginTraceLogId = "plugintracelogid";
			public const string Id = "plugintracelogid";
			public const string PrimaryEntity = "primaryentity";
			public const string Profile = "profile";
			public const string RequestId = "requestid";
			public const string SecureConfiguration = "secureconfiguration";
			public const string TypeName = "typename";
			public const string createdby_plugintracelog = "createdby_plugintracelog";
			public const string lk_plugintracelogbase_createdonbehalfby = "lk_plugintracelogbase_createdonbehalfby";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public PluginTraceLog() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "plugintracelog";
		
		public const string EntitySchemaName = "PluginTraceLog";
		
		public const string PrimaryIdAttribute = "plugintracelogid";
		
		public const string PrimaryNameAttribute = "typename";
		
		public const string EntityLogicalCollectionName = "plugintracelogs";
		
		public const string EntitySetName = "plugintracelogs";
		
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
		/// Unsecured configuration for the plug-in trace log.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("configuration")]
		public string Configuration
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("configuration");
			}
		}
		
		/// <summary>
		/// Unique identifier for tracking plug-in or custom workflow activity execution.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("correlationid")]
		public System.Nullable<System.Guid> CorrelationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("correlationid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the record.
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
		/// Depth of execution of the plug-in or custom workflow activity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("depth")]
		public System.Nullable<int> Depth
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("depth");
			}
		}
		
		/// <summary>
		/// Details of the exception.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exceptiondetails")]
		public string ExceptionDetails
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("exceptiondetails");
			}
		}
		
		/// <summary>
		/// Where the event originated. Set to true if it's a system trace; otherwise, false.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("issystemcreated")]
		public System.Nullable<bool> IsSystemCreated
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("issystemcreated");
			}
		}
		
		/// <summary>
		/// Trace text from the plug-in.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("messageblock")]
		public string MessageBlock
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("messageblock");
			}
		}
		
		/// <summary>
		/// Name of the message that triggered this plug-in.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("messagename")]
		public string MessageName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("messagename");
			}
		}
		
		/// <summary>
		/// Type of execution.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Mode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("mode");
			}
		}
		
		/// <summary>
		/// Type of custom code.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("operationtype")]
		public Microsoft.Xrm.Sdk.OptionSetValue OperationType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("operationtype");
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
		/// Time, in milliseconds, to construct.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("performanceconstructorduration")]
		public System.Nullable<int> PerformanceConstructorDuration
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("performanceconstructorduration");
			}
		}
		
		/// <summary>
		/// Date and time when constructed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("performanceconstructorstarttime")]
		public System.Nullable<System.DateTime> PerformanceConstructorStartTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("performanceconstructorstarttime");
			}
		}
		
		/// <summary>
		/// Time, in milliseconds, to execute the request.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("performanceexecutionduration")]
		public System.Nullable<int> PerformanceExecutionDuration
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("performanceexecutionduration");
			}
		}
		
		/// <summary>
		/// Time, in milliseconds, to execute the request.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("performanceexecutionstarttime")]
		public System.Nullable<System.DateTime> PerformanceExecutionStartTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("performanceexecutionstarttime");
			}
		}
		
		/// <summary>
		/// Asynchronous workflow persistence key.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("persistencekey")]
		public System.Nullable<System.Guid> PersistenceKey
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("persistencekey");
			}
		}
		
		/// <summary>
		/// ID of the plug-in registration step.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pluginstepid")]
		public System.Nullable<System.Guid> PluginStepId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("pluginstepid");
			}
		}
		
		/// <summary>
		/// Unique identifier for an entity instance.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("plugintracelogid")]
		public System.Nullable<System.Guid> PluginTraceLogId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("plugintracelogid");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("plugintracelogid")]
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
				base.Id = value;
			}
		}
		
		/// <summary>
		/// Entity, if any, that the plug-in is executed against.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primaryentity")]
		public string PrimaryEntity
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("primaryentity");
			}
		}
		
		/// <summary>
		/// Plug-in profile formatted as serialized text.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("profile")]
		public string Profile
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("profile");
			}
		}
		
		/// <summary>
		/// Unique identifier of the message request.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("requestid")]
		public System.Nullable<System.Guid> RequestId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("requestid");
			}
		}
		
		/// <summary>
		/// Secured configuration for the plug-in trace log.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("secureconfiguration")]
		public string SecureConfiguration
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("secureconfiguration");
			}
		}
		
		/// <summary>
		/// Class name of the plug-in.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("typename")]
		public string TypeName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("typename");
			}
		}
		
		/// <summary>
		/// N:1 createdby_plugintracelog
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_plugintracelog")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser createdby_plugintracelog
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("createdby_plugintracelog", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_plugintracelogbase_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_plugintracelogbase_createdonbehalfby")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser lk_plugintracelogbase_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_plugintracelogbase_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_plugintracelogbase_createdonbehalfby");
				this.SetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_plugintracelogbase_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_plugintracelogbase_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public PluginTraceLog(object anonymousType) : 
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
                        Attributes["plugintracelogid"] = base.Id;
                        break;
                    case "plugintracelogid":
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