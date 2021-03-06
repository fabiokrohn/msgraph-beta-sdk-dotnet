// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IEducationSubmissionResourceRequest.
    /// </summary>
    public partial interface IEducationSubmissionResourceRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EducationSubmissionResource using POST.
        /// </summary>
        /// <param name="educationSubmissionResourceToCreate">The EducationSubmissionResource to create.</param>
        /// <returns>The created EducationSubmissionResource.</returns>
        System.Threading.Tasks.Task<EducationSubmissionResource> CreateAsync(EducationSubmissionResource educationSubmissionResourceToCreate);        /// <summary>
        /// Creates the specified EducationSubmissionResource using POST.
        /// </summary>
        /// <param name="educationSubmissionResourceToCreate">The EducationSubmissionResource to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EducationSubmissionResource.</returns>
        System.Threading.Tasks.Task<EducationSubmissionResource> CreateAsync(EducationSubmissionResource educationSubmissionResourceToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified EducationSubmissionResource.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified EducationSubmissionResource.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified EducationSubmissionResource.
        /// </summary>
        /// <returns>The EducationSubmissionResource.</returns>
        System.Threading.Tasks.Task<EducationSubmissionResource> GetAsync();

        /// <summary>
        /// Gets the specified EducationSubmissionResource.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EducationSubmissionResource.</returns>
        System.Threading.Tasks.Task<EducationSubmissionResource> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified EducationSubmissionResource using PATCH.
        /// </summary>
        /// <param name="educationSubmissionResourceToUpdate">The EducationSubmissionResource to update.</param>
        /// <returns>The updated EducationSubmissionResource.</returns>
        System.Threading.Tasks.Task<EducationSubmissionResource> UpdateAsync(EducationSubmissionResource educationSubmissionResourceToUpdate);

        /// <summary>
        /// Updates the specified EducationSubmissionResource using PATCH.
        /// </summary>
        /// <param name="educationSubmissionResourceToUpdate">The EducationSubmissionResource to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EducationSubmissionResource.</returns>
        System.Threading.Tasks.Task<EducationSubmissionResource> UpdateAsync(EducationSubmissionResource educationSubmissionResourceToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationSubmissionResourceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationSubmissionResourceRequest Expand(Expression<Func<EducationSubmissionResource, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationSubmissionResourceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationSubmissionResourceRequest Select(Expression<Func<EducationSubmissionResource, object>> selectExpression);

    }
}
