// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Organizational Branding.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class OrganizationalBranding : Entity
    {
    
		///<summary>
		/// The OrganizationalBranding constructor
		///</summary>
        public OrganizationalBranding()
        {
            this.ODataType = "microsoft.graph.organizationalBranding";
        }
	
        /// <summary>
        /// Gets or sets background color.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "backgroundColor", Required = Newtonsoft.Json.Required.Default)]
        public string BackgroundColor { get; set; }
    
        /// <summary>
        /// Gets or sets background image.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "backgroundImage", Required = Newtonsoft.Json.Required.Default)]
        public Stream BackgroundImage { get; set; }
    
        /// <summary>
        /// Gets or sets banner logo.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bannerLogo", Required = Newtonsoft.Json.Required.Default)]
        public Stream BannerLogo { get; set; }
    
        /// <summary>
        /// Gets or sets locale.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "locale", Required = Newtonsoft.Json.Required.Default)]
        public string Locale { get; set; }
    
        /// <summary>
        /// Gets or sets sign in page text.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "signInPageText", Required = Newtonsoft.Json.Required.Default)]
        public string SignInPageText { get; set; }
    
        /// <summary>
        /// Gets or sets square logo.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "squareLogo", Required = Newtonsoft.Json.Required.Default)]
        public Stream SquareLogo { get; set; }
    
        /// <summary>
        /// Gets or sets username hint text.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "usernameHintText", Required = Newtonsoft.Json.Required.Default)]
        public string UsernameHintText { get; set; }
    
    }
}
