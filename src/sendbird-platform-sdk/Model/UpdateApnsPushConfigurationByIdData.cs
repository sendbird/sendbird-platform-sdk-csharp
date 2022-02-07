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
using OpenAPIDateConverter = sendbird-platform-sdk.Client.OpenAPIDateConverter;

namespace sendbird-platform-sdk.Model
{
    /// <summary>
    /// UpdateApnsPushConfigurationByIdData
    /// </summary>
    [DataContract]
    public partial class UpdateApnsPushConfigurationByIdData :  IEquatable<UpdateApnsPushConfigurationByIdData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApnsPushConfigurationByIdData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateApnsPushConfigurationByIdData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApnsPushConfigurationByIdData" /> class.
        /// </summary>
        /// <param name="providerId">Specifies the provider ID of the push configuration to update. (required).</param>
        /// <param name="apnsCert">In a form of the &#x60;multipart/form-data&#x60; content type, specifies a [.p12](/docs/chat/v3/ios/guides/push-notifications#2-step-3-export-a-p12-file-and-upload-to-sendbird-dashboard) file of which type is either development or production. Sendbird server scans the content of the file, finds out the certificate type, and then registers the file as the corresponding type. If you upload a wrong file, you will receive an error. You should specify either this property or the apns_type below to inform the server of which certificate type to update. (required).</param>
        /// <param name="apnsCertEnvType">Specifies the certificate type of the [.p12](/docs/chat/v3/ios/guides/push-notifications#2-step-3-export-a-p12-file-and-upload-to-sendbird-dashboard) file. Acceptable values are development and production. You should specify either this property or the apns_cert above to inform the server of which certificate type to update. (required).</param>
        /// <param name="apnsCertPassword">Specifies the password of the cerfificate file which has been set during the [.p12](/docs/chat/v3/ios/guides/push-notifications#2-step-3-export-a-p12-file-and-upload-to-sendbird-dashboard) export. (required).</param>
        /// <param name="hasUnreadCountBadge">Determines whether to badge your client app&#39;s icon with the number of a user&#39;s unread messages. (Default: true) (required).</param>
        /// <param name="contentAvailable">Determines for your client app whether to perform a silent background update on a user&#39;s device. For more information, see the Apple Developer Documentation&#39;s [Pushing Updates to Your App Silently](https://developer.apple.com/documentation/usernotifications/setting_up_a_remote_notification_server/pushing_updates_to_your_app_silently). (Default: false) (required).</param>
        /// <param name="mutableContent">Determines for your client app whether or not to modify the payload of a push notification before it is displayed on a user&#39;s device. For more information, see the Apple Developer Documentation&#39;s [Modifying Content in Newly Delivered Notifications](https://developer.apple.com/documentation/usernotifications/modifying_content_in_newly_delivered_notifications). (Default: false) (required).</param>
        /// <param name="pushSound">Specifies the name of a sound file to be played when a push notification is delivered to your client app. The file can be in the app&#39;s main bundle or in the &#x60;Library/Sounds&#x60; folder of the app&#39;s data container. (required).</param>
        /// <param name="apnsType">(Deprecated)  Specifies the certificate type of the [.p12](/docs/chat/v3/ios/guides/push-notifications#2-step-3-export-a-p12-file-and-upload-to-sendbird-dashboard) file. Acceptable values are development and production. You should specify either this property or the apns_cert above to inform the server of which certificate type to update. (required).</param>
        public UpdateApnsPushConfigurationByIdData(string providerId = default(string), System.IO.Stream apnsCert = default(System.IO.Stream), string apnsCertEnvType = default(string), string apnsCertPassword = default(string), bool hasUnreadCountBadge = default(bool), bool contentAvailable = default(bool), bool mutableContent = default(bool), string pushSound = default(string), string apnsType = default(string))
        {
            // to ensure "providerId" is required (not null)
            if (providerId == null)
            {
                throw new InvalidDataException("providerId is a required property for UpdateApnsPushConfigurationByIdData and cannot be null");
            }
            else
            {
                this.ProviderId = providerId;
            }

            // to ensure "apnsCert" is required (not null)
            if (apnsCert == null)
            {
                throw new InvalidDataException("apnsCert is a required property for UpdateApnsPushConfigurationByIdData and cannot be null");
            }
            else
            {
                this.ApnsCert = apnsCert;
            }

            // to ensure "apnsCertEnvType" is required (not null)
            if (apnsCertEnvType == null)
            {
                throw new InvalidDataException("apnsCertEnvType is a required property for UpdateApnsPushConfigurationByIdData and cannot be null");
            }
            else
            {
                this.ApnsCertEnvType = apnsCertEnvType;
            }

            // to ensure "apnsCertPassword" is required (not null)
            if (apnsCertPassword == null)
            {
                throw new InvalidDataException("apnsCertPassword is a required property for UpdateApnsPushConfigurationByIdData and cannot be null");
            }
            else
            {
                this.ApnsCertPassword = apnsCertPassword;
            }

            // to ensure "hasUnreadCountBadge" is required (not null)
            if (hasUnreadCountBadge == null)
            {
                throw new InvalidDataException("hasUnreadCountBadge is a required property for UpdateApnsPushConfigurationByIdData and cannot be null");
            }
            else
            {
                this.HasUnreadCountBadge = hasUnreadCountBadge;
            }

            // to ensure "contentAvailable" is required (not null)
            if (contentAvailable == null)
            {
                throw new InvalidDataException("contentAvailable is a required property for UpdateApnsPushConfigurationByIdData and cannot be null");
            }
            else
            {
                this.ContentAvailable = contentAvailable;
            }

            // to ensure "mutableContent" is required (not null)
            if (mutableContent == null)
            {
                throw new InvalidDataException("mutableContent is a required property for UpdateApnsPushConfigurationByIdData and cannot be null");
            }
            else
            {
                this.MutableContent = mutableContent;
            }

            // to ensure "pushSound" is required (not null)
            if (pushSound == null)
            {
                throw new InvalidDataException("pushSound is a required property for UpdateApnsPushConfigurationByIdData and cannot be null");
            }
            else
            {
                this.PushSound = pushSound;
            }

            // to ensure "apnsType" is required (not null)
            if (apnsType == null)
            {
                throw new InvalidDataException("apnsType is a required property for UpdateApnsPushConfigurationByIdData and cannot be null");
            }
            else
            {
                this.ApnsType = apnsType;
            }

        }

        /// <summary>
        /// Specifies the provider ID of the push configuration to update.
        /// </summary>
        /// <value>Specifies the provider ID of the push configuration to update.</value>
        [DataMember(Name="provider_id", EmitDefaultValue=true)]
        public string ProviderId { get; set; }

        /// <summary>
        /// In a form of the &#x60;multipart/form-data&#x60; content type, specifies a [.p12](/docs/chat/v3/ios/guides/push-notifications#2-step-3-export-a-p12-file-and-upload-to-sendbird-dashboard) file of which type is either development or production. Sendbird server scans the content of the file, finds out the certificate type, and then registers the file as the corresponding type. If you upload a wrong file, you will receive an error. You should specify either this property or the apns_type below to inform the server of which certificate type to update.
        /// </summary>
        /// <value>In a form of the &#x60;multipart/form-data&#x60; content type, specifies a [.p12](/docs/chat/v3/ios/guides/push-notifications#2-step-3-export-a-p12-file-and-upload-to-sendbird-dashboard) file of which type is either development or production. Sendbird server scans the content of the file, finds out the certificate type, and then registers the file as the corresponding type. If you upload a wrong file, you will receive an error. You should specify either this property or the apns_type below to inform the server of which certificate type to update.</value>
        [DataMember(Name="apns_cert", EmitDefaultValue=true)]
        public System.IO.Stream ApnsCert { get; set; }

        /// <summary>
        /// Specifies the certificate type of the [.p12](/docs/chat/v3/ios/guides/push-notifications#2-step-3-export-a-p12-file-and-upload-to-sendbird-dashboard) file. Acceptable values are development and production. You should specify either this property or the apns_cert above to inform the server of which certificate type to update.
        /// </summary>
        /// <value>Specifies the certificate type of the [.p12](/docs/chat/v3/ios/guides/push-notifications#2-step-3-export-a-p12-file-and-upload-to-sendbird-dashboard) file. Acceptable values are development and production. You should specify either this property or the apns_cert above to inform the server of which certificate type to update.</value>
        [DataMember(Name="apns_cert_env_type", EmitDefaultValue=true)]
        public string ApnsCertEnvType { get; set; }

        /// <summary>
        /// Specifies the password of the cerfificate file which has been set during the [.p12](/docs/chat/v3/ios/guides/push-notifications#2-step-3-export-a-p12-file-and-upload-to-sendbird-dashboard) export.
        /// </summary>
        /// <value>Specifies the password of the cerfificate file which has been set during the [.p12](/docs/chat/v3/ios/guides/push-notifications#2-step-3-export-a-p12-file-and-upload-to-sendbird-dashboard) export.</value>
        [DataMember(Name="apns_cert_password", EmitDefaultValue=true)]
        public string ApnsCertPassword { get; set; }

        /// <summary>
        /// Determines whether to badge your client app&#39;s icon with the number of a user&#39;s unread messages. (Default: true)
        /// </summary>
        /// <value>Determines whether to badge your client app&#39;s icon with the number of a user&#39;s unread messages. (Default: true)</value>
        [DataMember(Name="has_unread_count_badge", EmitDefaultValue=true)]
        public bool HasUnreadCountBadge { get; set; }

        /// <summary>
        /// Determines for your client app whether to perform a silent background update on a user&#39;s device. For more information, see the Apple Developer Documentation&#39;s [Pushing Updates to Your App Silently](https://developer.apple.com/documentation/usernotifications/setting_up_a_remote_notification_server/pushing_updates_to_your_app_silently). (Default: false)
        /// </summary>
        /// <value>Determines for your client app whether to perform a silent background update on a user&#39;s device. For more information, see the Apple Developer Documentation&#39;s [Pushing Updates to Your App Silently](https://developer.apple.com/documentation/usernotifications/setting_up_a_remote_notification_server/pushing_updates_to_your_app_silently). (Default: false)</value>
        [DataMember(Name="content_available", EmitDefaultValue=true)]
        public bool ContentAvailable { get; set; }

        /// <summary>
        /// Determines for your client app whether or not to modify the payload of a push notification before it is displayed on a user&#39;s device. For more information, see the Apple Developer Documentation&#39;s [Modifying Content in Newly Delivered Notifications](https://developer.apple.com/documentation/usernotifications/modifying_content_in_newly_delivered_notifications). (Default: false)
        /// </summary>
        /// <value>Determines for your client app whether or not to modify the payload of a push notification before it is displayed on a user&#39;s device. For more information, see the Apple Developer Documentation&#39;s [Modifying Content in Newly Delivered Notifications](https://developer.apple.com/documentation/usernotifications/modifying_content_in_newly_delivered_notifications). (Default: false)</value>
        [DataMember(Name="mutable_content", EmitDefaultValue=true)]
        public bool MutableContent { get; set; }

        /// <summary>
        /// Specifies the name of a sound file to be played when a push notification is delivered to your client app. The file can be in the app&#39;s main bundle or in the &#x60;Library/Sounds&#x60; folder of the app&#39;s data container.
        /// </summary>
        /// <value>Specifies the name of a sound file to be played when a push notification is delivered to your client app. The file can be in the app&#39;s main bundle or in the &#x60;Library/Sounds&#x60; folder of the app&#39;s data container.</value>
        [DataMember(Name="push_sound", EmitDefaultValue=true)]
        public string PushSound { get; set; }

        /// <summary>
        /// (Deprecated)  Specifies the certificate type of the [.p12](/docs/chat/v3/ios/guides/push-notifications#2-step-3-export-a-p12-file-and-upload-to-sendbird-dashboard) file. Acceptable values are development and production. You should specify either this property or the apns_cert above to inform the server of which certificate type to update.
        /// </summary>
        /// <value>(Deprecated)  Specifies the certificate type of the [.p12](/docs/chat/v3/ios/guides/push-notifications#2-step-3-export-a-p12-file-and-upload-to-sendbird-dashboard) file. Acceptable values are development and production. You should specify either this property or the apns_cert above to inform the server of which certificate type to update.</value>
        [DataMember(Name="apns_type", EmitDefaultValue=true)]
        public string ApnsType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateApnsPushConfigurationByIdData {\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  ApnsCert: ").Append(ApnsCert).Append("\n");
            sb.Append("  ApnsCertEnvType: ").Append(ApnsCertEnvType).Append("\n");
            sb.Append("  ApnsCertPassword: ").Append(ApnsCertPassword).Append("\n");
            sb.Append("  HasUnreadCountBadge: ").Append(HasUnreadCountBadge).Append("\n");
            sb.Append("  ContentAvailable: ").Append(ContentAvailable).Append("\n");
            sb.Append("  MutableContent: ").Append(MutableContent).Append("\n");
            sb.Append("  PushSound: ").Append(PushSound).Append("\n");
            sb.Append("  ApnsType: ").Append(ApnsType).Append("\n");
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
            return this.Equals(input as UpdateApnsPushConfigurationByIdData);
        }

        /// <summary>
        /// Returns true if UpdateApnsPushConfigurationByIdData instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateApnsPushConfigurationByIdData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateApnsPushConfigurationByIdData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProviderId == input.ProviderId ||
                    (this.ProviderId != null &&
                    this.ProviderId.Equals(input.ProviderId))
                ) && 
                (
                    this.ApnsCert == input.ApnsCert ||
                    (this.ApnsCert != null &&
                    this.ApnsCert.Equals(input.ApnsCert))
                ) && 
                (
                    this.ApnsCertEnvType == input.ApnsCertEnvType ||
                    (this.ApnsCertEnvType != null &&
                    this.ApnsCertEnvType.Equals(input.ApnsCertEnvType))
                ) && 
                (
                    this.ApnsCertPassword == input.ApnsCertPassword ||
                    (this.ApnsCertPassword != null &&
                    this.ApnsCertPassword.Equals(input.ApnsCertPassword))
                ) && 
                (
                    this.HasUnreadCountBadge == input.HasUnreadCountBadge ||
                    (this.HasUnreadCountBadge != null &&
                    this.HasUnreadCountBadge.Equals(input.HasUnreadCountBadge))
                ) && 
                (
                    this.ContentAvailable == input.ContentAvailable ||
                    (this.ContentAvailable != null &&
                    this.ContentAvailable.Equals(input.ContentAvailable))
                ) && 
                (
                    this.MutableContent == input.MutableContent ||
                    (this.MutableContent != null &&
                    this.MutableContent.Equals(input.MutableContent))
                ) && 
                (
                    this.PushSound == input.PushSound ||
                    (this.PushSound != null &&
                    this.PushSound.Equals(input.PushSound))
                ) && 
                (
                    this.ApnsType == input.ApnsType ||
                    (this.ApnsType != null &&
                    this.ApnsType.Equals(input.ApnsType))
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
                if (this.ProviderId != null)
                    hashCode = hashCode * 59 + this.ProviderId.GetHashCode();
                if (this.ApnsCert != null)
                    hashCode = hashCode * 59 + this.ApnsCert.GetHashCode();
                if (this.ApnsCertEnvType != null)
                    hashCode = hashCode * 59 + this.ApnsCertEnvType.GetHashCode();
                if (this.ApnsCertPassword != null)
                    hashCode = hashCode * 59 + this.ApnsCertPassword.GetHashCode();
                if (this.HasUnreadCountBadge != null)
                    hashCode = hashCode * 59 + this.HasUnreadCountBadge.GetHashCode();
                if (this.ContentAvailable != null)
                    hashCode = hashCode * 59 + this.ContentAvailable.GetHashCode();
                if (this.MutableContent != null)
                    hashCode = hashCode * 59 + this.MutableContent.GetHashCode();
                if (this.PushSound != null)
                    hashCode = hashCode * 59 + this.PushSound.GetHashCode();
                if (this.ApnsType != null)
                    hashCode = hashCode * 59 + this.ApnsType.GetHashCode();
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
