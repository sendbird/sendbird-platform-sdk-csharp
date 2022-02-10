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

using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Model;

namespace sendbird_platform_sdk.Test
{
    /// <summary>
    ///  Class for testing AdvancedAnalyticsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AdvancedAnalyticsApiTests
    {
        private AdvancedAnalyticsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AdvancedAnalyticsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AdvancedAnalyticsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' AdvancedAnalyticsApi
            //Assert.IsInstanceOf(typeof(AdvancedAnalyticsApi), instance);
        }

        
        /// <summary>
        /// Test RetrieveAdvancedAnalyticsMetrics
        /// </summary>
        [Test]
        public void RetrieveAdvancedAnalyticsMetricsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //var response = instance.RetrieveAdvancedAnalyticsMetrics(apiToken);
            //Assert.IsInstanceOf(typeof(RetrieveAdvancedAnalyticsMetricsResponse), response, "response is RetrieveAdvancedAnalyticsMetricsResponse");
        }
        
    }

}
