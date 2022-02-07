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
import org.openapitools.client.model.InlineResponse20039Announcements;

/**
 * InlineResponse20039
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2022-02-07T15:17:22.820442Z[Europe/London]")
public class InlineResponse20039 {
  public static final String SERIALIZED_NAME_ANNOUNCEMENTS = "announcements";
  @SerializedName(SERIALIZED_NAME_ANNOUNCEMENTS)
  private List<InlineResponse20039Announcements> announcements = null;

  public static final String SERIALIZED_NAME_NEXT = "next";
  @SerializedName(SERIALIZED_NAME_NEXT)
  private String next;

  public InlineResponse20039() { 
  }

  public InlineResponse20039 announcements(List<InlineResponse20039Announcements> announcements) {
    
    this.announcements = announcements;
    return this;
  }

  public InlineResponse20039 addAnnouncementsItem(InlineResponse20039Announcements announcementsItem) {
    if (this.announcements == null) {
      this.announcements = new ArrayList<InlineResponse20039Announcements>();
    }
    this.announcements.add(announcementsItem);
    return this;
  }

   /**
   * Get announcements
   * @return announcements
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<InlineResponse20039Announcements> getAnnouncements() {
    return announcements;
  }


  public void setAnnouncements(List<InlineResponse20039Announcements> announcements) {
    this.announcements = announcements;
  }


  public InlineResponse20039 next(String next) {
    
    this.next = next;
    return this;
  }

   /**
   * Get next
   * @return next
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getNext() {
    return next;
  }


  public void setNext(String next) {
    this.next = next;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    InlineResponse20039 inlineResponse20039 = (InlineResponse20039) o;
    return Objects.equals(this.announcements, inlineResponse20039.announcements) &&
        Objects.equals(this.next, inlineResponse20039.next);
  }

  @Override
  public int hashCode() {
    return Objects.hash(announcements, next);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class InlineResponse20039 {\n");
    sb.append("    announcements: ").append(toIndentedString(announcements)).append("\n");
    sb.append("    next: ").append(toIndentedString(next)).append("\n");
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

