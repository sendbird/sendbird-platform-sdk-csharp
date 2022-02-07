/*
 * Sendbird Platform SDK
 *
 * Sendbird Platform API Javascript SDK  https://sendbird.com/docs/chat/v3/platform-api/getting-started/prepare-to-use-api
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using sendbird-platform-sdk.Client;
using sendbird-platform-sdk.org.sendbird.client.api;
using sendbird-platform-sdk.Model;

namespace sendbird-platform-sdk.Test
{
    /// <summary>
    ///  Class for testing GroupChannelApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GroupChannelApiTests
    {
        private GroupChannelApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GroupChannelApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GroupChannelApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' GroupChannelApi
            //Assert.IsInstanceOf(typeof(GroupChannelApi), instance);
        }

        
        /// <summary>
        /// Test GcAcceptInvitation
        /// </summary>
        [Test]
        public void GcAcceptInvitationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string apiToken = null;
            //GcAcceptInvitationData gcAcceptInvitationData = null;
            //var response = instance.GcAcceptInvitation(channelUrl, apiToken, gcAcceptInvitationData);
            //Assert.IsInstanceOf(typeof(SendBirdGroupChannel), response, "response is SendBirdGroupChannel");
        }
        
        /// <summary>
        /// Test GcBanUser
        /// </summary>
        [Test]
        public void GcBanUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string apiToken = null;
            //GcBanUserData gcBanUserData = null;
            //var response = instance.GcBanUser(channelUrl, apiToken, gcBanUserData);
            //Assert.IsInstanceOf(typeof(InlineResponse20033BannedList), response, "response is InlineResponse20033BannedList");
        }
        
        /// <summary>
        /// Test GcCancelTheRegistrationOfOperators
        /// </summary>
        [Test]
        public void GcCancelTheRegistrationOfOperatorsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //List<string> operatorIds = null;
            //string apiToken = null;
            //bool? deleteAll = null;
            //instance.GcCancelTheRegistrationOfOperators(channelUrl, operatorIds, apiToken, deleteAll);
            
        }
        
        /// <summary>
        /// Test GcCheckIfMemberById
        /// </summary>
        [Test]
        public void GcCheckIfMemberByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string userId = null;
            //string apiToken = null;
            //var response = instance.GcCheckIfMemberById(channelUrl, userId, apiToken);
            //Assert.IsInstanceOf(typeof(InlineResponse20037), response, "response is InlineResponse20037");
        }
        
        /// <summary>
        /// Test GcCreateChannel
        /// </summary>
        [Test]
        public void GcCreateChannelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //GcCreateChannelData gcCreateChannelData = null;
            //var response = instance.GcCreateChannel(apiToken, gcCreateChannelData);
            //Assert.IsInstanceOf(typeof(SendBirdGroupChannel), response, "response is SendBirdGroupChannel");
        }
        
        /// <summary>
        /// Test GcDeclineInvitation
        /// </summary>
        [Test]
        public void GcDeclineInvitationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string apiToken = null;
            //GcDeclineInvitationData gcDeclineInvitationData = null;
            //instance.GcDeclineInvitation(channelUrl, apiToken, gcDeclineInvitationData);
            
        }
        
        /// <summary>
        /// Test GcDeleteChannelByUrl
        /// </summary>
        [Test]
        public void GcDeleteChannelByUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string apiToken = null;
            //instance.GcDeleteChannelByUrl(channelUrl, apiToken);
            
        }
        
        /// <summary>
        /// Test GcFreezeChannel
        /// </summary>
        [Test]
        public void GcFreezeChannelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string apiToken = null;
            //GcFreezeChannelData gcFreezeChannelData = null;
            //var response = instance.GcFreezeChannel(channelUrl, apiToken, gcFreezeChannelData);
            //Assert.IsInstanceOf(typeof(SendBirdGroupChannel), response, "response is SendBirdGroupChannel");
        }
        
        /// <summary>
        /// Test GcHideOrArchiveChannel
        /// </summary>
        [Test]
        public void GcHideOrArchiveChannelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string apiToken = null;
            //GcHideOrArchiveChannelData gcHideOrArchiveChannelData = null;
            //instance.GcHideOrArchiveChannel(channelUrl, apiToken, gcHideOrArchiveChannelData);
            
        }
        
        /// <summary>
        /// Test GcInviteAsMembers
        /// </summary>
        [Test]
        public void GcInviteAsMembersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string apiToken = null;
            //GcInviteAsMembersData gcInviteAsMembersData = null;
            //var response = instance.GcInviteAsMembers(channelUrl, apiToken, gcInviteAsMembersData);
            //Assert.IsInstanceOf(typeof(SendBirdGroupChannel), response, "response is SendBirdGroupChannel");
        }
        
        /// <summary>
        /// Test GcJoinChannel
        /// </summary>
        [Test]
        public void GcJoinChannelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string apiToken = null;
            //GcJoinChannelData gcJoinChannelData = null;
            //instance.GcJoinChannel(channelUrl, apiToken, gcJoinChannelData);
            
        }
        
        /// <summary>
        /// Test GcLeaveChannel
        /// </summary>
        [Test]
        public void GcLeaveChannelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string apiToken = null;
            //GcLeaveChannelData gcLeaveChannelData = null;
            //instance.GcLeaveChannel(channelUrl, apiToken, gcLeaveChannelData);
            
        }
        
        /// <summary>
        /// Test GcListBannedUsers
        /// </summary>
        [Test]
        public void GcListBannedUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string apiToken = null;
            //string token = null;
            //int? limit = null;
            //var response = instance.GcListBannedUsers(channelUrl, apiToken, token, limit);
            //Assert.IsInstanceOf(typeof(InlineResponse20033), response, "response is InlineResponse20033");
        }
        
        /// <summary>
        /// Test GcListChannels
        /// </summary>
        [Test]
        public void GcListChannelsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string token = null;
            //int? limit = null;
            //string distinctMode = null;
            //string publicMode = null;
            //string superMode = null;
            //int? createdAfter = null;
            //int? createdBefore = null;
            //bool? showEmpty = null;
            //bool? showMember = null;
            //bool? showDeliveryReceipt = null;
            //bool? showReadReceipt = null;
            //bool? showMetadata = null;
            //bool? showFrozen = null;
            //string order = null;
            //string metadataOrderKey = null;
            //string customTypes = null;
            //string customTypeStartswith = null;
            //string channelUrls = null;
            //string name = null;
            //string nameContains = null;
            //string nameStartswith = null;
            //string membersExactlyIn = null;
            //string membersIncludeIn = null;
            //string queryType = null;
            //string membersNickname = null;
            //string membersNicknameContains = null;
            //string metadataKey = null;
            //string metadataValues = null;
            //string metadataValueStartswith = null;
            //string metacounterKey = null;
            //string metacounterValues = null;
            //string metacounterValueGt = null;
            //string metacounterValueGte = null;
            //string metacounterValueLt = null;
            //string metacounterValueLte = null;
            //bool? includeSortedMetaarrayInLastMessage = null;
            //string customType = null;
            //bool? readReceipt = null;
            //bool? member = null;
            //bool? isDistinct = null;
            //string membersIn = null;
            //string userId = null;
            //var response = instance.GcListChannels(apiToken, token, limit, distinctMode, publicMode, superMode, createdAfter, createdBefore, showEmpty, showMember, showDeliveryReceipt, showReadReceipt, showMetadata, showFrozen, order, metadataOrderKey, customTypes, customTypeStartswith, channelUrls, name, nameContains, nameStartswith, membersExactlyIn, membersIncludeIn, queryType, membersNickname, membersNicknameContains, metadataKey, metadataValues, metadataValueStartswith, metacounterKey, metacounterValues, metacounterValueGt, metacounterValueGte, metacounterValueLt, metacounterValueLte, includeSortedMetaarrayInLastMessage, customType, readReceipt, member, isDistinct, membersIn, userId);
            //Assert.IsInstanceOf(typeof(InlineResponse20017), response, "response is InlineResponse20017");
        }
        
        /// <summary>
        /// Test GcListMembers
        /// </summary>
        [Test]
        public void GcListMembersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string apiToken = null;
            //string token = null;
            //int? limit = null;
            //bool? showDeliveryReceipt = null;
            //bool? showReadReceipt = null;
            //string order = null;
            //string operatorFilter = null;
            //string memberStateFilter = null;
            //string mutedMemberFilter = null;
            //string nicknameStartswith = null;
            //var response = instance.GcListMembers(channelUrl, apiToken, token, limit, showDeliveryReceipt, showReadReceipt, order, operatorFilter, memberStateFilter, mutedMemberFilter, nicknameStartswith);
            //Assert.IsInstanceOf(typeof(InlineResponse20036), response, "response is InlineResponse20036");
        }
        
        /// <summary>
        /// Test GcListMutedUsers
        /// </summary>
        [Test]
        public void GcListMutedUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string apiToken = null;
            //string token = null;
            //int? limit = null;
            //var response = instance.GcListMutedUsers(channelUrl, apiToken, token, limit);
            //Assert.IsInstanceOf(typeof(InlineResponse20031), response, "response is InlineResponse20031");
        }
        
        /// <summary>
        /// Test GcListOperators
        /// </summary>
        [Test]
        public void GcListOperatorsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string apiToken = null;
            //string token = null;
            //int? limit = null;
            //var response = instance.GcListOperators(channelUrl, apiToken, token, limit);
            //Assert.IsInstanceOf(typeof(InlineResponse20034), response, "response is InlineResponse20034");
        }
        
        /// <summary>
        /// Test GcMuteUser
        /// </summary>
        [Test]
        public void GcMuteUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string apiToken = null;
            //GcMuteUserData gcMuteUserData = null;
            //var response = instance.GcMuteUser(channelUrl, apiToken, gcMuteUserData);
            //Assert.IsInstanceOf(typeof(SendBirdGroupChannel), response, "response is SendBirdGroupChannel");
        }
        
        /// <summary>
        /// Test GcRegisterOperators
        /// </summary>
        [Test]
        public void GcRegisterOperatorsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string apiToken = null;
            //GcRegisterOperatorsData gcRegisterOperatorsData = null;
            //var response = instance.GcRegisterOperators(channelUrl, apiToken, gcRegisterOperatorsData);
            //Assert.IsInstanceOf(typeof(InlineResponse20038), response, "response is InlineResponse20038");
        }
        
        /// <summary>
        /// Test GcResetChatHistory
        /// </summary>
        [Test]
        public void GcResetChatHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string apiToken = null;
            //GcResetChatHistoryData gcResetChatHistoryData = null;
            //instance.GcResetChatHistory(channelUrl, apiToken, gcResetChatHistoryData);
            
        }
        
        /// <summary>
        /// Test GcUnbanUserById
        /// </summary>
        [Test]
        public void GcUnbanUserByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string bannedUserId = null;
            //string apiToken = null;
            //instance.GcUnbanUserById(channelUrl, bannedUserId, apiToken);
            
        }
        
        /// <summary>
        /// Test GcUnhideOrUnarchiveChannel
        /// </summary>
        [Test]
        public void GcUnhideOrUnarchiveChannelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string userId = null;
            //string apiToken = null;
            //bool? shouldUnhideAll = null;
            //instance.GcUnhideOrUnarchiveChannel(channelUrl, userId, apiToken, shouldUnhideAll);
            
        }
        
        /// <summary>
        /// Test GcUnmuteUserById
        /// </summary>
        [Test]
        public void GcUnmuteUserByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string mutedUserId = null;
            //string apiToken = null;
            //instance.GcUnmuteUserById(channelUrl, mutedUserId, apiToken);
            
        }
        
        /// <summary>
        /// Test GcUpdateBanById
        /// </summary>
        [Test]
        public void GcUpdateBanByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string bannedUserId = null;
            //string apiToken = null;
            //GcUpdateBanByIdData gcUpdateBanByIdData = null;
            //var response = instance.GcUpdateBanById(channelUrl, bannedUserId, apiToken, gcUpdateBanByIdData);
            //Assert.IsInstanceOf(typeof(SendBirdUser), response, "response is SendBirdUser");
        }
        
        /// <summary>
        /// Test GcUpdateChannelByUrl
        /// </summary>
        [Test]
        public void GcUpdateChannelByUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string apiToken = null;
            //GcUpdateChannelByUrlData gcUpdateChannelByUrlData = null;
            //var response = instance.GcUpdateChannelByUrl(channelUrl, apiToken, gcUpdateChannelByUrlData);
            //Assert.IsInstanceOf(typeof(SendBirdGroupChannel), response, "response is SendBirdGroupChannel");
        }
        
        /// <summary>
        /// Test GcViewBanById
        /// </summary>
        [Test]
        public void GcViewBanByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string bannedUserId = null;
            //string apiToken = null;
            //var response = instance.GcViewBanById(channelUrl, bannedUserId, apiToken);
            //Assert.IsInstanceOf(typeof(SendBirdUser), response, "response is SendBirdUser");
        }
        
        /// <summary>
        /// Test GcViewChannelByUrl
        /// </summary>
        [Test]
        public void GcViewChannelByUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string apiToken = null;
            //bool? showDeliveryReceipt = null;
            //bool? showReadReceipt = null;
            //bool? showMember = null;
            //bool? readReceipt = null;
            //bool? member = null;
            //var response = instance.GcViewChannelByUrl(channelUrl, apiToken, showDeliveryReceipt, showReadReceipt, showMember, readReceipt, member);
            //Assert.IsInstanceOf(typeof(SendBirdGroupChannel), response, "response is SendBirdGroupChannel");
        }
        
        /// <summary>
        /// Test GcViewMuteById
        /// </summary>
        [Test]
        public void GcViewMuteByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string mutedUserId = null;
            //string apiToken = null;
            //var response = instance.GcViewMuteById(channelUrl, mutedUserId, apiToken);
            //Assert.IsInstanceOf(typeof(InlineResponse20035), response, "response is InlineResponse20035");
        }
        
    }

}