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

/**
 * GcUpdateBanByIdData
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2022-02-07T15:17:22.820442Z[Europe/London]")
public class GcUpdateBanByIdData {
  public static final String SERIALIZED_NAME_CHANNEL_URL = "channel_url";
  @SerializedName(SERIALIZED_NAME_CHANNEL_URL)
  private String channelUrl;

  public static final String SERIALIZED_NAME_BANNED_USER_ID = "banned_user_id";
  @SerializedName(SERIALIZED_NAME_BANNED_USER_ID)
  private String bannedUserId;

  public static final String SERIALIZED_NAME_SECONDS = "seconds";
  @SerializedName(SERIALIZED_NAME_SECONDS)
  private Integer seconds;

  public static final String SERIALIZED_NAME_DESCRIPTION = "description";
  @SerializedName(SERIALIZED_NAME_DESCRIPTION)
  private String description;

  public GcUpdateBanByIdData() { 
  }

  public GcUpdateBanByIdData channelUrl(String channelUrl) {
    
    this.channelUrl = channelUrl;
    return this;
  }

   /**
   * Specifies the URL of the target channel.
   * @return channelUrl
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "Specifies the URL of the target channel.")

  public String getChannelUrl() {
    return channelUrl;
  }


  public void setChannelUrl(String channelUrl) {
    this.channelUrl = channelUrl;
  }


  public GcUpdateBanByIdData bannedUserId(String bannedUserId) {
    
    this.bannedUserId = bannedUserId;
    return this;
  }

   /**
   * Specifies the ID of the banned user to update.
   * @return bannedUserId
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "Specifies the ID of the banned user to update.")

  public String getBannedUserId() {
    return bannedUserId;
  }


  public void setBannedUserId(String bannedUserId) {
    this.bannedUserId = bannedUserId;
  }


  public GcUpdateBanByIdData seconds(Integer seconds) {
    
    this.seconds = seconds;
    return this;
  }

   /**
   * Specifies a new ban duration to update. If set to -1, the user will be banned permanently (10 years, technically).
   * @return seconds
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "Specifies a new ban duration to update. If set to -1, the user will be banned permanently (10 years, technically).")

  public Integer getSeconds() {
    return seconds;
  }


  public void setSeconds(Integer seconds) {
    this.seconds = seconds;
  }


  public GcUpdateBanByIdData description(String description) {
    
    this.description = description;
    return this;
  }

   /**
   * Specifies a new reason for the banning to update. The length is limited to 250 characters.
   * @return description
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "Specifies a new reason for the banning to update. The length is limited to 250 characters.")

  public String getDescription() {
    return description;
  }


  public void setDescription(String description) {
    this.description = description;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    GcUpdateBanByIdData gcUpdateBanByIdData = (GcUpdateBanByIdData) o;
    return Objects.equals(this.channelUrl, gcUpdateBanByIdData.channelUrl) &&
        Objects.equals(this.bannedUserId, gcUpdateBanByIdData.bannedUserId) &&
        Objects.equals(this.seconds, gcUpdateBanByIdData.seconds) &&
        Objects.equals(this.description, gcUpdateBanByIdData.description);
  }

  @Override
  public int hashCode() {
    return Objects.hash(channelUrl, bannedUserId, seconds, description);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class GcUpdateBanByIdData {\n");
    sb.append("    channelUrl: ").append(toIndentedString(channelUrl)).append("\n");
    sb.append("    bannedUserId: ").append(toIndentedString(bannedUserId)).append("\n");
    sb.append("    seconds: ").append(toIndentedString(seconds)).append("\n");
    sb.append("    description: ").append(toIndentedString(description)).append("\n");
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

