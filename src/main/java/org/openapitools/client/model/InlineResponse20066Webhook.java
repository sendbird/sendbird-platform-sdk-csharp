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
 * InlineResponse20066Webhook
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2022-02-07T15:17:22.820442Z[Europe/London]")
public class InlineResponse20066Webhook {
  public static final String SERIALIZED_NAME_ENABLED = "enabled";
  @SerializedName(SERIALIZED_NAME_ENABLED)
  private Boolean enabled;

  public static final String SERIALIZED_NAME_URL = "url";
  @SerializedName(SERIALIZED_NAME_URL)
  private String url;

  public static final String SERIALIZED_NAME_INCLUDE_MEMBERS = "include_members";
  @SerializedName(SERIALIZED_NAME_INCLUDE_MEMBERS)
  private Boolean includeMembers;

  public static final String SERIALIZED_NAME_ENABLED_EVENTS = "enabled_events";
  @SerializedName(SERIALIZED_NAME_ENABLED_EVENTS)
  private List<String> enabledEvents = null;

  public static final String SERIALIZED_NAME_ALL_WEBHOOK_CATEGORIES = "all_webhook_categories";
  @SerializedName(SERIALIZED_NAME_ALL_WEBHOOK_CATEGORIES)
  private List<String> allWebhookCategories = null;

  public InlineResponse20066Webhook() { 
  }

  public InlineResponse20066Webhook enabled(Boolean enabled) {
    
    this.enabled = enabled;
    return this;
  }

   /**
   * Get enabled
   * @return enabled
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getEnabled() {
    return enabled;
  }


  public void setEnabled(Boolean enabled) {
    this.enabled = enabled;
  }


  public InlineResponse20066Webhook url(String url) {
    
    this.url = url;
    return this;
  }

   /**
   * Get url
   * @return url
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getUrl() {
    return url;
  }


  public void setUrl(String url) {
    this.url = url;
  }


  public InlineResponse20066Webhook includeMembers(Boolean includeMembers) {
    
    this.includeMembers = includeMembers;
    return this;
  }

   /**
   * Get includeMembers
   * @return includeMembers
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getIncludeMembers() {
    return includeMembers;
  }


  public void setIncludeMembers(Boolean includeMembers) {
    this.includeMembers = includeMembers;
  }


  public InlineResponse20066Webhook enabledEvents(List<String> enabledEvents) {
    
    this.enabledEvents = enabledEvents;
    return this;
  }

  public InlineResponse20066Webhook addEnabledEventsItem(String enabledEventsItem) {
    if (this.enabledEvents == null) {
      this.enabledEvents = new ArrayList<String>();
    }
    this.enabledEvents.add(enabledEventsItem);
    return this;
  }

   /**
   * Get enabledEvents
   * @return enabledEvents
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<String> getEnabledEvents() {
    return enabledEvents;
  }


  public void setEnabledEvents(List<String> enabledEvents) {
    this.enabledEvents = enabledEvents;
  }


  public InlineResponse20066Webhook allWebhookCategories(List<String> allWebhookCategories) {
    
    this.allWebhookCategories = allWebhookCategories;
    return this;
  }

  public InlineResponse20066Webhook addAllWebhookCategoriesItem(String allWebhookCategoriesItem) {
    if (this.allWebhookCategories == null) {
      this.allWebhookCategories = new ArrayList<String>();
    }
    this.allWebhookCategories.add(allWebhookCategoriesItem);
    return this;
  }

   /**
   * Get allWebhookCategories
   * @return allWebhookCategories
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<String> getAllWebhookCategories() {
    return allWebhookCategories;
  }


  public void setAllWebhookCategories(List<String> allWebhookCategories) {
    this.allWebhookCategories = allWebhookCategories;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    InlineResponse20066Webhook inlineResponse20066Webhook = (InlineResponse20066Webhook) o;
    return Objects.equals(this.enabled, inlineResponse20066Webhook.enabled) &&
        Objects.equals(this.url, inlineResponse20066Webhook.url) &&
        Objects.equals(this.includeMembers, inlineResponse20066Webhook.includeMembers) &&
        Objects.equals(this.enabledEvents, inlineResponse20066Webhook.enabledEvents) &&
        Objects.equals(this.allWebhookCategories, inlineResponse20066Webhook.allWebhookCategories);
  }

  @Override
  public int hashCode() {
    return Objects.hash(enabled, url, includeMembers, enabledEvents, allWebhookCategories);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class InlineResponse20066Webhook {\n");
    sb.append("    enabled: ").append(toIndentedString(enabled)).append("\n");
    sb.append("    url: ").append(toIndentedString(url)).append("\n");
    sb.append("    includeMembers: ").append(toIndentedString(includeMembers)).append("\n");
    sb.append("    enabledEvents: ").append(toIndentedString(enabledEvents)).append("\n");
    sb.append("    allWebhookCategories: ").append(toIndentedString(allWebhookCategories)).append("\n");
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

