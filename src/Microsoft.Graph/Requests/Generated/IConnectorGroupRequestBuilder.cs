// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IConnectorGroupRequestBuilder.
    /// </summary>
    public partial interface IConnectorGroupRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IConnectorGroupRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IConnectorGroupRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Members.
        /// </summary>
        /// <returns>The <see cref="IConnectorGroupMembersCollectionWithReferencesRequestBuilder"/>.</returns>
        IConnectorGroupMembersCollectionWithReferencesRequestBuilder Members { get; }

        /// <summary>
        /// Gets the request builder for Applications.
        /// </summary>
        /// <returns>The <see cref="IConnectorGroupApplicationsCollectionWithReferencesRequestBuilder"/>.</returns>
        IConnectorGroupApplicationsCollectionWithReferencesRequestBuilder Applications { get; }
    
    }
}
