/*
 * Sendbird Platform SDK
 *
 * Sendbird Platform API SDK  https://sendbird.com/docs/chat/v3/platform-api/getting-started/prepare-to-use-api
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@sendbird.com
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
    /// CreateBotData
    /// </summary>
    [DataContract]
    public partial class CreateBotData :  IEquatable<CreateBotData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBotData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateBotData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBotData" /> class.
        /// </summary>
        /// <param name="botUserid">Specifies the unique ID of the bot. The length is limited to 80 characters. (required).</param>
        /// <param name="botNickname">Specifies the bot&#39;s nickname. The length is limited to 80 characters. (required).</param>
        /// <param name="botProfileUrl">Specifies the URL of the bot&#39;s profile image. The size is limited to 2,048 characters. (required).</param>
        /// <param name="botType">Specifies the type of the bot that you can specify for categorization. The length is limited to 128 characters. (required).</param>
        /// <param name="botCallbackUrl">Specifies the server URL where bot is located to receive all events, requests, and data forwarded from an application. For security reasons, it is highly recommended that you use an SSL server. The length is limited to 1,024 characters. (required).</param>
        /// <param name="isPrivacyMode">In the channels of where the bot is a member, determines whether to only forward the messages with the specific conditions to the bot or forword all messages to the bot, for privacy concerns. If set to true, only messages that start with a &#39;/&#39; or mention the bot_userid are forwarded to the bot. If set to false, all messages are forwarded. (required).</param>
        /// <param name="enableMarkAsRead">Determines whether to mark the bot&#39;s message as read upon sending it. (Default: true).</param>
        /// <param name="showMember">Determines whether to include information about the members of each channel in a callback response. (Default: false).</param>
        /// <param name="channelInvitationPreference">channelInvitationPreference.</param>
        public CreateBotData(string botUserid = default(string), string botNickname = default(string), string botProfileUrl = default(string), string botType = default(string), string botCallbackUrl = default(string), bool isPrivacyMode = default(bool), bool enableMarkAsRead = default(bool), bool showMember = default(bool), int channelInvitationPreference = default(int))
        {
            // to ensure "botUserid" is required (not null)
            if (botUserid == null)
            {
                throw new InvalidDataException("botUserid is a required property for CreateBotData and cannot be null");
            }
            else
            {
                this.BotUserid = botUserid;
            }

            // to ensure "botNickname" is required (not null)
            if (botNickname == null)
            {
                throw new InvalidDataException("botNickname is a required property for CreateBotData and cannot be null");
            }
            else
            {
                this.BotNickname = botNickname;
            }

            // to ensure "botProfileUrl" is required (not null)
            if (botProfileUrl == null)
            {
                throw new InvalidDataException("botProfileUrl is a required property for CreateBotData and cannot be null");
            }
            else
            {
                this.BotProfileUrl = botProfileUrl;
            }

            // to ensure "botType" is required (not null)
            if (botType == null)
            {
                throw new InvalidDataException("botType is a required property for CreateBotData and cannot be null");
            }
            else
            {
                this.BotType = botType;
            }

            // to ensure "botCallbackUrl" is required (not null)
            if (botCallbackUrl == null)
            {
                throw new InvalidDataException("botCallbackUrl is a required property for CreateBotData and cannot be null");
            }
            else
            {
                this.BotCallbackUrl = botCallbackUrl;
            }

            // to ensure "isPrivacyMode" is required (not null)
            if (isPrivacyMode == null)
            {
                throw new InvalidDataException("isPrivacyMode is a required property for CreateBotData and cannot be null");
            }
            else
            {
                this.IsPrivacyMode = isPrivacyMode;
            }

            this.EnableMarkAsRead = enableMarkAsRead;
            this.ShowMember = showMember;
            this.ChannelInvitationPreference = channelInvitationPreference;
        }

        /// <summary>
        /// Specifies the unique ID of the bot. The length is limited to 80 characters.
        /// </summary>
        /// <value>Specifies the unique ID of the bot. The length is limited to 80 characters.</value>
        [DataMember(Name="bot_userid", EmitDefaultValue=true)]
        public string BotUserid { get; set; }

        /// <summary>
        /// Specifies the bot&#39;s nickname. The length is limited to 80 characters.
        /// </summary>
        /// <value>Specifies the bot&#39;s nickname. The length is limited to 80 characters.</value>
        [DataMember(Name="bot_nickname", EmitDefaultValue=true)]
        public string BotNickname { get; set; }

        /// <summary>
        /// Specifies the URL of the bot&#39;s profile image. The size is limited to 2,048 characters.
        /// </summary>
        /// <value>Specifies the URL of the bot&#39;s profile image. The size is limited to 2,048 characters.</value>
        [DataMember(Name="bot_profile_url", EmitDefaultValue=true)]
        public string BotProfileUrl { get; set; }

        /// <summary>
        /// Specifies the type of the bot that you can specify for categorization. The length is limited to 128 characters.
        /// </summary>
        /// <value>Specifies the type of the bot that you can specify for categorization. The length is limited to 128 characters.</value>
        [DataMember(Name="bot_type", EmitDefaultValue=true)]
        public string BotType { get; set; }

        /// <summary>
        /// Specifies the server URL where bot is located to receive all events, requests, and data forwarded from an application. For security reasons, it is highly recommended that you use an SSL server. The length is limited to 1,024 characters.
        /// </summary>
        /// <value>Specifies the server URL where bot is located to receive all events, requests, and data forwarded from an application. For security reasons, it is highly recommended that you use an SSL server. The length is limited to 1,024 characters.</value>
        [DataMember(Name="bot_callback_url", EmitDefaultValue=true)]
        public string BotCallbackUrl { get; set; }

        /// <summary>
        /// In the channels of where the bot is a member, determines whether to only forward the messages with the specific conditions to the bot or forword all messages to the bot, for privacy concerns. If set to true, only messages that start with a &#39;/&#39; or mention the bot_userid are forwarded to the bot. If set to false, all messages are forwarded.
        /// </summary>
        /// <value>In the channels of where the bot is a member, determines whether to only forward the messages with the specific conditions to the bot or forword all messages to the bot, for privacy concerns. If set to true, only messages that start with a &#39;/&#39; or mention the bot_userid are forwarded to the bot. If set to false, all messages are forwarded.</value>
        [DataMember(Name="is_privacy_mode", EmitDefaultValue=true)]
        public bool IsPrivacyMode { get; set; }

        /// <summary>
        /// Determines whether to mark the bot&#39;s message as read upon sending it. (Default: true)
        /// </summary>
        /// <value>Determines whether to mark the bot&#39;s message as read upon sending it. (Default: true)</value>
        [DataMember(Name="enable_mark_as_read", EmitDefaultValue=false)]
        public bool EnableMarkAsRead { get; set; }

        /// <summary>
        /// Determines whether to include information about the members of each channel in a callback response. (Default: false)
        /// </summary>
        /// <value>Determines whether to include information about the members of each channel in a callback response. (Default: false)</value>
        [DataMember(Name="show_member", EmitDefaultValue=false)]
        public bool ShowMember { get; set; }

        /// <summary>
        /// Gets or Sets ChannelInvitationPreference
        /// </summary>
        [DataMember(Name="channel_invitation_preference", EmitDefaultValue=false)]
        public int ChannelInvitationPreference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateBotData {\n");
            sb.Append("  BotUserid: ").Append(BotUserid).Append("\n");
            sb.Append("  BotNickname: ").Append(BotNickname).Append("\n");
            sb.Append("  BotProfileUrl: ").Append(BotProfileUrl).Append("\n");
            sb.Append("  BotType: ").Append(BotType).Append("\n");
            sb.Append("  BotCallbackUrl: ").Append(BotCallbackUrl).Append("\n");
            sb.Append("  IsPrivacyMode: ").Append(IsPrivacyMode).Append("\n");
            sb.Append("  EnableMarkAsRead: ").Append(EnableMarkAsRead).Append("\n");
            sb.Append("  ShowMember: ").Append(ShowMember).Append("\n");
            sb.Append("  ChannelInvitationPreference: ").Append(ChannelInvitationPreference).Append("\n");
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
            return this.Equals(input as CreateBotData);
        }

        /// <summary>
        /// Returns true if CreateBotData instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateBotData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateBotData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BotUserid == input.BotUserid ||
                    (this.BotUserid != null &&
                    this.BotUserid.Equals(input.BotUserid))
                ) && 
                (
                    this.BotNickname == input.BotNickname ||
                    (this.BotNickname != null &&
                    this.BotNickname.Equals(input.BotNickname))
                ) && 
                (
                    this.BotProfileUrl == input.BotProfileUrl ||
                    (this.BotProfileUrl != null &&
                    this.BotProfileUrl.Equals(input.BotProfileUrl))
                ) && 
                (
                    this.BotType == input.BotType ||
                    (this.BotType != null &&
                    this.BotType.Equals(input.BotType))
                ) && 
                (
                    this.BotCallbackUrl == input.BotCallbackUrl ||
                    (this.BotCallbackUrl != null &&
                    this.BotCallbackUrl.Equals(input.BotCallbackUrl))
                ) && 
                (
                    this.IsPrivacyMode == input.IsPrivacyMode ||
                    (this.IsPrivacyMode != null &&
                    this.IsPrivacyMode.Equals(input.IsPrivacyMode))
                ) && 
                (
                    this.EnableMarkAsRead == input.EnableMarkAsRead ||
                    (this.EnableMarkAsRead != null &&
                    this.EnableMarkAsRead.Equals(input.EnableMarkAsRead))
                ) && 
                (
                    this.ShowMember == input.ShowMember ||
                    (this.ShowMember != null &&
                    this.ShowMember.Equals(input.ShowMember))
                ) && 
                (
                    this.ChannelInvitationPreference == input.ChannelInvitationPreference ||
                    (this.ChannelInvitationPreference != null &&
                    this.ChannelInvitationPreference.Equals(input.ChannelInvitationPreference))
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
                if (this.BotUserid != null)
                    hashCode = hashCode * 59 + this.BotUserid.GetHashCode();
                if (this.BotNickname != null)
                    hashCode = hashCode * 59 + this.BotNickname.GetHashCode();
                if (this.BotProfileUrl != null)
                    hashCode = hashCode * 59 + this.BotProfileUrl.GetHashCode();
                if (this.BotType != null)
                    hashCode = hashCode * 59 + this.BotType.GetHashCode();
                if (this.BotCallbackUrl != null)
                    hashCode = hashCode * 59 + this.BotCallbackUrl.GetHashCode();
                if (this.IsPrivacyMode != null)
                    hashCode = hashCode * 59 + this.IsPrivacyMode.GetHashCode();
                if (this.EnableMarkAsRead != null)
                    hashCode = hashCode * 59 + this.EnableMarkAsRead.GetHashCode();
                if (this.ShowMember != null)
                    hashCode = hashCode * 59 + this.ShowMember.GetHashCode();
                if (this.ChannelInvitationPreference != null)
                    hashCode = hashCode * 59 + this.ChannelInvitationPreference.GetHashCode();
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
