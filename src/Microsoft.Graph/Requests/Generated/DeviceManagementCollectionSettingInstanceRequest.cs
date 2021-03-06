// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type DeviceManagementCollectionSettingInstanceRequest.
    /// </summary>
    public partial class DeviceManagementCollectionSettingInstanceRequest : BaseRequest, IDeviceManagementCollectionSettingInstanceRequest
    {
        /// <summary>
        /// Constructs a new DeviceManagementCollectionSettingInstanceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceManagementCollectionSettingInstanceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceManagementCollectionSettingInstance using POST.
        /// </summary>
        /// <param name="deviceManagementCollectionSettingInstanceToCreate">The DeviceManagementCollectionSettingInstance to create.</param>
        /// <returns>The created DeviceManagementCollectionSettingInstance.</returns>
        public System.Threading.Tasks.Task<DeviceManagementCollectionSettingInstance> CreateAsync(DeviceManagementCollectionSettingInstance deviceManagementCollectionSettingInstanceToCreate)
        {
            return this.CreateAsync(deviceManagementCollectionSettingInstanceToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DeviceManagementCollectionSettingInstance using POST.
        /// </summary>
        /// <param name="deviceManagementCollectionSettingInstanceToCreate">The DeviceManagementCollectionSettingInstance to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementCollectionSettingInstance.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementCollectionSettingInstance> CreateAsync(DeviceManagementCollectionSettingInstance deviceManagementCollectionSettingInstanceToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<DeviceManagementCollectionSettingInstance>(deviceManagementCollectionSettingInstanceToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified DeviceManagementCollectionSettingInstance.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementCollectionSettingInstance.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<DeviceManagementCollectionSettingInstance>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified DeviceManagementCollectionSettingInstance.
        /// </summary>
        /// <returns>The DeviceManagementCollectionSettingInstance.</returns>
        public System.Threading.Tasks.Task<DeviceManagementCollectionSettingInstance> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DeviceManagementCollectionSettingInstance.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementCollectionSettingInstance.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementCollectionSettingInstance> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<DeviceManagementCollectionSettingInstance>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceManagementCollectionSettingInstance using PATCH.
        /// </summary>
        /// <param name="deviceManagementCollectionSettingInstanceToUpdate">The DeviceManagementCollectionSettingInstance to update.</param>
        /// <returns>The updated DeviceManagementCollectionSettingInstance.</returns>
        public System.Threading.Tasks.Task<DeviceManagementCollectionSettingInstance> UpdateAsync(DeviceManagementCollectionSettingInstance deviceManagementCollectionSettingInstanceToUpdate)
        {
            return this.UpdateAsync(deviceManagementCollectionSettingInstanceToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DeviceManagementCollectionSettingInstance using PATCH.
        /// </summary>
        /// <param name="deviceManagementCollectionSettingInstanceToUpdate">The DeviceManagementCollectionSettingInstance to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementCollectionSettingInstance.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementCollectionSettingInstance> UpdateAsync(DeviceManagementCollectionSettingInstance deviceManagementCollectionSettingInstanceToUpdate, CancellationToken cancellationToken)
        {
			if (deviceManagementCollectionSettingInstanceToUpdate.AdditionalData != null)
			{
				if (deviceManagementCollectionSettingInstanceToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					deviceManagementCollectionSettingInstanceToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceManagementCollectionSettingInstanceToUpdate.GetType().Name)
						});
				}
			}
            if (deviceManagementCollectionSettingInstanceToUpdate.AdditionalData != null)
            {
                if (deviceManagementCollectionSettingInstanceToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    deviceManagementCollectionSettingInstanceToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceManagementCollectionSettingInstanceToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<DeviceManagementCollectionSettingInstance>(deviceManagementCollectionSettingInstanceToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementCollectionSettingInstanceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementCollectionSettingInstanceRequest Expand(Expression<Func<DeviceManagementCollectionSettingInstance, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementCollectionSettingInstanceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementCollectionSettingInstanceRequest Select(Expression<Func<DeviceManagementCollectionSettingInstance, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="deviceManagementCollectionSettingInstanceToInitialize">The <see cref="DeviceManagementCollectionSettingInstance"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceManagementCollectionSettingInstance deviceManagementCollectionSettingInstanceToInitialize)
        {

            if (deviceManagementCollectionSettingInstanceToInitialize != null && deviceManagementCollectionSettingInstanceToInitialize.AdditionalData != null)
            {

                if (deviceManagementCollectionSettingInstanceToInitialize.Value != null && deviceManagementCollectionSettingInstanceToInitialize.Value.CurrentPage != null)
                {
                    deviceManagementCollectionSettingInstanceToInitialize.Value.AdditionalData = deviceManagementCollectionSettingInstanceToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementCollectionSettingInstanceToInitialize.AdditionalData.TryGetValue("value@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementCollectionSettingInstanceToInitialize.Value.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
