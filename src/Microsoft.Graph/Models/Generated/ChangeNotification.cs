// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type ChangeNotification.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class ChangeNotification
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeNotification"/> class.
        /// </summary>
        public ChangeNotification()
        {
            this.ODataType = "microsoft.graph.changeNotification";
        }

        /// <summary>
        /// Gets or sets subscriptionId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscriptionId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? SubscriptionId { get; set; }
    
        /// <summary>
        /// Gets or sets subscriptionExpirationDateTime.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscriptionExpirationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? SubscriptionExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets clientState.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "clientState", Required = Newtonsoft.Json.Required.Default)]
        public string ClientState { get; set; }
    
        /// <summary>
        /// Gets or sets changeType.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "changeType", Required = Newtonsoft.Json.Required.Default)]
        public ChangeType? ChangeType { get; set; }
    
        /// <summary>
        /// Gets or sets resource.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resource", Required = Newtonsoft.Json.Required.Default)]
        public string Resource { get; set; }
    
        /// <summary>
        /// Gets or sets tenantId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tenantId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? TenantId { get; set; }
    
        /// <summary>
        /// Gets or sets encryptedContent.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "encryptedContent", Required = Newtonsoft.Json.Required.Default)]
        public ChangeNotificationEncryptedContent EncryptedContent { get; set; }
    
        /// <summary>
        /// Gets or sets lifecycleEvent.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lifecycleEvent", Required = Newtonsoft.Json.Required.Default)]
        public LifecycleEventType? LifecycleEvent { get; set; }
    
        /// <summary>
        /// Gets or sets resourceData.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourceData", Required = Newtonsoft.Json.Required.Default)]
        public ResourceData ResourceData { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
