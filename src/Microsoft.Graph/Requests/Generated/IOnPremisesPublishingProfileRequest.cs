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
    /// The interface IOnPremisesPublishingProfileRequest.
    /// </summary>
    public partial interface IOnPremisesPublishingProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified OnPremisesPublishingProfile using POST.
        /// </summary>
        /// <param name="onPremisesPublishingProfileToCreate">The OnPremisesPublishingProfile to create.</param>
        /// <returns>The created OnPremisesPublishingProfile.</returns>
        System.Threading.Tasks.Task<OnPremisesPublishingProfile> CreateAsync(OnPremisesPublishingProfile onPremisesPublishingProfileToCreate);        /// <summary>
        /// Creates the specified OnPremisesPublishingProfile using POST.
        /// </summary>
        /// <param name="onPremisesPublishingProfileToCreate">The OnPremisesPublishingProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OnPremisesPublishingProfile.</returns>
        System.Threading.Tasks.Task<OnPremisesPublishingProfile> CreateAsync(OnPremisesPublishingProfile onPremisesPublishingProfileToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified OnPremisesPublishingProfile.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified OnPremisesPublishingProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified OnPremisesPublishingProfile.
        /// </summary>
        /// <returns>The OnPremisesPublishingProfile.</returns>
        System.Threading.Tasks.Task<OnPremisesPublishingProfile> GetAsync();

        /// <summary>
        /// Gets the specified OnPremisesPublishingProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OnPremisesPublishingProfile.</returns>
        System.Threading.Tasks.Task<OnPremisesPublishingProfile> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified OnPremisesPublishingProfile using PATCH.
        /// </summary>
        /// <param name="onPremisesPublishingProfileToUpdate">The OnPremisesPublishingProfile to update.</param>
        /// <returns>The updated OnPremisesPublishingProfile.</returns>
        System.Threading.Tasks.Task<OnPremisesPublishingProfile> UpdateAsync(OnPremisesPublishingProfile onPremisesPublishingProfileToUpdate);

        /// <summary>
        /// Updates the specified OnPremisesPublishingProfile using PATCH.
        /// </summary>
        /// <param name="onPremisesPublishingProfileToUpdate">The OnPremisesPublishingProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OnPremisesPublishingProfile.</returns>
        System.Threading.Tasks.Task<OnPremisesPublishingProfile> UpdateAsync(OnPremisesPublishingProfile onPremisesPublishingProfileToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOnPremisesPublishingProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOnPremisesPublishingProfileRequest Expand(Expression<Func<OnPremisesPublishingProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOnPremisesPublishingProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOnPremisesPublishingProfileRequest Select(Expression<Func<OnPremisesPublishingProfile, object>> selectExpression);

    }
}
