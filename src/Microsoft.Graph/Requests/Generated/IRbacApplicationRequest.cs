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
    /// The interface IRbacApplicationRequest.
    /// </summary>
    public partial interface IRbacApplicationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified RbacApplication using POST.
        /// </summary>
        /// <param name="rbacApplicationToCreate">The RbacApplication to create.</param>
        /// <returns>The created RbacApplication.</returns>
        System.Threading.Tasks.Task<RbacApplication> CreateAsync(RbacApplication rbacApplicationToCreate);        /// <summary>
        /// Creates the specified RbacApplication using POST.
        /// </summary>
        /// <param name="rbacApplicationToCreate">The RbacApplication to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created RbacApplication.</returns>
        System.Threading.Tasks.Task<RbacApplication> CreateAsync(RbacApplication rbacApplicationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified RbacApplication.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified RbacApplication.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified RbacApplication.
        /// </summary>
        /// <returns>The RbacApplication.</returns>
        System.Threading.Tasks.Task<RbacApplication> GetAsync();

        /// <summary>
        /// Gets the specified RbacApplication.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The RbacApplication.</returns>
        System.Threading.Tasks.Task<RbacApplication> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified RbacApplication using PATCH.
        /// </summary>
        /// <param name="rbacApplicationToUpdate">The RbacApplication to update.</param>
        /// <returns>The updated RbacApplication.</returns>
        System.Threading.Tasks.Task<RbacApplication> UpdateAsync(RbacApplication rbacApplicationToUpdate);

        /// <summary>
        /// Updates the specified RbacApplication using PATCH.
        /// </summary>
        /// <param name="rbacApplicationToUpdate">The RbacApplication to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated RbacApplication.</returns>
        System.Threading.Tasks.Task<RbacApplication> UpdateAsync(RbacApplication rbacApplicationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IRbacApplicationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IRbacApplicationRequest Expand(Expression<Func<RbacApplication, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IRbacApplicationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IRbacApplicationRequest Select(Expression<Func<RbacApplication, object>> selectExpression);

    }
}
