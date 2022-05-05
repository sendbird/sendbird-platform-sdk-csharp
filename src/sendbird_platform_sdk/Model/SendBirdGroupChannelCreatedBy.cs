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
using OpenAPIDateConverter = sendbird_platform_sdk.Client.OpenAPIDateConverter;

namespace sendbird_platform_sdk.Model
{
    /// <summary>
    /// SendBirdGroupChannelCreatedBy
    /// </summary>
    [DataContract]
    public partial class SendBirdGroupChannelCreatedBy :  IEquatable<SendBirdGroupChannelCreatedBy>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendBirdGroupChannelCreatedBy" /> class.
        /// </summary>
        /// <param name="requireAuthForProfileImage">requireAuthForProfileImage.</param>
        /// <param name="nickname">nickname.</param>
        /// <param name="userId">userId.</param>
        /// <param name="profileUrl">profileUrl.</param>
        public SendBirdGroupChannelCreatedBy(bool requireAuthForProfileImage = default(bool), string nickname = default(string), string userId = default(string), string profileUrl = default(string))
        {
            this.RequireAuthForProfileImage = requireAuthForProfileImage;
            this.Nickname = nickname;
            this.UserId = userId;
            this.ProfileUrl = profileUrl;
        }

        /// <summary>
        /// Gets or Sets RequireAuthForProfileImage
        /// </summary>
        [DataMember(Name="require_auth_for_profile_image", EmitDefaultValue=false)]
        public bool RequireAuthForProfileImage { get; set; }

        /// <summary>
        /// Gets or Sets Nickname
        /// </summary>
        [DataMember(Name="nickname", EmitDefaultValue=false)]
        public string Nickname { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or Sets ProfileUrl
        /// </summary>
        [DataMember(Name="profile_url", EmitDefaultValue=false)]
        public string ProfileUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendBirdGroupChannelCreatedBy {\n");
            sb.Append("  RequireAuthForProfileImage: ").Append(RequireAuthForProfileImage).Append("\n");
            sb.Append("  Nickname: ").Append(Nickname).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ProfileUrl: ").Append(ProfileUrl).Append("\n");
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
            return this.Equals(input as SendBirdGroupChannelCreatedBy);
        }

        /// <summary>
        /// Returns true if SendBirdGroupChannelCreatedBy instances are equal
        /// </summary>
        /// <param name="input">Instance of SendBirdGroupChannelCreatedBy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendBirdGroupChannelCreatedBy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequireAuthForProfileImage == input.RequireAuthForProfileImage ||
                    (this.RequireAuthForProfileImage != null &&
                    this.RequireAuthForProfileImage.Equals(input.RequireAuthForProfileImage))
                ) && 
                (
                    this.Nickname == input.Nickname ||
                    (this.Nickname != null &&
                    this.Nickname.Equals(input.Nickname))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.ProfileUrl == input.ProfileUrl ||
                    (this.ProfileUrl != null &&
                    this.ProfileUrl.Equals(input.ProfileUrl))
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
                if (this.RequireAuthForProfileImage != null)
                    hashCode = hashCode * 59 + this.RequireAuthForProfileImage.GetHashCode();
                if (this.Nickname != null)
                    hashCode = hashCode * 59 + this.Nickname.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.ProfileUrl != null)
                    hashCode = hashCode * 59 + this.ProfileUrl.GetHashCode();
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
