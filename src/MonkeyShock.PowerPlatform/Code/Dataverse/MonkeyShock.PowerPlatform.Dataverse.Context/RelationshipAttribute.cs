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
	/// Stores relationship attributes mapping for Multi-predicate relationship
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("relationshipattribute")]
	public partial class RelationshipAttribute : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string ComponentIdUnique = "componentidunique";
			public const string ComponentState = "componentstate";
			public const string IsCustomizable = "iscustomizable";
			public const string IsManaged = "ismanaged";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OverwriteTime = "overwritetime";
			public const string ReferencedAttributeId = "referencedattributeid";
			public const string ReferencingAttributeId = "referencingattributeid";
			public const string RelationshipAttributeId = "relationshipattributeid";
			public const string Id = "relationshipattributeid";
			public const string RelationshipId = "relationshipid";
			public const string SolutionId = "solutionid";
			public const string organization_relationshipattribute = "organization_relationshipattribute";
			public const string referencedattribute_relationshipattribute = "referencedattribute_relationshipattribute";
			public const string referencingattribute_relationshipattribute = "referencingattribute_relationshipattribute";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public RelationshipAttribute() : 
				base(EntityLogicalName)
		{
		}
		
		public const string AlternateKeys = "componentstate,overwritetime,referencedattributeid,referencingattributeid,relatio" +
			"nshipid|componentstate,overwritetime,referencedattributeid,referencingattributei" +
			"d,relationshipid";
		
		public const string EntityLogicalName = "relationshipattribute";
		
		public const string EntitySchemaName = "RelationshipAttribute";
		
		public const string PrimaryIdAttribute = "relationshipattributeid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const string EntityLogicalCollectionName = "relationshipattributes";
		
		public const string EntitySetName = "relationshipattributes";
		
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
		/// Display Name
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
		/// Referenced Attribute Id
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("referencedattributeid")]
		public Microsoft.Xrm.Sdk.EntityReference ReferencedAttributeId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("referencedattributeid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ReferencedAttributeId");
				this.SetAttributeValue("referencedattributeid", value);
				this.OnPropertyChanged("ReferencedAttributeId");
			}
		}
		
		/// <summary>
		/// Referencing Attribute Id
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("referencingattributeid")]
		public Microsoft.Xrm.Sdk.EntityReference ReferencingAttributeId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("referencingattributeid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ReferencingAttributeId");
				this.SetAttributeValue("referencingattributeid", value);
				this.OnPropertyChanged("ReferencingAttributeId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the relationship attribute
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("relationshipattributeid")]
		public System.Nullable<System.Guid> RelationshipAttributeId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("relationshipattributeid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RelationshipAttributeId");
				this.SetAttributeValue("relationshipattributeid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("RelationshipAttributeId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("relationshipattributeid")]
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
				this.RelationshipAttributeId = value;
			}
		}
		
		/// <summary>
		/// Relationship Id
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("relationshipid")]
		public Microsoft.Xrm.Sdk.EntityReference RelationshipId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("relationshipid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RelationshipId");
				this.SetAttributeValue("relationshipid", value);
				this.OnPropertyChanged("RelationshipId");
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
		/// 1:N relationshipattribute_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("relationshipattribute_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.AsyncOperation> relationshipattribute_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.AsyncOperation>("relationshipattribute_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("relationshipattribute_AsyncOperations");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.AsyncOperation>("relationshipattribute_AsyncOperations", null, value);
				this.OnPropertyChanged("relationshipattribute_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N relationshipattribute_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("relationshipattribute_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.BulkDeleteFailure> relationshipattribute_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.BulkDeleteFailure>("relationshipattribute_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("relationshipattribute_BulkDeleteFailures");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.BulkDeleteFailure>("relationshipattribute_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("relationshipattribute_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N relationshipattribute_MailboxTrackingFolders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("relationshipattribute_MailboxTrackingFolders")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.MailboxTrackingFolder> relationshipattribute_MailboxTrackingFolders
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.MailboxTrackingFolder>("relationshipattribute_MailboxTrackingFolders", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("relationshipattribute_MailboxTrackingFolders");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.MailboxTrackingFolder>("relationshipattribute_MailboxTrackingFolders", null, value);
				this.OnPropertyChanged("relationshipattribute_MailboxTrackingFolders");
			}
		}
		
		/// <summary>
		/// 1:N relationshipattribute_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("relationshipattribute_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.PrincipalObjectAttributeAccess> relationshipattribute_PrincipalObjectAttributeAccesses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.PrincipalObjectAttributeAccess>("relationshipattribute_PrincipalObjectAttributeAccesses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("relationshipattribute_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.PrincipalObjectAttributeAccess>("relationshipattribute_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("relationshipattribute_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N relationshipattribute_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("relationshipattribute_SyncErrors")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.SyncError> relationshipattribute_SyncErrors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.SyncError>("relationshipattribute_SyncErrors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("relationshipattribute_SyncErrors");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.SyncError>("relationshipattribute_SyncErrors", null, value);
				this.OnPropertyChanged("relationshipattribute_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N relationshipattribute_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("relationshipattribute_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.UserEntityInstanceData> relationshipattribute_UserEntityInstanceDatas
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.UserEntityInstanceData>("relationshipattribute_UserEntityInstanceDatas", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("relationshipattribute_UserEntityInstanceDatas");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.UserEntityInstanceData>("relationshipattribute_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("relationshipattribute_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// N:1 organization_relationshipattribute
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_relationshipattribute")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.Organization organization_relationshipattribute
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.Organization>("organization_relationshipattribute", null);
			}
		}
		
		/// <summary>
		/// N:1 referencedattribute_relationshipattribute
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("referencedattributeid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("referencedattribute_relationshipattribute")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.Attribute referencedattribute_relationshipattribute
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.Attribute>("referencedattribute_relationshipattribute", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("referencedattribute_relationshipattribute");
				this.SetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.Attribute>("referencedattribute_relationshipattribute", null, value);
				this.OnPropertyChanged("referencedattribute_relationshipattribute");
			}
		}
		
		/// <summary>
		/// N:1 referencingattribute_relationshipattribute
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("referencingattributeid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("referencingattribute_relationshipattribute")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.Attribute referencingattribute_relationshipattribute
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.Attribute>("referencingattribute_relationshipattribute", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("referencingattribute_relationshipattribute");
				this.SetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.Attribute>("referencingattribute_relationshipattribute", null, value);
				this.OnPropertyChanged("referencingattribute_relationshipattribute");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public RelationshipAttribute(object anonymousType) : 
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
                        Attributes["relationshipattributeid"] = base.Id;
                        break;
                    case "relationshipattributeid":
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