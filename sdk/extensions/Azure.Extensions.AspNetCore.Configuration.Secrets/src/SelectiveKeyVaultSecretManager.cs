// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Linq;
using Azure.Security.KeyVault.Secrets;

namespace Azure.Extensions.AspNetCore.Configuration.Secrets
{
    /// <summary>
    /// Extends the default implementation of <see cref="KeyVaultSecretManager"/> by allowing
    /// only a specific list of keys to be loaded.
    /// </summary>
    public class SelectiveKeyVaultSecretManager : KeyVaultSecretManager
    {
        internal static new SelectiveKeyVaultSecretManager Instance { get; } = new SelectiveKeyVaultSecretManager(null);

        private readonly string[] _secrets;

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectiveKeyVaultSecretManager"/> class
        /// with a list of secret names to load.
        /// </summary>
        /// <param name="secrets"></param>
        public SelectiveKeyVaultSecretManager(string[] secrets)
        {
            _secrets = secrets;
        }

        /// <inheritdoc/>
        public override bool Load(SecretProperties secret)
        {
            return _secrets?.Length > 0 ? _secrets.Any(s => s.Equals(secret.Name, System.StringComparison.OrdinalIgnoreCase)) : base.Load(secret);
        }
    }
}
