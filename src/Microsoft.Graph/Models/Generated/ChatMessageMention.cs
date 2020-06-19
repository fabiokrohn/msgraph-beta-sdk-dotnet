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
    /// The type ChatMessageMention.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class ChatMessageMention
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageMention"/> class.
        /// </summary>
        public ChatMessageMention()
        {
            this.ODataType = "microsoft.graph.chatMessageMention";
        }

        /// <summary>
        /// Gets or sets id.
        /// Index of an entity being mentioned in the specified chatMessage. Matches the {index} value in the corresponding &amp;lt;at id='{index}'&amp;gt; tag in the message body.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Id { get; set; }
    
        /// <summary>
        /// Gets or sets mentionText.
        /// String used to represent the mention. For example, a user's display name, a team name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mentionText", Required = Newtonsoft.Json.Required.Default)]
        public string MentionText { get; set; }
    
        /// <summary>
        /// Gets or sets mentioned.
        /// The entity (user, application, team, or channel) that was mentioned.  If it was a channel or team that was @mentioned, the identitySet contains a conversation property giving the ID of the team/channel, and a conversationIdentityType property that represents either the team or channel.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mentioned", Required = Newtonsoft.Json.Required.Default)]
        public IdentitySet Mentioned { get; set; }
    
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
