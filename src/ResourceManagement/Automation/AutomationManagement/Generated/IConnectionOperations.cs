// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation
{
    /// <summary>
    /// Service operation for automation connections.  (see
    /// http://aka.ms/azureautomationsdk/connectionoperations for more
    /// information)
    /// </summary>
    public partial interface IConnectionOperations
    {
        /// <summary>
        /// Create a connection.  (see
        /// http://aka.ms/azureautomationsdk/connectionoperations for more
        /// information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// The parameters supplied to the create or update connection
        /// operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the create or update connection operation.
        /// </returns>
        Task<ConnectionCreateOrUpdateResponse> CreateOrUpdateAsync(string resourceGroupName, string automationAccount, ConnectionCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Delete the connection.  (see
        /// http://aka.ms/azureautomationsdk/connectionoperations for more
        /// information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='connectionName'>
        /// The name of connection.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DeleteAsync(string resourceGroupName, string automationAccount, string connectionName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieve the connection identified by connection name.  (see
        /// http://aka.ms/azureautomationsdk/connectionoperations for more
        /// information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='connectionName'>
        /// The name of connection.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the get connection operation.
        /// </returns>
        Task<ConnectionGetResponse> GetAsync(string resourceGroupName, string automationAccount, string connectionName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieve a list of connections.  (see
        /// http://aka.ms/azureautomationsdk/connectionoperations for more
        /// information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list connection operation.
        /// </returns>
        Task<ConnectionListResponse> ListAsync(string resourceGroupName, string automationAccount, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieve next list of connections.  (see
        /// http://aka.ms/azureautomationsdk/connectionoperations for more
        /// information)
        /// </summary>
        /// <param name='nextLink'>
        /// The link to retrieve next set of items.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list connection operation.
        /// </returns>
        Task<ConnectionListResponse> ListNextAsync(string nextLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// Update a connection.  (see
        /// http://aka.ms/azureautomationsdk/connectionoperations for more
        /// information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// The parameters supplied to the patch a connection operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> PatchAsync(string resourceGroupName, string automationAccount, ConnectionPatchParameters parameters, CancellationToken cancellationToken);
    }
}
