/*
 * Sendbird Platform SDK
 *
 * Sendbird Platform API SDK  https://sendbird.com/docs/chat/v3/platform-api/getting-started/prepare-to-use-api
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@sendbird.com
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

using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Model;

namespace sendbird_platform_sdk.Test
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
            //string apiToken = null;
            //string channelUrl = null;
            //GcAcceptInvitationData gcAcceptInvitationData = null;
            //var response = instance.GcAcceptInvitation(apiToken, channelUrl, gcAcceptInvitationData);
            //Assert.IsInstanceOf(typeof(SendBirdGroupChannel), response, "response is SendBirdGroupChannel");
        }
        
        /// <summary>
        /// Test GcCancelTheRegistrationOfOperators
        /// </summary>
        [Test]
        public void GcCancelTheRegistrationOfOperatorsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string channelUrl = null;
            //List<string> operatorIds = null;
            //bool? deleteAll = null;
            //var response = instance.GcCancelTheRegistrationOfOperators(apiToken, channelUrl, operatorIds, deleteAll);
            //Assert.IsInstanceOf(typeof(OcDeleteChannelByUrl200Response), response, "response is OcDeleteChannelByUrl200Response");
        }
        
        /// <summary>
        /// Test GcCheckIfMemberById
        /// </summary>
        [Test]
        public void GcCheckIfMemberByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string channelUrl = null;
            //string userId = null;
            //var response = instance.GcCheckIfMemberById(apiToken, channelUrl, userId);
            //Assert.IsInstanceOf(typeof(GcCheckIfMemberByIdResponse), response, "response is GcCheckIfMemberByIdResponse");
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
            //string apiToken = null;
            //string channelUrl = null;
            //GcDeclineInvitationData gcDeclineInvitationData = null;
            //var response = instance.GcDeclineInvitation(apiToken, channelUrl, gcDeclineInvitationData);
            //Assert.IsInstanceOf(typeof(OcDeleteChannelByUrl200Response), response, "response is OcDeleteChannelByUrl200Response");
        }
        
        /// <summary>
        /// Test GcDeleteChannelByUrl
        /// </summary>
        [Test]
        public void GcDeleteChannelByUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string channelUrl = null;
            //var response = instance.GcDeleteChannelByUrl(apiToken, channelUrl);
            //Assert.IsInstanceOf(typeof(OcDeleteChannelByUrl200Response), response, "response is OcDeleteChannelByUrl200Response");
        }
        
        /// <summary>
        /// Test GcHideOrArchiveChannel
        /// </summary>
        [Test]
        public void GcHideOrArchiveChannelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string channelUrl = null;
            //GcHideOrArchiveChannelData gcHideOrArchiveChannelData = null;
            //var response = instance.GcHideOrArchiveChannel(apiToken, channelUrl, gcHideOrArchiveChannelData);
            //Assert.IsInstanceOf(typeof(OcDeleteChannelByUrl200Response), response, "response is OcDeleteChannelByUrl200Response");
        }
        
        /// <summary>
        /// Test GcInviteAsMembers
        /// </summary>
        [Test]
        public void GcInviteAsMembersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string channelUrl = null;
            //GcInviteAsMembersData gcInviteAsMembersData = null;
            //var response = instance.GcInviteAsMembers(apiToken, channelUrl, gcInviteAsMembersData);
            //Assert.IsInstanceOf(typeof(SendBirdGroupChannel), response, "response is SendBirdGroupChannel");
        }
        
        /// <summary>
        /// Test GcJoinChannel
        /// </summary>
        [Test]
        public void GcJoinChannelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string channelUrl = null;
            //GcJoinChannelData gcJoinChannelData = null;
            //instance.GcJoinChannel(apiToken, channelUrl, gcJoinChannelData);
            
        }
        
        /// <summary>
        /// Test GcLeaveChannel
        /// </summary>
        [Test]
        public void GcLeaveChannelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string channelUrl = null;
            //GcLeaveChannelData gcLeaveChannelData = null;
            //var response = instance.GcLeaveChannel(apiToken, channelUrl, gcLeaveChannelData);
            //Assert.IsInstanceOf(typeof(OcDeleteChannelByUrl200Response), response, "response is OcDeleteChannelByUrl200Response");
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
            //Assert.IsInstanceOf(typeof(GcListChannelsResponse), response, "response is GcListChannelsResponse");
        }
        
        /// <summary>
        /// Test GcListMembers
        /// </summary>
        [Test]
        public void GcListMembersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string channelUrl = null;
            //string token = null;
            //int? limit = null;
            //bool? showDeliveryReceipt = null;
            //bool? showReadReceipt = null;
            //string order = null;
            //string operatorFilter = null;
            //string memberStateFilter = null;
            //string mutedMemberFilter = null;
            //string nicknameStartswith = null;
            //var response = instance.GcListMembers(apiToken, channelUrl, token, limit, showDeliveryReceipt, showReadReceipt, order, operatorFilter, memberStateFilter, mutedMemberFilter, nicknameStartswith);
            //Assert.IsInstanceOf(typeof(GcListMembersResponse), response, "response is GcListMembersResponse");
        }
        
        /// <summary>
        /// Test GcListOperators
        /// </summary>
        [Test]
        public void GcListOperatorsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string channelUrl = null;
            //string token = null;
            //int? limit = null;
            //var response = instance.GcListOperators(apiToken, channelUrl, token, limit);
            //Assert.IsInstanceOf(typeof(GcListOperatorsResponse), response, "response is GcListOperatorsResponse");
        }
        
        /// <summary>
        /// Test GcRegisterOperators
        /// </summary>
        [Test]
        public void GcRegisterOperatorsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string channelUrl = null;
            //GcRegisterOperatorsData gcRegisterOperatorsData = null;
            //var response = instance.GcRegisterOperators(apiToken, channelUrl, gcRegisterOperatorsData);
            //Assert.IsInstanceOf(typeof(GcRegisterOperatorsResponse), response, "response is GcRegisterOperatorsResponse");
        }
        
        /// <summary>
        /// Test GcResetChatHistory
        /// </summary>
        [Test]
        public void GcResetChatHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string channelUrl = null;
            //GcResetChatHistoryData gcResetChatHistoryData = null;
            //var response = instance.GcResetChatHistory(apiToken, channelUrl, gcResetChatHistoryData);
            //Assert.IsInstanceOf(typeof(GcResetChatHistoryResponse), response, "response is GcResetChatHistoryResponse");
        }
        
        /// <summary>
        /// Test GcUnhideOrUnarchiveChannel
        /// </summary>
        [Test]
        public void GcUnhideOrUnarchiveChannelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string channelUrl = null;
            //string userId = null;
            //bool? shouldUnhideAll = null;
            //var response = instance.GcUnhideOrUnarchiveChannel(apiToken, channelUrl, userId, shouldUnhideAll);
            //Assert.IsInstanceOf(typeof(OcDeleteChannelByUrl200Response), response, "response is OcDeleteChannelByUrl200Response");
        }
        
        /// <summary>
        /// Test GcUpdateChannelByUrl
        /// </summary>
        [Test]
        public void GcUpdateChannelByUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string channelUrl = null;
            //GcUpdateChannelByUrlData gcUpdateChannelByUrlData = null;
            //var response = instance.GcUpdateChannelByUrl(apiToken, channelUrl, gcUpdateChannelByUrlData);
            //Assert.IsInstanceOf(typeof(SendBirdGroupChannel), response, "response is SendBirdGroupChannel");
        }
        
        /// <summary>
        /// Test GcViewChannelByUrl
        /// </summary>
        [Test]
        public void GcViewChannelByUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string channelUrl = null;
            //bool? showDeliveryReceipt = null;
            //bool? showReadReceipt = null;
            //bool? showMember = null;
            //bool? readReceipt = null;
            //bool? member = null;
            //var response = instance.GcViewChannelByUrl(apiToken, channelUrl, showDeliveryReceipt, showReadReceipt, showMember, readReceipt, member);
            //Assert.IsInstanceOf(typeof(SendBirdGroupChannel), response, "response is SendBirdGroupChannel");
        }
        
    }

}
