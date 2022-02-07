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
import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

/**
 * OcUpdateChannelByUrlData
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2022-02-07T15:17:22.820442Z[Europe/London]")
public class OcUpdateChannelByUrlData {
  public static final String SERIALIZED_NAME_CHANNEL_URL = "channel_url";
  @SerializedName(SERIALIZED_NAME_CHANNEL_URL)
  private String channelUrl;

  public static final String SERIALIZED_NAME_NAME = "name";
  @SerializedName(SERIALIZED_NAME_NAME)
  private String name;

  public static final String SERIALIZED_NAME_COVER_URL = "cover_url";
  @SerializedName(SERIALIZED_NAME_COVER_URL)
  private String coverUrl;

  public static final String SERIALIZED_NAME_COVER_FILE = "cover_file";
  @SerializedName(SERIALIZED_NAME_COVER_FILE)
  private File coverFile;

  public static final String SERIALIZED_NAME_CUSTOM_TYPE = "custom_type";
  @SerializedName(SERIALIZED_NAME_CUSTOM_TYPE)
  private String customType;

  public static final String SERIALIZED_NAME_DATA = "data";
  @SerializedName(SERIALIZED_NAME_DATA)
  private String data;

  public static final String SERIALIZED_NAME_OPERATOR_IDS = "operator_ids";
  @SerializedName(SERIALIZED_NAME_OPERATOR_IDS)
  private List<Integer> operatorIds = new ArrayList<Integer>();

  public static final String SERIALIZED_NAME_OPERATORS = "operators";
  @SerializedName(SERIALIZED_NAME_OPERATORS)
  private List<String> operators = new ArrayList<String>();

  public OcUpdateChannelByUrlData() { 
  }

  public OcUpdateChannelByUrlData channelUrl(String channelUrl) {
    
    this.channelUrl = channelUrl;
    return this;
  }

   /**
   * Specifies the URL of the channel to update.
   * @return channelUrl
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "Specifies the URL of the channel to update.")

  public String getChannelUrl() {
    return channelUrl;
  }


  public void setChannelUrl(String channelUrl) {
    this.channelUrl = channelUrl;
  }


  public OcUpdateChannelByUrlData name(String name) {
    
    this.name = name;
    return this;
  }

   /**
   * Specifies the channel topic, or the name of the channel. The length is limited to 191 characters.
   * @return name
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "Specifies the channel topic, or the name of the channel. The length is limited to 191 characters.")

  public String getName() {
    return name;
  }


  public void setName(String name) {
    this.name = name;
  }


  public OcUpdateChannelByUrlData coverUrl(String coverUrl) {
    
    this.coverUrl = coverUrl;
    return this;
  }

   /**
   * Specifies the URL of the cover image. The length is limited to 2,048 characters.
   * @return coverUrl
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "Specifies the URL of the cover image. The length is limited to 2,048 characters.")

  public String getCoverUrl() {
    return coverUrl;
  }


  public void setCoverUrl(String coverUrl) {
    this.coverUrl = coverUrl;
  }


  public OcUpdateChannelByUrlData coverFile(File coverFile) {
    
    this.coverFile = coverFile;
    return this;
  }

   /**
   * Uploads the file for the channel cover image.
   * @return coverFile
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "Uploads the file for the channel cover image.")

  public File getCoverFile() {
    return coverFile;
  }


  public void setCoverFile(File coverFile) {
    this.coverFile = coverFile;
  }


  public OcUpdateChannelByUrlData customType(String customType) {
    
    this.customType = customType;
    return this;
  }

   /**
   * Specifies the custom channel type which is used for channel grouping. The length is limited to 128 characters.&lt;br /&gt;&lt;br /&gt; Custom types are also used within Sendbird&#39;s [Advanced analytics](/docs/chat/v3/platform-api/guides/advanced-analytics) to segment metrics, which enables the sub-classification of data views.
   * @return customType
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "Specifies the custom channel type which is used for channel grouping. The length is limited to 128 characters.<br /><br /> Custom types are also used within Sendbird's [Advanced analytics](/docs/chat/v3/platform-api/guides/advanced-analytics) to segment metrics, which enables the sub-classification of data views.")

  public String getCustomType() {
    return customType;
  }


  public void setCustomType(String customType) {
    this.customType = customType;
  }


  public OcUpdateChannelByUrlData data(String data) {
    
    this.data = data;
    return this;
  }

   /**
   * Specifies additional channel information such as a long description of the channel or &#x60;JSON&#x60; formatted string.
   * @return data
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "Specifies additional channel information such as a long description of the channel or `JSON` formatted string.")

  public String getData() {
    return data;
  }


  public void setData(String data) {
    this.data = data;
  }


  public OcUpdateChannelByUrlData operatorIds(List<Integer> operatorIds) {
    
    this.operatorIds = operatorIds;
    return this;
  }

  public OcUpdateChannelByUrlData addOperatorIdsItem(Integer operatorIdsItem) {
    this.operatorIds.add(operatorIdsItem);
    return this;
  }

   /**
   * Specifies an array of one or more user IDs to register as operators of the channel. The maximum allowed number of operators per channel is 100. Operators can delete any messages in the channel, and can also receive all messages that have been throttled.&lt;br/&gt;&lt;br/&gt;  Operators cannot view messages that have been [moderated by](/docs/chat/v3/platform-api/guides/filter-and-moderation) the domain filter or profanity filter. Only the sender will be notified that the message has been blocked.
   * @return operatorIds
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "Specifies an array of one or more user IDs to register as operators of the channel. The maximum allowed number of operators per channel is 100. Operators can delete any messages in the channel, and can also receive all messages that have been throttled.<br/><br/>  Operators cannot view messages that have been [moderated by](/docs/chat/v3/platform-api/guides/filter-and-moderation) the domain filter or profanity filter. Only the sender will be notified that the message has been blocked.")

  public List<Integer> getOperatorIds() {
    return operatorIds;
  }


  public void setOperatorIds(List<Integer> operatorIds) {
    this.operatorIds = operatorIds;
  }


  public OcUpdateChannelByUrlData operators(List<String> operators) {
    
    this.operators = operators;
    return this;
  }

  public OcUpdateChannelByUrlData addOperatorsItem(String operatorsItem) {
    this.operators.add(operatorsItem);
    return this;
  }

   /**
   * (Deprecated) Specifies the string IDs of the users registered as channel operators. Operators can delete any messages in the channel, and can also receive all messages that have been throttled.
   * @return operators
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "(Deprecated) Specifies the string IDs of the users registered as channel operators. Operators can delete any messages in the channel, and can also receive all messages that have been throttled.")

  public List<String> getOperators() {
    return operators;
  }


  public void setOperators(List<String> operators) {
    this.operators = operators;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    OcUpdateChannelByUrlData ocUpdateChannelByUrlData = (OcUpdateChannelByUrlData) o;
    return Objects.equals(this.channelUrl, ocUpdateChannelByUrlData.channelUrl) &&
        Objects.equals(this.name, ocUpdateChannelByUrlData.name) &&
        Objects.equals(this.coverUrl, ocUpdateChannelByUrlData.coverUrl) &&
        Objects.equals(this.coverFile, ocUpdateChannelByUrlData.coverFile) &&
        Objects.equals(this.customType, ocUpdateChannelByUrlData.customType) &&
        Objects.equals(this.data, ocUpdateChannelByUrlData.data) &&
        Objects.equals(this.operatorIds, ocUpdateChannelByUrlData.operatorIds) &&
        Objects.equals(this.operators, ocUpdateChannelByUrlData.operators);
  }

  @Override
  public int hashCode() {
    return Objects.hash(channelUrl, name, coverUrl, coverFile, customType, data, operatorIds, operators);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class OcUpdateChannelByUrlData {\n");
    sb.append("    channelUrl: ").append(toIndentedString(channelUrl)).append("\n");
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    coverUrl: ").append(toIndentedString(coverUrl)).append("\n");
    sb.append("    coverFile: ").append(toIndentedString(coverFile)).append("\n");
    sb.append("    customType: ").append(toIndentedString(customType)).append("\n");
    sb.append("    data: ").append(toIndentedString(data)).append("\n");
    sb.append("    operatorIds: ").append(toIndentedString(operatorIds)).append("\n");
    sb.append("    operators: ").append(toIndentedString(operators)).append("\n");
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

