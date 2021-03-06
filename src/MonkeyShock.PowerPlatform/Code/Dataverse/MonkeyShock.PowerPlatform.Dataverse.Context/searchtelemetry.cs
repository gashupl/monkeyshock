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
	/// Entity to log telemetry that used to improve search quality
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("searchtelemetry")]
	public partial class searchtelemetry : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string CorrelationId = "correlationid";
			public const string CreatedOn = "createdon";
			public const string EyesOnAnalyticsAllowed = "eyesonanalyticsallowed";
			public const string FeedbackData = "feedbackdata";
			public const string RequestId = "requestid";
			public const string ScenarioName = "scenarioname";
			public const string searchtelemetryId = "searchtelemetryid";
			public const string Id = "searchtelemetryid";
			public const string SessionId = "sessionid";
			public const string TTLInSeconds = "ttlinseconds";
			public const string UserQuery = "userquery";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public searchtelemetry() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "searchtelemetry";
		
		public const string EntitySchemaName = "searchtelemetry";
		
		public const string PrimaryIdAttribute = "searchtelemetryid";
		
		public const string PrimaryNameAttribute = "userquery";
		
		public const string EntityLogicalCollectionName = "searchtelemetries";
		
		public const string EntitySetName = "searchtelemetries";
		
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
		/// CorrelationId for the search
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("correlationid")]
		public string CorrelationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("correlationid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CorrelationId");
				this.SetAttributeValue("correlationid", value);
				this.OnPropertyChanged("CorrelationId");
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
		/// If customer is allow our engineer to eye on
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("eyesonanalyticsallowed")]
		public System.Nullable<bool> EyesOnAnalyticsAllowed
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("eyesonanalyticsallowed");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EyesOnAnalyticsAllowed");
				this.SetAttributeValue("eyesonanalyticsallowed", value);
				this.OnPropertyChanged("EyesOnAnalyticsAllowed");
			}
		}
		
		/// <summary>
		/// Feedback data for the search
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("feedbackdata")]
		public string FeedbackData
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("feedbackdata");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FeedbackData");
				this.SetAttributeValue("feedbackdata", value);
				this.OnPropertyChanged("FeedbackData");
			}
		}
		
		/// <summary>
		/// RequestId for the search
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("requestid")]
		public string RequestId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("requestid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RequestId");
				this.SetAttributeValue("requestid", value);
				this.OnPropertyChanged("RequestId");
			}
		}
		
		/// <summary>
		/// ScenarioName for the search, current will be one of RelevanceSearch/Marketing/Cxp
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scenarioname")]
		public string ScenarioName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("scenarioname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ScenarioName");
				this.SetAttributeValue("scenarioname", value);
				this.OnPropertyChanged("ScenarioName");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("searchtelemetryid")]
		public System.Nullable<System.Guid> searchtelemetryId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("searchtelemetryid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("searchtelemetryId");
				this.SetAttributeValue("searchtelemetryid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("searchtelemetryId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("searchtelemetryid")]
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
				this.searchtelemetryId = value;
			}
		}
		
		/// <summary>
		/// SessionId for the search
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sessionid")]
		public string SessionId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("sessionid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SessionId");
				this.SetAttributeValue("sessionid", value);
				this.OnPropertyChanged("SessionId");
			}
		}
		
		/// <summary>
		/// Time to live in seconds.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttlinseconds")]
		public System.Nullable<int> TTLInSeconds
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("ttlinseconds");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TTLInSeconds");
				this.SetAttributeValue("ttlinseconds", value);
				this.OnPropertyChanged("TTLInSeconds");
			}
		}
		
		/// <summary>
		/// User Query
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userquery")]
		public string UserQuery
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("userquery");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UserQuery");
				this.SetAttributeValue("userquery", value);
				this.OnPropertyChanged("UserQuery");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public searchtelemetry(object anonymousType) : 
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
                        Attributes["searchtelemetryid"] = base.Id;
                        break;
                    case "searchtelemetryid":
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