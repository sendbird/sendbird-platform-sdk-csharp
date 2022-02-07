/*
 * Sendbird Platform SDK
 * Sendbird Platform API Javascript SDK  https://sendbird.com/docs/chat/v3/platform-api/getting-started/prepare-to-use-api
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.List;
import org.openapitools.client.model.Blob;
import org.openapitools.client.model.SendBirdAppleCriticalAlertOptions;
import org.openapitools.client.model.SendBirdMessageMetaArray;
import org.openapitools.client.model.SendBirdThumbnailSize;
import org.openapitools.client.model.SendBirdUser;

/**
 * SendBirdFileMessageParams
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2022-02-07T15:17:22.820442Z[Europe/London]")
public class SendBirdFileMessageParams {
  public static final String SERIALIZED_NAME_APPLE_CRITICAL_ALERT_OPTIONS = "apple_critical_alert_options";
  @SerializedName(SERIALIZED_NAME_APPLE_CRITICAL_ALERT_OPTIONS)
  private SendBirdAppleCriticalAlertOptions appleCriticalAlertOptions;

  public static final String SERIALIZED_NAME_CUSTOM_TYPE = "custom_type";
  @SerializedName(SERIALIZED_NAME_CUSTOM_TYPE)
  private String customType;

  public static final String SERIALIZED_NAME_DATA = "data";
  @SerializedName(SERIALIZED_NAME_DATA)
  private String data;

  public static final String SERIALIZED_NAME_FILE = "file";
  @SerializedName(SERIALIZED_NAME_FILE)
  private Blob file;

  public static final String SERIALIZED_NAME_FILE_NAME = "file_name";
  @SerializedName(SERIALIZED_NAME_FILE_NAME)
  private String fileName;

  public static final String SERIALIZED_NAME_FILE_SIZE = "file_size";
  @SerializedName(SERIALIZED_NAME_FILE_SIZE)
  private BigDecimal fileSize;

  public static final String SERIALIZED_NAME_FILE_URL = "file_url";
  @SerializedName(SERIALIZED_NAME_FILE_URL)
  private String fileUrl;

  public static final String SERIALIZED_NAME_IS_REPLY_TO_CHANNEL = "is_reply_to_channel";
  @SerializedName(SERIALIZED_NAME_IS_REPLY_TO_CHANNEL)
  private Boolean isReplyToChannel;

  /**
   * Gets or Sets mentionType
   */
  @JsonAdapter(MentionTypeEnum.Adapter.class)
  public enum MentionTypeEnum {
    CHANNEL("channel"),
    
    USERS("users");

    private String value;

    MentionTypeEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static MentionTypeEnum fromValue(String value) {
      for (MentionTypeEnum b : MentionTypeEnum.values()) {
        if (b.value.equals(value)) {
          return b;
        }
      }
      throw new IllegalArgumentException("Unexpected value '" + value + "'");
    }

    public static class Adapter extends TypeAdapter<MentionTypeEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final MentionTypeEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public MentionTypeEnum read(final JsonReader jsonReader) throws IOException {
        String value =  jsonReader.nextString();
        return MentionTypeEnum.fromValue(value);
      }
    }
  }

  public static final String SERIALIZED_NAME_MENTION_TYPE = "mention_type";
  @SerializedName(SERIALIZED_NAME_MENTION_TYPE)
  private MentionTypeEnum mentionType;

  public static final String SERIALIZED_NAME_MENTIONED_USER_IDS = "mentioned_user_ids";
  @SerializedName(SERIALIZED_NAME_MENTIONED_USER_IDS)
  private List<String> mentionedUserIds = null;

  public static final String SERIALIZED_NAME_MENTIONED_USERS = "mentioned_users";
  @SerializedName(SERIALIZED_NAME_MENTIONED_USERS)
  private List<SendBirdUser> mentionedUsers = null;

  public static final String SERIALIZED_NAME_META_ARRAY_KEYS = "meta_array_keys";
  @SerializedName(SERIALIZED_NAME_META_ARRAY_KEYS)
  private List<String> metaArrayKeys = null;

  public static final String SERIALIZED_NAME_META_ARRAYS = "meta_arrays";
  @SerializedName(SERIALIZED_NAME_META_ARRAYS)
  private List<SendBirdMessageMetaArray> metaArrays = null;

  public static final String SERIALIZED_NAME_MIME_TYPE = "mime_type";
  @SerializedName(SERIALIZED_NAME_MIME_TYPE)
  private String mimeType;

  public static final String SERIALIZED_NAME_PARENT_MESSAGE_ID = "parent_message_id";
  @SerializedName(SERIALIZED_NAME_PARENT_MESSAGE_ID)
  private BigDecimal parentMessageId;

  /**
   * Gets or Sets pushNotificationDeliveryOption
   */
  @JsonAdapter(PushNotificationDeliveryOptionEnum.Adapter.class)
  public enum PushNotificationDeliveryOptionEnum {
    DEFAULT("default"),
    
    SUPPRESS("suppress");

    private String value;

    PushNotificationDeliveryOptionEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static PushNotificationDeliveryOptionEnum fromValue(String value) {
      for (PushNotificationDeliveryOptionEnum b : PushNotificationDeliveryOptionEnum.values()) {
        if (b.value.equals(value)) {
          return b;
        }
      }
      throw new IllegalArgumentException("Unexpected value '" + value + "'");
    }

    public static class Adapter extends TypeAdapter<PushNotificationDeliveryOptionEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final PushNotificationDeliveryOptionEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public PushNotificationDeliveryOptionEnum read(final JsonReader jsonReader) throws IOException {
        String value =  jsonReader.nextString();
        return PushNotificationDeliveryOptionEnum.fromValue(value);
      }
    }
  }

  public static final String SERIALIZED_NAME_PUSH_NOTIFICATION_DELIVERY_OPTION = "push_notification_delivery_option";
  @SerializedName(SERIALIZED_NAME_PUSH_NOTIFICATION_DELIVERY_OPTION)
  private PushNotificationDeliveryOptionEnum pushNotificationDeliveryOption;

  public static final String SERIALIZED_NAME_THUMBNAIL_SIZES = "thumbnail_sizes";
  @SerializedName(SERIALIZED_NAME_THUMBNAIL_SIZES)
  private List<SendBirdThumbnailSize> thumbnailSizes = null;

  public SendBirdFileMessageParams() { 
  }

  public SendBirdFileMessageParams appleCriticalAlertOptions(SendBirdAppleCriticalAlertOptions appleCriticalAlertOptions) {
    
    this.appleCriticalAlertOptions = appleCriticalAlertOptions;
    return this;
  }

   /**
   * Get appleCriticalAlertOptions
   * @return appleCriticalAlertOptions
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public SendBirdAppleCriticalAlertOptions getAppleCriticalAlertOptions() {
    return appleCriticalAlertOptions;
  }


  public void setAppleCriticalAlertOptions(SendBirdAppleCriticalAlertOptions appleCriticalAlertOptions) {
    this.appleCriticalAlertOptions = appleCriticalAlertOptions;
  }


  public SendBirdFileMessageParams customType(String customType) {
    
    this.customType = customType;
    return this;
  }

   /**
   * Get customType
   * @return customType
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getCustomType() {
    return customType;
  }


  public void setCustomType(String customType) {
    this.customType = customType;
  }


  public SendBirdFileMessageParams data(String data) {
    
    this.data = data;
    return this;
  }

   /**
   * Get data
   * @return data
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getData() {
    return data;
  }


  public void setData(String data) {
    this.data = data;
  }


  public SendBirdFileMessageParams file(Blob file) {
    
    this.file = file;
    return this;
  }

   /**
   * Get file
   * @return file
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Blob getFile() {
    return file;
  }


  public void setFile(Blob file) {
    this.file = file;
  }


  public SendBirdFileMessageParams fileName(String fileName) {
    
    this.fileName = fileName;
    return this;
  }

   /**
   * Get fileName
   * @return fileName
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getFileName() {
    return fileName;
  }


  public void setFileName(String fileName) {
    this.fileName = fileName;
  }


  public SendBirdFileMessageParams fileSize(BigDecimal fileSize) {
    
    this.fileSize = fileSize;
    return this;
  }

   /**
   * Get fileSize
   * @return fileSize
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public BigDecimal getFileSize() {
    return fileSize;
  }


  public void setFileSize(BigDecimal fileSize) {
    this.fileSize = fileSize;
  }


  public SendBirdFileMessageParams fileUrl(String fileUrl) {
    
    this.fileUrl = fileUrl;
    return this;
  }

   /**
   * Get fileUrl
   * @return fileUrl
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getFileUrl() {
    return fileUrl;
  }


  public void setFileUrl(String fileUrl) {
    this.fileUrl = fileUrl;
  }


  public SendBirdFileMessageParams isReplyToChannel(Boolean isReplyToChannel) {
    
    this.isReplyToChannel = isReplyToChannel;
    return this;
  }

   /**
   * Get isReplyToChannel
   * @return isReplyToChannel
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getIsReplyToChannel() {
    return isReplyToChannel;
  }


  public void setIsReplyToChannel(Boolean isReplyToChannel) {
    this.isReplyToChannel = isReplyToChannel;
  }


  public SendBirdFileMessageParams mentionType(MentionTypeEnum mentionType) {
    
    this.mentionType = mentionType;
    return this;
  }

   /**
   * Get mentionType
   * @return mentionType
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public MentionTypeEnum getMentionType() {
    return mentionType;
  }


  public void setMentionType(MentionTypeEnum mentionType) {
    this.mentionType = mentionType;
  }


  public SendBirdFileMessageParams mentionedUserIds(List<String> mentionedUserIds) {
    
    this.mentionedUserIds = mentionedUserIds;
    return this;
  }

  public SendBirdFileMessageParams addMentionedUserIdsItem(String mentionedUserIdsItem) {
    if (this.mentionedUserIds == null) {
      this.mentionedUserIds = new ArrayList<String>();
    }
    this.mentionedUserIds.add(mentionedUserIdsItem);
    return this;
  }

   /**
   * Get mentionedUserIds
   * @return mentionedUserIds
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<String> getMentionedUserIds() {
    return mentionedUserIds;
  }


  public void setMentionedUserIds(List<String> mentionedUserIds) {
    this.mentionedUserIds = mentionedUserIds;
  }


  public SendBirdFileMessageParams mentionedUsers(List<SendBirdUser> mentionedUsers) {
    
    this.mentionedUsers = mentionedUsers;
    return this;
  }

  public SendBirdFileMessageParams addMentionedUsersItem(SendBirdUser mentionedUsersItem) {
    if (this.mentionedUsers == null) {
      this.mentionedUsers = new ArrayList<SendBirdUser>();
    }
    this.mentionedUsers.add(mentionedUsersItem);
    return this;
  }

   /**
   * Get mentionedUsers
   * @return mentionedUsers
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<SendBirdUser> getMentionedUsers() {
    return mentionedUsers;
  }


  public void setMentionedUsers(List<SendBirdUser> mentionedUsers) {
    this.mentionedUsers = mentionedUsers;
  }


  public SendBirdFileMessageParams metaArrayKeys(List<String> metaArrayKeys) {
    
    this.metaArrayKeys = metaArrayKeys;
    return this;
  }

  public SendBirdFileMessageParams addMetaArrayKeysItem(String metaArrayKeysItem) {
    if (this.metaArrayKeys == null) {
      this.metaArrayKeys = new ArrayList<String>();
    }
    this.metaArrayKeys.add(metaArrayKeysItem);
    return this;
  }

   /**
   * Get metaArrayKeys
   * @return metaArrayKeys
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<String> getMetaArrayKeys() {
    return metaArrayKeys;
  }


  public void setMetaArrayKeys(List<String> metaArrayKeys) {
    this.metaArrayKeys = metaArrayKeys;
  }


  public SendBirdFileMessageParams metaArrays(List<SendBirdMessageMetaArray> metaArrays) {
    
    this.metaArrays = metaArrays;
    return this;
  }

  public SendBirdFileMessageParams addMetaArraysItem(SendBirdMessageMetaArray metaArraysItem) {
    if (this.metaArrays == null) {
      this.metaArrays = new ArrayList<SendBirdMessageMetaArray>();
    }
    this.metaArrays.add(metaArraysItem);
    return this;
  }

   /**
   * Get metaArrays
   * @return metaArrays
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<SendBirdMessageMetaArray> getMetaArrays() {
    return metaArrays;
  }


  public void setMetaArrays(List<SendBirdMessageMetaArray> metaArrays) {
    this.metaArrays = metaArrays;
  }


  public SendBirdFileMessageParams mimeType(String mimeType) {
    
    this.mimeType = mimeType;
    return this;
  }

   /**
   * Get mimeType
   * @return mimeType
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getMimeType() {
    return mimeType;
  }


  public void setMimeType(String mimeType) {
    this.mimeType = mimeType;
  }


  public SendBirdFileMessageParams parentMessageId(BigDecimal parentMessageId) {
    
    this.parentMessageId = parentMessageId;
    return this;
  }

   /**
   * Get parentMessageId
   * @return parentMessageId
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public BigDecimal getParentMessageId() {
    return parentMessageId;
  }


  public void setParentMessageId(BigDecimal parentMessageId) {
    this.parentMessageId = parentMessageId;
  }


  public SendBirdFileMessageParams pushNotificationDeliveryOption(PushNotificationDeliveryOptionEnum pushNotificationDeliveryOption) {
    
    this.pushNotificationDeliveryOption = pushNotificationDeliveryOption;
    return this;
  }

   /**
   * Get pushNotificationDeliveryOption
   * @return pushNotificationDeliveryOption
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public PushNotificationDeliveryOptionEnum getPushNotificationDeliveryOption() {
    return pushNotificationDeliveryOption;
  }


  public void setPushNotificationDeliveryOption(PushNotificationDeliveryOptionEnum pushNotificationDeliveryOption) {
    this.pushNotificationDeliveryOption = pushNotificationDeliveryOption;
  }


  public SendBirdFileMessageParams thumbnailSizes(List<SendBirdThumbnailSize> thumbnailSizes) {
    
    this.thumbnailSizes = thumbnailSizes;
    return this;
  }

  public SendBirdFileMessageParams addThumbnailSizesItem(SendBirdThumbnailSize thumbnailSizesItem) {
    if (this.thumbnailSizes == null) {
      this.thumbnailSizes = new ArrayList<SendBirdThumbnailSize>();
    }
    this.thumbnailSizes.add(thumbnailSizesItem);
    return this;
  }

   /**
   * Get thumbnailSizes
   * @return thumbnailSizes
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<SendBirdThumbnailSize> getThumbnailSizes() {
    return thumbnailSizes;
  }


  public void setThumbnailSizes(List<SendBirdThumbnailSize> thumbnailSizes) {
    this.thumbnailSizes = thumbnailSizes;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SendBirdFileMessageParams sendBirdFileMessageParams = (SendBirdFileMessageParams) o;
    return Objects.equals(this.appleCriticalAlertOptions, sendBirdFileMessageParams.appleCriticalAlertOptions) &&
        Objects.equals(this.customType, sendBirdFileMessageParams.customType) &&
        Objects.equals(this.data, sendBirdFileMessageParams.data) &&
        Objects.equals(this.file, sendBirdFileMessageParams.file) &&
        Objects.equals(this.fileName, sendBirdFileMessageParams.fileName) &&
        Objects.equals(this.fileSize, sendBirdFileMessageParams.fileSize) &&
        Objects.equals(this.fileUrl, sendBirdFileMessageParams.fileUrl) &&
        Objects.equals(this.isReplyToChannel, sendBirdFileMessageParams.isReplyToChannel) &&
        Objects.equals(this.mentionType, sendBirdFileMessageParams.mentionType) &&
        Objects.equals(this.mentionedUserIds, sendBirdFileMessageParams.mentionedUserIds) &&
        Objects.equals(this.mentionedUsers, sendBirdFileMessageParams.mentionedUsers) &&
        Objects.equals(this.metaArrayKeys, sendBirdFileMessageParams.metaArrayKeys) &&
        Objects.equals(this.metaArrays, sendBirdFileMessageParams.metaArrays) &&
        Objects.equals(this.mimeType, sendBirdFileMessageParams.mimeType) &&
        Objects.equals(this.parentMessageId, sendBirdFileMessageParams.parentMessageId) &&
        Objects.equals(this.pushNotificationDeliveryOption, sendBirdFileMessageParams.pushNotificationDeliveryOption) &&
        Objects.equals(this.thumbnailSizes, sendBirdFileMessageParams.thumbnailSizes);
  }

  @Override
  public int hashCode() {
    return Objects.hash(appleCriticalAlertOptions, customType, data, file, fileName, fileSize, fileUrl, isReplyToChannel, mentionType, mentionedUserIds, mentionedUsers, metaArrayKeys, metaArrays, mimeType, parentMessageId, pushNotificationDeliveryOption, thumbnailSizes);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SendBirdFileMessageParams {\n");
    sb.append("    appleCriticalAlertOptions: ").append(toIndentedString(appleCriticalAlertOptions)).append("\n");
    sb.append("    customType: ").append(toIndentedString(customType)).append("\n");
    sb.append("    data: ").append(toIndentedString(data)).append("\n");
    sb.append("    file: ").append(toIndentedString(file)).append("\n");
    sb.append("    fileName: ").append(toIndentedString(fileName)).append("\n");
    sb.append("    fileSize: ").append(toIndentedString(fileSize)).append("\n");
    sb.append("    fileUrl: ").append(toIndentedString(fileUrl)).append("\n");
    sb.append("    isReplyToChannel: ").append(toIndentedString(isReplyToChannel)).append("\n");
    sb.append("    mentionType: ").append(toIndentedString(mentionType)).append("\n");
    sb.append("    mentionedUserIds: ").append(toIndentedString(mentionedUserIds)).append("\n");
    sb.append("    mentionedUsers: ").append(toIndentedString(mentionedUsers)).append("\n");
    sb.append("    metaArrayKeys: ").append(toIndentedString(metaArrayKeys)).append("\n");
    sb.append("    metaArrays: ").append(toIndentedString(metaArrays)).append("\n");
    sb.append("    mimeType: ").append(toIndentedString(mimeType)).append("\n");
    sb.append("    parentMessageId: ").append(toIndentedString(parentMessageId)).append("\n");
    sb.append("    pushNotificationDeliveryOption: ").append(toIndentedString(pushNotificationDeliveryOption)).append("\n");
    sb.append("    thumbnailSizes: ").append(toIndentedString(thumbnailSizes)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

