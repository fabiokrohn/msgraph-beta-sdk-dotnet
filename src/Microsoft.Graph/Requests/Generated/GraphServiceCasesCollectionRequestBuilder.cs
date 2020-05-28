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
    /// The type GraphServiceCasesCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceCasesCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceCasesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceCasesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceCasesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceCasesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceCasesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceCasesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IEdiscoveryCaseRequestBuilder"/> for the specified GraphServiceEdiscoveryCase.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceEdiscoveryCase.</param>
        /// <returns>The <see cref="IEdiscoveryCaseRequestBuilder"/>.</returns>
        public IEdiscoveryCaseRequestBuilder this[string id]
        {
            get
            {
                return new EdiscoveryCaseRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}