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
import org.openapitools.client.model.SendBirdGroupChannel;
import org.openapitools.client.model.SendBirdMember;
import org.openapitools.client.model.SendBirdMessageResponse;
import org.openapitools.client.model.SendBirdOpenChannel;
import org.openapitools.client.model.SendBirdUser;

/**
 * SendBirdChannelResponse
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2022-02-07T15:17:22.820442Z[Europe/London]")
public class SendBirdChannelResponse {
  public static final String SERIALIZED_NAME_COVER_URL = "cover_url";
  @SerializedName(SERIALIZED_NAME_COVER_URL)
  private String coverUrl;

  public static final String SERIALIZED_NAME_CREATED_AT = "created_at";
  @SerializedName(SERIALIZED_NAME_CREATED_AT)
  private BigDecimal createdAt;

  public static final String SERIALIZED_NAME_CREATOR = "creator";
  @SerializedName(SERIALIZED_NAME_CREATOR)
  private SendBirdUser creator;

  public static final String SERIALIZED_NAME_CUSTOM_TYPE = "custom_type";
  @SerializedName(SERIALIZED_NAME_CUSTOM_TYPE)
  private String customType;

  public static final String SERIALIZED_NAME_DATA = "data";
  @SerializedName(SERIALIZED_NAME_DATA)
  private String data;

  /**
   * Gets or Sets hiddenState
   */
  @JsonAdapter(HiddenStateEnum.Adapter.class)
  public enum HiddenStateEnum {
    HIDDEN_ALLOW_AUTO_UNHIDE("hidden_allow_auto_unhide"),
    
    HIDDEN_PREVENT_AUTO_UNHIDE("hidden_prevent_auto_unhide"),
    
    UNHIDDEN("unhidden");

    private String value;

    HiddenStateEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static HiddenStateEnum fromValue(String value) {
      for (HiddenStateEnum b : HiddenStateEnum.values()) {
        if (b.value.equals(value)) {
          return b;
        }
      }
      throw new IllegalArgumentException("Unexpected value '" + value + "'");
    }

    public static class Adapter extends TypeAdapter<HiddenStateEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final HiddenStateEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public HiddenStateEnum read(final JsonReader jsonReader) throws IOException {
        String value =  jsonReader.nextString();
        return HiddenStateEnum.fromValue(value);
      }
    }
  }

  public static final String SERIALIZED_NAME_HIDDEN_STATE = "hidden_state";
  @SerializedName(SERIALIZED_NAME_HIDDEN_STATE)
  private HiddenStateEnum hiddenState;

  public static final String SERIALIZED_NAME_INVITED_AT = "invited_at";
  @SerializedName(SERIALIZED_NAME_INVITED_AT)
  private BigDecimal invitedAt;

  public static final String SERIALIZED_NAME_INVITER = "inviter";
  @SerializedName(SERIALIZED_NAME_INVITER)
  private SendBirdUser inviter;

  public static final String SERIALIZED_NAME_IS_ACCESS_CODE_REQUIRED = "is_access_code_required";
  @SerializedName(SERIALIZED_NAME_IS_ACCESS_CODE_REQUIRED)
  private Boolean isAccessCodeRequired;

  public static final String SERIALIZED_NAME_IS_BROADCAST = "is_broadcast";
  @SerializedName(SERIALIZED_NAME_IS_BROADCAST)
  private Boolean isBroadcast;

  public static final String SERIALIZED_NAME_IS_DISCOVERABLE = "is_discoverable";
  @SerializedName(SERIALIZED_NAME_IS_DISCOVERABLE)
  private Boolean isDiscoverable;

  public static final String SERIALIZED_NAME_IS_DISTINCT = "is_distinct";
  @SerializedName(SERIALIZED_NAME_IS_DISTINCT)
  private Boolean isDistinct;

  public static final String SERIALIZED_NAME_IS_EPHEMERAL = "is_ephemeral";
  @SerializedName(SERIALIZED_NAME_IS_EPHEMERAL)
  private Boolean isEphemeral;

  public static final String SERIALIZED_NAME_IS_FROZEN = "is_frozen";
  @SerializedName(SERIALIZED_NAME_IS_FROZEN)
  private Boolean isFrozen;

  public static final String SERIALIZED_NAME_IS_HIDDEN = "is_hidden";
  @SerializedName(SERIALIZED_NAME_IS_HIDDEN)
  private Boolean isHidden;

  public static final String SERIALIZED_NAME_IS_PUBLIC = "is_public";
  @SerializedName(SERIALIZED_NAME_IS_PUBLIC)
  private Boolean isPublic;

  public static final String SERIALIZED_NAME_IS_PUSH_ENABLED = "is_push_enabled";
  @SerializedName(SERIALIZED_NAME_IS_PUSH_ENABLED)
  private Boolean isPushEnabled;

  public static final String SERIALIZED_NAME_IS_SUPER = "is_super";
  @SerializedName(SERIALIZED_NAME_IS_SUPER)
  private Boolean isSuper;

  public static final String SERIALIZED_NAME_JOINED_AT = "joined_at";
  @SerializedName(SERIALIZED_NAME_JOINED_AT)
  private BigDecimal joinedAt;

  public static final String SERIALIZED_NAME_JOINED_MEMBER_COUNT = "joined_member_count";
  @SerializedName(SERIALIZED_NAME_JOINED_MEMBER_COUNT)
  private BigDecimal joinedMemberCount;

  public static final String SERIALIZED_NAME_LAST_MESSAGE = "last_message";
  @SerializedName(SERIALIZED_NAME_LAST_MESSAGE)
  private SendBirdMessageResponse lastMessage;

  public static final String SERIALIZED_NAME_MEMBER_COUNT = "member_count";
  @SerializedName(SERIALIZED_NAME_MEMBER_COUNT)
  private BigDecimal memberCount;

  public static final String SERIALIZED_NAME_MEMBERS = "members";
  @SerializedName(SERIALIZED_NAME_MEMBERS)
  private List<SendBirdMember> members = null;

  public static final String SERIALIZED_NAME_MESSAGE_OFFSET_TIMESTAMP = "message_offset_timestamp";
  @SerializedName(SERIALIZED_NAME_MESSAGE_OFFSET_TIMESTAMP)
  private BigDecimal messageOffsetTimestamp;

  public static final String SERIALIZED_NAME_MESSAGE_SURVIVAL_SECONDS = "message_survival_seconds";
  @SerializedName(SERIALIZED_NAME_MESSAGE_SURVIVAL_SECONDS)
  private BigDecimal messageSurvivalSeconds;

  public static final String SERIALIZED_NAME_MY_COUNT_PREFERENCE = "my_count_preference";
  @SerializedName(SERIALIZED_NAME_MY_COUNT_PREFERENCE)
  private String myCountPreference;

  public static final String SERIALIZED_NAME_MY_LAST_READ = "my_last_read";
  @SerializedName(SERIALIZED_NAME_MY_LAST_READ)
  private BigDecimal myLastRead;

  /**
   * Gets or Sets myMemberState
   */
  @JsonAdapter(MyMemberStateEnum.Adapter.class)
  public enum MyMemberStateEnum {
    INVITED("invited"),
    
    JOINED("joined"),
    
    NONE("none");

    private String value;

    MyMemberStateEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static MyMemberStateEnum fromValue(String value) {
      for (MyMemberStateEnum b : MyMemberStateEnum.values()) {
        if (b.value.equals(value)) {
          return b;
        }
      }
      throw new IllegalArgumentException("Unexpected value '" + value + "'");
    }

    public static class Adapter extends TypeAdapter<MyMemberStateEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final MyMemberStateEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public MyMemberStateEnum read(final JsonReader jsonReader) throws IOException {
        String value =  jsonReader.nextString();
        return MyMemberStateEnum.fromValue(value);
      }
    }
  }

  public static final String SERIALIZED_NAME_MY_MEMBER_STATE = "my_member_state";
  @SerializedName(SERIALIZED_NAME_MY_MEMBER_STATE)
  private MyMemberStateEnum myMemberState;

  /**
   * Gets or Sets myMutedState
   */
  @JsonAdapter(MyMutedStateEnum.Adapter.class)
  public enum MyMutedStateEnum {
    MUTED("muted"),
    
    UNMUTED("unmuted");

    private String value;

    MyMutedStateEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static MyMutedStateEnum fromValue(String value) {
      for (MyMutedStateEnum b : MyMutedStateEnum.values()) {
        if (b.value.equals(value)) {
          return b;
        }
      }
      throw new IllegalArgumentException("Unexpected value '" + value + "'");
    }

    public static class Adapter extends TypeAdapter<MyMutedStateEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final MyMutedStateEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public MyMutedStateEnum read(final JsonReader jsonReader) throws IOException {
        String value =  jsonReader.nextString();
        return MyMutedStateEnum.fromValue(value);
      }
    }
  }

  public static final String SERIALIZED_NAME_MY_MUTED_STATE = "my_muted_state";
  @SerializedName(SERIALIZED_NAME_MY_MUTED_STATE)
  private MyMutedStateEnum myMutedState;

  /**
   * Gets or Sets myPushTriggerOption
   */
  @JsonAdapter(MyPushTriggerOptionEnum.Adapter.class)
  public enum MyPushTriggerOptionEnum {
    ALL("all"),
    
    DEFAULT("default"),
    
    MENTION_ONLY("mention_only"),
    
    FALSE("false");

    private String value;

    MyPushTriggerOptionEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static MyPushTriggerOptionEnum fromValue(String value) {
      for (MyPushTriggerOptionEnum b : MyPushTriggerOptionEnum.values()) {
        if (b.value.equals(value)) {
          return b;
        }
      }
      throw new IllegalArgumentException("Unexpected value '" + value + "'");
    }

    public static class Adapter extends TypeAdapter<MyPushTriggerOptionEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final MyPushTriggerOptionEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public MyPushTriggerOptionEnum read(final JsonReader jsonReader) throws IOException {
        String value =  jsonReader.nextString();
        return MyPushTriggerOptionEnum.fromValue(value);
      }
    }
  }

  public static final String SERIALIZED_NAME_MY_PUSH_TRIGGER_OPTION = "my_push_trigger_option";
  @SerializedName(SERIALIZED_NAME_MY_PUSH_TRIGGER_OPTION)
  private MyPushTriggerOptionEnum myPushTriggerOption;

  /**
   * Gets or Sets myRole
   */
  @JsonAdapter(MyRoleEnum.Adapter.class)
  public enum MyRoleEnum {
    NONE("none"),
    
    OPERATOR("operator");

    private String value;

    MyRoleEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static MyRoleEnum fromValue(String value) {
      for (MyRoleEnum b : MyRoleEnum.values()) {
        if (b.value.equals(value)) {
          return b;
        }
      }
      throw new IllegalArgumentException("Unexpected value '" + value + "'");
    }

    public static class Adapter extends TypeAdapter<MyRoleEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final MyRoleEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public MyRoleEnum read(final JsonReader jsonReader) throws IOException {
        String value =  jsonReader.nextString();
        return MyRoleEnum.fromValue(value);
      }
    }
  }

  public static final String SERIALIZED_NAME_MY_ROLE = "my_role";
  @SerializedName(SERIALIZED_NAME_MY_ROLE)
  private MyRoleEnum myRole;

  public static final String SERIALIZED_NAME_NAME = "name";
  @SerializedName(SERIALIZED_NAME_NAME)
  private String name;

  public static final String SERIALIZED_NAME_UNREAD_MENTION_COUNT = "unread_mention_count";
  @SerializedName(SERIALIZED_NAME_UNREAD_MENTION_COUNT)
  private BigDecimal unreadMentionCount;

  public static final String SERIALIZED_NAME_UNREAD_MESSAGE_COUNT = "unread_message_count";
  @SerializedName(SERIALIZED_NAME_UNREAD_MESSAGE_COUNT)
  private BigDecimal unreadMessageCount;

  public static final String SERIALIZED_NAME_CHANNEL_URL = "channel_url";
  @SerializedName(SERIALIZED_NAME_CHANNEL_URL)
  private String channelUrl;

  public static final String SERIALIZED_NAME_OPERATORS = "operators";
  @SerializedName(SERIALIZED_NAME_OPERATORS)
  private List<SendBirdUser> operators = null;

  public static final String SERIALIZED_NAME_PARTICIPANT_COUNT = "participant_count";
  @SerializedName(SERIALIZED_NAME_PARTICIPANT_COUNT)
  private BigDecimal participantCount;

  public SendBirdChannelResponse() { 
  }

  public SendBirdChannelResponse coverUrl(String coverUrl) {
    
    this.coverUrl = coverUrl;
    return this;
  }

   /**
   * Get coverUrl
   * @return coverUrl
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getCoverUrl() {
    return coverUrl;
  }


  public void setCoverUrl(String coverUrl) {
    this.coverUrl = coverUrl;
  }


  public SendBirdChannelResponse createdAt(BigDecimal createdAt) {
    
    this.createdAt = createdAt;
    return this;
  }

   /**
   * Get createdAt
   * @return createdAt
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public BigDecimal getCreatedAt() {
    return createdAt;
  }


  public void setCreatedAt(BigDecimal createdAt) {
    this.createdAt = createdAt;
  }


  public SendBirdChannelResponse creator(SendBirdUser creator) {
    
    this.creator = creator;
    return this;
  }

   /**
   * Get creator
   * @return creator
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public SendBirdUser getCreator() {
    return creator;
  }


  public void setCreator(SendBirdUser creator) {
    this.creator = creator;
  }


  public SendBirdChannelResponse customType(String customType) {
    
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


  public SendBirdChannelResponse data(String data) {
    
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


  public SendBirdChannelResponse hiddenState(HiddenStateEnum hiddenState) {
    
    this.hiddenState = hiddenState;
    return this;
  }

   /**
   * Get hiddenState
   * @return hiddenState
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public HiddenStateEnum getHiddenState() {
    return hiddenState;
  }


  public void setHiddenState(HiddenStateEnum hiddenState) {
    this.hiddenState = hiddenState;
  }


  public SendBirdChannelResponse invitedAt(BigDecimal invitedAt) {
    
    this.invitedAt = invitedAt;
    return this;
  }

   /**
   * Get invitedAt
   * @return invitedAt
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public BigDecimal getInvitedAt() {
    return invitedAt;
  }


  public void setInvitedAt(BigDecimal invitedAt) {
    this.invitedAt = invitedAt;
  }


  public SendBirdChannelResponse inviter(SendBirdUser inviter) {
    
    this.inviter = inviter;
    return this;
  }

   /**
   * Get inviter
   * @return inviter
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public SendBirdUser getInviter() {
    return inviter;
  }


  public void setInviter(SendBirdUser inviter) {
    this.inviter = inviter;
  }


  public SendBirdChannelResponse isAccessCodeRequired(Boolean isAccessCodeRequired) {
    
    this.isAccessCodeRequired = isAccessCodeRequired;
    return this;
  }

   /**
   * Get isAccessCodeRequired
   * @return isAccessCodeRequired
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getIsAccessCodeRequired() {
    return isAccessCodeRequired;
  }


  public void setIsAccessCodeRequired(Boolean isAccessCodeRequired) {
    this.isAccessCodeRequired = isAccessCodeRequired;
  }


  public SendBirdChannelResponse isBroadcast(Boolean isBroadcast) {
    
    this.isBroadcast = isBroadcast;
    return this;
  }

   /**
   * Get isBroadcast
   * @return isBroadcast
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getIsBroadcast() {
    return isBroadcast;
  }


  public void setIsBroadcast(Boolean isBroadcast) {
    this.isBroadcast = isBroadcast;
  }


  public SendBirdChannelResponse isDiscoverable(Boolean isDiscoverable) {
    
    this.isDiscoverable = isDiscoverable;
    return this;
  }

   /**
   * Get isDiscoverable
   * @return isDiscoverable
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getIsDiscoverable() {
    return isDiscoverable;
  }


  public void setIsDiscoverable(Boolean isDiscoverable) {
    this.isDiscoverable = isDiscoverable;
  }


  public SendBirdChannelResponse isDistinct(Boolean isDistinct) {
    
    this.isDistinct = isDistinct;
    return this;
  }

   /**
   * Get isDistinct
   * @return isDistinct
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getIsDistinct() {
    return isDistinct;
  }


  public void setIsDistinct(Boolean isDistinct) {
    this.isDistinct = isDistinct;
  }


  public SendBirdChannelResponse isEphemeral(Boolean isEphemeral) {
    
    this.isEphemeral = isEphemeral;
    return this;
  }

   /**
   * Get isEphemeral
   * @return isEphemeral
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getIsEphemeral() {
    return isEphemeral;
  }


  public void setIsEphemeral(Boolean isEphemeral) {
    this.isEphemeral = isEphemeral;
  }


  public SendBirdChannelResponse isFrozen(Boolean isFrozen) {
    
    this.isFrozen = isFrozen;
    return this;
  }

   /**
   * Get isFrozen
   * @return isFrozen
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getIsFrozen() {
    return isFrozen;
  }


  public void setIsFrozen(Boolean isFrozen) {
    this.isFrozen = isFrozen;
  }


  public SendBirdChannelResponse isHidden(Boolean isHidden) {
    
    this.isHidden = isHidden;
    return this;
  }

   /**
   * Get isHidden
   * @return isHidden
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getIsHidden() {
    return isHidden;
  }


  public void setIsHidden(Boolean isHidden) {
    this.isHidden = isHidden;
  }


  public SendBirdChannelResponse isPublic(Boolean isPublic) {
    
    this.isPublic = isPublic;
    return this;
  }

   /**
   * Get isPublic
   * @return isPublic
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getIsPublic() {
    return isPublic;
  }


  public void setIsPublic(Boolean isPublic) {
    this.isPublic = isPublic;
  }


  public SendBirdChannelResponse isPushEnabled(Boolean isPushEnabled) {
    
    this.isPushEnabled = isPushEnabled;
    return this;
  }

   /**
   * Get isPushEnabled
   * @return isPushEnabled
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getIsPushEnabled() {
    return isPushEnabled;
  }


  public void setIsPushEnabled(Boolean isPushEnabled) {
    this.isPushEnabled = isPushEnabled;
  }


  public SendBirdChannelResponse isSuper(Boolean isSuper) {
    
    this.isSuper = isSuper;
    return this;
  }

   /**
   * Get isSuper
   * @return isSuper
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getIsSuper() {
    return isSuper;
  }


  public void setIsSuper(Boolean isSuper) {
    this.isSuper = isSuper;
  }


  public SendBirdChannelResponse joinedAt(BigDecimal joinedAt) {
    
    this.joinedAt = joinedAt;
    return this;
  }

   /**
   * Get joinedAt
   * @return joinedAt
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public BigDecimal getJoinedAt() {
    return joinedAt;
  }


  public void setJoinedAt(BigDecimal joinedAt) {
    this.joinedAt = joinedAt;
  }


  public SendBirdChannelResponse joinedMemberCount(BigDecimal joinedMemberCount) {
    
    this.joinedMemberCount = joinedMemberCount;
    return this;
  }

   /**
   * Get joinedMemberCount
   * @return joinedMemberCount
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public BigDecimal getJoinedMemberCount() {
    return joinedMemberCount;
  }


  public void setJoinedMemberCount(BigDecimal joinedMemberCount) {
    this.joinedMemberCount = joinedMemberCount;
  }


  public SendBirdChannelResponse lastMessage(SendBirdMessageResponse lastMessage) {
    
    this.lastMessage = lastMessage;
    return this;
  }

   /**
   * Get lastMessage
   * @return lastMessage
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public SendBirdMessageResponse getLastMessage() {
    return lastMessage;
  }


  public void setLastMessage(SendBirdMessageResponse lastMessage) {
    this.lastMessage = lastMessage;
  }


  public SendBirdChannelResponse memberCount(BigDecimal memberCount) {
    
    this.memberCount = memberCount;
    return this;
  }

   /**
   * Get memberCount
   * @return memberCount
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public BigDecimal getMemberCount() {
    return memberCount;
  }


  public void setMemberCount(BigDecimal memberCount) {
    this.memberCount = memberCount;
  }


  public SendBirdChannelResponse members(List<SendBirdMember> members) {
    
    this.members = members;
    return this;
  }

  public SendBirdChannelResponse addMembersItem(SendBirdMember membersItem) {
    if (this.members == null) {
      this.members = new ArrayList<SendBirdMember>();
    }
    this.members.add(membersItem);
    return this;
  }

   /**
   * Get members
   * @return members
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<SendBirdMember> getMembers() {
    return members;
  }


  public void setMembers(List<SendBirdMember> members) {
    this.members = members;
  }


  public SendBirdChannelResponse messageOffsetTimestamp(BigDecimal messageOffsetTimestamp) {
    
    this.messageOffsetTimestamp = messageOffsetTimestamp;
    return this;
  }

   /**
   * Get messageOffsetTimestamp
   * @return messageOffsetTimestamp
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public BigDecimal getMessageOffsetTimestamp() {
    return messageOffsetTimestamp;
  }


  public void setMessageOffsetTimestamp(BigDecimal messageOffsetTimestamp) {
    this.messageOffsetTimestamp = messageOffsetTimestamp;
  }


  public SendBirdChannelResponse messageSurvivalSeconds(BigDecimal messageSurvivalSeconds) {
    
    this.messageSurvivalSeconds = messageSurvivalSeconds;
    return this;
  }

   /**
   * Get messageSurvivalSeconds
   * @return messageSurvivalSeconds
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public BigDecimal getMessageSurvivalSeconds() {
    return messageSurvivalSeconds;
  }


  public void setMessageSurvivalSeconds(BigDecimal messageSurvivalSeconds) {
    this.messageSurvivalSeconds = messageSurvivalSeconds;
  }


  public SendBirdChannelResponse myCountPreference(String myCountPreference) {
    
    this.myCountPreference = myCountPreference;
    return this;
  }

   /**
   * Get myCountPreference
   * @return myCountPreference
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getMyCountPreference() {
    return myCountPreference;
  }


  public void setMyCountPreference(String myCountPreference) {
    this.myCountPreference = myCountPreference;
  }


  public SendBirdChannelResponse myLastRead(BigDecimal myLastRead) {
    
    this.myLastRead = myLastRead;
    return this;
  }

   /**
   * Get myLastRead
   * @return myLastRead
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public BigDecimal getMyLastRead() {
    return myLastRead;
  }


  public void setMyLastRead(BigDecimal myLastRead) {
    this.myLastRead = myLastRead;
  }


  public SendBirdChannelResponse myMemberState(MyMemberStateEnum myMemberState) {
    
    this.myMemberState = myMemberState;
    return this;
  }

   /**
   * Get myMemberState
   * @return myMemberState
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public MyMemberStateEnum getMyMemberState() {
    return myMemberState;
  }


  public void setMyMemberState(MyMemberStateEnum myMemberState) {
    this.myMemberState = myMemberState;
  }


  public SendBirdChannelResponse myMutedState(MyMutedStateEnum myMutedState) {
    
    this.myMutedState = myMutedState;
    return this;
  }

   /**
   * Get myMutedState
   * @return myMutedState
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public MyMutedStateEnum getMyMutedState() {
    return myMutedState;
  }


  public void setMyMutedState(MyMutedStateEnum myMutedState) {
    this.myMutedState = myMutedState;
  }


  public SendBirdChannelResponse myPushTriggerOption(MyPushTriggerOptionEnum myPushTriggerOption) {
    
    this.myPushTriggerOption = myPushTriggerOption;
    return this;
  }

   /**
   * Get myPushTriggerOption
   * @return myPushTriggerOption
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public MyPushTriggerOptionEnum getMyPushTriggerOption() {
    return myPushTriggerOption;
  }


  public void setMyPushTriggerOption(MyPushTriggerOptionEnum myPushTriggerOption) {
    this.myPushTriggerOption = myPushTriggerOption;
  }


  public SendBirdChannelResponse myRole(MyRoleEnum myRole) {
    
    this.myRole = myRole;
    return this;
  }

   /**
   * Get myRole
   * @return myRole
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public MyRoleEnum getMyRole() {
    return myRole;
  }


  public void setMyRole(MyRoleEnum myRole) {
    this.myRole = myRole;
  }


  public SendBirdChannelResponse name(String name) {
    
    this.name = name;
    return this;
  }

   /**
   * Get name
   * @return name
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getName() {
    return name;
  }


  public void setName(String name) {
    this.name = name;
  }


  public SendBirdChannelResponse unreadMentionCount(BigDecimal unreadMentionCount) {
    
    this.unreadMentionCount = unreadMentionCount;
    return this;
  }

   /**
   * Get unreadMentionCount
   * @return unreadMentionCount
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public BigDecimal getUnreadMentionCount() {
    return unreadMentionCount;
  }


  public void setUnreadMentionCount(BigDecimal unreadMentionCount) {
    this.unreadMentionCount = unreadMentionCount;
  }


  public SendBirdChannelResponse unreadMessageCount(BigDecimal unreadMessageCount) {
    
    this.unreadMessageCount = unreadMessageCount;
    return this;
  }

   /**
   * Get unreadMessageCount
   * @return unreadMessageCount
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public BigDecimal getUnreadMessageCount() {
    return unreadMessageCount;
  }


  public void setUnreadMessageCount(BigDecimal unreadMessageCount) {
    this.unreadMessageCount = unreadMessageCount;
  }


  public SendBirdChannelResponse channelUrl(String channelUrl) {
    
    this.channelUrl = channelUrl;
    return this;
  }

   /**
   * Get channelUrl
   * @return channelUrl
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getChannelUrl() {
    return channelUrl;
  }


  public void setChannelUrl(String channelUrl) {
    this.channelUrl = channelUrl;
  }


  public SendBirdChannelResponse operators(List<SendBirdUser> operators) {
    
    this.operators = operators;
    return this;
  }

  public SendBirdChannelResponse addOperatorsItem(SendBirdUser operatorsItem) {
    if (this.operators == null) {
      this.operators = new ArrayList<SendBirdUser>();
    }
    this.operators.add(operatorsItem);
    return this;
  }

   /**
   * Get operators
   * @return operators
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<SendBirdUser> getOperators() {
    return operators;
  }


  public void setOperators(List<SendBirdUser> operators) {
    this.operators = operators;
  }


  public SendBirdChannelResponse participantCount(BigDecimal participantCount) {
    
    this.participantCount = participantCount;
    return this;
  }

   /**
   * Get participantCount
   * @return participantCount
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public BigDecimal getParticipantCount() {
    return participantCount;
  }


  public void setParticipantCount(BigDecimal participantCount) {
    this.participantCount = participantCount;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SendBirdChannelResponse sendBirdChannelResponse = (SendBirdChannelResponse) o;
    return Objects.equals(this.coverUrl, sendBirdChannelResponse.coverUrl) &&
        Objects.equals(this.createdAt, sendBirdChannelResponse.createdAt) &&
        Objects.equals(this.creator, sendBirdChannelResponse.creator) &&
        Objects.equals(this.customType, sendBirdChannelResponse.customType) &&
        Objects.equals(this.data, sendBirdChannelResponse.data) &&
        Objects.equals(this.hiddenState, sendBirdChannelResponse.hiddenState) &&
        Objects.equals(this.invitedAt, sendBirdChannelResponse.invitedAt) &&
        Objects.equals(this.inviter, sendBirdChannelResponse.inviter) &&
        Objects.equals(this.isAccessCodeRequired, sendBirdChannelResponse.isAccessCodeRequired) &&
        Objects.equals(this.isBroadcast, sendBirdChannelResponse.isBroadcast) &&
        Objects.equals(this.isDiscoverable, sendBirdChannelResponse.isDiscoverable) &&
        Objects.equals(this.isDistinct, sendBirdChannelResponse.isDistinct) &&
        Objects.equals(this.isEphemeral, sendBirdChannelResponse.isEphemeral) &&
        Objects.equals(this.isFrozen, sendBirdChannelResponse.isFrozen) &&
        Objects.equals(this.isHidden, sendBirdChannelResponse.isHidden) &&
        Objects.equals(this.isPublic, sendBirdChannelResponse.isPublic) &&
        Objects.equals(this.isPushEnabled, sendBirdChannelResponse.isPushEnabled) &&
        Objects.equals(this.isSuper, sendBirdChannelResponse.isSuper) &&
        Objects.equals(this.joinedAt, sendBirdChannelResponse.joinedAt) &&
        Objects.equals(this.joinedMemberCount, sendBirdChannelResponse.joinedMemberCount) &&
        Objects.equals(this.lastMessage, sendBirdChannelResponse.lastMessage) &&
        Objects.equals(this.memberCount, sendBirdChannelResponse.memberCount) &&
        Objects.equals(this.members, sendBirdChannelResponse.members) &&
        Objects.equals(this.messageOffsetTimestamp, sendBirdChannelResponse.messageOffsetTimestamp) &&
        Objects.equals(this.messageSurvivalSeconds, sendBirdChannelResponse.messageSurvivalSeconds) &&
        Objects.equals(this.myCountPreference, sendBirdChannelResponse.myCountPreference) &&
        Objects.equals(this.myLastRead, sendBirdChannelResponse.myLastRead) &&
        Objects.equals(this.myMemberState, sendBirdChannelResponse.myMemberState) &&
        Objects.equals(this.myMutedState, sendBirdChannelResponse.myMutedState) &&
        Objects.equals(this.myPushTriggerOption, sendBirdChannelResponse.myPushTriggerOption) &&
        Objects.equals(this.myRole, sendBirdChannelResponse.myRole) &&
        Objects.equals(this.name, sendBirdChannelResponse.name) &&
        Objects.equals(this.unreadMentionCount, sendBirdChannelResponse.unreadMentionCount) &&
        Objects.equals(this.unreadMessageCount, sendBirdChannelResponse.unreadMessageCount) &&
        Objects.equals(this.channelUrl, sendBirdChannelResponse.channelUrl) &&
        Objects.equals(this.operators, sendBirdChannelResponse.operators) &&
        Objects.equals(this.participantCount, sendBirdChannelResponse.participantCount);
  }

  @Override
  public int hashCode() {
    return Objects.hash(coverUrl, createdAt, creator, customType, data, hiddenState, invitedAt, inviter, isAccessCodeRequired, isBroadcast, isDiscoverable, isDistinct, isEphemeral, isFrozen, isHidden, isPublic, isPushEnabled, isSuper, joinedAt, joinedMemberCount, lastMessage, memberCount, members, messageOffsetTimestamp, messageSurvivalSeconds, myCountPreference, myLastRead, myMemberState, myMutedState, myPushTriggerOption, myRole, name, unreadMentionCount, unreadMessageCount, channelUrl, operators, participantCount);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SendBirdChannelResponse {\n");
    sb.append("    coverUrl: ").append(toIndentedString(coverUrl)).append("\n");
    sb.append("    createdAt: ").append(toIndentedString(createdAt)).append("\n");
    sb.append("    creator: ").append(toIndentedString(creator)).append("\n");
    sb.append("    customType: ").append(toIndentedString(customType)).append("\n");
    sb.append("    data: ").append(toIndentedString(data)).append("\n");
    sb.append("    hiddenState: ").append(toIndentedString(hiddenState)).append("\n");
    sb.append("    invitedAt: ").append(toIndentedString(invitedAt)).append("\n");
    sb.append("    inviter: ").append(toIndentedString(inviter)).append("\n");
    sb.append("    isAccessCodeRequired: ").append(toIndentedString(isAccessCodeRequired)).append("\n");
    sb.append("    isBroadcast: ").append(toIndentedString(isBroadcast)).append("\n");
    sb.append("    isDiscoverable: ").append(toIndentedString(isDiscoverable)).append("\n");
    sb.append("    isDistinct: ").append(toIndentedString(isDistinct)).append("\n");
    sb.append("    isEphemeral: ").append(toIndentedString(isEphemeral)).append("\n");
    sb.append("    isFrozen: ").append(toIndentedString(isFrozen)).append("\n");
    sb.append("    isHidden: ").append(toIndentedString(isHidden)).append("\n");
    sb.append("    isPublic: ").append(toIndentedString(isPublic)).append("\n");
    sb.append("    isPushEnabled: ").append(toIndentedString(isPushEnabled)).append("\n");
    sb.append("    isSuper: ").append(toIndentedString(isSuper)).append("\n");
    sb.append("    joinedAt: ").append(toIndentedString(joinedAt)).append("\n");
    sb.append("    joinedMemberCount: ").append(toIndentedString(joinedMemberCount)).append("\n");
    sb.append("    lastMessage: ").append(toIndentedString(lastMessage)).append("\n");
    sb.append("    memberCount: ").append(toIndentedString(memberCount)).append("\n");
    sb.append("    members: ").append(toIndentedString(members)).append("\n");
    sb.append("    messageOffsetTimestamp: ").append(toIndentedString(messageOffsetTimestamp)).append("\n");
    sb.append("    messageSurvivalSeconds: ").append(toIndentedString(messageSurvivalSeconds)).append("\n");
    sb.append("    myCountPreference: ").append(toIndentedString(myCountPreference)).append("\n");
    sb.append("    myLastRead: ").append(toIndentedString(myLastRead)).append("\n");
    sb.append("    myMemberState: ").append(toIndentedString(myMemberState)).append("\n");
    sb.append("    myMutedState: ").append(toIndentedString(myMutedState)).append("\n");
    sb.append("    myPushTriggerOption: ").append(toIndentedString(myPushTriggerOption)).append("\n");
    sb.append("    myRole: ").append(toIndentedString(myRole)).append("\n");
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    unreadMentionCount: ").append(toIndentedString(unreadMentionCount)).append("\n");
    sb.append("    unreadMessageCount: ").append(toIndentedString(unreadMessageCount)).append("\n");
    sb.append("    channelUrl: ").append(toIndentedString(channelUrl)).append("\n");
    sb.append("    operators: ").append(toIndentedString(operators)).append("\n");
    sb.append("    participantCount: ").append(toIndentedString(participantCount)).append("\n");
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

