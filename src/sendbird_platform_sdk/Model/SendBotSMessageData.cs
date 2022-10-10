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
    /// SendBotSMessageData
    /// </summary>
    [DataContract]
    public partial class SendBotSMessageData :  IEquatable<SendBotSMessageData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendBotSMessageData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SendBotSMessageData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SendBotSMessageData" /> class.
        /// </summary>
        /// <param name="message">Specifies the content of the message sent by the bot. (required).</param>
        /// <param name="channelUrl">Specifies the URL of the channel where the message is sent to. (required).</param>
        /// <param name="customType">Specifies a custom message type which is used for message grouping. The length is limited to 128 characters..</param>
        /// <param name="data">Specifies additional message information such as custom font size, font type or &#x60;JSON&#x60; formatted string..</param>
        /// <param name="sendPush">Determines whether to send a push notification for the message to the members of the channel (Default: true).</param>
        /// <param name="mentioned">Specifies an array of one or more IDs of the users who get a notification for the message..</param>
        /// <param name="markAsRead">Determines whether to mark the message as read for the bot. If set to false, the bot&#39;s unread_count and read_receipt remain unchanged after the message is sent. (Default: true).</param>
        /// <param name="dedupId">Specifies the unique ID for the message to prevent the same message data from getting sent to the channel..</param>
        /// <param name="createdAt">Specifies the time that the message was sent, in [Unix milliseconds](/docs/chat/v3/platform-api/guides/miscellaneous#2-timestamps) format..</param>
        public SendBotSMessageData(string message = default(string), string channelUrl = default(string), string customType = default(string), string data = default(string), bool sendPush = default(bool), List<string> mentioned = default(List<string>), bool markAsRead = default(bool), string dedupId = default(string), int createdAt = default(int))
        {
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new InvalidDataException("message is a required property for SendBotSMessageData and cannot be null");
            }
            else
            {
                this.Message = message;
            }

            // to ensure "channelUrl" is required (not null)
            if (channelUrl == null)
            {
                throw new InvalidDataException("channelUrl is a required property for SendBotSMessageData and cannot be null");
            }
            else
            {
                this.ChannelUrl = channelUrl;
            }

            this.CustomType = customType;
            this.Data = data;
            this.SendPush = sendPush;
            this.Mentioned = mentioned;
            this.MarkAsRead = markAsRead;
            this.DedupId = dedupId;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Specifies the content of the message sent by the bot.
        /// </summary>
        /// <value>Specifies the content of the message sent by the bot.</value>
        [DataMember(Name="message", EmitDefaultValue=true)]
        public string Message { get; set; }

        /// <summary>
        /// Specifies the URL of the channel where the message is sent to.
        /// </summary>
        /// <value>Specifies the URL of the channel where the message is sent to.</value>
        [DataMember(Name="channel_url", EmitDefaultValue=true)]
        public string ChannelUrl { get; set; }

        /// <summary>
        /// Specifies a custom message type which is used for message grouping. The length is limited to 128 characters.
        /// </summary>
        /// <value>Specifies a custom message type which is used for message grouping. The length is limited to 128 characters.</value>
        [DataMember(Name="custom_type", EmitDefaultValue=false)]
        public string CustomType { get; set; }

        /// <summary>
        /// Specifies additional message information such as custom font size, font type or &#x60;JSON&#x60; formatted string.
        /// </summary>
        /// <value>Specifies additional message information such as custom font size, font type or &#x60;JSON&#x60; formatted string.</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public string Data { get; set; }

        /// <summary>
        /// Determines whether to send a push notification for the message to the members of the channel (Default: true)
        /// </summary>
        /// <value>Determines whether to send a push notification for the message to the members of the channel (Default: true)</value>
        [DataMember(Name="send_push", EmitDefaultValue=false)]
        public bool SendPush { get; set; }

        /// <summary>
        /// Specifies an array of one or more IDs of the users who get a notification for the message.
        /// </summary>
        /// <value>Specifies an array of one or more IDs of the users who get a notification for the message.</value>
        [DataMember(Name="mentioned", EmitDefaultValue=false)]
        public List<string> Mentioned { get; set; }

        /// <summary>
        /// Determines whether to mark the message as read for the bot. If set to false, the bot&#39;s unread_count and read_receipt remain unchanged after the message is sent. (Default: true)
        /// </summary>
        /// <value>Determines whether to mark the message as read for the bot. If set to false, the bot&#39;s unread_count and read_receipt remain unchanged after the message is sent. (Default: true)</value>
        [DataMember(Name="mark_as_read", EmitDefaultValue=false)]
        public bool MarkAsRead { get; set; }

        /// <summary>
        /// Specifies the unique ID for the message to prevent the same message data from getting sent to the channel.
        /// </summary>
        /// <value>Specifies the unique ID for the message to prevent the same message data from getting sent to the channel.</value>
        [DataMember(Name="dedup_id", EmitDefaultValue=false)]
        public string DedupId { get; set; }

        /// <summary>
        /// Specifies the time that the message was sent, in [Unix milliseconds](/docs/chat/v3/platform-api/guides/miscellaneous#2-timestamps) format.
        /// </summary>
        /// <value>Specifies the time that the message was sent, in [Unix milliseconds](/docs/chat/v3/platform-api/guides/miscellaneous#2-timestamps) format.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public int CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendBotSMessageData {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  ChannelUrl: ").Append(ChannelUrl).Append("\n");
            sb.Append("  CustomType: ").Append(CustomType).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  SendPush: ").Append(SendPush).Append("\n");
            sb.Append("  Mentioned: ").Append(Mentioned).Append("\n");
            sb.Append("  MarkAsRead: ").Append(MarkAsRead).Append("\n");
            sb.Append("  DedupId: ").Append(DedupId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(input as SendBotSMessageData);
        }

        /// <summary>
        /// Returns true if SendBotSMessageData instances are equal
        /// </summary>
        /// <param name="input">Instance of SendBotSMessageData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendBotSMessageData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.ChannelUrl == input.ChannelUrl ||
                    (this.ChannelUrl != null &&
                    this.ChannelUrl.Equals(input.ChannelUrl))
                ) && 
                (
                    this.CustomType == input.CustomType ||
                    (this.CustomType != null &&
                    this.CustomType.Equals(input.CustomType))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.SendPush == input.SendPush ||
                    (this.SendPush != null &&
                    this.SendPush.Equals(input.SendPush))
                ) && 
                (
                    this.Mentioned == input.Mentioned ||
                    this.Mentioned != null &&
                    input.Mentioned != null &&
                    this.Mentioned.SequenceEqual(input.Mentioned)
                ) && 
                (
                    this.MarkAsRead == input.MarkAsRead ||
                    (this.MarkAsRead != null &&
                    this.MarkAsRead.Equals(input.MarkAsRead))
                ) && 
                (
                    this.DedupId == input.DedupId ||
                    (this.DedupId != null &&
                    this.DedupId.Equals(input.DedupId))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.ChannelUrl != null)
                    hashCode = hashCode * 59 + this.ChannelUrl.GetHashCode();
                if (this.CustomType != null)
                    hashCode = hashCode * 59 + this.CustomType.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.SendPush != null)
                    hashCode = hashCode * 59 + this.SendPush.GetHashCode();
                if (this.Mentioned != null)
                    hashCode = hashCode * 59 + this.Mentioned.GetHashCode();
                if (this.MarkAsRead != null)
                    hashCode = hashCode * 59 + this.MarkAsRead.GetHashCode();
                if (this.DedupId != null)
                    hashCode = hashCode * 59 + this.DedupId.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
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
