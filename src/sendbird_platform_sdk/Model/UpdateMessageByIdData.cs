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
    /// UpdateMessageByIdData
    /// </summary>
    [DataContract]
    public partial class UpdateMessageByIdData :  IEquatable<UpdateMessageByIdData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMessageByIdData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateMessageByIdData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMessageByIdData" /> class.
        /// </summary>
        /// <param name="channelType">Specifies the type of the channel. Either open_channels or group_channels..</param>
        /// <param name="channelUrl">Specifies the URL of the target channel..</param>
        /// <param name="messageId">Specifies the unique ID of the message to update. (required).</param>
        /// <param name="messageType">Specifies the type of the message as ADMM..</param>
        /// <param name="message">Specifies the content of the message..</param>
        /// <param name="customType">Specifies a custom message type which is used for message grouping. The length is limited to 128 characters.&lt;br /&gt;&lt;br /&gt; Custom types are also used within Sendbird&#39;s [Advanced analytics](/docs/chat/v3/platform-api/guides/advanced-analytics) to segment metrics, which enables the sub-classification of data views..</param>
        /// <param name="data">Specifies additional message information such as custom font size, font type or &#x60;JSON&#x60; formatted string..</param>
        /// <param name="mentionType">Specifies the mentioning method which indicates the user scope who will get a notification for the message. Acceptable values are users and channel. If set to users, only the specified users with the mentioned_users property below will get notified. If set to channel, all users in the channel will get notified. (Default: users).</param>
        /// <param name="mentionedUserIds">Specifies an array of one or more IDs of the users who will get a notification for the message..</param>
        public UpdateMessageByIdData(string channelType = default(string), string channelUrl = default(string), int messageId = default(int), string messageType = default(string), string message = default(string), string customType = default(string), string data = default(string), string mentionType = default(string), List<string> mentionedUserIds = default(List<string>))
        {
            // to ensure "messageId" is required (not null)
            if (messageId == null)
            {
                throw new InvalidDataException("messageId is a required property for UpdateMessageByIdData and cannot be null");
            }
            else
            {
                this.MessageId = messageId;
            }

            this.ChannelType = channelType;
            this.ChannelUrl = channelUrl;
            this.MessageType = messageType;
            this.Message = message;
            this.CustomType = customType;
            this.Data = data;
            this.MentionType = mentionType;
            this.MentionedUserIds = mentionedUserIds;
        }

        /// <summary>
        /// Specifies the type of the channel. Either open_channels or group_channels.
        /// </summary>
        /// <value>Specifies the type of the channel. Either open_channels or group_channels.</value>
        [DataMember(Name="channel_type", EmitDefaultValue=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// Specifies the URL of the target channel.
        /// </summary>
        /// <value>Specifies the URL of the target channel.</value>
        [DataMember(Name="channel_url", EmitDefaultValue=false)]
        public string ChannelUrl { get; set; }

        /// <summary>
        /// Specifies the unique ID of the message to update.
        /// </summary>
        /// <value>Specifies the unique ID of the message to update.</value>
        [DataMember(Name="message_id", EmitDefaultValue=true)]
        public int MessageId { get; set; }

        /// <summary>
        /// Specifies the type of the message as ADMM.
        /// </summary>
        /// <value>Specifies the type of the message as ADMM.</value>
        [DataMember(Name="message_type", EmitDefaultValue=false)]
        public string MessageType { get; set; }

        /// <summary>
        /// Specifies the content of the message.
        /// </summary>
        /// <value>Specifies the content of the message.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Specifies a custom message type which is used for message grouping. The length is limited to 128 characters.&lt;br /&gt;&lt;br /&gt; Custom types are also used within Sendbird&#39;s [Advanced analytics](/docs/chat/v3/platform-api/guides/advanced-analytics) to segment metrics, which enables the sub-classification of data views.
        /// </summary>
        /// <value>Specifies a custom message type which is used for message grouping. The length is limited to 128 characters.&lt;br /&gt;&lt;br /&gt; Custom types are also used within Sendbird&#39;s [Advanced analytics](/docs/chat/v3/platform-api/guides/advanced-analytics) to segment metrics, which enables the sub-classification of data views.</value>
        [DataMember(Name="custom_type", EmitDefaultValue=false)]
        public string CustomType { get; set; }

        /// <summary>
        /// Specifies additional message information such as custom font size, font type or &#x60;JSON&#x60; formatted string.
        /// </summary>
        /// <value>Specifies additional message information such as custom font size, font type or &#x60;JSON&#x60; formatted string.</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public string Data { get; set; }

        /// <summary>
        /// Specifies the mentioning method which indicates the user scope who will get a notification for the message. Acceptable values are users and channel. If set to users, only the specified users with the mentioned_users property below will get notified. If set to channel, all users in the channel will get notified. (Default: users)
        /// </summary>
        /// <value>Specifies the mentioning method which indicates the user scope who will get a notification for the message. Acceptable values are users and channel. If set to users, only the specified users with the mentioned_users property below will get notified. If set to channel, all users in the channel will get notified. (Default: users)</value>
        [DataMember(Name="mention_type", EmitDefaultValue=false)]
        public string MentionType { get; set; }

        /// <summary>
        /// Specifies an array of one or more IDs of the users who will get a notification for the message.
        /// </summary>
        /// <value>Specifies an array of one or more IDs of the users who will get a notification for the message.</value>
        [DataMember(Name="mentioned_user_ids", EmitDefaultValue=false)]
        public List<string> MentionedUserIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateMessageByIdData {\n");
            sb.Append("  ChannelType: ").Append(ChannelType).Append("\n");
            sb.Append("  ChannelUrl: ").Append(ChannelUrl).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  CustomType: ").Append(CustomType).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  MentionType: ").Append(MentionType).Append("\n");
            sb.Append("  MentionedUserIds: ").Append(MentionedUserIds).Append("\n");
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
            return this.Equals(input as UpdateMessageByIdData);
        }

        /// <summary>
        /// Returns true if UpdateMessageByIdData instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateMessageByIdData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateMessageByIdData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChannelType == input.ChannelType ||
                    (this.ChannelType != null &&
                    this.ChannelType.Equals(input.ChannelType))
                ) && 
                (
                    this.ChannelUrl == input.ChannelUrl ||
                    (this.ChannelUrl != null &&
                    this.ChannelUrl.Equals(input.ChannelUrl))
                ) && 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.MessageType == input.MessageType ||
                    (this.MessageType != null &&
                    this.MessageType.Equals(input.MessageType))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                    this.MentionType == input.MentionType ||
                    (this.MentionType != null &&
                    this.MentionType.Equals(input.MentionType))
                ) && 
                (
                    this.MentionedUserIds == input.MentionedUserIds ||
                    this.MentionedUserIds != null &&
                    input.MentionedUserIds != null &&
                    this.MentionedUserIds.SequenceEqual(input.MentionedUserIds)
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
                if (this.ChannelType != null)
                    hashCode = hashCode * 59 + this.ChannelType.GetHashCode();
                if (this.ChannelUrl != null)
                    hashCode = hashCode * 59 + this.ChannelUrl.GetHashCode();
                if (this.MessageId != null)
                    hashCode = hashCode * 59 + this.MessageId.GetHashCode();
                if (this.MessageType != null)
                    hashCode = hashCode * 59 + this.MessageType.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.CustomType != null)
                    hashCode = hashCode * 59 + this.CustomType.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.MentionType != null)
                    hashCode = hashCode * 59 + this.MentionType.GetHashCode();
                if (this.MentionedUserIds != null)
                    hashCode = hashCode * 59 + this.MentionedUserIds.GetHashCode();
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
