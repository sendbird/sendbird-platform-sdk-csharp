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
    /// ReportUserByIdResponse
    /// </summary>
    [DataContract]
    public partial class ReportUserByIdResponse :  IEquatable<ReportUserByIdResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportUserByIdResponse" /> class.
        /// </summary>
        /// <param name="reportType">reportType.</param>
        /// <param name="reportCategory">reportCategory.</param>
        /// <param name="reportingUser">reportingUser.</param>
        /// <param name="offendingUser">offendingUser.</param>
        /// <param name="reportedMessage">reportedMessage.</param>
        /// <param name="channel">channel.</param>
        /// <param name="reportDescription">reportDescription.</param>
        /// <param name="createdAt">createdAt.</param>
        public ReportUserByIdResponse(string reportType = default(string), string reportCategory = default(string), SendBirdUser reportingUser = default(SendBirdUser), SendBirdUser offendingUser = default(SendBirdUser), SendBirdMessageResponse reportedMessage = default(SendBirdMessageResponse), SendBirdChannelResponse channel = default(SendBirdChannelResponse), string reportDescription = default(string), decimal createdAt = default(decimal))
        {
            this.ReportedMessage = reportedMessage;
            this.ReportType = reportType;
            this.ReportCategory = reportCategory;
            this.ReportingUser = reportingUser;
            this.OffendingUser = offendingUser;
            this.ReportedMessage = reportedMessage;
            this.Channel = channel;
            this.ReportDescription = reportDescription;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Gets or Sets ReportType
        /// </summary>
        [DataMember(Name="report_type", EmitDefaultValue=false)]
        public string ReportType { get; set; }

        /// <summary>
        /// Gets or Sets ReportCategory
        /// </summary>
        [DataMember(Name="report_category", EmitDefaultValue=false)]
        public string ReportCategory { get; set; }

        /// <summary>
        /// Gets or Sets ReportingUser
        /// </summary>
        [DataMember(Name="reporting_user", EmitDefaultValue=false)]
        public SendBirdUser ReportingUser { get; set; }

        /// <summary>
        /// Gets or Sets OffendingUser
        /// </summary>
        [DataMember(Name="offending_user", EmitDefaultValue=false)]
        public SendBirdUser OffendingUser { get; set; }

        /// <summary>
        /// Gets or Sets ReportedMessage
        /// </summary>
        [DataMember(Name="reported_message", EmitDefaultValue=true)]
        public SendBirdMessageResponse ReportedMessage { get; set; }

        /// <summary>
        /// Gets or Sets Channel
        /// </summary>
        [DataMember(Name="channel", EmitDefaultValue=false)]
        public SendBirdChannelResponse Channel { get; set; }

        /// <summary>
        /// Gets or Sets ReportDescription
        /// </summary>
        [DataMember(Name="report_description", EmitDefaultValue=false)]
        public string ReportDescription { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public decimal CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportUserByIdResponse {\n");
            sb.Append("  ReportType: ").Append(ReportType).Append("\n");
            sb.Append("  ReportCategory: ").Append(ReportCategory).Append("\n");
            sb.Append("  ReportingUser: ").Append(ReportingUser).Append("\n");
            sb.Append("  OffendingUser: ").Append(OffendingUser).Append("\n");
            sb.Append("  ReportedMessage: ").Append(ReportedMessage).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  ReportDescription: ").Append(ReportDescription).Append("\n");
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
            return this.Equals(input as ReportUserByIdResponse);
        }

        /// <summary>
        /// Returns true if ReportUserByIdResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportUserByIdResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportUserByIdResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReportType == input.ReportType ||
                    (this.ReportType != null &&
                    this.ReportType.Equals(input.ReportType))
                ) && 
                (
                    this.ReportCategory == input.ReportCategory ||
                    (this.ReportCategory != null &&
                    this.ReportCategory.Equals(input.ReportCategory))
                ) && 
                (
                    this.ReportingUser == input.ReportingUser ||
                    (this.ReportingUser != null &&
                    this.ReportingUser.Equals(input.ReportingUser))
                ) && 
                (
                    this.OffendingUser == input.OffendingUser ||
                    (this.OffendingUser != null &&
                    this.OffendingUser.Equals(input.OffendingUser))
                ) && 
                (
                    this.ReportedMessage == input.ReportedMessage ||
                    (this.ReportedMessage != null &&
                    this.ReportedMessage.Equals(input.ReportedMessage))
                ) && 
                (
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
                ) && 
                (
                    this.ReportDescription == input.ReportDescription ||
                    (this.ReportDescription != null &&
                    this.ReportDescription.Equals(input.ReportDescription))
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
                if (this.ReportType != null)
                    hashCode = hashCode * 59 + this.ReportType.GetHashCode();
                if (this.ReportCategory != null)
                    hashCode = hashCode * 59 + this.ReportCategory.GetHashCode();
                if (this.ReportingUser != null)
                    hashCode = hashCode * 59 + this.ReportingUser.GetHashCode();
                if (this.OffendingUser != null)
                    hashCode = hashCode * 59 + this.OffendingUser.GetHashCode();
                if (this.ReportedMessage != null)
                    hashCode = hashCode * 59 + this.ReportedMessage.GetHashCode();
                if (this.Channel != null)
                    hashCode = hashCode * 59 + this.Channel.GetHashCode();
                if (this.ReportDescription != null)
                    hashCode = hashCode * 59 + this.ReportDescription.GetHashCode();
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
