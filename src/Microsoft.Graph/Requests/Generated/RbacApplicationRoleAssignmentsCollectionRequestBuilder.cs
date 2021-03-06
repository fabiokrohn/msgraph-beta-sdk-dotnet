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
    /// The type RbacApplicationRoleAssignmentsCollectionRequestBuilder.
    /// </summary>
    public partial class RbacApplicationRoleAssignmentsCollectionRequestBuilder : BaseRequestBuilder, IRbacApplicationRoleAssignmentsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new RbacApplicationRoleAssignmentsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public RbacApplicationRoleAssignmentsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IRbacApplicationRoleAssignmentsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IRbacApplicationRoleAssignmentsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new RbacApplicationRoleAssignmentsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IUnifiedRoleAssignmentRequestBuilder"/> for the specified RbacApplicationUnifiedRoleAssignment.
        /// </summary>
        /// <param name="id">The ID for the RbacApplicationUnifiedRoleAssignment.</param>
        /// <returns>The <see cref="IUnifiedRoleAssignmentRequestBuilder"/>.</returns>
        public IUnifiedRoleAssignmentRequestBuilder this[string id]
        {
            get
            {
                return new UnifiedRoleAssignmentRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
