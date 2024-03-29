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
    ///  Class for testing WebhookApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WebhookApiTests
    {
        private WebhookApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WebhookApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WebhookApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' WebhookApi
            //Assert.IsInstanceOf(typeof(WebhookApi), instance);
        }

        
        /// <summary>
        /// Test ChooseWhichEventsToSubscribeTo
        /// </summary>
        [Test]
        public void ChooseWhichEventsToSubscribeToTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //ChooseWhichEventsToSubscribeToData chooseWhichEventsToSubscribeToData = null;
            //var response = instance.ChooseWhichEventsToSubscribeTo(apiToken, chooseWhichEventsToSubscribeToData);
            //Assert.IsInstanceOf(typeof(ChooseWhichEventsToSubscribeToResponse), response, "response is ChooseWhichEventsToSubscribeToResponse");
        }
        
        /// <summary>
        /// Test RetrieveListOfSubscribedEvents
        /// </summary>
        [Test]
        public void RetrieveListOfSubscribedEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //bool? displayAllWebhookCategories = null;
            //var response = instance.RetrieveListOfSubscribedEvents(apiToken, displayAllWebhookCategories);
            //Assert.IsInstanceOf(typeof(RetrieveListOfSubscribedEventsResponse), response, "response is RetrieveListOfSubscribedEventsResponse");
        }
        
    }

}
