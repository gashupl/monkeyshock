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
	/// Stores data regarding organization insights notification
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("orginsightsnotification")]
	public partial class OrgInsightsNotification : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string InternalName = "internalname";
			public const string JsonData = "jsondata";
			public const string Name = "name";
			public const string OrgInsightsNotificationId = "orginsightsnotificationid";
			public const string Id = "orginsightsnotificationid";
			public const string organization_orginsightsnotification = "organization_orginsightsnotification";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public OrgInsightsNotification() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "orginsightsnotification";
		
		public const string EntitySchemaName = "OrgInsightsNotification";
		
		public const string PrimaryIdAttribute = "orginsightsnotificationid";
		
		public const string EntityLogicalCollectionName = "orginsightsnotifications";
		
		public const string EntitySetName = "orginsightsnotifications";
		
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
		/// Name of the notification which is used for retrieving the data
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("internalname")]
		public string InternalName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("internalname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("InternalName");
				this.SetAttributeValue("internalname", value);
				this.OnPropertyChanged("InternalName");
			}
		}
		
		/// <summary>
		/// Notification Data in Json format
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("jsondata")]
		public string JsonData
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("jsondata");
			}
		}
		
		/// <summary>
		/// Legend Name used while displaying the notification
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
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orginsightsnotificationid")]
		public System.Nullable<System.Guid> OrgInsightsNotificationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("orginsightsnotificationid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OrgInsightsNotificationId");
				this.SetAttributeValue("orginsightsnotificationid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("OrgInsightsNotificationId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orginsightsnotificationid")]
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
				this.OrgInsightsNotificationId = value;
			}
		}
		
		/// <summary>
		/// N:1 organization_orginsightsnotification
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_orginsightsnotification")]
		public MonkeyShock.PowerPlatform.Dataverse.Context.Organization organization_orginsightsnotification
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<MonkeyShock.PowerPlatform.Dataverse.Context.Organization>("organization_orginsightsnotification", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public OrgInsightsNotification(object anonymousType) : 
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
                        Attributes["orginsightsnotificationid"] = base.Id;
                        break;
                    case "orginsightsnotificationid":
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