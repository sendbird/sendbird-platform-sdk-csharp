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
 * AddEmojisData
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2022-02-07T15:17:22.820442Z[Europe/London]")
public class AddEmojisData {
  public static final String SERIALIZED_NAME_EMOJI_CATEGORY_ID = "emoji_category_id";
  @SerializedName(SERIALIZED_NAME_EMOJI_CATEGORY_ID)
  private Integer emojiCategoryId;

  public static final String SERIALIZED_NAME_EMOJIS = "emojis";
  @SerializedName(SERIALIZED_NAME_EMOJIS)
  private List<String> emojis = new ArrayList<String>();

  public AddEmojisData() { 
  }

  public AddEmojisData emojiCategoryId(Integer emojiCategoryId) {
    
    this.emojiCategoryId = emojiCategoryId;
    return this;
  }

   /**
   * Specifies the unique ID of the emoji category that a list of new emojis belong to.
   * @return emojiCategoryId
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "Specifies the unique ID of the emoji category that a list of new emojis belong to.")

  public Integer getEmojiCategoryId() {
    return emojiCategoryId;
  }


  public void setEmojiCategoryId(Integer emojiCategoryId) {
    this.emojiCategoryId = emojiCategoryId;
  }


  public AddEmojisData emojis(List<String> emojis) {
    
    this.emojis = emojis;
    return this;
  }

  public AddEmojisData addEmojisItem(String emojisItem) {
    this.emojis.add(emojisItem);
    return this;
  }

   /**
   * Specifies a list of one or more new emojis to register.
   * @return emojis
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "Specifies a list of one or more new emojis to register.")

  public List<String> getEmojis() {
    return emojis;
  }


  public void setEmojis(List<String> emojis) {
    this.emojis = emojis;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    AddEmojisData addEmojisData = (AddEmojisData) o;
    return Objects.equals(this.emojiCategoryId, addEmojisData.emojiCategoryId) &&
        Objects.equals(this.emojis, addEmojisData.emojis);
  }

  @Override
  public int hashCode() {
    return Objects.hash(emojiCategoryId, emojis);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class AddEmojisData {\n");
    sb.append("    emojiCategoryId: ").append(toIndentedString(emojiCategoryId)).append("\n");
    sb.append("    emojis: ").append(toIndentedString(emojis)).append("\n");
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

