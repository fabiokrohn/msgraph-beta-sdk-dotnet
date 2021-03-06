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
    /// The type GraphServiceScopedRoleMembershipsCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceScopedRoleMembershipsCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceScopedRoleMembershipsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceScopedRoleMembershipsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceScopedRoleMembershipsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceScopedRoleMembershipsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceScopedRoleMembershipsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceScopedRoleMembershipsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IScopedRoleMembershipRequestBuilder"/> for the specified GraphServiceScopedRoleMembership.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceScopedRoleMembership.</param>
        /// <returns>The <see cref="IScopedRoleMembershipRequestBuilder"/>.</returns>
        public IScopedRoleMembershipRequestBuilder this[string id]
        {
            get
            {
                return new ScopedRoleMembershipRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
