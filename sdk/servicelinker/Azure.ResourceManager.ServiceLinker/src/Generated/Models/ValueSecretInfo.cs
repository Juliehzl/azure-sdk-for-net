// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary> The secret info when type is rawValue. It&apos;s for scenarios that user input the secret. </summary>
    internal partial class ValueSecretInfo : SecretInfoBase
    {
        /// <summary> Initializes a new instance of ValueSecretInfo. </summary>
        public ValueSecretInfo()
        {
            SecretType = SecretType.RawValue;
        }

        /// <summary> Initializes a new instance of ValueSecretInfo. </summary>
        /// <param name="secretType"> The secret type. </param>
        /// <param name="value"> The actual value of the secret. </param>
        internal ValueSecretInfo(SecretType secretType, string value) : base(secretType)
        {
            Value = value;
            SecretType = secretType;
        }

        /// <summary> The actual value of the secret. </summary>
        public string Value { get; set; }
    }
}
