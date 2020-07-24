// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SqlPoolsV3Operations.
    /// </summary>
    public static partial class SqlPoolsV3OperationsExtensions
    {
            /// <summary>
            /// Gets a SqlPool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// The name of the sql pool.
            /// </param>
            public static SqlPoolV3 Get(this ISqlPoolsV3Operations operations, string resourceGroupName, string workspaceName, string sqlPoolName)
            {
                return operations.GetAsync(resourceGroupName, workspaceName, sqlPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a SqlPool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// The name of the sql pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SqlPoolV3> GetAsync(this ISqlPoolsV3Operations operations, string resourceGroupName, string workspaceName, string sqlPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new SqlPool or updates an existing SqlPool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// The name of the sql pool.
            /// </param>
            /// <param name='parameters'>
            /// The requested SqlPool resource state.
            /// </param>
            public static SqlPoolV3 CreateOrUpdate(this ISqlPoolsV3Operations operations, string resourceGroupName, string workspaceName, string sqlPoolName, SqlPoolV3 parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, workspaceName, sqlPoolName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new SqlPool or updates an existing SqlPool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// The name of the sql pool.
            /// </param>
            /// <param name='parameters'>
            /// The requested SqlPool resource state.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SqlPoolV3> CreateOrUpdateAsync(this ISqlPoolsV3Operations operations, string resourceGroupName, string workspaceName, string sqlPoolName, SqlPoolV3 parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the SqlPool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// The name of the sql pool.
            /// </param>
            public static void Delete(this ISqlPoolsV3Operations operations, string resourceGroupName, string workspaceName, string sqlPoolName)
            {
                operations.DeleteAsync(resourceGroupName, workspaceName, sqlPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the SqlPool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// The name of the sql pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISqlPoolsV3Operations operations, string resourceGroupName, string workspaceName, string sqlPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates an existing sqlpool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// The name of the sql pool.
            /// </param>
            /// <param name='parameters'>
            /// The requested SqlPool resource state.
            /// </param>
            public static SqlPoolV3 Update(this ISqlPoolsV3Operations operations, string resourceGroupName, string workspaceName, string sqlPoolName, SqlPoolUpdate parameters)
            {
                return operations.UpdateAsync(resourceGroupName, workspaceName, sqlPoolName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an existing sqlpool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// The name of the sql pool.
            /// </param>
            /// <param name='parameters'>
            /// The requested SqlPool resource state.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SqlPoolV3> UpdateAsync(this ISqlPoolsV3Operations operations, string resourceGroupName, string workspaceName, string sqlPoolName, SqlPoolUpdate parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of sql pools.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            public static IPage<SqlPoolV3> ListByWorkspace(this ISqlPoolsV3Operations operations, string resourceGroupName, string workspaceName)
            {
                return operations.ListByWorkspaceAsync(resourceGroupName, workspaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of sql pools.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SqlPoolV3>> ListByWorkspaceAsync(this ISqlPoolsV3Operations operations, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByWorkspaceWithHttpMessagesAsync(resourceGroupName, workspaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new SqlPool or updates an existing SqlPool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// The name of the sql pool.
            /// </param>
            /// <param name='parameters'>
            /// The requested SqlPool resource state.
            /// </param>
            public static SqlPoolV3 BeginCreateOrUpdate(this ISqlPoolsV3Operations operations, string resourceGroupName, string workspaceName, string sqlPoolName, SqlPoolV3 parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, workspaceName, sqlPoolName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new SqlPool or updates an existing SqlPool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// The name of the sql pool.
            /// </param>
            /// <param name='parameters'>
            /// The requested SqlPool resource state.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SqlPoolV3> BeginCreateOrUpdateAsync(this ISqlPoolsV3Operations operations, string resourceGroupName, string workspaceName, string sqlPoolName, SqlPoolV3 parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the SqlPool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// The name of the sql pool.
            /// </param>
            public static void BeginDelete(this ISqlPoolsV3Operations operations, string resourceGroupName, string workspaceName, string sqlPoolName)
            {
                operations.BeginDeleteAsync(resourceGroupName, workspaceName, sqlPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the SqlPool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// The name of the sql pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this ISqlPoolsV3Operations operations, string resourceGroupName, string workspaceName, string sqlPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates an existing sqlpool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// The name of the sql pool.
            /// </param>
            /// <param name='parameters'>
            /// The requested SqlPool resource state.
            /// </param>
            public static SqlPoolV3 BeginUpdate(this ISqlPoolsV3Operations operations, string resourceGroupName, string workspaceName, string sqlPoolName, SqlPoolUpdate parameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, workspaceName, sqlPoolName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an existing sqlpool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='sqlPoolName'>
            /// The name of the sql pool.
            /// </param>
            /// <param name='parameters'>
            /// The requested SqlPool resource state.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SqlPoolV3> BeginUpdateAsync(this ISqlPoolsV3Operations operations, string resourceGroupName, string workspaceName, string sqlPoolName, SqlPoolUpdate parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of sql pools.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SqlPoolV3> ListByWorkspaceNext(this ISqlPoolsV3Operations operations, string nextPageLink)
            {
                return operations.ListByWorkspaceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of sql pools.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SqlPoolV3>> ListByWorkspaceNextAsync(this ISqlPoolsV3Operations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByWorkspaceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}