// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.15.0.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.TrafficManager.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Class containing DNS settings in a Traffic Manager profile.
    /// </summary>
    public partial class DnsConfig
    {
        /// <summary>
        /// Initializes a new instance of the DnsConfig class.
        /// </summary>
        public DnsConfig() { }

        /// <summary>
        /// Initializes a new instance of the DnsConfig class.
        /// </summary>
        public DnsConfig(string relativeName = default(string), string fqdn = default(string), long? ttl = default(long?))
        {
            RelativeName = relativeName;
            Fqdn = fqdn;
            Ttl = ttl;
        }

        /// <summary>
        /// Gets or sets the relative DNS name provided by this Traffic
        /// Manager profile.  This value is combined with the DNS domain name
        /// used by Azure Traffic Manager to form the fully-qualified domain
        /// name (FQDN) of the profile.
        /// </summary>
        [JsonProperty(PropertyName = "relativeName")]
        public string RelativeName { get; set; }

        /// <summary>
        /// Gets or sets the fully-qualified domain name (FQDN) of the Traffic
        /// Manager profile.  This is formed from the concatenation of the
        /// RelativeName with the DNS domain used by Azure Traffic Manager.
        /// </summary>
        [JsonProperty(PropertyName = "fqdn")]
        public string Fqdn { get; set; }

        /// <summary>
        /// Gets or sets the DNS Ttime-To-Live (TTL), in seconds.  This
        /// informs the local DNS resolvers and DNS clients how long to cache
        /// DNS responses provided by this Traffic Manager profile.
        /// </summary>
        [JsonProperty(PropertyName = "ttl")]
        public long? Ttl { get; set; }

    }
}
