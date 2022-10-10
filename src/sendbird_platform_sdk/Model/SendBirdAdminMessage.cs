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
    /// SendBirdAdminMessage
    /// </summary>
    [DataContract]
    public partial class SendBirdAdminMessage :  IEquatable<SendBirdAdminMessage>, IValidatableObject
    {
        /// <summary>
        /// Defines MessageType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MessageTypeEnum
        {
            /// <summary>
            /// Enum MESG for value: MESG
            /// </summary>
            [EnumMember(Value = "MESG")]
            MESG = 1,

            /// <summary>
            /// Enum ADMM for value: ADMM
            /// </summary>
            [EnumMember(Value = "ADMM")]
            ADMM = 2,

            /// <summary>
            /// Enum FILE for value: FILE
            /// </summary>
            [EnumMember(Value = "FILE")]
            FILE = 3

        }

        /// <summary>
        /// Gets or Sets MessageType
        /// </summary>
        [DataMember(Name="message_type", EmitDefaultValue=false)]
        public MessageTypeEnum? MessageType { get; set; }
        /// <summary>
        /// Defines SendingStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SendingStatusEnum
        {
            /// <summary>
            /// Enum Canceled for value: canceled
            /// </summary>
            [EnumMember(Value = "canceled")]
            Canceled = 1,

            /// <summary>
            /// Enum Failed for value: failed
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed = 2,

            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 3,

            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 4,

            /// <summary>
            /// Enum Succeeded for value: succeeded
            /// </summary>
            [EnumMember(Value = "succeeded")]
            Succeeded = 5

        }

        /// <summary>
        /// Gets or Sets SendingStatus
        /// </summary>
        [DataMember(Name="sending_status", EmitDefaultValue=false)]
        public SendingStatusEnum? SendingStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SendBirdAdminMessage" /> class.
        /// </summary>
        /// <param name="appleCriticalAlertOptions">appleCriticalAlertOptions.</param>
        /// <param name="channelType">channelType.</param>
        /// <param name="channelUrl">channelUrl.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="customType">customType.</param>
        /// <param name="data">data.</param>
        /// <param name="isReplyToChannel">isReplyToChannel.</param>
        /// <param name="mentionType">mentionType.</param>
        /// <param name="mentionedUsers">mentionedUsers.</param>
        /// <param name="message">message.</param>
        /// <param name="messageId">messageId.</param>
        /// <param name="messageType">messageType.</param>
        /// <param name="metaArray">metaArray.</param>
        /// <param name="metaArrays">metaArrays.</param>
        /// <param name="ogMetaData">ogMetaData.</param>
        /// <param name="parentMessage">parentMessage.</param>
        /// <param name="parentMessageId">parentMessageId.</param>
        /// <param name="parentMessageText">parentMessageText.</param>
        /// <param name="reactions">reactions.</param>
        /// <param name="sendingStatus">sendingStatus.</param>
        /// <param name="silent">silent.</param>
        /// <param name="threadInfo">threadInfo.</param>
        /// <param name="translations">translations.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public SendBirdAdminMessage(SendBirdAppleCriticalAlertOptions appleCriticalAlertOptions = default(SendBirdAppleCriticalAlertOptions), string channelType = default(string), string channelUrl = default(string), decimal createdAt = default(decimal), string customType = default(string), string data = default(string), bool isReplyToChannel = default(bool), string mentionType = default(string), List<SendBirdUser> mentionedUsers = default(List<SendBirdUser>), string message = default(string), decimal messageId = default(decimal), MessageTypeEnum? messageType = default(MessageTypeEnum?), SBObject metaArray = default(SBObject), List<SendBirdMessageMetaArray> metaArrays = default(List<SendBirdMessageMetaArray>), SendBirdOGMetaData ogMetaData = default(SendBirdOGMetaData), SendBirdMessageResponse parentMessage = default(SendBirdMessageResponse), decimal parentMessageId = default(decimal), string parentMessageText = default(string), List<SendBirdReaction> reactions = default(List<SendBirdReaction>), SendingStatusEnum? sendingStatus = default(SendingStatusEnum?), bool silent = default(bool), SendBirdThreadInfo threadInfo = default(SendBirdThreadInfo), SBObject translations = default(SBObject), decimal updatedAt = default(decimal))
        {
            this.ParentMessage = parentMessage;
            this.AppleCriticalAlertOptions = appleCriticalAlertOptions;
            this.ChannelType = channelType;
            this.ChannelUrl = channelUrl;
            this.CreatedAt = createdAt;
            this.CustomType = customType;
            this.Data = data;
            this.IsReplyToChannel = isReplyToChannel;
            this.MentionType = mentionType;
            this.MentionedUsers = mentionedUsers;
            this.Message = message;
            this.MessageId = messageId;
            this.MessageType = messageType;
            this.MetaArray = metaArray;
            this.MetaArrays = metaArrays;
            this.OgMetaData = ogMetaData;
            this.ParentMessage = parentMessage;
            this.ParentMessageId = parentMessageId;
            this.ParentMessageText = parentMessageText;
            this.Reactions = reactions;
            this.SendingStatus = sendingStatus;
            this.Silent = silent;
            this.ThreadInfo = threadInfo;
            this.Translations = translations;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets AppleCriticalAlertOptions
        /// </summary>
        [DataMember(Name="apple_critical_alert_options", EmitDefaultValue=false)]
        public SendBirdAppleCriticalAlertOptions AppleCriticalAlertOptions { get; set; }

        /// <summary>
        /// Gets or Sets ChannelType
        /// </summary>
        [DataMember(Name="channel_type", EmitDefaultValue=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// Gets or Sets ChannelUrl
        /// </summary>
        [DataMember(Name="channel_url", EmitDefaultValue=false)]
        public string ChannelUrl { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public decimal CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets CustomType
        /// </summary>
        [DataMember(Name="custom_type", EmitDefaultValue=false)]
        public string CustomType { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public string Data { get; set; }

        /// <summary>
        /// Gets or Sets IsReplyToChannel
        /// </summary>
        [DataMember(Name="is_reply_to_channel", EmitDefaultValue=false)]
        public bool IsReplyToChannel { get; set; }

        /// <summary>
        /// Gets or Sets MentionType
        /// </summary>
        [DataMember(Name="mention_type", EmitDefaultValue=false)]
        public string MentionType { get; set; }

        /// <summary>
        /// Gets or Sets MentionedUsers
        /// </summary>
        [DataMember(Name="mentioned_users", EmitDefaultValue=false)]
        public List<SendBirdUser> MentionedUsers { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets MessageId
        /// </summary>
        [DataMember(Name="message_id", EmitDefaultValue=false)]
        public decimal MessageId { get; set; }


        /// <summary>
        /// Gets or Sets MetaArray
        /// </summary>
        [DataMember(Name="meta_array", EmitDefaultValue=false)]
        public SBObject MetaArray { get; set; }

        /// <summary>
        /// Gets or Sets MetaArrays
        /// </summary>
        [DataMember(Name="meta_arrays", EmitDefaultValue=false)]
        public List<SendBirdMessageMetaArray> MetaArrays { get; set; }

        /// <summary>
        /// Gets or Sets OgMetaData
        /// </summary>
        [DataMember(Name="og_meta_data", EmitDefaultValue=false)]
        public SendBirdOGMetaData OgMetaData { get; set; }

        /// <summary>
        /// Gets or Sets ParentMessage
        /// </summary>
        [DataMember(Name="parent_message", EmitDefaultValue=true)]
        public SendBirdMessageResponse ParentMessage { get; set; }

        /// <summary>
        /// Gets or Sets ParentMessageId
        /// </summary>
        [DataMember(Name="parent_message_id", EmitDefaultValue=false)]
        public decimal ParentMessageId { get; set; }

        /// <summary>
        /// Gets or Sets ParentMessageText
        /// </summary>
        [DataMember(Name="parent_message_text", EmitDefaultValue=false)]
        public string ParentMessageText { get; set; }

        /// <summary>
        /// Gets or Sets Reactions
        /// </summary>
        [DataMember(Name="reactions", EmitDefaultValue=false)]
        public List<SendBirdReaction> Reactions { get; set; }


        /// <summary>
        /// Gets or Sets Silent
        /// </summary>
        [DataMember(Name="silent", EmitDefaultValue=false)]
        public bool Silent { get; set; }

        /// <summary>
        /// Gets or Sets ThreadInfo
        /// </summary>
        [DataMember(Name="thread_info", EmitDefaultValue=false)]
        public SendBirdThreadInfo ThreadInfo { get; set; }

        /// <summary>
        /// Gets or Sets Translations
        /// </summary>
        [DataMember(Name="translations", EmitDefaultValue=false)]
        public SBObject Translations { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public decimal UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendBirdAdminMessage {\n");
            sb.Append("  AppleCriticalAlertOptions: ").Append(AppleCriticalAlertOptions).Append("\n");
            sb.Append("  ChannelType: ").Append(ChannelType).Append("\n");
            sb.Append("  ChannelUrl: ").Append(ChannelUrl).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CustomType: ").Append(CustomType).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  IsReplyToChannel: ").Append(IsReplyToChannel).Append("\n");
            sb.Append("  MentionType: ").Append(MentionType).Append("\n");
            sb.Append("  MentionedUsers: ").Append(MentionedUsers).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  MetaArray: ").Append(MetaArray).Append("\n");
            sb.Append("  MetaArrays: ").Append(MetaArrays).Append("\n");
            sb.Append("  OgMetaData: ").Append(OgMetaData).Append("\n");
            sb.Append("  ParentMessage: ").Append(ParentMessage).Append("\n");
            sb.Append("  ParentMessageId: ").Append(ParentMessageId).Append("\n");
            sb.Append("  ParentMessageText: ").Append(ParentMessageText).Append("\n");
            sb.Append("  Reactions: ").Append(Reactions).Append("\n");
            sb.Append("  SendingStatus: ").Append(SendingStatus).Append("\n");
            sb.Append("  Silent: ").Append(Silent).Append("\n");
            sb.Append("  ThreadInfo: ").Append(ThreadInfo).Append("\n");
            sb.Append("  Translations: ").Append(Translations).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as SendBirdAdminMessage);
        }

        /// <summary>
        /// Returns true if SendBirdAdminMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of SendBirdAdminMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendBirdAdminMessage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppleCriticalAlertOptions == input.AppleCriticalAlertOptions ||
                    (this.AppleCriticalAlertOptions != null &&
                    this.AppleCriticalAlertOptions.Equals(input.AppleCriticalAlertOptions))
                ) && 
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
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                    this.IsReplyToChannel == input.IsReplyToChannel ||
                    (this.IsReplyToChannel != null &&
                    this.IsReplyToChannel.Equals(input.IsReplyToChannel))
                ) && 
                (
                    this.MentionType == input.MentionType ||
                    (this.MentionType != null &&
                    this.MentionType.Equals(input.MentionType))
                ) && 
                (
                    this.MentionedUsers == input.MentionedUsers ||
                    this.MentionedUsers != null &&
                    input.MentionedUsers != null &&
                    this.MentionedUsers.SequenceEqual(input.MentionedUsers)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                    this.MetaArray == input.MetaArray ||
                    (this.MetaArray != null &&
                    this.MetaArray.Equals(input.MetaArray))
                ) && 
                (
                    this.MetaArrays == input.MetaArrays ||
                    this.MetaArrays != null &&
                    input.MetaArrays != null &&
                    this.MetaArrays.SequenceEqual(input.MetaArrays)
                ) && 
                (
                    this.OgMetaData == input.OgMetaData ||
                    (this.OgMetaData != null &&
                    this.OgMetaData.Equals(input.OgMetaData))
                ) && 
                (
                    this.ParentMessage == input.ParentMessage ||
                    (this.ParentMessage != null &&
                    this.ParentMessage.Equals(input.ParentMessage))
                ) && 
                (
                    this.ParentMessageId == input.ParentMessageId ||
                    (this.ParentMessageId != null &&
                    this.ParentMessageId.Equals(input.ParentMessageId))
                ) && 
                (
                    this.ParentMessageText == input.ParentMessageText ||
                    (this.ParentMessageText != null &&
                    this.ParentMessageText.Equals(input.ParentMessageText))
                ) && 
                (
                    this.Reactions == input.Reactions ||
                    this.Reactions != null &&
                    input.Reactions != null &&
                    this.Reactions.SequenceEqual(input.Reactions)
                ) && 
                (
                    this.SendingStatus == input.SendingStatus ||
                    (this.SendingStatus != null &&
                    this.SendingStatus.Equals(input.SendingStatus))
                ) && 
                (
                    this.Silent == input.Silent ||
                    (this.Silent != null &&
                    this.Silent.Equals(input.Silent))
                ) && 
                (
                    this.ThreadInfo == input.ThreadInfo ||
                    (this.ThreadInfo != null &&
                    this.ThreadInfo.Equals(input.ThreadInfo))
                ) && 
                (
                    this.Translations == input.Translations ||
                    (this.Translations != null &&
                    this.Translations.Equals(input.Translations))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.AppleCriticalAlertOptions != null)
                    hashCode = hashCode * 59 + this.AppleCriticalAlertOptions.GetHashCode();
                if (this.ChannelType != null)
                    hashCode = hashCode * 59 + this.ChannelType.GetHashCode();
                if (this.ChannelUrl != null)
                    hashCode = hashCode * 59 + this.ChannelUrl.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.CustomType != null)
                    hashCode = hashCode * 59 + this.CustomType.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.IsReplyToChannel != null)
                    hashCode = hashCode * 59 + this.IsReplyToChannel.GetHashCode();
                if (this.MentionType != null)
                    hashCode = hashCode * 59 + this.MentionType.GetHashCode();
                if (this.MentionedUsers != null)
                    hashCode = hashCode * 59 + this.MentionedUsers.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.MessageId != null)
                    hashCode = hashCode * 59 + this.MessageId.GetHashCode();
                if (this.MessageType != null)
                    hashCode = hashCode * 59 + this.MessageType.GetHashCode();
                if (this.MetaArray != null)
                    hashCode = hashCode * 59 + this.MetaArray.GetHashCode();
                if (this.MetaArrays != null)
                    hashCode = hashCode * 59 + this.MetaArrays.GetHashCode();
                if (this.OgMetaData != null)
                    hashCode = hashCode * 59 + this.OgMetaData.GetHashCode();
                if (this.ParentMessage != null)
                    hashCode = hashCode * 59 + this.ParentMessage.GetHashCode();
                if (this.ParentMessageId != null)
                    hashCode = hashCode * 59 + this.ParentMessageId.GetHashCode();
                if (this.ParentMessageText != null)
                    hashCode = hashCode * 59 + this.ParentMessageText.GetHashCode();
                if (this.Reactions != null)
                    hashCode = hashCode * 59 + this.Reactions.GetHashCode();
                if (this.SendingStatus != null)
                    hashCode = hashCode * 59 + this.SendingStatus.GetHashCode();
                if (this.Silent != null)
                    hashCode = hashCode * 59 + this.Silent.GetHashCode();
                if (this.ThreadInfo != null)
                    hashCode = hashCode * 59 + this.ThreadInfo.GetHashCode();
                if (this.Translations != null)
                    hashCode = hashCode * 59 + this.Translations.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
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
