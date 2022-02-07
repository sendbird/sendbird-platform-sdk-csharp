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

/**
 * SendMessageData
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2022-02-07T15:17:22.820442Z[Europe/London]")
public class SendMessageData {
  public static final String SERIALIZED_NAME_USER_ID = "user_id";
  @SerializedName(SERIALIZED_NAME_USER_ID)
  private String userId;

  public static final String SERIALIZED_NAME_CHANNEL_TYPE = "channel_type";
  @SerializedName(SERIALIZED_NAME_CHANNEL_TYPE)
  private String channelType;

  public static final String SERIALIZED_NAME_CHANNEL_URL = "channel_url";
  @SerializedName(SERIALIZED_NAME_CHANNEL_URL)
  private String channelUrl;

  public static final String SERIALIZED_NAME_MESSAGE_TYPE = "message_type";
  @SerializedName(SERIALIZED_NAME_MESSAGE_TYPE)
  private String messageType;

  public static final String SERIALIZED_NAME_MESSAGE = "message";
  @SerializedName(SERIALIZED_NAME_MESSAGE)
  private String message;

  public static final String SERIALIZED_NAME_CUSTOM_TYPE = "custom_type";
  @SerializedName(SERIALIZED_NAME_CUSTOM_TYPE)
  private String customType;

  public static final String SERIALIZED_NAME_DATA = "data";
  @SerializedName(SERIALIZED_NAME_DATA)
  private String data;

  public static final String SERIALIZED_NAME_SEND_PUSH = "send_push";
  @SerializedName(SERIALIZED_NAME_SEND_PUSH)
  private Boolean sendPush;

  public static final String SERIALIZED_NAME_MENTION_TYPE = "mention_type";
  @SerializedName(SERIALIZED_NAME_MENTION_TYPE)
  private String mentionType;

  public static final String SERIALIZED_NAME_MENTIONED_USER_IDS = "mentioned_user_ids";
  @SerializedName(SERIALIZED_NAME_MENTIONED_USER_IDS)
  private List<String> mentionedUserIds = null;

  public static final String SERIALIZED_NAME_IS_SILENT = "is_silent";
  @SerializedName(SERIALIZED_NAME_IS_SILENT)
  private Boolean isSilent;

  public static final String SERIALIZED_NAME_SORTED_METAARRAY = "sorted_metaarray";
  @SerializedName(SERIALIZED_NAME_SORTED_METAARRAY)
  private String sortedMetaarray;

  public static final String SERIALIZED_NAME_CREATED_AT = "created_at";
  @SerializedName(SERIALIZED_NAME_CREATED_AT)
  private Integer createdAt;

  public static final String SERIALIZED_NAME_DEDUP_ID = "dedup_id";
  @SerializedName(SERIALIZED_NAME_DEDUP_ID)
  private String dedupId;

  public static final String SERIALIZED_NAME_APNS_BUNDLE_ID = "apns_bundle_id";
  @SerializedName(SERIALIZED_NAME_APNS_BUNDLE_ID)
  private String apnsBundleId;

  public static final String SERIALIZED_NAME_SOUND = "sound";
  @SerializedName(SERIALIZED_NAME_SOUND)
  private String sound;

  public static final String SERIALIZED_NAME_VOLUME = "volume";
  @SerializedName(SERIALIZED_NAME_VOLUME)
  private BigDecimal volume;

  public SendMessageData() { 
  }

  public SendMessageData userId(String userId) {
    
    this.userId = userId;
    return this;
  }

   /**
   * Specifies the user ID of the sender.
   * @return userId
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "Specifies the user ID of the sender.")

  public String getUserId() {
    return userId;
  }


  public void setUserId(String userId) {
    this.userId = userId;
  }


  public SendMessageData channelType(String channelType) {
    
    this.channelType = channelType;
    return this;
  }

   /**
   * Specifies the type of the channel. Either open_channels or group_channels.
   * @return channelType
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Specifies the type of the channel. Either open_channels or group_channels.")

  public String getChannelType() {
    return channelType;
  }


  public void setChannelType(String channelType) {
    this.channelType = channelType;
  }


  public SendMessageData channelUrl(String channelUrl) {
    
    this.channelUrl = channelUrl;
    return this;
  }

   /**
   * Specifies the URL of the channel to send a message to.
   * @return channelUrl
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Specifies the URL of the channel to send a message to.")

  public String getChannelUrl() {
    return channelUrl;
  }


  public void setChannelUrl(String channelUrl) {
    this.channelUrl = channelUrl;
  }


  public SendMessageData messageType(String messageType) {
    
    this.messageType = messageType;
    return this;
  }

   /**
   * Specifies the type of the message as MESG, FILE or ADMM
   * @return messageType
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "Specifies the type of the message as MESG, FILE or ADMM")

  public String getMessageType() {
    return messageType;
  }


  public void setMessageType(String messageType) {
    this.messageType = messageType;
  }


  public SendMessageData message(String message) {
    
    this.message = message;
    return this;
  }

   /**
   * Specifies the content of the message.
   * @return message
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "Specifies the content of the message.")

  public String getMessage() {
    return message;
  }


  public void setMessage(String message) {
    this.message = message;
  }


  public SendMessageData customType(String customType) {
    
    this.customType = customType;
    return this;
  }

   /**
   * Specifies a custom message type which is used for message grouping. The length is limited to 128 characters.&lt;br /&gt;&lt;br /&gt; Custom types are also used within Sendbird&#39;s [Advanced analytics](/docs/chat/v3/platform-api/guides/advanced-analytics) to segment metrics, which enables the sub-classification of data views.
   * @return customType
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Specifies a custom message type which is used for message grouping. The length is limited to 128 characters.<br /><br /> Custom types are also used within Sendbird's [Advanced analytics](/docs/chat/v3/platform-api/guides/advanced-analytics) to segment metrics, which enables the sub-classification of data views.")

  public String getCustomType() {
    return customType;
  }


  public void setCustomType(String customType) {
    this.customType = customType;
  }


  public SendMessageData data(String data) {
    
    this.data = data;
    return this;
  }

   /**
   * Specifies additional message information such as custom font size, font type or &#x60;JSON&#x60; formatted string.
   * @return data
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Specifies additional message information such as custom font size, font type or `JSON` formatted string.")

  public String getData() {
    return data;
  }


  public void setData(String data) {
    this.data = data;
  }


  public SendMessageData sendPush(Boolean sendPush) {
    
    this.sendPush = sendPush;
    return this;
  }

   /**
   * Determines whether to send a push notification for the message to the members of the channel (applicable to group channels only). Unlike text and file messages, a push notification for an admin message is not sent by default. (Default: true)
   * @return sendPush
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Determines whether to send a push notification for the message to the members of the channel (applicable to group channels only). Unlike text and file messages, a push notification for an admin message is not sent by default. (Default: true)")

  public Boolean getSendPush() {
    return sendPush;
  }


  public void setSendPush(Boolean sendPush) {
    this.sendPush = sendPush;
  }


  public SendMessageData mentionType(String mentionType) {
    
    this.mentionType = mentionType;
    return this;
  }

   /**
   * Specifies the mentioning type which indicates the user scope who will get a notification for the message. Acceptable values are users and channel. If set to users, only the specified users with the mentioned_users property below will get notified. If set to channel, all users in the channel will get notified. (Default: users)
   * @return mentionType
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Specifies the mentioning type which indicates the user scope who will get a notification for the message. Acceptable values are users and channel. If set to users, only the specified users with the mentioned_users property below will get notified. If set to channel, all users in the channel will get notified. (Default: users)")

  public String getMentionType() {
    return mentionType;
  }


  public void setMentionType(String mentionType) {
    this.mentionType = mentionType;
  }


  public SendMessageData mentionedUserIds(List<String> mentionedUserIds) {
    
    this.mentionedUserIds = mentionedUserIds;
    return this;
  }

  public SendMessageData addMentionedUserIdsItem(String mentionedUserIdsItem) {
    if (this.mentionedUserIds == null) {
      this.mentionedUserIds = new ArrayList<String>();
    }
    this.mentionedUserIds.add(mentionedUserIdsItem);
    return this;
  }

   /**
   * Specifies an array of one or more IDs of the users who will get a notification for the message.
   * @return mentionedUserIds
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Specifies an array of one or more IDs of the users who will get a notification for the message.")

  public List<String> getMentionedUserIds() {
    return mentionedUserIds;
  }


  public void setMentionedUserIds(List<String> mentionedUserIds) {
    this.mentionedUserIds = mentionedUserIds;
  }


  public SendMessageData isSilent(Boolean isSilent) {
    
    this.isSilent = isSilent;
    return this;
  }

   /**
   * Determines whether to send a message without updating some of the channel properties. If a message is sent in a channel, with this property set to true, the channel&#39;s last_message is updated only for the sender while its unread_message_count remains unchanged for all channel members. Also, the message doesn&#39;t send a push notification to message receivers. If the message is sent to a hidden channel, the channel still remains hidden. (Default: false)&lt;/br&gt;&lt;/br&gt;  Once the value of this property is set, it can&#39;t be reverted.
   * @return isSilent
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Determines whether to send a message without updating some of the channel properties. If a message is sent in a channel, with this property set to true, the channel's last_message is updated only for the sender while its unread_message_count remains unchanged for all channel members. Also, the message doesn't send a push notification to message receivers. If the message is sent to a hidden channel, the channel still remains hidden. (Default: false)</br></br>  Once the value of this property is set, it can't be reverted.")

  public Boolean getIsSilent() {
    return isSilent;
  }


  public void setIsSilent(Boolean isSilent) {
    this.isSilent = isSilent;
  }


  public SendMessageData sortedMetaarray(String sortedMetaarray) {
    
    this.sortedMetaarray = sortedMetaarray;
    return this;
  }

   /**
   * Specifies a &#x60;JSON&#x60; object of one or more key-values items which store additional message information. Each item consists of a key and the values in an array. Items are saved and will be returned in the exact order they&#39;ve been specified.
   * @return sortedMetaarray
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Specifies a `JSON` object of one or more key-values items which store additional message information. Each item consists of a key and the values in an array. Items are saved and will be returned in the exact order they've been specified.")

  public String getSortedMetaarray() {
    return sortedMetaarray;
  }


  public void setSortedMetaarray(String sortedMetaarray) {
    this.sortedMetaarray = sortedMetaarray;
  }


  public SendMessageData createdAt(Integer createdAt) {
    
    this.createdAt = createdAt;
    return this;
  }

   /**
   * Specifies the time that the message was sent, in [Unix milliseconds](/docs/chat/v3/platform-api/guides/miscellaneous#2-timestamps) format. This property can be used when migrating the messages of other system to Sendbird server. If specified, the server sets the message&#39;s creation time as the property value.
   * @return createdAt
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Specifies the time that the message was sent, in [Unix milliseconds](/docs/chat/v3/platform-api/guides/miscellaneous#2-timestamps) format. This property can be used when migrating the messages of other system to Sendbird server. If specified, the server sets the message's creation time as the property value.")

  public Integer getCreatedAt() {
    return createdAt;
  }


  public void setCreatedAt(Integer createdAt) {
    this.createdAt = createdAt;
  }


  public SendMessageData dedupId(String dedupId) {
    
    this.dedupId = dedupId;
    return this;
  }

   /**
   * Specifies the unique message ID created by other system. In general, this property is used to prevent the same message data from getting inserted when migrating the messages of the other system to Sendbird server. If specified, the server performs a duplicate check using the property value.
   * @return dedupId
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Specifies the unique message ID created by other system. In general, this property is used to prevent the same message data from getting inserted when migrating the messages of the other system to Sendbird server. If specified, the server performs a duplicate check using the property value.")

  public String getDedupId() {
    return dedupId;
  }


  public void setDedupId(String dedupId) {
    this.dedupId = dedupId;
  }


  public SendMessageData apnsBundleId(String apnsBundleId) {
    
    this.apnsBundleId = apnsBundleId;
    return this;
  }

   /**
   * Specifies the bundle ID of the client app in order to send a push notification to iOS devices. You can find this in Settings &gt; Chat &gt; Notifications &gt; Push notification services
   * @return apnsBundleId
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Specifies the bundle ID of the client app in order to send a push notification to iOS devices. You can find this in Settings > Chat > Notifications > Push notification services")

  public String getApnsBundleId() {
    return apnsBundleId;
  }


  public void setApnsBundleId(String apnsBundleId) {
    this.apnsBundleId = apnsBundleId;
  }


  public SendMessageData sound(String sound) {
    
    this.sound = sound;
    return this;
  }

   /**
   * Specifies the name of the file that sounds for critical alerts.
   * @return sound
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Specifies the name of the file that sounds for critical alerts.")

  public String getSound() {
    return sound;
  }


  public void setSound(String sound) {
    this.sound = sound;
  }


  public SendMessageData volume(BigDecimal volume) {
    
    this.volume = volume;
    return this;
  }

   /**
   * Specifies the volume of the critical alert sound. The volume ranges from 0.0 to 1.0, which indicates silent and full volume, respectively. (Default 1.0)
   * @return volume
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Specifies the volume of the critical alert sound. The volume ranges from 0.0 to 1.0, which indicates silent and full volume, respectively. (Default 1.0)")

  public BigDecimal getVolume() {
    return volume;
  }


  public void setVolume(BigDecimal volume) {
    this.volume = volume;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SendMessageData sendMessageData = (SendMessageData) o;
    return Objects.equals(this.userId, sendMessageData.userId) &&
        Objects.equals(this.channelType, sendMessageData.channelType) &&
        Objects.equals(this.channelUrl, sendMessageData.channelUrl) &&
        Objects.equals(this.messageType, sendMessageData.messageType) &&
        Objects.equals(this.message, sendMessageData.message) &&
        Objects.equals(this.customType, sendMessageData.customType) &&
        Objects.equals(this.data, sendMessageData.data) &&
        Objects.equals(this.sendPush, sendMessageData.sendPush) &&
        Objects.equals(this.mentionType, sendMessageData.mentionType) &&
        Objects.equals(this.mentionedUserIds, sendMessageData.mentionedUserIds) &&
        Objects.equals(this.isSilent, sendMessageData.isSilent) &&
        Objects.equals(this.sortedMetaarray, sendMessageData.sortedMetaarray) &&
        Objects.equals(this.createdAt, sendMessageData.createdAt) &&
        Objects.equals(this.dedupId, sendMessageData.dedupId) &&
        Objects.equals(this.apnsBundleId, sendMessageData.apnsBundleId) &&
        Objects.equals(this.sound, sendMessageData.sound) &&
        Objects.equals(this.volume, sendMessageData.volume);
  }

  @Override
  public int hashCode() {
    return Objects.hash(userId, channelType, channelUrl, messageType, message, customType, data, sendPush, mentionType, mentionedUserIds, isSilent, sortedMetaarray, createdAt, dedupId, apnsBundleId, sound, volume);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SendMessageData {\n");
    sb.append("    userId: ").append(toIndentedString(userId)).append("\n");
    sb.append("    channelType: ").append(toIndentedString(channelType)).append("\n");
    sb.append("    channelUrl: ").append(toIndentedString(channelUrl)).append("\n");
    sb.append("    messageType: ").append(toIndentedString(messageType)).append("\n");
    sb.append("    message: ").append(toIndentedString(message)).append("\n");
    sb.append("    customType: ").append(toIndentedString(customType)).append("\n");
    sb.append("    data: ").append(toIndentedString(data)).append("\n");
    sb.append("    sendPush: ").append(toIndentedString(sendPush)).append("\n");
    sb.append("    mentionType: ").append(toIndentedString(mentionType)).append("\n");
    sb.append("    mentionedUserIds: ").append(toIndentedString(mentionedUserIds)).append("\n");
    sb.append("    isSilent: ").append(toIndentedString(isSilent)).append("\n");
    sb.append("    sortedMetaarray: ").append(toIndentedString(sortedMetaarray)).append("\n");
    sb.append("    createdAt: ").append(toIndentedString(createdAt)).append("\n");
    sb.append("    dedupId: ").append(toIndentedString(dedupId)).append("\n");
    sb.append("    apnsBundleId: ").append(toIndentedString(apnsBundleId)).append("\n");
    sb.append("    sound: ").append(toIndentedString(sound)).append("\n");
    sb.append("    volume: ").append(toIndentedString(volume)).append("\n");
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

