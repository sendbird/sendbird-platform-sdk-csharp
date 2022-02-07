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
 * UpdateCountPreferenceOfChannelByUrlData
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2022-02-07T15:17:22.820442Z[Europe/London]")
public class UpdateCountPreferenceOfChannelByUrlData {
  public static final String SERIALIZED_NAME_COUNT_PREFERENCE = "count_preference";
  @SerializedName(SERIALIZED_NAME_COUNT_PREFERENCE)
  private String countPreference;

  public UpdateCountPreferenceOfChannelByUrlData() { 
  }

  public UpdateCountPreferenceOfChannelByUrlData countPreference(String countPreference) {
    
    this.countPreference = countPreference;
    return this;
  }

   /**
   * Determines whether to only count the number of unread messages or the number of unread mentioned messages in the specified group channel. Only the one that is chosen to be preferenced will be counted and added to the total number count after the action. A value of off indicates that both read statuses will not be counted, while all indicates that both read statuses will be counted by the system. A value of unread_message_count_only indicates that only the user&#39;s unread messages will be counted in the channel while unread_mentioned_count_only indicates that only the user&#39;s unread mentioned messages will be counted. (Default: all)
   * @return countPreference
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "Determines whether to only count the number of unread messages or the number of unread mentioned messages in the specified group channel. Only the one that is chosen to be preferenced will be counted and added to the total number count after the action. A value of off indicates that both read statuses will not be counted, while all indicates that both read statuses will be counted by the system. A value of unread_message_count_only indicates that only the user's unread messages will be counted in the channel while unread_mentioned_count_only indicates that only the user's unread mentioned messages will be counted. (Default: all)")

  public String getCountPreference() {
    return countPreference;
  }


  public void setCountPreference(String countPreference) {
    this.countPreference = countPreference;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    UpdateCountPreferenceOfChannelByUrlData updateCountPreferenceOfChannelByUrlData = (UpdateCountPreferenceOfChannelByUrlData) o;
    return Objects.equals(this.countPreference, updateCountPreferenceOfChannelByUrlData.countPreference);
  }

  @Override
  public int hashCode() {
    return Objects.hash(countPreference);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class UpdateCountPreferenceOfChannelByUrlData {\n");
    sb.append("    countPreference: ").append(toIndentedString(countPreference)).append("\n");
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

