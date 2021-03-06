// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ManagedDeviceEnableLostModeRequestBuilder.
    /// </summary>
    public partial class ManagedDeviceEnableLostModeRequestBuilder : BaseActionMethodRequestBuilder<IManagedDeviceEnableLostModeRequest>, IManagedDeviceEnableLostModeRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="ManagedDeviceEnableLostModeRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="message">A message parameter for the OData method call.</param>
        /// <param name="phoneNumber">A phoneNumber parameter for the OData method call.</param>
        /// <param name="footer">A footer parameter for the OData method call.</param>
        public ManagedDeviceEnableLostModeRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string message,
            string phoneNumber,
            string footer)
            : base(requestUrl, client)
        {
            this.SetParameter("message", message, true);
            this.SetParameter("phoneNumber", phoneNumber, true);
            this.SetParameter("footer", footer, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IManagedDeviceEnableLostModeRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new ManagedDeviceEnableLostModeRequest(functionUrl, this.Client, options);

            if (this.HasParameter("message"))
            {
                request.RequestBody.Message = this.GetParameter<string>("message");
            }

            if (this.HasParameter("phoneNumber"))
            {
                request.RequestBody.PhoneNumber = this.GetParameter<string>("phoneNumber");
            }

            if (this.HasParameter("footer"))
            {
                request.RequestBody.Footer = this.GetParameter<string>("footer");
            }

            return request;
        }
    }
}
