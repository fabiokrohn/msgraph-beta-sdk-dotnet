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
    /// The interface IDeviceManagementExportJobRequest.
    /// </summary>
    public partial interface IDeviceManagementExportJobRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceManagementExportJob using POST.
        /// </summary>
        /// <param name="deviceManagementExportJobToCreate">The DeviceManagementExportJob to create.</param>
        /// <returns>The created DeviceManagementExportJob.</returns>
        System.Threading.Tasks.Task<DeviceManagementExportJob> CreateAsync(DeviceManagementExportJob deviceManagementExportJobToCreate);        /// <summary>
        /// Creates the specified DeviceManagementExportJob using POST.
        /// </summary>
        /// <param name="deviceManagementExportJobToCreate">The DeviceManagementExportJob to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementExportJob.</returns>
        System.Threading.Tasks.Task<DeviceManagementExportJob> CreateAsync(DeviceManagementExportJob deviceManagementExportJobToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceManagementExportJob.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceManagementExportJob.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceManagementExportJob.
        /// </summary>
        /// <returns>The DeviceManagementExportJob.</returns>
        System.Threading.Tasks.Task<DeviceManagementExportJob> GetAsync();

        /// <summary>
        /// Gets the specified DeviceManagementExportJob.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementExportJob.</returns>
        System.Threading.Tasks.Task<DeviceManagementExportJob> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceManagementExportJob using PATCH.
        /// </summary>
        /// <param name="deviceManagementExportJobToUpdate">The DeviceManagementExportJob to update.</param>
        /// <returns>The updated DeviceManagementExportJob.</returns>
        System.Threading.Tasks.Task<DeviceManagementExportJob> UpdateAsync(DeviceManagementExportJob deviceManagementExportJobToUpdate);

        /// <summary>
        /// Updates the specified DeviceManagementExportJob using PATCH.
        /// </summary>
        /// <param name="deviceManagementExportJobToUpdate">The DeviceManagementExportJob to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementExportJob.</returns>
        System.Threading.Tasks.Task<DeviceManagementExportJob> UpdateAsync(DeviceManagementExportJob deviceManagementExportJobToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementExportJobRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementExportJobRequest Expand(Expression<Func<DeviceManagementExportJob, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementExportJobRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementExportJobRequest Select(Expression<Func<DeviceManagementExportJob, object>> selectExpression);

    }
}
