// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> Bastion Host resource. </summary>
    public partial class BastionHost : Resource
    {
        /// <summary> Initializes a new instance of BastionHost. </summary>
        public BastionHost()
        {
        }

        /// <summary> Initializes a new instance of BastionHost. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="ipConfigurations"> IP configuration of the Bastion Host resource. </param>
        /// <param name="dnsName"> FQDN for the endpoint on which bastion host is accessible. </param>
        /// <param name="provisioningState"> The provisioning state of the bastion host resource. </param>
        internal BastionHost(string id, string name, string type, string location, IDictionary<string, string> tags, string etag, IList<BastionHostIPConfiguration> ipConfigurations, string dnsName, ProvisioningState? provisioningState) : base(id, name, type, location, tags)
        {
            Etag = etag;
            IpConfigurations = ipConfigurations;
            DnsName = dnsName;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> IP configuration of the Bastion Host resource. </summary>
        public IList<BastionHostIPConfiguration> IpConfigurations { get; set; }
        /// <summary> FQDN for the endpoint on which bastion host is accessible. </summary>
        public string DnsName { get; set; }
        /// <summary> The provisioning state of the bastion host resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}