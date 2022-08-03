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
    /// RegisterAndScheduleDataExportData
    /// </summary>
    [DataContract]
    public partial class RegisterAndScheduleDataExportData :  IEquatable<RegisterAndScheduleDataExportData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterAndScheduleDataExportData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RegisterAndScheduleDataExportData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterAndScheduleDataExportData" /> class.
        /// </summary>
        /// <param name="startTs">Specifies the starting timestamp of a period for target objects&#39; creation date, in [Unix milliseconds](/docs/chat/v3/platform-api/guides/miscellaneous#2-timestamps) format. The creation time of messages, channels, and users will be in-between the start_ts and end_ts. (required).</param>
        /// <param name="endTs">Specifies the ending timestamp of a period for target objects&#39; creation date, in [Unix milliseconds](/docs/chat/v3/platform-api/guides/miscellaneous#2-timestamps) format. The creation time of messages, channels, and users will be in-between the start_ts and end_ts. (required).</param>
        /// <param name="format">Specifies the format of the file to export the messages to. Acceptable values are json and csv. (Default: json).</param>
        /// <param name="csvDelimiter">Sets a single character delimiter to separate the values in each row of the csv file which stores two-dimensional arrays of the exported message data. Either English alphabets or special characters can be used as a delimiter, including a horizontal tab (\\t), a line feed (\\n), a vertical bar (\\.</param>
        /// <param name="timezone">Specifies the timezone to be applied to the timestamp of the exported messages. For example, US/Pacific, Asia/Seoul, Europe/London, etc. (Default: UTC).</param>
        /// <param name="senderIds">Specifies an array of the IDs of the users which are used to filter the messages by its sender for the export. This property is effective only when the data_type parameter is set to messages, and can be specified up to 10 IDs in the request. (Default: all messages sent by any user).</param>
        /// <param name="excludeSenderIds">Specifies an array of the IDs of the users which are used to exclude their sent messages from the export. This property is effective only when the data_type parameter is set to messages, and can be specified up to 10 IDs. (Default: all messages sent by any user).</param>
        /// <param name="channelUrls">Specifies an array of one or more URLs of channels to export the messages from. This property is effective only when the data_type parameter is set to messages or channels. (Default: all channels).</param>
        /// <param name="excludeChannelUrls">Specifies an array of one or more URLs of channels to exclude when exporting the messages. This property is effective only when the data_type parameter is set to messages or channels. (Default: include all channels).</param>
        /// <param name="userIds">Specifies an array of the IDs of the users to export their information. This property is effective only when the data_type parameter is set to users. (Default: all users).</param>
        /// <param name="showReadReceipt">Determines whether to include information about the read receipts of each channel in the exported data. The read receipt indicates the timestamps of when each user has last read the messages in the channel, in [Unix milliseconds](/docs/chat/v3/platform-api/guides/miscellaneous#2-timestamps). (Default: true).</param>
        /// <param name="showChannelMetadata">Determines whether to include [channel metadata](/docs/chat/v3/platform-api/guides/user-and-channel-metadata#2-view-a-channel-metadata) in the result files..</param>
        /// <param name="neighboringMessageLimit">Specifies the maximum number of other users&#39; messages to be exported, which took place after the specified message of a user filtered by the sender_ids property. Even if there may be more messages that took place, if the quantity exceeds the number of the neighboring_message_limit, they are omitted. Only the messages that took place right after the specified message will be counted and exported. This can be used to better analyze the context. Acceptable values are 1 to 10, inclusive. (Default: 0).</param>
        public RegisterAndScheduleDataExportData(int startTs = default(int), int endTs = default(int), string format = default(string), string csvDelimiter = default(string), string timezone = default(string), List<string> senderIds = default(List<string>), List<string> excludeSenderIds = default(List<string>), List<string> channelUrls = default(List<string>), List<string> excludeChannelUrls = default(List<string>), List<string> userIds = default(List<string>), bool showReadReceipt = default(bool), bool showChannelMetadata = default(bool), int neighboringMessageLimit = default(int))
        {
            // to ensure "startTs" is required (not null)
            if (startTs == null)
            {
                throw new InvalidDataException("startTs is a required property for RegisterAndScheduleDataExportData and cannot be null");
            }
            else
            {
                this.StartTs = startTs;
            }

            // to ensure "endTs" is required (not null)
            if (endTs == null)
            {
                throw new InvalidDataException("endTs is a required property for RegisterAndScheduleDataExportData and cannot be null");
            }
            else
            {
                this.EndTs = endTs;
            }

            this.Format = format;
            this.CsvDelimiter = csvDelimiter;
            this.Timezone = timezone;
            this.SenderIds = senderIds;
            this.ExcludeSenderIds = excludeSenderIds;
            this.ChannelUrls = channelUrls;
            this.ExcludeChannelUrls = excludeChannelUrls;
            this.UserIds = userIds;
            this.ShowReadReceipt = showReadReceipt;
            this.ShowChannelMetadata = showChannelMetadata;
            this.NeighboringMessageLimit = neighboringMessageLimit;
        }

        /// <summary>
        /// Specifies the starting timestamp of a period for target objects&#39; creation date, in [Unix milliseconds](/docs/chat/v3/platform-api/guides/miscellaneous#2-timestamps) format. The creation time of messages, channels, and users will be in-between the start_ts and end_ts.
        /// </summary>
        /// <value>Specifies the starting timestamp of a period for target objects&#39; creation date, in [Unix milliseconds](/docs/chat/v3/platform-api/guides/miscellaneous#2-timestamps) format. The creation time of messages, channels, and users will be in-between the start_ts and end_ts.</value>
        [DataMember(Name="start_ts", EmitDefaultValue=true)]
        public int StartTs { get; set; }

        /// <summary>
        /// Specifies the ending timestamp of a period for target objects&#39; creation date, in [Unix milliseconds](/docs/chat/v3/platform-api/guides/miscellaneous#2-timestamps) format. The creation time of messages, channels, and users will be in-between the start_ts and end_ts.
        /// </summary>
        /// <value>Specifies the ending timestamp of a period for target objects&#39; creation date, in [Unix milliseconds](/docs/chat/v3/platform-api/guides/miscellaneous#2-timestamps) format. The creation time of messages, channels, and users will be in-between the start_ts and end_ts.</value>
        [DataMember(Name="end_ts", EmitDefaultValue=true)]
        public int EndTs { get; set; }

        /// <summary>
        /// Specifies the format of the file to export the messages to. Acceptable values are json and csv. (Default: json)
        /// </summary>
        /// <value>Specifies the format of the file to export the messages to. Acceptable values are json and csv. (Default: json)</value>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public string Format { get; set; }

        /// <summary>
        /// Sets a single character delimiter to separate the values in each row of the csv file which stores two-dimensional arrays of the exported message data. Either English alphabets or special characters can be used as a delimiter, including a horizontal tab (\\t), a line feed (\\n), a vertical bar (\\
        /// </summary>
        /// <value>Sets a single character delimiter to separate the values in each row of the csv file which stores two-dimensional arrays of the exported message data. Either English alphabets or special characters can be used as a delimiter, including a horizontal tab (\\t), a line feed (\\n), a vertical bar (\\</value>
        [DataMember(Name="csv_delimiter", EmitDefaultValue=false)]
        public string CsvDelimiter { get; set; }

        /// <summary>
        /// Specifies the timezone to be applied to the timestamp of the exported messages. For example, US/Pacific, Asia/Seoul, Europe/London, etc. (Default: UTC)
        /// </summary>
        /// <value>Specifies the timezone to be applied to the timestamp of the exported messages. For example, US/Pacific, Asia/Seoul, Europe/London, etc. (Default: UTC)</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Specifies an array of the IDs of the users which are used to filter the messages by its sender for the export. This property is effective only when the data_type parameter is set to messages, and can be specified up to 10 IDs in the request. (Default: all messages sent by any user)
        /// </summary>
        /// <value>Specifies an array of the IDs of the users which are used to filter the messages by its sender for the export. This property is effective only when the data_type parameter is set to messages, and can be specified up to 10 IDs in the request. (Default: all messages sent by any user)</value>
        [DataMember(Name="sender_ids", EmitDefaultValue=false)]
        public List<string> SenderIds { get; set; }

        /// <summary>
        /// Specifies an array of the IDs of the users which are used to exclude their sent messages from the export. This property is effective only when the data_type parameter is set to messages, and can be specified up to 10 IDs. (Default: all messages sent by any user)
        /// </summary>
        /// <value>Specifies an array of the IDs of the users which are used to exclude their sent messages from the export. This property is effective only when the data_type parameter is set to messages, and can be specified up to 10 IDs. (Default: all messages sent by any user)</value>
        [DataMember(Name="exclude_sender_ids", EmitDefaultValue=false)]
        public List<string> ExcludeSenderIds { get; set; }

        /// <summary>
        /// Specifies an array of one or more URLs of channels to export the messages from. This property is effective only when the data_type parameter is set to messages or channels. (Default: all channels)
        /// </summary>
        /// <value>Specifies an array of one or more URLs of channels to export the messages from. This property is effective only when the data_type parameter is set to messages or channels. (Default: all channels)</value>
        [DataMember(Name="channel_urls", EmitDefaultValue=false)]
        public List<string> ChannelUrls { get; set; }

        /// <summary>
        /// Specifies an array of one or more URLs of channels to exclude when exporting the messages. This property is effective only when the data_type parameter is set to messages or channels. (Default: include all channels)
        /// </summary>
        /// <value>Specifies an array of one or more URLs of channels to exclude when exporting the messages. This property is effective only when the data_type parameter is set to messages or channels. (Default: include all channels)</value>
        [DataMember(Name="exclude_channel_urls", EmitDefaultValue=false)]
        public List<string> ExcludeChannelUrls { get; set; }

        /// <summary>
        /// Specifies an array of the IDs of the users to export their information. This property is effective only when the data_type parameter is set to users. (Default: all users)
        /// </summary>
        /// <value>Specifies an array of the IDs of the users to export their information. This property is effective only when the data_type parameter is set to users. (Default: all users)</value>
        [DataMember(Name="user_ids", EmitDefaultValue=false)]
        public List<string> UserIds { get; set; }

        /// <summary>
        /// Determines whether to include information about the read receipts of each channel in the exported data. The read receipt indicates the timestamps of when each user has last read the messages in the channel, in [Unix milliseconds](/docs/chat/v3/platform-api/guides/miscellaneous#2-timestamps). (Default: true)
        /// </summary>
        /// <value>Determines whether to include information about the read receipts of each channel in the exported data. The read receipt indicates the timestamps of when each user has last read the messages in the channel, in [Unix milliseconds](/docs/chat/v3/platform-api/guides/miscellaneous#2-timestamps). (Default: true)</value>
        [DataMember(Name="show_read_receipt", EmitDefaultValue=false)]
        public bool ShowReadReceipt { get; set; }

        /// <summary>
        /// Determines whether to include [channel metadata](/docs/chat/v3/platform-api/guides/user-and-channel-metadata#2-view-a-channel-metadata) in the result files.
        /// </summary>
        /// <value>Determines whether to include [channel metadata](/docs/chat/v3/platform-api/guides/user-and-channel-metadata#2-view-a-channel-metadata) in the result files.</value>
        [DataMember(Name="show_channel_metadata", EmitDefaultValue=false)]
        public bool ShowChannelMetadata { get; set; }

        /// <summary>
        /// Specifies the maximum number of other users&#39; messages to be exported, which took place after the specified message of a user filtered by the sender_ids property. Even if there may be more messages that took place, if the quantity exceeds the number of the neighboring_message_limit, they are omitted. Only the messages that took place right after the specified message will be counted and exported. This can be used to better analyze the context. Acceptable values are 1 to 10, inclusive. (Default: 0)
        /// </summary>
        /// <value>Specifies the maximum number of other users&#39; messages to be exported, which took place after the specified message of a user filtered by the sender_ids property. Even if there may be more messages that took place, if the quantity exceeds the number of the neighboring_message_limit, they are omitted. Only the messages that took place right after the specified message will be counted and exported. This can be used to better analyze the context. Acceptable values are 1 to 10, inclusive. (Default: 0)</value>
        [DataMember(Name="neighboring_message_limit", EmitDefaultValue=false)]
        public int NeighboringMessageLimit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegisterAndScheduleDataExportData {\n");
            sb.Append("  StartTs: ").Append(StartTs).Append("\n");
            sb.Append("  EndTs: ").Append(EndTs).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  CsvDelimiter: ").Append(CsvDelimiter).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  SenderIds: ").Append(SenderIds).Append("\n");
            sb.Append("  ExcludeSenderIds: ").Append(ExcludeSenderIds).Append("\n");
            sb.Append("  ChannelUrls: ").Append(ChannelUrls).Append("\n");
            sb.Append("  ExcludeChannelUrls: ").Append(ExcludeChannelUrls).Append("\n");
            sb.Append("  UserIds: ").Append(UserIds).Append("\n");
            sb.Append("  ShowReadReceipt: ").Append(ShowReadReceipt).Append("\n");
            sb.Append("  ShowChannelMetadata: ").Append(ShowChannelMetadata).Append("\n");
            sb.Append("  NeighboringMessageLimit: ").Append(NeighboringMessageLimit).Append("\n");
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
            return this.Equals(input as RegisterAndScheduleDataExportData);
        }

        /// <summary>
        /// Returns true if RegisterAndScheduleDataExportData instances are equal
        /// </summary>
        /// <param name="input">Instance of RegisterAndScheduleDataExportData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegisterAndScheduleDataExportData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartTs == input.StartTs ||
                    (this.StartTs != null &&
                    this.StartTs.Equals(input.StartTs))
                ) && 
                (
                    this.EndTs == input.EndTs ||
                    (this.EndTs != null &&
                    this.EndTs.Equals(input.EndTs))
                ) && 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this.CsvDelimiter == input.CsvDelimiter ||
                    (this.CsvDelimiter != null &&
                    this.CsvDelimiter.Equals(input.CsvDelimiter))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.SenderIds == input.SenderIds ||
                    this.SenderIds != null &&
                    input.SenderIds != null &&
                    this.SenderIds.SequenceEqual(input.SenderIds)
                ) && 
                (
                    this.ExcludeSenderIds == input.ExcludeSenderIds ||
                    this.ExcludeSenderIds != null &&
                    input.ExcludeSenderIds != null &&
                    this.ExcludeSenderIds.SequenceEqual(input.ExcludeSenderIds)
                ) && 
                (
                    this.ChannelUrls == input.ChannelUrls ||
                    this.ChannelUrls != null &&
                    input.ChannelUrls != null &&
                    this.ChannelUrls.SequenceEqual(input.ChannelUrls)
                ) && 
                (
                    this.ExcludeChannelUrls == input.ExcludeChannelUrls ||
                    this.ExcludeChannelUrls != null &&
                    input.ExcludeChannelUrls != null &&
                    this.ExcludeChannelUrls.SequenceEqual(input.ExcludeChannelUrls)
                ) && 
                (
                    this.UserIds == input.UserIds ||
                    this.UserIds != null &&
                    input.UserIds != null &&
                    this.UserIds.SequenceEqual(input.UserIds)
                ) && 
                (
                    this.ShowReadReceipt == input.ShowReadReceipt ||
                    (this.ShowReadReceipt != null &&
                    this.ShowReadReceipt.Equals(input.ShowReadReceipt))
                ) && 
                (
                    this.ShowChannelMetadata == input.ShowChannelMetadata ||
                    (this.ShowChannelMetadata != null &&
                    this.ShowChannelMetadata.Equals(input.ShowChannelMetadata))
                ) && 
                (
                    this.NeighboringMessageLimit == input.NeighboringMessageLimit ||
                    (this.NeighboringMessageLimit != null &&
                    this.NeighboringMessageLimit.Equals(input.NeighboringMessageLimit))
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
                if (this.StartTs != null)
                    hashCode = hashCode * 59 + this.StartTs.GetHashCode();
                if (this.EndTs != null)
                    hashCode = hashCode * 59 + this.EndTs.GetHashCode();
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.CsvDelimiter != null)
                    hashCode = hashCode * 59 + this.CsvDelimiter.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.SenderIds != null)
                    hashCode = hashCode * 59 + this.SenderIds.GetHashCode();
                if (this.ExcludeSenderIds != null)
                    hashCode = hashCode * 59 + this.ExcludeSenderIds.GetHashCode();
                if (this.ChannelUrls != null)
                    hashCode = hashCode * 59 + this.ChannelUrls.GetHashCode();
                if (this.ExcludeChannelUrls != null)
                    hashCode = hashCode * 59 + this.ExcludeChannelUrls.GetHashCode();
                if (this.UserIds != null)
                    hashCode = hashCode * 59 + this.UserIds.GetHashCode();
                if (this.ShowReadReceipt != null)
                    hashCode = hashCode * 59 + this.ShowReadReceipt.GetHashCode();
                if (this.ShowChannelMetadata != null)
                    hashCode = hashCode * 59 + this.ShowChannelMetadata.GetHashCode();
                if (this.NeighboringMessageLimit != null)
                    hashCode = hashCode * 59 + this.NeighboringMessageLimit.GetHashCode();
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
