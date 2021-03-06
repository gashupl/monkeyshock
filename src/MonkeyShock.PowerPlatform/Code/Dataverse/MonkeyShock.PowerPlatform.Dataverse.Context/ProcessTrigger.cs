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
	/// Trigger that invoke a rule.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("processtrigger")]
	public partial class ProcessTrigger : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string ComponentState = "componentstate";
			public const string ControlName = "controlname";
			public const string ControlType = "controltype";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Event = "event";
			public const string FormId = "formid";
			public const string IsCustomizable = "iscustomizable";
			public const string IsManaged = "ismanaged";
			public const string MethodId = "methodid";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string OverwriteTime = "overwritetime";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningUser = "owninguser";
			public const string PipelineStage = "pipelinestage";
			public const string PrimaryEntityTypeCode = "primaryentitytypecode";
			public const string ProcessId = "processid";
			public const string ProcessTriggerId = "processtriggerid";
			public const string Id = "processtriggerid";
			public const string ProcessTriggerIdUnique = "processtriggeridunique";
			public const string Scope = "scope";
			public const string SolutionId = "solutionid";
			public const string VersionNumber = "versionnumber";
			public const string lk_processtriggerbase_createdby = "lk_processtriggerbase_createdby";
			public const string lk_processtriggerbase_createdonbehalfby = "lk_processtriggerbase_createdonbehalfby";
			public const string lk_processtriggerbase_modifiedby = "lk_processtriggerbase_modifiedby";
			public const string lk_processtriggerbase_modifiedonbehalfby = "lk_processtriggerbase_modifiedonbehalfby";
			public const string process_processtrigger = "process_processtrigger";
			public const string processtrigger_systemform = "processtrigger_systemform";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public ProcessTrigger() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "processtrigger";
		
		public const string EntitySchemaName = "ProcessTrigger";
		
		public const string PrimaryIdAttribute = "processtriggerid";
		
		public const string EntityLogicalCollectionName = "processtriggers";
		
		public const string EntitySetName = "processtriggers";
		
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
		/// Name of the control.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("controlname")]
		public string ControlName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("controlname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ControlName");
				this.SetAttributeValue("controlname", value);
				this.OnPropertyChanged("ControlName");
			}
		}
		
		/// <summary>
		/// Type of the control to which this trigger is bound
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("controltype")]
		public Microsoft.Xrm.Sdk.OptionSetValue ControlType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("controltype");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ControlType");
				this.SetAttributeValue("controltype", value);
				this.OnPropertyChanged("ControlType");
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
		/// Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
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
		/// Shows who created the record on behalf of another user.
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
		/// Indicates the event.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("event")]
		public string Event
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("event");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Event");
				this.SetAttributeValue("event", value);
				this.OnPropertyChanged("Event");
			}
		}
		
		/// <summary>
		/// Unique identifier of the form associated with the trigger.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formid")]
		public Microsoft.Xrm.Sdk.EntityReference FormId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("formid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FormId");
				this.SetAttributeValue("formid", value);
				this.OnPropertyChanged("FormId");
			}
		}
		
		/// <summary>
		/// Indicates whether this component can be customized.
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
		/// Displays StageID to which the PBL rule belongs to
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("methodid")]
		public System.Nullable<System.Guid> MethodId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("methodid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MethodId");
				this.SetAttributeValue("methodid", value);
				this.OnPropertyChanged("MethodId");
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
		/// Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.
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
		/// Select the business unit that owns the record.
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
		/// Unique identifier for the user that owns the record.
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
		/// Pipeline Stage to Execute Workflow Event Plugin.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pipelinestage")]
		public Microsoft.Xrm.Sdk.OptionSetValue PipelineStage
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("pipelinestage");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PipelineStage");
				this.SetAttributeValue("pipelinestage", value);
				this.OnPropertyChanged("PipelineStage");
			}
		}
		
		/// <summary>
		/// Primary entity for the process which is invoked by the event.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primaryentitytypecode")]
		public string PrimaryEntityTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("primaryentitytypecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PrimaryEntityTypeCode");
				this.SetAttributeValue("primaryentitytypecode", value);
				this.OnPropertyChanged("PrimaryEntityTypeCode");
			}
		}
		
		/// <summary>
		/// Shows the ID of the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		public Microsoft.Xrm.Sdk.EntityReference ProcessId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("processid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProcessId");
				this.SetAttributeValue("processid", value);
				this.OnPropertyChanged("ProcessId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the process trigger record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processtriggerid")]
		public System.Nullable<System.Guid> ProcessTriggerId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("processtriggerid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProcessTriggerId");
				this.SetAttributeValue("processtriggerid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ProcessTriggerId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processtriggerid")]
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
				this.ProcessTriggerId = value;
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processtriggeridunique")]
		public System.Nullable<System.Guid> ProcessTriggerIdUnique
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("processtriggeridunique");
			}
		}
		
		/// <summary>
		/// Scope level for PBL rules.
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
		/// 1:N ProcessTrigger_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProcessTrigger_SyncErrors")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.SyncError> ProcessTrigger_SyncErrors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.SyncError>("ProcessTrigger_SyncErrors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProcessTrigger_SyncErrors");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.SyncError>("ProcessTrigger_SyncErrors", null, value);
				this.OnPropertyChanged("ProcessTrigger_SyncErrors");
			}
		}
		
		/// <summary>
		/// N:1 lk_processtriggerbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processtriggerbase_createdby")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser lk_processtriggerbase_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_processtriggerbase_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_processtriggerbase_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processtriggerbase_createdonbehalfby")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser lk_processtriggerbase_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_processtriggerbase_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_processtriggerbase_createdonbehalfby");
				this.SetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_processtriggerbase_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_processtriggerbase_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_processtriggerbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processtriggerbase_modifiedby")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser lk_processtriggerbase_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_processtriggerbase_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_processtriggerbase_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processtriggerbase_modifiedonbehalfby")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser lk_processtriggerbase_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_processtriggerbase_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_processtriggerbase_modifiedonbehalfby");
				this.SetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemUser>("lk_processtriggerbase_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_processtriggerbase_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 process_processtrigger
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("process_processtrigger")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.Workflow process_processtrigger
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.Workflow>("process_processtrigger", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("process_processtrigger");
				this.SetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.Workflow>("process_processtrigger", null, value);
				this.OnPropertyChanged("process_processtrigger");
			}
		}
		
		/// <summary>
		/// N:1 processtrigger_systemform
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processtrigger_systemform")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.SystemForm processtrigger_systemform
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemForm>("processtrigger_systemform", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processtrigger_systemform");
				this.SetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemForm>("processtrigger_systemform", null, value);
				this.OnPropertyChanged("processtrigger_systemform");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public ProcessTrigger(object anonymousType) : 
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
                        Attributes["processtriggerid"] = base.Id;
                        break;
                    case "processtriggerid":
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