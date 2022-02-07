/*
 * Sendbird Platform SDK
 *
 * Sendbird Platform API Javascript SDK  https://sendbird.com/docs/chat/v3/platform-api/getting-started/prepare-to-use-api
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = sendbird-platform-sdk.Client.OpenAPIDateConverter;

namespace sendbird-platform-sdk.Model
{
    /// <summary>
    /// AddFcmPushConfigurationData
    /// </summary>
    [DataContract]
    public partial class AddFcmPushConfigurationData :  IEquatable<AddFcmPushConfigurationData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddFcmPushConfigurationData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddFcmPushConfigurationData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddFcmPushConfigurationData" /> class.
        /// </summary>
        /// <param name="apiKey">Specifies the FCM server key to register. (required).</param>
        /// <param name="pushSound">Specifies the name of a sound file to be played when a push notification is delivered to your client app. The file should be located in the &#x60;/res/raw&#x60; folder. (required).</param>
        public AddFcmPushConfigurationData(string apiKey = default(string), string pushSound = default(string))
        {
            // to ensure "apiKey" is required (not null)
            if (apiKey == null)
            {
                throw new InvalidDataException("apiKey is a required property for AddFcmPushConfigurationData and cannot be null");
            }
            else
            {
                this.ApiKey = apiKey;
            }

            // to ensure "pushSound" is required (not null)
            if (pushSound == null)
            {
                throw new InvalidDataException("pushSound is a required property for AddFcmPushConfigurationData and cannot be null");
            }
            else
            {
                this.PushSound = pushSound;
            }

        }

        /// <summary>
        /// Specifies the FCM server key to register.
        /// </summary>
        /// <value>Specifies the FCM server key to register.</value>
        [DataMember(Name="api_key", EmitDefaultValue=true)]
        public string ApiKey { get; set; }

        /// <summary>
        /// Specifies the name of a sound file to be played when a push notification is delivered to your client app. The file should be located in the &#x60;/res/raw&#x60; folder.
        /// </summary>
        /// <value>Specifies the name of a sound file to be played when a push notification is delivered to your client app. The file should be located in the &#x60;/res/raw&#x60; folder.</value>
        [DataMember(Name="push_sound", EmitDefaultValue=true)]
        public string PushSound { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddFcmPushConfigurationData {\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
            sb.Append("  PushSound: ").Append(PushSound).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddFcmPushConfigurationData);
        }

        /// <summary>
        /// Returns true if AddFcmPushConfigurationData instances are equal
        /// </summary>
        /// <param name="input">Instance of AddFcmPushConfigurationData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddFcmPushConfigurationData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApiKey == input.ApiKey ||
                    (this.ApiKey != null &&
                    this.ApiKey.Equals(input.ApiKey))
                ) && 
                (
                    this.PushSound == input.PushSound ||
                    (this.PushSound != null &&
                    this.PushSound.Equals(input.PushSound))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ApiKey != null)
                    hashCode = hashCode * 59 + this.ApiKey.GetHashCode();
                if (this.PushSound != null)
                    hashCode = hashCode * 59 + this.PushSound.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
