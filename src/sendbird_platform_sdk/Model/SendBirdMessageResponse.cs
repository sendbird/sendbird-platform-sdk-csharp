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
    /// SendBirdMessageResponse
    /// </summary>
    [DataContract]
    public partial class SendBirdMessageResponse :  IEquatable<SendBirdMessageResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendBirdMessageResponse" /> class.
        /// </summary>
        /// <param name="requireAuth">requireAuth.</param>
        /// <param name="messageSurvivalSeconds">messageSurvivalSeconds.</param>
        /// <param name="customType">customType.</param>
        /// <param name="mentionedUsers">mentionedUsers.</param>
        /// <param name="translations">translations.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="isOpMsg">isOpMsg.</param>
        /// <param name="isRemoved">isRemoved.</param>
        /// <param name="user">user.</param>
        /// <param name="file">file.</param>
        /// <param name="message">message.</param>
        /// <param name="data">data.</param>
        /// <param name="messageRetentionHour">messageRetentionHour.</param>
        /// <param name="silent">silent.</param>
        /// <param name="type">type.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="channelType">channelType.</param>
        /// <param name="reqId">reqId.</param>
        /// <param name="mentionType">mentionType.</param>
        /// <param name="channelUrl">channelUrl.</param>
        /// <param name="messageId">messageId.</param>
        /// <param name="size">size.</param>
        /// <param name="sortedMetaarray">sortedMetaarray.</param>
        /// <param name="threadInfo">threadInfo.</param>
        /// <param name="parentMessageId">parentMessageId.</param>
        /// <param name="parentMessageInfo">parentMessageInfo.</param>
        /// <param name="isReplyToChannel">isReplyToChannel.</param>
        public SendBirdMessageResponse(bool requireAuth = default(bool), decimal messageSurvivalSeconds = default(decimal), string customType = default(string), List<SendBirdMessageResponseMentionedUsersInner> mentionedUsers = default(List<SendBirdMessageResponseMentionedUsersInner>), Object translations = default(Object), decimal updatedAt = default(decimal), bool isOpMsg = default(bool), bool isRemoved = default(bool), SendBirdMessageResponseUser user = default(SendBirdMessageResponseUser), Object file = default(Object), string message = default(string), string data = default(string), decimal messageRetentionHour = default(decimal), bool silent = default(bool), string type = default(string), decimal createdAt = default(decimal), string channelType = default(string), string reqId = default(string), string mentionType = default(string), string channelUrl = default(string), decimal messageId = default(decimal), decimal size = default(decimal), List<Object> sortedMetaarray = default(List<Object>), Object threadInfo = default(Object), decimal parentMessageId = default(decimal), Object parentMessageInfo = default(Object), bool isReplyToChannel = default(bool))
        {
            this.RequireAuth = requireAuth;
            this.MessageSurvivalSeconds = messageSurvivalSeconds;
            this.CustomType = customType;
            this.MentionedUsers = mentionedUsers;
            this.Translations = translations;
            this.UpdatedAt = updatedAt;
            this.IsOpMsg = isOpMsg;
            this.IsRemoved = isRemoved;
            this.User = user;
            this.File = file;
            this.Message = message;
            this.Data = data;
            this.MessageRetentionHour = messageRetentionHour;
            this.Silent = silent;
            this.Type = type;
            this.CreatedAt = createdAt;
            this.ChannelType = channelType;
            this.ReqId = reqId;
            this.MentionType = mentionType;
            this.ChannelUrl = channelUrl;
            this.MessageId = messageId;
            this.Size = size;
            this.SortedMetaarray = sortedMetaarray;
            this.ThreadInfo = threadInfo;
            this.ParentMessageId = parentMessageId;
            this.ParentMessageInfo = parentMessageInfo;
            this.IsReplyToChannel = isReplyToChannel;
        }

        /// <summary>
        /// Gets or Sets RequireAuth
        /// </summary>
        [DataMember(Name="require_auth", EmitDefaultValue=false)]
        public bool RequireAuth { get; set; }

        /// <summary>
        /// Gets or Sets MessageSurvivalSeconds
        /// </summary>
        [DataMember(Name="message_survival_seconds", EmitDefaultValue=false)]
        public decimal MessageSurvivalSeconds { get; set; }

        /// <summary>
        /// Gets or Sets CustomType
        /// </summary>
        [DataMember(Name="custom_type", EmitDefaultValue=false)]
        public string CustomType { get; set; }

        /// <summary>
        /// Gets or Sets MentionedUsers
        /// </summary>
        [DataMember(Name="mentioned_users", EmitDefaultValue=false)]
        public List<SendBirdMessageResponseMentionedUsersInner> MentionedUsers { get; set; }

        /// <summary>
        /// Gets or Sets Translations
        /// </summary>
        [DataMember(Name="translations", EmitDefaultValue=false)]
        public Object Translations { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public decimal UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets IsOpMsg
        /// </summary>
        [DataMember(Name="is_op_msg", EmitDefaultValue=false)]
        public bool IsOpMsg { get; set; }

        /// <summary>
        /// Gets or Sets IsRemoved
        /// </summary>
        [DataMember(Name="is_removed", EmitDefaultValue=false)]
        public bool IsRemoved { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public SendBirdMessageResponseUser User { get; set; }

        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name="file", EmitDefaultValue=false)]
        public Object File { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public string Data { get; set; }

        /// <summary>
        /// Gets or Sets MessageRetentionHour
        /// </summary>
        [DataMember(Name="message_retention_hour", EmitDefaultValue=false)]
        public decimal MessageRetentionHour { get; set; }

        /// <summary>
        /// Gets or Sets Silent
        /// </summary>
        [DataMember(Name="silent", EmitDefaultValue=false)]
        public bool Silent { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public decimal CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets ChannelType
        /// </summary>
        [DataMember(Name="channel_type", EmitDefaultValue=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// Gets or Sets ReqId
        /// </summary>
        [DataMember(Name="req_id", EmitDefaultValue=false)]
        public string ReqId { get; set; }

        /// <summary>
        /// Gets or Sets MentionType
        /// </summary>
        [DataMember(Name="mention_type", EmitDefaultValue=false)]
        public string MentionType { get; set; }

        /// <summary>
        /// Gets or Sets ChannelUrl
        /// </summary>
        [DataMember(Name="channel_url", EmitDefaultValue=false)]
        public string ChannelUrl { get; set; }

        /// <summary>
        /// Gets or Sets MessageId
        /// </summary>
        [DataMember(Name="message_id", EmitDefaultValue=false)]
        public decimal MessageId { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public decimal Size { get; set; }

        /// <summary>
        /// Gets or Sets SortedMetaarray
        /// </summary>
        [DataMember(Name="sorted_metaarray", EmitDefaultValue=false)]
        public List<Object> SortedMetaarray { get; set; }

        /// <summary>
        /// Gets or Sets ThreadInfo
        /// </summary>
        [DataMember(Name="thread_info", EmitDefaultValue=false)]
        public Object ThreadInfo { get; set; }

        /// <summary>
        /// Gets or Sets ParentMessageId
        /// </summary>
        [DataMember(Name="parent_message_id", EmitDefaultValue=false)]
        public decimal ParentMessageId { get; set; }

        /// <summary>
        /// Gets or Sets ParentMessageInfo
        /// </summary>
        [DataMember(Name="parent_message_info", EmitDefaultValue=false)]
        public Object ParentMessageInfo { get; set; }

        /// <summary>
        /// Gets or Sets IsReplyToChannel
        /// </summary>
        [DataMember(Name="is_reply_to_channel", EmitDefaultValue=false)]
        public bool IsReplyToChannel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendBirdMessageResponse {\n");
            sb.Append("  RequireAuth: ").Append(RequireAuth).Append("\n");
            sb.Append("  MessageSurvivalSeconds: ").Append(MessageSurvivalSeconds).Append("\n");
            sb.Append("  CustomType: ").Append(CustomType).Append("\n");
            sb.Append("  MentionedUsers: ").Append(MentionedUsers).Append("\n");
            sb.Append("  Translations: ").Append(Translations).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  IsOpMsg: ").Append(IsOpMsg).Append("\n");
            sb.Append("  IsRemoved: ").Append(IsRemoved).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  MessageRetentionHour: ").Append(MessageRetentionHour).Append("\n");
            sb.Append("  Silent: ").Append(Silent).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ChannelType: ").Append(ChannelType).Append("\n");
            sb.Append("  ReqId: ").Append(ReqId).Append("\n");
            sb.Append("  MentionType: ").Append(MentionType).Append("\n");
            sb.Append("  ChannelUrl: ").Append(ChannelUrl).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  SortedMetaarray: ").Append(SortedMetaarray).Append("\n");
            sb.Append("  ThreadInfo: ").Append(ThreadInfo).Append("\n");
            sb.Append("  ParentMessageId: ").Append(ParentMessageId).Append("\n");
            sb.Append("  ParentMessageInfo: ").Append(ParentMessageInfo).Append("\n");
            sb.Append("  IsReplyToChannel: ").Append(IsReplyToChannel).Append("\n");
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
            return this.Equals(input as SendBirdMessageResponse);
        }

        /// <summary>
        /// Returns true if SendBirdMessageResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SendBirdMessageResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendBirdMessageResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequireAuth == input.RequireAuth ||
                    (this.RequireAuth != null &&
                    this.RequireAuth.Equals(input.RequireAuth))
                ) && 
                (
                    this.MessageSurvivalSeconds == input.MessageSurvivalSeconds ||
                    (this.MessageSurvivalSeconds != null &&
                    this.MessageSurvivalSeconds.Equals(input.MessageSurvivalSeconds))
                ) && 
                (
                    this.CustomType == input.CustomType ||
                    (this.CustomType != null &&
                    this.CustomType.Equals(input.CustomType))
                ) && 
                (
                    this.MentionedUsers == input.MentionedUsers ||
                    this.MentionedUsers != null &&
                    input.MentionedUsers != null &&
                    this.MentionedUsers.SequenceEqual(input.MentionedUsers)
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
                ) && 
                (
                    this.IsOpMsg == input.IsOpMsg ||
                    (this.IsOpMsg != null &&
                    this.IsOpMsg.Equals(input.IsOpMsg))
                ) && 
                (
                    this.IsRemoved == input.IsRemoved ||
                    (this.IsRemoved != null &&
                    this.IsRemoved.Equals(input.IsRemoved))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.MessageRetentionHour == input.MessageRetentionHour ||
                    (this.MessageRetentionHour != null &&
                    this.MessageRetentionHour.Equals(input.MessageRetentionHour))
                ) && 
                (
                    this.Silent == input.Silent ||
                    (this.Silent != null &&
                    this.Silent.Equals(input.Silent))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.ChannelType == input.ChannelType ||
                    (this.ChannelType != null &&
                    this.ChannelType.Equals(input.ChannelType))
                ) && 
                (
                    this.ReqId == input.ReqId ||
                    (this.ReqId != null &&
                    this.ReqId.Equals(input.ReqId))
                ) && 
                (
                    this.MentionType == input.MentionType ||
                    (this.MentionType != null &&
                    this.MentionType.Equals(input.MentionType))
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
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.SortedMetaarray == input.SortedMetaarray ||
                    this.SortedMetaarray != null &&
                    input.SortedMetaarray != null &&
                    this.SortedMetaarray.SequenceEqual(input.SortedMetaarray)
                ) && 
                (
                    this.ThreadInfo == input.ThreadInfo ||
                    (this.ThreadInfo != null &&
                    this.ThreadInfo.Equals(input.ThreadInfo))
                ) && 
                (
                    this.ParentMessageId == input.ParentMessageId ||
                    (this.ParentMessageId != null &&
                    this.ParentMessageId.Equals(input.ParentMessageId))
                ) && 
                (
                    this.ParentMessageInfo == input.ParentMessageInfo ||
                    (this.ParentMessageInfo != null &&
                    this.ParentMessageInfo.Equals(input.ParentMessageInfo))
                ) && 
                (
                    this.IsReplyToChannel == input.IsReplyToChannel ||
                    (this.IsReplyToChannel != null &&
                    this.IsReplyToChannel.Equals(input.IsReplyToChannel))
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
                if (this.RequireAuth != null)
                    hashCode = hashCode * 59 + this.RequireAuth.GetHashCode();
                if (this.MessageSurvivalSeconds != null)
                    hashCode = hashCode * 59 + this.MessageSurvivalSeconds.GetHashCode();
                if (this.CustomType != null)
                    hashCode = hashCode * 59 + this.CustomType.GetHashCode();
                if (this.MentionedUsers != null)
                    hashCode = hashCode * 59 + this.MentionedUsers.GetHashCode();
                if (this.Translations != null)
                    hashCode = hashCode * 59 + this.Translations.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.IsOpMsg != null)
                    hashCode = hashCode * 59 + this.IsOpMsg.GetHashCode();
                if (this.IsRemoved != null)
                    hashCode = hashCode * 59 + this.IsRemoved.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.File != null)
                    hashCode = hashCode * 59 + this.File.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.MessageRetentionHour != null)
                    hashCode = hashCode * 59 + this.MessageRetentionHour.GetHashCode();
                if (this.Silent != null)
                    hashCode = hashCode * 59 + this.Silent.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.ChannelType != null)
                    hashCode = hashCode * 59 + this.ChannelType.GetHashCode();
                if (this.ReqId != null)
                    hashCode = hashCode * 59 + this.ReqId.GetHashCode();
                if (this.MentionType != null)
                    hashCode = hashCode * 59 + this.MentionType.GetHashCode();
                if (this.ChannelUrl != null)
                    hashCode = hashCode * 59 + this.ChannelUrl.GetHashCode();
                if (this.MessageId != null)
                    hashCode = hashCode * 59 + this.MessageId.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.SortedMetaarray != null)
                    hashCode = hashCode * 59 + this.SortedMetaarray.GetHashCode();
                if (this.ThreadInfo != null)
                    hashCode = hashCode * 59 + this.ThreadInfo.GetHashCode();
                if (this.ParentMessageId != null)
                    hashCode = hashCode * 59 + this.ParentMessageId.GetHashCode();
                if (this.ParentMessageInfo != null)
                    hashCode = hashCode * 59 + this.ParentMessageInfo.GetHashCode();
                if (this.IsReplyToChannel != null)
                    hashCode = hashCode * 59 + this.IsReplyToChannel.GetHashCode();
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
