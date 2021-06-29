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
	/// Team Sync-Attribute Mapping Profiles
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("teamsyncattributemappingprofiles")]
	public partial class TeamSyncAttributeMappingProfiles : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string SyncAttributeMappingProfileId = "syncattributemappingprofileid";
			public const string TeamId = "teamid";
			public const string TeamSyncAttributeMappingProfileId = "teamsyncattributemappingprofileid";
			public const string Id = "teamsyncattributemappingprofileid";
			public const string VersionNumber = "versionnumber";
		}
		
		public static class Relationships
		{
			public const string teamsyncattributemappingprofiles_association = "teamsyncattributemappingprofiles_association";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public TeamSyncAttributeMappingProfiles() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "teamsyncattributemappingprofiles";
		
		public const string EntitySchemaName = "TeamSyncAttributeMappingProfiles";
		
		public const string PrimaryIdAttribute = "teamsyncattributemappingprofileid";
		
		public const string EntityLogicalCollectionName = "teamsyncattributemappingprofilescollection";
		
		public const string EntitySetName = "teamsyncattributemappingprofilescollection";
		
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
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("syncattributemappingprofileid")]
		public System.Nullable<System.Guid> SyncAttributeMappingProfileId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("syncattributemappingprofileid");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamid")]
		public System.Nullable<System.Guid> TeamId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("teamid");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamsyncattributemappingprofileid")]
		public System.Nullable<System.Guid> TeamSyncAttributeMappingProfileId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("teamsyncattributemappingprofileid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TeamSyncAttributeMappingProfileId");
				this.SetAttributeValue("teamsyncattributemappingprofileid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("TeamSyncAttributeMappingProfileId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamsyncattributemappingprofileid")]
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
				this.TeamSyncAttributeMappingProfileId = value;
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
		/// N:N teamsyncattributemappingprofiles_association
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("teamsyncattributemappingprofiles_association")]
		public System.Collections.Generic.IEnumerable<MonkeyShock.PowerPlatform.Dataverse.Context.Team> teamsyncattributemappingprofiles_association
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.Team>("teamsyncattributemappingprofiles_association", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("teamsyncattributemappingprofiles_association");
				this.SetRelatedEntities<MonkeyShock.PowerPlatform.Dataverse.Context.Team>("teamsyncattributemappingprofiles_association", null, value);
				this.OnPropertyChanged("teamsyncattributemappingprofiles_association");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public TeamSyncAttributeMappingProfiles(object anonymousType) : 
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
                        Attributes["teamsyncattributemappingprofileid"] = base.Id;
                        break;
                    case "teamsyncattributemappingprofileid":
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