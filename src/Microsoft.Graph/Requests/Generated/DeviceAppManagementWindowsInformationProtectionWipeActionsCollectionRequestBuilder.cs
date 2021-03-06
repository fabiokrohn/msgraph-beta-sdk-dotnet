// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type DeviceAppManagementWindowsInformationProtectionWipeActionsCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceAppManagementWindowsInformationProtectionWipeActionsCollectionRequestBuilder : BaseRequestBuilder, IDeviceAppManagementWindowsInformationProtectionWipeActionsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceAppManagementWindowsInformationProtectionWipeActionsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceAppManagementWindowsInformationProtectionWipeActionsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceAppManagementWindowsInformationProtectionWipeActionsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceAppManagementWindowsInformationProtectionWipeActionsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceAppManagementWindowsInformationProtectionWipeActionsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IWindowsInformationProtectionWipeActionRequestBuilder"/> for the specified DeviceAppManagementWindowsInformationProtectionWipeAction.
        /// </summary>
        /// <param name="id">The ID for the DeviceAppManagementWindowsInformationProtectionWipeAction.</param>
        /// <returns>The <see cref="IWindowsInformationProtectionWipeActionRequestBuilder"/>.</returns>
        public IWindowsInformationProtectionWipeActionRequestBuilder this[string id]
        {
            get
            {
                return new WindowsInformationProtectionWipeActionRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
