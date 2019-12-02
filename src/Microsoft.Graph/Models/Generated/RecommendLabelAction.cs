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
    /// The type RecommendLabelAction.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class RecommendLabelAction : InformationProtectionAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendLabelAction"/> class.
        /// </summary>
        public RecommendLabelAction()
        {
            this.ODataType = "microsoft.graph.recommendLabelAction";
        }

        /// <summary>
        /// Gets or sets label.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "label", Required = Newtonsoft.Json.Required.Default)]
        public LabelDetails Label { get; set; }
    
        /// <summary>
        /// Gets or sets responsibleSensitiveTypeIds.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "responsibleSensitiveTypeIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Guid> ResponsibleSensitiveTypeIds { get; set; }
    
        /// <summary>
        /// Gets or sets actions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "actions", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<InformationProtectionAction> Actions { get; set; }
    
        /// <summary>
        /// Gets or sets actionSource.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "actionSource", Required = Newtonsoft.Json.Required.Default)]
        public ActionSource? ActionSource { get; set; }
    
    }
}