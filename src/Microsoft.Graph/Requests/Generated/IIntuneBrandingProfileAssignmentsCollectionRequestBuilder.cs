// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IIntuneBrandingProfileAssignmentsCollectionRequestBuilder.
    /// </summary>
    public partial interface IIntuneBrandingProfileAssignmentsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IIntuneBrandingProfileAssignmentsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IIntuneBrandingProfileAssignmentsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IIntuneBrandingProfileAssignmentRequestBuilder"/> for the specified IntuneBrandingProfileAssignment.
        /// </summary>
        /// <param name="id">The ID for the IntuneBrandingProfileAssignment.</param>
        /// <returns>The <see cref="IIntuneBrandingProfileAssignmentRequestBuilder"/>.</returns>
        IIntuneBrandingProfileAssignmentRequestBuilder this[string id] { get; }

        
    }
}
