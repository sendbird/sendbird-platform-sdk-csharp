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
    /// CreateUserData
    /// </summary>
    [DataContract]
    public partial class CreateUserData :  IEquatable<CreateUserData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateUserData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserData" /> class.
        /// </summary>
        /// <param name="userId">Specifies a user&#39;s unique ID, which is used to sign into the Sendbird service. The length is limited to 80 characters.&lt;br /&gt;&lt;br /&gt; Do not use PII (Personally Identifiable Information) of your service, such as user email address, legal name or phone number. (required).</param>
        /// <param name="nickname">Specifies a nickname for a new user. The length is limited to 80 characters. (required).</param>
        /// <param name="profileUrl">Specifies the URL of the user&#39;s profile image. If left empty, no profile image is set for the user. The length is limited to 2,048 characters.&lt;br /&gt;&lt;br /&gt; The [domain filter](/docs/chat/v3/platform-api/guides/filter-and-moderation#2-domain-filter) filters out the request if the value of this property matches the filter&#39;s domain set. (required).</param>
        /// <param name="profileFile">Uploads the file of the user&#39;s profile image. An acceptable image is limited to &#x60;JPG&#x60; (.jpg), &#x60;JPEG&#x60; (.jpeg), or &#x60;PNG&#x60; (.png) file of up to 25 MB..</param>
        /// <param name="issueAccessToken">Determines whether to create an access token for the user. If true, an opaque string token is issued and provided upon creation, which should be passed whenever the user logs in. If false, an access token is not required when the user logs in. (Default: false).</param>
        /// <param name="discoveryKeys">Specifies an array of unique keys of the user which is provided to Sendbird server for discovering friends. By using the keys, the server can identify and match the user with other users..</param>
        /// <param name="metadata">Specifies a &#x60;JSON&#x60; object to store key-value items for additional user information such as phone number, email or a long description of the user. The key must not have a comma (,) and its length is limited to 128 characters. The value must be a string and its length is limited to 190 characters. This property can have up to 5 items..</param>
        public CreateUserData(string userId = default(string), string nickname = default(string), string profileUrl = default(string), System.IO.Stream profileFile = default(System.IO.Stream), bool issueAccessToken = default(bool), List<string> discoveryKeys = default(List<string>), string metadata = default(string))
        {
            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new InvalidDataException("userId is a required property for CreateUserData and cannot be null");
            }
            else
            {
                this.UserId = userId;
            }

            // to ensure "nickname" is required (not null)
            if (nickname == null)
            {
                throw new InvalidDataException("nickname is a required property for CreateUserData and cannot be null");
            }
            else
            {
                this.Nickname = nickname;
            }

            // to ensure "profileUrl" is required (not null)
            if (profileUrl == null)
            {
                throw new InvalidDataException("profileUrl is a required property for CreateUserData and cannot be null");
            }
            else
            {
                this.ProfileUrl = profileUrl;
            }

            this.ProfileFile = profileFile;
            this.IssueAccessToken = issueAccessToken;
            this.DiscoveryKeys = discoveryKeys;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Specifies a user&#39;s unique ID, which is used to sign into the Sendbird service. The length is limited to 80 characters.&lt;br /&gt;&lt;br /&gt; Do not use PII (Personally Identifiable Information) of your service, such as user email address, legal name or phone number.
        /// </summary>
        /// <value>Specifies a user&#39;s unique ID, which is used to sign into the Sendbird service. The length is limited to 80 characters.&lt;br /&gt;&lt;br /&gt; Do not use PII (Personally Identifiable Information) of your service, such as user email address, legal name or phone number.</value>
        [DataMember(Name="user_id", EmitDefaultValue=true)]
        public string UserId { get; set; }

        /// <summary>
        /// Specifies a nickname for a new user. The length is limited to 80 characters.
        /// </summary>
        /// <value>Specifies a nickname for a new user. The length is limited to 80 characters.</value>
        [DataMember(Name="nickname", EmitDefaultValue=true)]
        public string Nickname { get; set; }

        /// <summary>
        /// Specifies the URL of the user&#39;s profile image. If left empty, no profile image is set for the user. The length is limited to 2,048 characters.&lt;br /&gt;&lt;br /&gt; The [domain filter](/docs/chat/v3/platform-api/guides/filter-and-moderation#2-domain-filter) filters out the request if the value of this property matches the filter&#39;s domain set.
        /// </summary>
        /// <value>Specifies the URL of the user&#39;s profile image. If left empty, no profile image is set for the user. The length is limited to 2,048 characters.&lt;br /&gt;&lt;br /&gt; The [domain filter](/docs/chat/v3/platform-api/guides/filter-and-moderation#2-domain-filter) filters out the request if the value of this property matches the filter&#39;s domain set.</value>
        [DataMember(Name="profile_url", EmitDefaultValue=true)]
        public string ProfileUrl { get; set; }

        /// <summary>
        /// Uploads the file of the user&#39;s profile image. An acceptable image is limited to &#x60;JPG&#x60; (.jpg), &#x60;JPEG&#x60; (.jpeg), or &#x60;PNG&#x60; (.png) file of up to 25 MB.
        /// </summary>
        /// <value>Uploads the file of the user&#39;s profile image. An acceptable image is limited to &#x60;JPG&#x60; (.jpg), &#x60;JPEG&#x60; (.jpeg), or &#x60;PNG&#x60; (.png) file of up to 25 MB.</value>
        [DataMember(Name="profile_file", EmitDefaultValue=false)]
        public System.IO.Stream ProfileFile { get; set; }

        /// <summary>
        /// Determines whether to create an access token for the user. If true, an opaque string token is issued and provided upon creation, which should be passed whenever the user logs in. If false, an access token is not required when the user logs in. (Default: false)
        /// </summary>
        /// <value>Determines whether to create an access token for the user. If true, an opaque string token is issued and provided upon creation, which should be passed whenever the user logs in. If false, an access token is not required when the user logs in. (Default: false)</value>
        [DataMember(Name="issue_access_token", EmitDefaultValue=false)]
        public bool IssueAccessToken { get; set; }

        /// <summary>
        /// Specifies an array of unique keys of the user which is provided to Sendbird server for discovering friends. By using the keys, the server can identify and match the user with other users.
        /// </summary>
        /// <value>Specifies an array of unique keys of the user which is provided to Sendbird server for discovering friends. By using the keys, the server can identify and match the user with other users.</value>
        [DataMember(Name="discovery_keys", EmitDefaultValue=false)]
        public List<string> DiscoveryKeys { get; set; }

        /// <summary>
        /// Specifies a &#x60;JSON&#x60; object to store key-value items for additional user information such as phone number, email or a long description of the user. The key must not have a comma (,) and its length is limited to 128 characters. The value must be a string and its length is limited to 190 characters. This property can have up to 5 items.
        /// </summary>
        /// <value>Specifies a &#x60;JSON&#x60; object to store key-value items for additional user information such as phone number, email or a long description of the user. The key must not have a comma (,) and its length is limited to 128 characters. The value must be a string and its length is limited to 190 characters. This property can have up to 5 items.</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public string Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateUserData {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Nickname: ").Append(Nickname).Append("\n");
            sb.Append("  ProfileUrl: ").Append(ProfileUrl).Append("\n");
            sb.Append("  ProfileFile: ").Append(ProfileFile).Append("\n");
            sb.Append("  IssueAccessToken: ").Append(IssueAccessToken).Append("\n");
            sb.Append("  DiscoveryKeys: ").Append(DiscoveryKeys).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(input as CreateUserData);
        }

        /// <summary>
        /// Returns true if CreateUserData instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateUserData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateUserData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Nickname == input.Nickname ||
                    (this.Nickname != null &&
                    this.Nickname.Equals(input.Nickname))
                ) && 
                (
                    this.ProfileUrl == input.ProfileUrl ||
                    (this.ProfileUrl != null &&
                    this.ProfileUrl.Equals(input.ProfileUrl))
                ) && 
                (
                    this.ProfileFile == input.ProfileFile ||
                    (this.ProfileFile != null &&
                    this.ProfileFile.Equals(input.ProfileFile))
                ) && 
                (
                    this.IssueAccessToken == input.IssueAccessToken ||
                    (this.IssueAccessToken != null &&
                    this.IssueAccessToken.Equals(input.IssueAccessToken))
                ) && 
                (
                    this.DiscoveryKeys == input.DiscoveryKeys ||
                    this.DiscoveryKeys != null &&
                    input.DiscoveryKeys != null &&
                    this.DiscoveryKeys.SequenceEqual(input.DiscoveryKeys)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Nickname != null)
                    hashCode = hashCode * 59 + this.Nickname.GetHashCode();
                if (this.ProfileUrl != null)
                    hashCode = hashCode * 59 + this.ProfileUrl.GetHashCode();
                if (this.ProfileFile != null)
                    hashCode = hashCode * 59 + this.ProfileFile.GetHashCode();
                if (this.IssueAccessToken != null)
                    hashCode = hashCode * 59 + this.IssueAccessToken.GetHashCode();
                if (this.DiscoveryKeys != null)
                    hashCode = hashCode * 59 + this.DiscoveryKeys.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
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
