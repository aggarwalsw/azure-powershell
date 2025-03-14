// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Resources.Models
{
    using System.Linq;

    /// <summary>
    /// Information about a tenant managing the subscription.
    /// </summary>
    public partial class ManagedByTenant
    {
        /// <summary>
        /// Initializes a new instance of the ManagedByTenant class.
        /// </summary>
        public ManagedByTenant()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedByTenant class.
        /// </summary>

        /// <param name="tenantId">The tenant ID of the managing tenant. This is a GUID.
        /// </param>
        public ManagedByTenant(string tenantId = default(string))

        {
            this.TenantId = tenantId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the tenant ID of the managing tenant. This is a GUID.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tenantId")]
        public string TenantId {get; private set; }
    }
}