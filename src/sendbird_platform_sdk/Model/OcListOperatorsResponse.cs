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
    /// OcListOperatorsResponse
    /// </summary>
    [DataContract]
    public partial class OcListOperatorsResponse :  IEquatable<OcListOperatorsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OcListOperatorsResponse" /> class.
        /// </summary>
        /// <param name="operators">operators.</param>
        /// <param name="next">next.</param>
        public OcListOperatorsResponse(List<SendBirdUser> operators = default(List<SendBirdUser>), string next = default(string))
        {
            this.Operators = operators;
            this.Next = next;
        }

        /// <summary>
        /// Gets or Sets Operators
        /// </summary>
        [DataMember(Name="operators", EmitDefaultValue=false)]
        public List<SendBirdUser> Operators { get; set; }

        /// <summary>
        /// Gets or Sets Next
        /// </summary>
        [DataMember(Name="next", EmitDefaultValue=false)]
        public string Next { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OcListOperatorsResponse {\n");
            sb.Append("  Operators: ").Append(Operators).Append("\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
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
            return this.Equals(input as OcListOperatorsResponse);
        }

        /// <summary>
        /// Returns true if OcListOperatorsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OcListOperatorsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OcListOperatorsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Operators == input.Operators ||
                    this.Operators != null &&
                    input.Operators != null &&
                    this.Operators.SequenceEqual(input.Operators)
                ) && 
                (
                    this.Next == input.Next ||
                    (this.Next != null &&
                    this.Next.Equals(input.Next))
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
                if (this.Operators != null)
                    hashCode = hashCode * 59 + this.Operators.GetHashCode();
                if (this.Next != null)
                    hashCode = hashCode * 59 + this.Next.GetHashCode();
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
