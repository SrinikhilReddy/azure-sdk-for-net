// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> List of ExternalNetworks. </summary>
    internal partial class ExternalNetworksList
    {
        /// <summary> Initializes a new instance of ExternalNetworksList. </summary>
        internal ExternalNetworksList()
        {
            Value = new ChangeTrackingList<ExternalNetworkData>();
        }

        /// <summary> Initializes a new instance of ExternalNetworksList. </summary>
        /// <param name="value"> List of ExternalNetworks resources. </param>
        /// <param name="nextLink"> Url to follow for getting next page of resources. </param>
        internal ExternalNetworksList(IReadOnlyList<ExternalNetworkData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of ExternalNetworks resources. </summary>
        public IReadOnlyList<ExternalNetworkData> Value { get; }
        /// <summary> Url to follow for getting next page of resources. </summary>
        public string NextLink { get; }
    }
}
