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
    /// UpdateAnnouncementByIdData
    /// </summary>
    [DataContract]
    public partial class UpdateAnnouncementByIdData :  IEquatable<UpdateAnnouncementByIdData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAnnouncementByIdData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateAnnouncementByIdData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAnnouncementByIdData" /> class.
        /// </summary>
        /// <param name="uniqueId">Specifies the unique ID of the announcement to update. (required).</param>
        /// <param name="action">Specifies an action to take on the announcement. If this property is updated, other specified properties in the request are not effective. Acceptable values are limited to remove, pause, resume, and cancel. The [Announcement actions](#2-update-an-announcement-3-how-to-change-announcement-status) table explains each action in detail..</param>
        /// <param name="announcementGroup">Specifies the name of an announcement group to retrieve. If not specified, all announcements are returned, regardless of their group..</param>
        /// <param name="createChannel">Determines whether to create a new channel if there is no existing channel that matches with the target options including target_at and target_list..</param>
        /// <param name="createChannelOptionsName">Specifies the name of the channel. (Default: Group Channel).</param>
        /// <param name="createChannelOptionsCoverUrl">Specifies the URL of the cover image..</param>
        /// <param name="createChannelOptionsCustomType">Specifies the custom channel type..</param>
        /// <param name="createChannelOptionsData">Specifies additional channel information such as a long description of the channel or &#x60;JSON&#x60; formatted string..</param>
        /// <param name="createChannelOptionsDistinct">Determines whether to create a [distinct](/docs/chat/v3/platform-api/guides/channel-types#2-group-channel) channel. (Default: true).</param>
        /// <param name="messageUserId">Specifies the unique ID of the announcement sender..</param>
        /// <param name="messageContent">Specifies the content of the message..</param>
        /// <param name="messageData">Specifies additional message information such as custom font size, font type or &#x60;JSON&#x60; formatted string..</param>
        /// <param name="enablePush">Determines whether to turn on push notification for the announcement. If set to true, push notifications will be sent for announcements..</param>
        /// <param name="scheduledAt">Specifies the time to start the announcement, in [Unix milliseconds](/docs/chat/v3/platform-api/guides/miscellaneous#2-timestamps) format. (Default: current timestamp).</param>
        /// <param name="endAt">Specifies the time to permanently end the announcement, in [Unix milliseconds](/docs/chat/v3/platform-api/guides/miscellaneous#2-timestamps) format, even if the announcement is not sent to all its targets..</param>
        /// <param name="ceaseAt">Specifies the time to temporarily put the announcement on hold in UTC. The string is represented in HHMM format. This property should be specified in conjunction with the resume_at below..</param>
        /// <param name="resumeAt">Specifies the time to automatically resume the on-hold announcement in UTC. The string is represented in HHMM format. This property should be specified in conjunction with the cease_at above..</param>
        public UpdateAnnouncementByIdData(string uniqueId = default(string), string action = default(string), string announcementGroup = default(string), bool createChannel = default(bool), string createChannelOptionsName = default(string), string createChannelOptionsCoverUrl = default(string), string createChannelOptionsCustomType = default(string), string createChannelOptionsData = default(string), string createChannelOptionsDistinct = default(string), string messageUserId = default(string), string messageContent = default(string), string messageData = default(string), bool enablePush = default(bool), int scheduledAt = default(int), int endAt = default(int), string ceaseAt = default(string), string resumeAt = default(string))
        {
            // to ensure "uniqueId" is required (not null)
            if (uniqueId == null)
            {
                throw new InvalidDataException("uniqueId is a required property for UpdateAnnouncementByIdData and cannot be null");
            }
            else
            {
                this.UniqueId = uniqueId;
            }

            this.Action = action;
            this.AnnouncementGroup = announcementGroup;
            this.CreateChannel = createChannel;
            this.CreateChannelOptionsName = createChannelOptionsName;
            this.CreateChannelOptionsCoverUrl = createChannelOptionsCoverUrl;
            this.CreateChannelOptionsCustomType = createChannelOptionsCustomType;
            this.CreateChannelOptionsData = createChannelOptionsData;
            this.CreateChannelOptionsDistinct = createChannelOptionsDistinct;
            this.MessageUserId = messageUserId;
            this.MessageContent = messageContent;
            this.MessageData = messageData;
            this.EnablePush = enablePush;
            this.ScheduledAt = scheduledAt;
            this.EndAt = endAt;
            this.CeaseAt = ceaseAt;
            this.ResumeAt = resumeAt;
        }

        /// <summary>
        /// Specifies the unique ID of the announcement to update.
        /// </summary>
        /// <value>Specifies the unique ID of the announcement to update.</value>
        [DataMember(Name="unique_id", EmitDefaultValue=true)]
        public string UniqueId { get; set; }

        /// <summary>
        /// Specifies an action to take on the announcement. If this property is updated, other specified properties in the request are not effective. Acceptable values are limited to remove, pause, resume, and cancel. The [Announcement actions](#2-update-an-announcement-3-how-to-change-announcement-status) table explains each action in detail.
        /// </summary>
        /// <value>Specifies an action to take on the announcement. If this property is updated, other specified properties in the request are not effective. Acceptable values are limited to remove, pause, resume, and cancel. The [Announcement actions](#2-update-an-announcement-3-how-to-change-announcement-status) table explains each action in detail.</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }

        /// <summary>
        /// Specifies the name of an announcement group to retrieve. If not specified, all announcements are returned, regardless of their group.
        /// </summary>
        /// <value>Specifies the name of an announcement group to retrieve. If not specified, all announcements are returned, regardless of their group.</value>
        [DataMember(Name="announcement_group", EmitDefaultValue=false)]
        public string AnnouncementGroup { get; set; }

        /// <summary>
        /// Determines whether to create a new channel if there is no existing channel that matches with the target options including target_at and target_list.
        /// </summary>
        /// <value>Determines whether to create a new channel if there is no existing channel that matches with the target options including target_at and target_list.</value>
        [DataMember(Name="create_channel", EmitDefaultValue=false)]
        public bool CreateChannel { get; set; }

        /// <summary>
        /// Specifies the name of the channel. (Default: Group Channel)
        /// </summary>
        /// <value>Specifies the name of the channel. (Default: Group Channel)</value>
        [DataMember(Name="create_channel_options.name", EmitDefaultValue=false)]
        public string CreateChannelOptionsName { get; set; }

        /// <summary>
        /// Specifies the URL of the cover image.
        /// </summary>
        /// <value>Specifies the URL of the cover image.</value>
        [DataMember(Name="create_channel_options.cover_url", EmitDefaultValue=false)]
        public string CreateChannelOptionsCoverUrl { get; set; }

        /// <summary>
        /// Specifies the custom channel type.
        /// </summary>
        /// <value>Specifies the custom channel type.</value>
        [DataMember(Name="create_channel_options.custom_type", EmitDefaultValue=false)]
        public string CreateChannelOptionsCustomType { get; set; }

        /// <summary>
        /// Specifies additional channel information such as a long description of the channel or &#x60;JSON&#x60; formatted string.
        /// </summary>
        /// <value>Specifies additional channel information such as a long description of the channel or &#x60;JSON&#x60; formatted string.</value>
        [DataMember(Name="create_channel_options.data", EmitDefaultValue=false)]
        public string CreateChannelOptionsData { get; set; }

        /// <summary>
        /// Determines whether to create a [distinct](/docs/chat/v3/platform-api/guides/channel-types#2-group-channel) channel. (Default: true)
        /// </summary>
        /// <value>Determines whether to create a [distinct](/docs/chat/v3/platform-api/guides/channel-types#2-group-channel) channel. (Default: true)</value>
        [DataMember(Name="create_channel_options.distinct", EmitDefaultValue=false)]
        public string CreateChannelOptionsDistinct { get; set; }

        /// <summary>
        /// Specifies the unique ID of the announcement sender.
        /// </summary>
        /// <value>Specifies the unique ID of the announcement sender.</value>
        [DataMember(Name="message.user_id", EmitDefaultValue=false)]
        public string MessageUserId { get; set; }

        /// <summary>
        /// Specifies the content of the message.
        /// </summary>
        /// <value>Specifies the content of the message.</value>
        [DataMember(Name="message.content", EmitDefaultValue=false)]
        public string MessageContent { get; set; }

        /// <summary>
        /// Specifies additional message information such as custom font size, font type or &#x60;JSON&#x60; formatted string.
        /// </summary>
        /// <value>Specifies additional message information such as custom font size, font type or &#x60;JSON&#x60; formatted string.</value>
        [DataMember(Name="message.data", EmitDefaultValue=false)]
        public string MessageData { get; set; }

        /// <summary>
        /// Determines whether to turn on push notification for the announcement. If set to true, push notifications will be sent for announcements.
        /// </summary>
        /// <value>Determines whether to turn on push notification for the announcement. If set to true, push notifications will be sent for announcements.</value>
        [DataMember(Name="enable_push", EmitDefaultValue=false)]
        public bool EnablePush { get; set; }

        /// <summary>
        /// Specifies the time to start the announcement, in [Unix milliseconds](/docs/chat/v3/platform-api/guides/miscellaneous#2-timestamps) format. (Default: current timestamp)
        /// </summary>
        /// <value>Specifies the time to start the announcement, in [Unix milliseconds](/docs/chat/v3/platform-api/guides/miscellaneous#2-timestamps) format. (Default: current timestamp)</value>
        [DataMember(Name="scheduled_at", EmitDefaultValue=false)]
        public int ScheduledAt { get; set; }

        /// <summary>
        /// Specifies the time to permanently end the announcement, in [Unix milliseconds](/docs/chat/v3/platform-api/guides/miscellaneous#2-timestamps) format, even if the announcement is not sent to all its targets.
        /// </summary>
        /// <value>Specifies the time to permanently end the announcement, in [Unix milliseconds](/docs/chat/v3/platform-api/guides/miscellaneous#2-timestamps) format, even if the announcement is not sent to all its targets.</value>
        [DataMember(Name="end_at", EmitDefaultValue=false)]
        public int EndAt { get; set; }

        /// <summary>
        /// Specifies the time to temporarily put the announcement on hold in UTC. The string is represented in HHMM format. This property should be specified in conjunction with the resume_at below.
        /// </summary>
        /// <value>Specifies the time to temporarily put the announcement on hold in UTC. The string is represented in HHMM format. This property should be specified in conjunction with the resume_at below.</value>
        [DataMember(Name="cease_at", EmitDefaultValue=false)]
        public string CeaseAt { get; set; }

        /// <summary>
        /// Specifies the time to automatically resume the on-hold announcement in UTC. The string is represented in HHMM format. This property should be specified in conjunction with the cease_at above.
        /// </summary>
        /// <value>Specifies the time to automatically resume the on-hold announcement in UTC. The string is represented in HHMM format. This property should be specified in conjunction with the cease_at above.</value>
        [DataMember(Name="resume_at", EmitDefaultValue=false)]
        public string ResumeAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAnnouncementByIdData {\n");
            sb.Append("  UniqueId: ").Append(UniqueId).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  AnnouncementGroup: ").Append(AnnouncementGroup).Append("\n");
            sb.Append("  CreateChannel: ").Append(CreateChannel).Append("\n");
            sb.Append("  CreateChannelOptionsName: ").Append(CreateChannelOptionsName).Append("\n");
            sb.Append("  CreateChannelOptionsCoverUrl: ").Append(CreateChannelOptionsCoverUrl).Append("\n");
            sb.Append("  CreateChannelOptionsCustomType: ").Append(CreateChannelOptionsCustomType).Append("\n");
            sb.Append("  CreateChannelOptionsData: ").Append(CreateChannelOptionsData).Append("\n");
            sb.Append("  CreateChannelOptionsDistinct: ").Append(CreateChannelOptionsDistinct).Append("\n");
            sb.Append("  MessageUserId: ").Append(MessageUserId).Append("\n");
            sb.Append("  MessageContent: ").Append(MessageContent).Append("\n");
            sb.Append("  MessageData: ").Append(MessageData).Append("\n");
            sb.Append("  EnablePush: ").Append(EnablePush).Append("\n");
            sb.Append("  ScheduledAt: ").Append(ScheduledAt).Append("\n");
            sb.Append("  EndAt: ").Append(EndAt).Append("\n");
            sb.Append("  CeaseAt: ").Append(CeaseAt).Append("\n");
            sb.Append("  ResumeAt: ").Append(ResumeAt).Append("\n");
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
            return this.Equals(input as UpdateAnnouncementByIdData);
        }

        /// <summary>
        /// Returns true if UpdateAnnouncementByIdData instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateAnnouncementByIdData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateAnnouncementByIdData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UniqueId == input.UniqueId ||
                    (this.UniqueId != null &&
                    this.UniqueId.Equals(input.UniqueId))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.AnnouncementGroup == input.AnnouncementGroup ||
                    (this.AnnouncementGroup != null &&
                    this.AnnouncementGroup.Equals(input.AnnouncementGroup))
                ) && 
                (
                    this.CreateChannel == input.CreateChannel ||
                    (this.CreateChannel != null &&
                    this.CreateChannel.Equals(input.CreateChannel))
                ) && 
                (
                    this.CreateChannelOptionsName == input.CreateChannelOptionsName ||
                    (this.CreateChannelOptionsName != null &&
                    this.CreateChannelOptionsName.Equals(input.CreateChannelOptionsName))
                ) && 
                (
                    this.CreateChannelOptionsCoverUrl == input.CreateChannelOptionsCoverUrl ||
                    (this.CreateChannelOptionsCoverUrl != null &&
                    this.CreateChannelOptionsCoverUrl.Equals(input.CreateChannelOptionsCoverUrl))
                ) && 
                (
                    this.CreateChannelOptionsCustomType == input.CreateChannelOptionsCustomType ||
                    (this.CreateChannelOptionsCustomType != null &&
                    this.CreateChannelOptionsCustomType.Equals(input.CreateChannelOptionsCustomType))
                ) && 
                (
                    this.CreateChannelOptionsData == input.CreateChannelOptionsData ||
                    (this.CreateChannelOptionsData != null &&
                    this.CreateChannelOptionsData.Equals(input.CreateChannelOptionsData))
                ) && 
                (
                    this.CreateChannelOptionsDistinct == input.CreateChannelOptionsDistinct ||
                    (this.CreateChannelOptionsDistinct != null &&
                    this.CreateChannelOptionsDistinct.Equals(input.CreateChannelOptionsDistinct))
                ) && 
                (
                    this.MessageUserId == input.MessageUserId ||
                    (this.MessageUserId != null &&
                    this.MessageUserId.Equals(input.MessageUserId))
                ) && 
                (
                    this.MessageContent == input.MessageContent ||
                    (this.MessageContent != null &&
                    this.MessageContent.Equals(input.MessageContent))
                ) && 
                (
                    this.MessageData == input.MessageData ||
                    (this.MessageData != null &&
                    this.MessageData.Equals(input.MessageData))
                ) && 
                (
                    this.EnablePush == input.EnablePush ||
                    (this.EnablePush != null &&
                    this.EnablePush.Equals(input.EnablePush))
                ) && 
                (
                    this.ScheduledAt == input.ScheduledAt ||
                    (this.ScheduledAt != null &&
                    this.ScheduledAt.Equals(input.ScheduledAt))
                ) && 
                (
                    this.EndAt == input.EndAt ||
                    (this.EndAt != null &&
                    this.EndAt.Equals(input.EndAt))
                ) && 
                (
                    this.CeaseAt == input.CeaseAt ||
                    (this.CeaseAt != null &&
                    this.CeaseAt.Equals(input.CeaseAt))
                ) && 
                (
                    this.ResumeAt == input.ResumeAt ||
                    (this.ResumeAt != null &&
                    this.ResumeAt.Equals(input.ResumeAt))
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
                if (this.UniqueId != null)
                    hashCode = hashCode * 59 + this.UniqueId.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.AnnouncementGroup != null)
                    hashCode = hashCode * 59 + this.AnnouncementGroup.GetHashCode();
                if (this.CreateChannel != null)
                    hashCode = hashCode * 59 + this.CreateChannel.GetHashCode();
                if (this.CreateChannelOptionsName != null)
                    hashCode = hashCode * 59 + this.CreateChannelOptionsName.GetHashCode();
                if (this.CreateChannelOptionsCoverUrl != null)
                    hashCode = hashCode * 59 + this.CreateChannelOptionsCoverUrl.GetHashCode();
                if (this.CreateChannelOptionsCustomType != null)
                    hashCode = hashCode * 59 + this.CreateChannelOptionsCustomType.GetHashCode();
                if (this.CreateChannelOptionsData != null)
                    hashCode = hashCode * 59 + this.CreateChannelOptionsData.GetHashCode();
                if (this.CreateChannelOptionsDistinct != null)
                    hashCode = hashCode * 59 + this.CreateChannelOptionsDistinct.GetHashCode();
                if (this.MessageUserId != null)
                    hashCode = hashCode * 59 + this.MessageUserId.GetHashCode();
                if (this.MessageContent != null)
                    hashCode = hashCode * 59 + this.MessageContent.GetHashCode();
                if (this.MessageData != null)
                    hashCode = hashCode * 59 + this.MessageData.GetHashCode();
                if (this.EnablePush != null)
                    hashCode = hashCode * 59 + this.EnablePush.GetHashCode();
                if (this.ScheduledAt != null)
                    hashCode = hashCode * 59 + this.ScheduledAt.GetHashCode();
                if (this.EndAt != null)
                    hashCode = hashCode * 59 + this.EndAt.GetHashCode();
                if (this.CeaseAt != null)
                    hashCode = hashCode * 59 + this.CeaseAt.GetHashCode();
                if (this.ResumeAt != null)
                    hashCode = hashCode * 59 + this.ResumeAt.GetHashCode();
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
