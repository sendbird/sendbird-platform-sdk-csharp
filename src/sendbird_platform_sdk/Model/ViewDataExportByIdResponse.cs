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
    /// ViewDataExportByIdResponse
    /// </summary>
    [DataContract]
    public partial class ViewDataExportByIdResponse :  IEquatable<ViewDataExportByIdResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewDataExportByIdResponse" /> class.
        /// </summary>
        /// <param name="requestId">requestId.</param>
        /// <param name="dataType">dataType.</param>
        /// <param name="status">status.</param>
        /// <param name="format">format.</param>
        /// <param name="csvDelimiter">csvDelimiter.</param>
        /// <param name="timezone">timezone.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="startTs">startTs.</param>
        /// <param name="endTs">endTs.</param>
        /// <param name="channelUrls">channelUrls.</param>
        /// <param name="channelCustomTypes">channelCustomTypes.</param>
        /// <param name="senderIds">senderIds.</param>
        /// <param name="file">file.</param>
        /// <param name="userIds">userIds.</param>
        public ViewDataExportByIdResponse(string requestId = default(string), string dataType = default(string), string status = default(string), string format = default(string), string csvDelimiter = default(string), string timezone = default(string), decimal createdAt = default(decimal), decimal startTs = default(decimal), decimal endTs = default(decimal), List<string> channelUrls = default(List<string>), List<string> channelCustomTypes = default(List<string>), List<string> senderIds = default(List<string>), ListDataExportsByMessageChannelOrUserResponseExportedDataInnerFile file = default(ListDataExportsByMessageChannelOrUserResponseExportedDataInnerFile), List<string> userIds = default(List<string>))
        {
            this.RequestId = requestId;
            this.DataType = dataType;
            this.Status = status;
            this.Format = format;
            this.CsvDelimiter = csvDelimiter;
            this.Timezone = timezone;
            this.CreatedAt = createdAt;
            this.StartTs = startTs;
            this.EndTs = endTs;
            this.ChannelUrls = channelUrls;
            this.ChannelCustomTypes = channelCustomTypes;
            this.SenderIds = senderIds;
            this.File = file;
            this.UserIds = userIds;
        }

        /// <summary>
        /// Gets or Sets RequestId
        /// </summary>
        [DataMember(Name="request_id", EmitDefaultValue=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Gets or Sets DataType
        /// </summary>
        [DataMember(Name="data_type", EmitDefaultValue=false)]
        public string DataType { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public string Format { get; set; }

        /// <summary>
        /// Gets or Sets CsvDelimiter
        /// </summary>
        [DataMember(Name="csv_delimiter", EmitDefaultValue=false)]
        public string CsvDelimiter { get; set; }

        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public decimal CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets StartTs
        /// </summary>
        [DataMember(Name="start_ts", EmitDefaultValue=false)]
        public decimal StartTs { get; set; }

        /// <summary>
        /// Gets or Sets EndTs
        /// </summary>
        [DataMember(Name="end_ts", EmitDefaultValue=false)]
        public decimal EndTs { get; set; }

        /// <summary>
        /// Gets or Sets ChannelUrls
        /// </summary>
        [DataMember(Name="channel_urls", EmitDefaultValue=false)]
        public List<string> ChannelUrls { get; set; }

        /// <summary>
        /// Gets or Sets ChannelCustomTypes
        /// </summary>
        [DataMember(Name="channel_custom_types", EmitDefaultValue=false)]
        public List<string> ChannelCustomTypes { get; set; }

        /// <summary>
        /// Gets or Sets SenderIds
        /// </summary>
        [DataMember(Name="sender_ids", EmitDefaultValue=false)]
        public List<string> SenderIds { get; set; }

        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name="file", EmitDefaultValue=false)]
        public ListDataExportsByMessageChannelOrUserResponseExportedDataInnerFile File { get; set; }

        /// <summary>
        /// Gets or Sets UserIds
        /// </summary>
        [DataMember(Name="user_ids", EmitDefaultValue=false)]
        public List<string> UserIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ViewDataExportByIdResponse {\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  CsvDelimiter: ").Append(CsvDelimiter).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  StartTs: ").Append(StartTs).Append("\n");
            sb.Append("  EndTs: ").Append(EndTs).Append("\n");
            sb.Append("  ChannelUrls: ").Append(ChannelUrls).Append("\n");
            sb.Append("  ChannelCustomTypes: ").Append(ChannelCustomTypes).Append("\n");
            sb.Append("  SenderIds: ").Append(SenderIds).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  UserIds: ").Append(UserIds).Append("\n");
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
            return this.Equals(input as ViewDataExportByIdResponse);
        }

        /// <summary>
        /// Returns true if ViewDataExportByIdResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewDataExportByIdResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewDataExportByIdResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.DataType == input.DataType ||
                    (this.DataType != null &&
                    this.DataType.Equals(input.DataType))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
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
                    this.ChannelUrls == input.ChannelUrls ||
                    this.ChannelUrls != null &&
                    input.ChannelUrls != null &&
                    this.ChannelUrls.SequenceEqual(input.ChannelUrls)
                ) && 
                (
                    this.ChannelCustomTypes == input.ChannelCustomTypes ||
                    this.ChannelCustomTypes != null &&
                    input.ChannelCustomTypes != null &&
                    this.ChannelCustomTypes.SequenceEqual(input.ChannelCustomTypes)
                ) && 
                (
                    this.SenderIds == input.SenderIds ||
                    this.SenderIds != null &&
                    input.SenderIds != null &&
                    this.SenderIds.SequenceEqual(input.SenderIds)
                ) && 
                (
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
                ) && 
                (
                    this.UserIds == input.UserIds ||
                    this.UserIds != null &&
                    input.UserIds != null &&
                    this.UserIds.SequenceEqual(input.UserIds)
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
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.DataType != null)
                    hashCode = hashCode * 59 + this.DataType.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.CsvDelimiter != null)
                    hashCode = hashCode * 59 + this.CsvDelimiter.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.StartTs != null)
                    hashCode = hashCode * 59 + this.StartTs.GetHashCode();
                if (this.EndTs != null)
                    hashCode = hashCode * 59 + this.EndTs.GetHashCode();
                if (this.ChannelUrls != null)
                    hashCode = hashCode * 59 + this.ChannelUrls.GetHashCode();
                if (this.ChannelCustomTypes != null)
                    hashCode = hashCode * 59 + this.ChannelCustomTypes.GetHashCode();
                if (this.SenderIds != null)
                    hashCode = hashCode * 59 + this.SenderIds.GetHashCode();
                if (this.File != null)
                    hashCode = hashCode * 59 + this.File.GetHashCode();
                if (this.UserIds != null)
                    hashCode = hashCode * 59 + this.UserIds.GetHashCode();
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
