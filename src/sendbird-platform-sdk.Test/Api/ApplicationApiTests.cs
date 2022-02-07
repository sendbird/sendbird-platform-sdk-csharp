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
using sendbird-platform-sdk.Api;
using sendbird-platform-sdk.Model;

namespace sendbird-platform-sdk.Test
{
    /// <summary>
    ///  Class for testing ApplicationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ApplicationApiTests
    {
        private ApplicationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ApplicationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ApplicationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ApplicationApi
            //Assert.IsInstanceOf(typeof(ApplicationApi), instance);
        }

        
        /// <summary>
        /// Test AddApnsPushConfiguration
        /// </summary>
        [Test]
        public void AddApnsPushConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //AddApnsPushConfigurationData addApnsPushConfigurationData = null;
            //var response = instance.AddApnsPushConfiguration(apiToken, addApnsPushConfigurationData);
            //Assert.IsInstanceOf(typeof(InlineResponse2003), response, "response is InlineResponse2003");
        }
        
        /// <summary>
        /// Test AddFcmPushConfiguration
        /// </summary>
        [Test]
        public void AddFcmPushConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //AddFcmPushConfigurationData addFcmPushConfigurationData = null;
            //var response = instance.AddFcmPushConfiguration(apiToken, addFcmPushConfigurationData);
            //Assert.IsInstanceOf(typeof(InlineResponse2001), response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test AddHmsPushConfiguration
        /// </summary>
        [Test]
        public void AddHmsPushConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //AddHmsPushConfigurationData addHmsPushConfigurationData = null;
            //var response = instance.AddHmsPushConfiguration(apiToken, addHmsPushConfigurationData);
            //Assert.IsInstanceOf(typeof(InlineResponse2002), response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test AddIpToWhitelist
        /// </summary>
        [Test]
        public void AddIpToWhitelistTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //AddIpToWhitelistData addIpToWhitelistData = null;
            //var response = instance.AddIpToWhitelist(apiToken, addIpToWhitelistData);
            //Assert.IsInstanceOf(typeof(InlineResponse2006), response, "response is InlineResponse2006");
        }
        
        /// <summary>
        /// Test DeleteAllowedIpsFromWhitelist
        /// </summary>
        [Test]
        public void DeleteAllowedIpsFromWhitelistTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> ipWhitelistAddresses = null;
            //string apiToken = null;
            //var response = instance.DeleteAllowedIpsFromWhitelist(ipWhitelistAddresses, apiToken);
            //Assert.IsInstanceOf(typeof(InlineResponse2006), response, "response is InlineResponse2006");
        }
        
        /// <summary>
        /// Test DeleteApnsCertificateById
        /// </summary>
        [Test]
        public void DeleteApnsCertificateByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string providerId = null;
            //string apiToken = null;
            //var response = instance.DeleteApnsCertificateById(providerId, apiToken);
            //Assert.IsInstanceOf(typeof(InlineResponse20013), response, "response is InlineResponse20013");
        }
        
        /// <summary>
        /// Test GenerateSecondaryApiToken
        /// </summary>
        [Test]
        public void GenerateSecondaryApiTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //GenerateSecondaryApiTokenData generateSecondaryApiTokenData = null;
            //var response = instance.GenerateSecondaryApiToken(apiToken, generateSecondaryApiTokenData);
            //Assert.IsInstanceOf(typeof(InlineResponse2007), response, "response is InlineResponse2007");
        }
        
        /// <summary>
        /// Test ListPushConfigurations
        /// </summary>
        [Test]
        public void ListPushConfigurationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pushType = null;
            //string apiToken = null;
            //var response = instance.ListPushConfigurations(pushType, apiToken);
            //Assert.IsInstanceOf(typeof(InlineResponse20012), response, "response is InlineResponse20012");
        }
        
        /// <summary>
        /// Test ListPushNotificationContentTemplates
        /// </summary>
        [Test]
        public void ListPushNotificationContentTemplatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //var response = instance.ListPushNotificationContentTemplates(apiToken);
            //Assert.IsInstanceOf(typeof(InlineResponse2004), response, "response is InlineResponse2004");
        }
        
        /// <summary>
        /// Test ListSecondaryApiTokens
        /// </summary>
        [Test]
        public void ListSecondaryApiTokensTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //var response = instance.ListSecondaryApiTokens(apiToken);
            //Assert.IsInstanceOf(typeof(InlineResponse2008), response, "response is InlineResponse2008");
        }
        
        /// <summary>
        /// Test RemovePushConfigurationById
        /// </summary>
        [Test]
        public void RemovePushConfigurationByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pushType = null;
            //string providerId = null;
            //string apiToken = null;
            //var response = instance.RemovePushConfigurationById(pushType, providerId, apiToken);
            //Assert.IsInstanceOf(typeof(InlineResponse20013), response, "response is InlineResponse20013");
        }
        
        /// <summary>
        /// Test RetrieveIpWhitelist
        /// </summary>
        [Test]
        public void RetrieveIpWhitelistTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //var response = instance.RetrieveIpWhitelist(apiToken);
            //Assert.IsInstanceOf(typeof(InlineResponse2006), response, "response is InlineResponse2006");
        }
        
        /// <summary>
        /// Test RevokeSecondaryApiTokenByToken
        /// </summary>
        [Test]
        public void RevokeSecondaryApiTokenByTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken2 = null;
            //string apiToken = null;
            //var response = instance.RevokeSecondaryApiTokenByToken(apiToken2, apiToken);
            //Assert.IsInstanceOf(typeof(InlineResponse2007), response, "response is InlineResponse2007");
        }
        
        /// <summary>
        /// Test UpdateApnsPushConfigurationById
        /// </summary>
        [Test]
        public void UpdateApnsPushConfigurationByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string providerId = null;
            //string apiToken = null;
            //UpdateApnsPushConfigurationByIdData updateApnsPushConfigurationByIdData = null;
            //var response = instance.UpdateApnsPushConfigurationById(providerId, apiToken, updateApnsPushConfigurationByIdData);
            //Assert.IsInstanceOf(typeof(InlineResponse20014), response, "response is InlineResponse20014");
        }
        
        /// <summary>
        /// Test UpdateDefaultChannelInvitationPreference
        /// </summary>
        [Test]
        public void UpdateDefaultChannelInvitationPreferenceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //UpdateDefaultChannelInvitationPreferenceData updateDefaultChannelInvitationPreferenceData = null;
            //var response = instance.UpdateDefaultChannelInvitationPreference(apiToken, updateDefaultChannelInvitationPreferenceData);
            //Assert.IsInstanceOf(typeof(InlineResponse2005), response, "response is InlineResponse2005");
        }
        
        /// <summary>
        /// Test UpdateFcmPushConfigurationById
        /// </summary>
        [Test]
        public void UpdateFcmPushConfigurationByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string providerId = null;
            //string apiToken = null;
            //UpdateFcmPushConfigurationByIdData updateFcmPushConfigurationByIdData = null;
            //var response = instance.UpdateFcmPushConfigurationById(providerId, apiToken, updateFcmPushConfigurationByIdData);
            //Assert.IsInstanceOf(typeof(InlineResponse20014), response, "response is InlineResponse20014");
        }
        
        /// <summary>
        /// Test UpdateHmsPushConfigurationById
        /// </summary>
        [Test]
        public void UpdateHmsPushConfigurationByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string providerId = null;
            //string apiToken = null;
            //UpdateHmsPushConfigurationByIdData updateHmsPushConfigurationByIdData = null;
            //var response = instance.UpdateHmsPushConfigurationById(providerId, apiToken, updateHmsPushConfigurationByIdData);
            //Assert.IsInstanceOf(typeof(InlineResponse20014), response, "response is InlineResponse20014");
        }
        
        /// <summary>
        /// Test UpdatePushNotificationContentTemplate
        /// </summary>
        [Test]
        public void UpdatePushNotificationContentTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string templateName = null;
            //string apiToken = null;
            //UpdatePushNotificationContentTemplateData updatePushNotificationContentTemplateData = null;
            //var response = instance.UpdatePushNotificationContentTemplate(templateName, apiToken, updatePushNotificationContentTemplateData);
            //Assert.IsInstanceOf(typeof(InlineResponse20015), response, "response is InlineResponse20015");
        }
        
        /// <summary>
        /// Test ViewDefaultChannelInvitationPreference
        /// </summary>
        [Test]
        public void ViewDefaultChannelInvitationPreferenceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //var response = instance.ViewDefaultChannelInvitationPreference(apiToken);
            //Assert.IsInstanceOf(typeof(InlineResponse2005), response, "response is InlineResponse2005");
        }
        
        /// <summary>
        /// Test ViewNumberOfConcurrentConnections
        /// </summary>
        [Test]
        public void ViewNumberOfConcurrentConnectionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //var response = instance.ViewNumberOfConcurrentConnections(apiToken);
            //Assert.IsInstanceOf(typeof(InlineResponse200), response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test ViewNumberOfDailyActiveUsers
        /// </summary>
        [Test]
        public void ViewNumberOfDailyActiveUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string date = null;
            //var response = instance.ViewNumberOfDailyActiveUsers(apiToken, date);
            //Assert.IsInstanceOf(typeof(InlineResponse20011), response, "response is InlineResponse20011");
        }
        
        /// <summary>
        /// Test ViewNumberOfMonthlyActiveUsers
        /// </summary>
        [Test]
        public void ViewNumberOfMonthlyActiveUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string date = null;
            //var response = instance.ViewNumberOfMonthlyActiveUsers(apiToken, date);
            //Assert.IsInstanceOf(typeof(InlineResponse20010), response, "response is InlineResponse20010");
        }
        
        /// <summary>
        /// Test ViewNumberOfPeakConnections
        /// </summary>
        [Test]
        public void ViewNumberOfPeakConnectionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string timeDimension = null;
            //int startYear = null;
            //int startMonth = null;
            //int endYear = null;
            //int endMonth = null;
            //string apiToken = null;
            //int? startDay = null;
            //int? endDay = null;
            //var response = instance.ViewNumberOfPeakConnections(timeDimension, startYear, startMonth, endYear, endMonth, apiToken, startDay, endDay);
            //Assert.IsInstanceOf(typeof(InlineResponse2009), response, "response is InlineResponse2009");
        }
        
        /// <summary>
        /// Test ViewPushConfigurationById
        /// </summary>
        [Test]
        public void ViewPushConfigurationByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pushType = null;
            //string providerId = null;
            //string apiToken = null;
            //var response = instance.ViewPushConfigurationById(pushType, providerId, apiToken);
            //Assert.IsInstanceOf(typeof(InlineResponse20012), response, "response is InlineResponse20012");
        }
        
        /// <summary>
        /// Test ViewPushNotificationContentTemplate
        /// </summary>
        [Test]
        public void ViewPushNotificationContentTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string templateName = null;
            //string apiToken = null;
            //var response = instance.ViewPushNotificationContentTemplate(templateName, apiToken);
            //Assert.IsInstanceOf(typeof(InlineResponse20015), response, "response is InlineResponse20015");
        }
        
        /// <summary>
        /// Test ViewSecondaryApiTokenByToken
        /// </summary>
        [Test]
        public void ViewSecondaryApiTokenByTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken2 = null;
            //string apiToken = null;
            //var response = instance.ViewSecondaryApiTokenByToken(apiToken2, apiToken);
            //Assert.IsInstanceOf(typeof(InlineResponse2007), response, "response is InlineResponse2007");
        }
        
    }

}
