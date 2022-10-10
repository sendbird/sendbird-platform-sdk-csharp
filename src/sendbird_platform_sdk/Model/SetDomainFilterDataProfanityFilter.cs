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
    /// SetDomainFilterDataProfanityFilter
    /// </summary>
    [DataContract]
    public partial class SetDomainFilterDataProfanityFilter :  IEquatable<SetDomainFilterDataProfanityFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetDomainFilterDataProfanityFilter" /> class.
        /// </summary>
        /// <param name="keywords">keywords.</param>
        /// <param name="regexFilters">regexFilters.</param>
        /// <param name="type">type.</param>
        /// <param name="shouldCheckGlobal">shouldCheckGlobal.</param>
        public SetDomainFilterDataProfanityFilter(List<string> keywords = default(List<string>), List<SetDomainFilterDataProfanityFilterRegexFiltersInner> regexFilters = default(List<SetDomainFilterDataProfanityFilterRegexFiltersInner>), int type = default(int), bool shouldCheckGlobal = default(bool))
        {
            this.Keywords = keywords;
            this.RegexFilters = regexFilters;
            this.Type = type;
            this.ShouldCheckGlobal = shouldCheckGlobal;
        }

        /// <summary>
        /// Gets or Sets Keywords
        /// </summary>
        [DataMember(Name="keywords", EmitDefaultValue=false)]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// Gets or Sets RegexFilters
        /// </summary>
        [DataMember(Name="regex_filters", EmitDefaultValue=false)]
        public List<SetDomainFilterDataProfanityFilterRegexFiltersInner> RegexFilters { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int Type { get; set; }

        /// <summary>
        /// Gets or Sets ShouldCheckGlobal
        /// </summary>
        [DataMember(Name="should_check_global", EmitDefaultValue=false)]
        public bool ShouldCheckGlobal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetDomainFilterDataProfanityFilter {\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  RegexFilters: ").Append(RegexFilters).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ShouldCheckGlobal: ").Append(ShouldCheckGlobal).Append("\n");
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
            return this.Equals(input as SetDomainFilterDataProfanityFilter);
        }

        /// <summary>
        /// Returns true if SetDomainFilterDataProfanityFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of SetDomainFilterDataProfanityFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetDomainFilterDataProfanityFilter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Keywords == input.Keywords ||
                    this.Keywords != null &&
                    input.Keywords != null &&
                    this.Keywords.SequenceEqual(input.Keywords)
                ) && 
                (
                    this.RegexFilters == input.RegexFilters ||
                    this.RegexFilters != null &&
                    input.RegexFilters != null &&
                    this.RegexFilters.SequenceEqual(input.RegexFilters)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ShouldCheckGlobal == input.ShouldCheckGlobal ||
                    (this.ShouldCheckGlobal != null &&
                    this.ShouldCheckGlobal.Equals(input.ShouldCheckGlobal))
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
                if (this.Keywords != null)
                    hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                if (this.RegexFilters != null)
                    hashCode = hashCode * 59 + this.RegexFilters.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ShouldCheckGlobal != null)
                    hashCode = hashCode * 59 + this.ShouldCheckGlobal.GetHashCode();
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
