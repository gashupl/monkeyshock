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
	/// Group of privileges used to categorize users to provide appropriate access to entities.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("channelaccessprofileentityaccesslevel")]
	public partial class ChannelAccessProfileEntityAccessLevel : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string ChannelAccessProfileEntityAccessLevelId = "channelaccessprofileentityaccesslevelid";
			public const string Id = "channelaccessprofileentityaccesslevelid";
			public const string ChannelAccessProfileEntityAccessLevelIdUnique = "channelaccessprofileentityaccesslevelidunique";
			public const string ChannelAccessProfileId = "channelaccessprofileid";
			public const string ComponentState = "componentstate";
			public const string EntityAccessLevelDepthMask = "entityaccessleveldepthmask";
			public const string EntityAccessLevelId = "entityaccesslevelid";
			public const string IsManaged = "ismanaged";
			public const string OverwriteTime = "overwritetime";
			public const string SolutionId = "solutionid";
			public const string VersionNumber = "versionnumber";
		}
		
		public static class Relationships
		{
			public const string ChannelAccessProfile_Privilege = "ChannelAccessProfile_Privilege";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public ChannelAccessProfileEntityAccessLevel() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "channelaccessprofileentityaccesslevel";
		
		public const string EntitySchemaName = "ChannelAccessProfileEntityAccessLevel";
		
		public const string PrimaryIdAttribute = "channelaccessprofileentityaccesslevelid";
		
		public const string EntityLogicalCollectionName = null;
		
		public const string EntitySetName = "channelaccessprofileentityaccesslevels";
		
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
		/// Unique identifier of the entity access level associated with the channel access profile.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("channelaccessprofileentityaccesslevelid")]
		public System.Nullable<System.Guid> ChannelAccessProfileEntityAccessLevelId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("channelaccessprofileentityaccesslevelid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ChannelAccessProfileEntityAccessLevelId");
				this.SetAttributeValue("channelaccessprofileentityaccesslevelid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ChannelAccessProfileEntityAccessLevelId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("channelaccessprofileentityaccesslevelid")]
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
				this.ChannelAccessProfileEntityAccessLevelId = value;
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("channelaccessprofileentityaccesslevelidunique")]
		public System.Nullable<System.Guid> ChannelAccessProfileEntityAccessLevelIdUnique
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("channelaccessprofileentityaccesslevelidunique");
			}
		}
		
		/// <summary>
		/// Unique identifier of the channel access profile.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("channelaccessprofileid")]
		public System.Nullable<System.Guid> ChannelAccessProfileId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("channelaccessprofileid");
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
		/// System-generated attribute that stores the privileges associated with the role.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityaccessleveldepthmask")]
		public System.Nullable<int> EntityAccessLevelDepthMask
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("entityaccessleveldepthmask");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EntityAccessLevelDepthMask");
				this.SetAttributeValue("entityaccessleveldepthmask", value);
				this.OnPropertyChanged("EntityAccessLevelDepthMask");
			}
		}
		
		/// <summary>
		/// Unique identifier of the entity access level associated with the channel access profile
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityaccesslevelid")]
		public System.Nullable<System.Guid> EntityAccessLevelId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("entityaccesslevelid");
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
		/// N:N ChannelAccessProfile_Privilege
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ChannelAccessProfile_Privilege")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.Privilege> ChannelAccessProfile_Privilege
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.Privilege>("ChannelAccessProfile_Privilege", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ChannelAccessProfile_Privilege");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.Privilege>("ChannelAccessProfile_Privilege", null, value);
				this.OnPropertyChanged("ChannelAccessProfile_Privilege");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public ChannelAccessProfileEntityAccessLevel(object anonymousType) : 
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
                        Attributes["channelaccessprofileentityaccesslevelid"] = base.Id;
                        break;
                    case "channelaccessprofileentityaccesslevelid":
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