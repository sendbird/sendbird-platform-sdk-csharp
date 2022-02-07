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
import java.util.ArrayList;
import java.util.List;

/**
 * MuteInChannelsWithCustomChannelTypesData
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2022-02-07T15:17:22.820442Z[Europe/London]")
public class MuteInChannelsWithCustomChannelTypesData {
  public static final String SERIALIZED_NAME_CHANNEL_CUSTOM_TYPES = "channel_custom_types";
  @SerializedName(SERIALIZED_NAME_CHANNEL_CUSTOM_TYPES)
  private List<String> channelCustomTypes = new ArrayList<String>();

  public MuteInChannelsWithCustomChannelTypesData() { 
  }

  public MuteInChannelsWithCustomChannelTypesData channelCustomTypes(List<String> channelCustomTypes) {
    
    this.channelCustomTypes = channelCustomTypes;
    return this;
  }

  public MuteInChannelsWithCustomChannelTypesData addChannelCustomTypesItem(String channelCustomTypesItem) {
    this.channelCustomTypes.add(channelCustomTypesItem);
    return this;
  }

   /**
   * Specifies an array of one or more custom channel types, in order to mute the user in channels with the channel types. The user is permanently muted unless unmuted (10 years, technically).
   * @return channelCustomTypes
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "Specifies an array of one or more custom channel types, in order to mute the user in channels with the channel types. The user is permanently muted unless unmuted (10 years, technically).")

  public List<String> getChannelCustomTypes() {
    return channelCustomTypes;
  }


  public void setChannelCustomTypes(List<String> channelCustomTypes) {
    this.channelCustomTypes = channelCustomTypes;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    MuteInChannelsWithCustomChannelTypesData muteInChannelsWithCustomChannelTypesData = (MuteInChannelsWithCustomChannelTypesData) o;
    return Objects.equals(this.channelCustomTypes, muteInChannelsWithCustomChannelTypesData.channelCustomTypes);
  }

  @Override
  public int hashCode() {
    return Objects.hash(channelCustomTypes);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class MuteInChannelsWithCustomChannelTypesData {\n");
    sb.append("    channelCustomTypes: ").append(toIndentedString(channelCustomTypes)).append("\n");
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

