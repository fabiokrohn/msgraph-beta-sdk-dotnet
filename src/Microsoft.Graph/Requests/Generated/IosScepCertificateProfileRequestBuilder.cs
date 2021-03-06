// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type IosScepCertificateProfileRequestBuilder.
    /// </summary>
    public partial class IosScepCertificateProfileRequestBuilder : IosCertificateProfileBaseRequestBuilder, IIosScepCertificateProfileRequestBuilder
    {

        /// <summary>
        /// Constructs a new IosScepCertificateProfileRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public IosScepCertificateProfileRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IIosScepCertificateProfileRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IIosScepCertificateProfileRequest Request(IEnumerable<Option> options)
        {
            return new IosScepCertificateProfileRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for RootCertificate.
        /// </summary>
        /// <returns>The <see cref="IIosTrustedRootCertificateWithReferenceRequestBuilder"/>.</returns>
        public IIosTrustedRootCertificateWithReferenceRequestBuilder RootCertificate
        {
            get
            {
                return new IosTrustedRootCertificateWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("rootCertificate"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceCertificateStates.
        /// </summary>
        /// <returns>The <see cref="IIosScepCertificateProfileManagedDeviceCertificateStatesCollectionRequestBuilder"/>.</returns>
        public IIosScepCertificateProfileManagedDeviceCertificateStatesCollectionRequestBuilder ManagedDeviceCertificateStates
        {
            get
            {
                return new IosScepCertificateProfileManagedDeviceCertificateStatesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("managedDeviceCertificateStates"), this.Client);
            }
        }
    
    }
}
