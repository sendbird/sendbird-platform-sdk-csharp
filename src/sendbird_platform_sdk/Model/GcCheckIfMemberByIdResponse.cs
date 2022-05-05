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
    /// GcCheckIfMemberByIdResponse
    /// </summary>
    [DataContract]
    public partial class GcCheckIfMemberByIdResponse :  IEquatable<GcCheckIfMemberByIdResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GcCheckIfMemberByIdResponse" /> class.
        /// </summary>
        /// <param name="isMember">isMember.</param>
        /// <param name="state">state.</param>
        public GcCheckIfMemberByIdResponse(bool isMember = default(bool), string state = default(string))
        {
            this.IsMember = isMember;
            this.State = state;
        }

        /// <summary>
        /// Gets or Sets IsMember
        /// </summary>
        [DataMember(Name="is_member", EmitDefaultValue=false)]
        public bool IsMember { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GcCheckIfMemberByIdResponse {\n");
            sb.Append("  IsMember: ").Append(IsMember).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as GcCheckIfMemberByIdResponse);
        }

        /// <summary>
        /// Returns true if GcCheckIfMemberByIdResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GcCheckIfMemberByIdResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GcCheckIfMemberByIdResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsMember == input.IsMember ||
                    (this.IsMember != null &&
                    this.IsMember.Equals(input.IsMember))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.IsMember != null)
                    hashCode = hashCode * 59 + this.IsMember.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
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
