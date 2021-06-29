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
	/// Organization-owned entity customizations including form layout and dashboards.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("systemform")]
	public partial class SystemForm : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string AncestorFormId = "ancestorformid";
			public const string CanBeDeleted = "canbedeleted";
			public const string ComponentState = "componentstate";
			public const string Description = "description";
			public const string FormActivationState = "formactivationstate";
			public const string FormId = "formid";
			public const string Id = "formid";
			public const string FormIdUnique = "formidunique";
			public const string FormJson = "formjson";
			public const string FormPresentation = "formpresentation";
			public const string FormXml = "formxml";
			public const string IntroducedVersion = "introducedversion";
			public const string IsAIRMerged = "isairmerged";
			public const string IsCustomizable = "iscustomizable";
			public const string IsDefault = "isdefault";
			public const string IsDesktopEnabled = "isdesktopenabled";
			public const string IsManaged = "ismanaged";
			public const string IsTabletEnabled = "istabletenabled";
			public const string Name = "name";
			public const string ObjectTypeCode = "objecttypecode";
			public const string OrganizationId = "organizationid";
			public const string OverwriteTime = "overwritetime";
			public const string PublishedOn = "publishedon";
			public const string SolutionId = "solutionid";
			public const string Type = "type";
			public const string UniqueName = "uniquename";
			public const string Version = "version";
			public const string VersionNumber = "versionnumber";
			public const string Referencingform_ancestor_form = "form_ancestor_form";
			public const string organization_systemforms = "organization_systemforms";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public SystemForm() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "systemform";
		
		public const string EntitySchemaName = "SystemForm";
		
		public const string PrimaryIdAttribute = "formid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const string EntityLogicalCollectionName = "systemforms";
		
		public const string EntitySetName = "systemforms";
		
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
		/// Unique identifier of the parent form.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ancestorformid")]
		public Microsoft.Xrm.Sdk.EntityReference AncestorFormId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ancestorformid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AncestorFormId");
				this.SetAttributeValue("ancestorformid", value);
				this.OnPropertyChanged("AncestorFormId");
			}
		}
		
		/// <summary>
		/// Information that specifies whether this component can be deleted.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("canbedeleted")]
		public Microsoft.Xrm.Sdk.BooleanManagedProperty CanBeDeleted
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("canbedeleted");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CanBeDeleted");
				this.SetAttributeValue("canbedeleted", value);
				this.OnPropertyChanged("CanBeDeleted");
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
		/// Description of the form or dashboard.
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
		/// Specifies the state of the form.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formactivationstate")]
		public Microsoft.Xrm.Sdk.OptionSetValue FormActivationState
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("formactivationstate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FormActivationState");
				this.SetAttributeValue("formactivationstate", value);
				this.OnPropertyChanged("FormActivationState");
			}
		}
		
		/// <summary>
		/// Unique identifier of the record type form.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formid")]
		public System.Nullable<System.Guid> FormId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("formid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FormId");
				this.SetAttributeValue("formid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("FormId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formid")]
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
				this.FormId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the form used when synchronizing customizations for the Microsoft Dynamics 365 client for Outlook.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formidunique")]
		public System.Nullable<System.Guid> FormIdUnique
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("formidunique");
			}
		}
		
		/// <summary>
		/// Json representation of the form layout.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formjson")]
		public string FormJson
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("formjson");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FormJson");
				this.SetAttributeValue("formjson", value);
				this.OnPropertyChanged("FormJson");
			}
		}
		
		/// <summary>
		/// Specifies whether this form is in the updated UI layout in Microsoft Dynamics CRM 2015 or Microsoft Dynamics CRM Online 2015 Update.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formpresentation")]
		public Microsoft.Xrm.Sdk.OptionSetValue FormPresentation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("formpresentation");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FormPresentation");
				this.SetAttributeValue("formpresentation", value);
				this.OnPropertyChanged("FormPresentation");
			}
		}
		
		/// <summary>
		/// XML representation of the form layout.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formxml")]
		public string FormXml
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("formxml");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FormXml");
				this.SetAttributeValue("formxml", value);
				this.OnPropertyChanged("FormXml");
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
		/// Specifies whether this form is merged with the updated UI layout in Microsoft Dynamics CRM 2015 or Microsoft Dynamics CRM Online 2015 Update.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isairmerged")]
		public System.Nullable<bool> IsAIRMerged
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isairmerged");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsAIRMerged");
				this.SetAttributeValue("isairmerged", value);
				this.OnPropertyChanged("IsAIRMerged");
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
		/// Information that specifies whether the form or the dashboard is the system default.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdefault")]
		public System.Nullable<bool> IsDefault
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isdefault");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsDefault");
				this.SetAttributeValue("isdefault", value);
				this.OnPropertyChanged("IsDefault");
			}
		}
		
		/// <summary>
		/// Information that specifies whether the dashboard is enabled for desktop.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdesktopenabled")]
		public System.Nullable<bool> IsDesktopEnabled
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isdesktopenabled");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsDesktopEnabled");
				this.SetAttributeValue("isdesktopenabled", value);
				this.OnPropertyChanged("IsDesktopEnabled");
			}
		}
		
		/// <summary>
		/// 
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
		/// Information that specifies whether the dashboard is enabled for tablet.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("istabletenabled")]
		public System.Nullable<bool> IsTabletEnabled
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("istabletenabled");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsTabletEnabled");
				this.SetAttributeValue("istabletenabled", value);
				this.OnPropertyChanged("IsTabletEnabled");
			}
		}
		
		/// <summary>
		/// Name of the form.
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
		/// Code that represents the record type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objecttypecode")]
		public string ObjectTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("objecttypecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ObjectTypeCode");
				this.SetAttributeValue("objecttypecode", value);
				this.OnPropertyChanged("ObjectTypeCode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization.
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
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publishedon")]
		public System.Nullable<System.DateTime> PublishedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("publishedon");
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
		/// Type of the form, for example, Dashboard or Preview.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("type")]
		public Microsoft.Xrm.Sdk.OptionSetValue Type
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("type");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Type");
				this.SetAttributeValue("type", value);
				this.OnPropertyChanged("Type");
			}
		}
		
		/// <summary>
		/// Unique Name
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uniquename")]
		public string UniqueName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("uniquename");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UniqueName");
				this.SetAttributeValue("uniquename", value);
				this.OnPropertyChanged("UniqueName");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("version")]
		public System.Nullable<int> Version
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("version");
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
		/// Represents a version of customizations to be synchronized with the Microsoft Dynamics 365 client for Outlook.
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
		/// 1:N form_ancestor_form
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("form_ancestor_form", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.SystemForm> Referencedform_ancestor_form
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.SystemForm>("form_ancestor_form", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Referencedform_ancestor_form");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.SystemForm>("form_ancestor_form", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedform_ancestor_form");
			}
		}
		
		/// <summary>
		/// 1:N processtrigger_systemform
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processtrigger_systemform")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.ProcessTrigger> processtrigger_systemform
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.ProcessTrigger>("processtrigger_systemform", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processtrigger_systemform");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.ProcessTrigger>("processtrigger_systemform", null, value);
				this.OnPropertyChanged("processtrigger_systemform");
			}
		}
		
		/// <summary>
		/// 1:N socialinsightsconfiguration_systemform
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("socialinsightsconfiguration_systemform")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.SocialInsightsConfiguration> socialinsightsconfiguration_systemform
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.SocialInsightsConfiguration>("socialinsightsconfiguration_systemform", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("socialinsightsconfiguration_systemform");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.SocialInsightsConfiguration>("socialinsightsconfiguration_systemform", null, value);
				this.OnPropertyChanged("socialinsightsconfiguration_systemform");
			}
		}
		
		/// <summary>
		/// 1:N SystemForm_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemForm_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.AsyncOperation> SystemForm_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.AsyncOperation>("SystemForm_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SystemForm_AsyncOperations");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.AsyncOperation>("SystemForm_AsyncOperations", null, value);
				this.OnPropertyChanged("SystemForm_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N SystemForm_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemForm_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.BulkDeleteFailure> SystemForm_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.BulkDeleteFailure>("SystemForm_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SystemForm_BulkDeleteFailures");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.BulkDeleteFailure>("SystemForm_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("SystemForm_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// N:1 form_ancestor_form
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ancestorformid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("form_ancestor_form", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public MonkeyShock.PowerPlatform.Dataverse.Context.SystemForm Referencingform_ancestor_form
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemForm>("form_ancestor_form", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Referencingform_ancestor_form");
				this.SetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.SystemForm>("form_ancestor_form", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
				this.OnPropertyChanged("Referencingform_ancestor_form");
			}
		}
		
		/// <summary>
		/// N:1 organization_systemforms
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_systemforms")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.Organization organization_systemforms
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.Organization>("organization_systemforms", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public SystemForm(object anonymousType) : 
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
                        Attributes["formid"] = base.Id;
                        break;
                    case "formid":
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