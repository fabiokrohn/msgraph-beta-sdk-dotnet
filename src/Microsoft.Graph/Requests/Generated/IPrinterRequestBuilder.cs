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
    /// The interface IPrinterRequestBuilder.
    /// </summary>
    public partial interface IPrinterRequestBuilder : IPrinterBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IPrinterRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IPrinterRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for AllowedUsers.
        /// </summary>
        /// <returns>The <see cref="IPrinterAllowedUsersCollectionRequestBuilder"/>.</returns>
        IPrinterAllowedUsersCollectionRequestBuilder AllowedUsers { get; }

        /// <summary>
        /// Gets the request builder for AllowedGroups.
        /// </summary>
        /// <returns>The <see cref="IPrinterAllowedGroupsCollectionRequestBuilder"/>.</returns>
        IPrinterAllowedGroupsCollectionRequestBuilder AllowedGroups { get; }

        /// <summary>
        /// Gets the request builder for Share.
        /// </summary>
        /// <returns>The <see cref="IPrinterShareWithReferenceRequestBuilder"/>.</returns>
        IPrinterShareWithReferenceRequestBuilder Share { get; }

        /// <summary>
        /// Gets the request builder for Connectors.
        /// </summary>
        /// <returns>The <see cref="IPrinterConnectorsCollectionWithReferencesRequestBuilder"/>.</returns>
        IPrinterConnectorsCollectionWithReferencesRequestBuilder Connectors { get; }
    
        /// <summary>
        /// Gets the request builder for PrinterResetDefaults.
        /// </summary>
        /// <returns>The <see cref="IPrinterResetDefaultsRequestBuilder"/>.</returns>
        IPrinterResetDefaultsRequestBuilder ResetDefaults();

        /// <summary>
        /// Gets the request builder for PrinterGetCapabilities.
        /// </summary>
        /// <returns>The <see cref="IPrinterGetCapabilitiesRequestBuilder"/>.</returns>
        IPrinterGetCapabilitiesRequestBuilder GetCapabilities();
    
    }
}
