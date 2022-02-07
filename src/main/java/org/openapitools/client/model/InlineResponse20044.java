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
import org.openapitools.client.model.InlineResponse20044Statistics;

/**
 * InlineResponse20044
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2022-02-07T15:17:22.820442Z[Europe/London]")
public class InlineResponse20044 {
  public static final String SERIALIZED_NAME_STATISTICS = "statistics";
  @SerializedName(SERIALIZED_NAME_STATISTICS)
  private List<InlineResponse20044Statistics> statistics = null;

  public static final String SERIALIZED_NAME_WEEK = "week";
  @SerializedName(SERIALIZED_NAME_WEEK)
  private BigDecimal week;

  public InlineResponse20044() { 
  }

  public InlineResponse20044 statistics(List<InlineResponse20044Statistics> statistics) {
    
    this.statistics = statistics;
    return this;
  }

  public InlineResponse20044 addStatisticsItem(InlineResponse20044Statistics statisticsItem) {
    if (this.statistics == null) {
      this.statistics = new ArrayList<InlineResponse20044Statistics>();
    }
    this.statistics.add(statisticsItem);
    return this;
  }

   /**
   * Get statistics
   * @return statistics
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<InlineResponse20044Statistics> getStatistics() {
    return statistics;
  }


  public void setStatistics(List<InlineResponse20044Statistics> statistics) {
    this.statistics = statistics;
  }


  public InlineResponse20044 week(BigDecimal week) {
    
    this.week = week;
    return this;
  }

   /**
   * Get week
   * @return week
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public BigDecimal getWeek() {
    return week;
  }


  public void setWeek(BigDecimal week) {
    this.week = week;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    InlineResponse20044 inlineResponse20044 = (InlineResponse20044) o;
    return Objects.equals(this.statistics, inlineResponse20044.statistics) &&
        Objects.equals(this.week, inlineResponse20044.week);
  }

  @Override
  public int hashCode() {
    return Objects.hash(statistics, week);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class InlineResponse20044 {\n");
    sb.append("    statistics: ").append(toIndentedString(statistics)).append("\n");
    sb.append("    week: ").append(toIndentedString(week)).append("\n");
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

