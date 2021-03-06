﻿namespace Microsoft.Azure.Batch.SoftwareEntitlement
{
    /// <summary>
    /// Values used to define the claims used in our software entitlement token
    /// </summary>
    public static class Claims
    {
        /// <summary>
        /// The identifier to use for application entitlement claims
        /// </summary>
        public const string Application = "app";

        /// <summary>
        /// The audience for each software entitlement token (essentially we self sign)
        /// </summary>
        public const string Audience = "https://batch.azure.com/software-entitlement";

        /// <summary>
        /// The identifier to use for the actual entitlement id
        /// </summary>
        public const string EntitlementId = "id";

        /// <summary>
        /// The identifier to use for the ip address of the entitled machine
        /// </summary>
        public const string IpAddress = "ip";

        /// <summary>
        /// The issuer of each software entitlement token
        /// </summary>
        public const string Issuer = "https://batch.azure.com/software-entitlement";

        /// <summary>
        /// Identifier use for the claim specifying the permitted virtual machine
        /// </summary>
        public const string VirtualMachineId = "vmid";
    }
}
