/* 
 * Orkes Conductor API Server
 *
 * Orkes Conductor API Server
 *
 * OpenAPI spec version: v2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing AuthorizationResourceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AuthorizationResourceApiTests
    {
        private AuthorizationResourceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AuthorizationResourceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AuthorizationResourceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AuthorizationResourceApi
            //Assert.IsInstanceOfType(typeof(AuthorizationResourceApi), instance, "instance is a AuthorizationResourceApi");
        }

        /// <summary>
        /// Test GetPermissions
        /// </summary>
        [Test]
        public void GetPermissionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //string id = null;
            //var response = instance.GetPermissions(type, id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test GrantPermissions
        /// </summary>
        [Test]
        public void GrantPermissionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AuthorizationRequest body = null;
            //var response = instance.GrantPermissions(body);
            //Assert.IsInstanceOf<Response> (response, "response is Response");
        }
        /// <summary>
        /// Test RemovePermissions
        /// </summary>
        [Test]
        public void RemovePermissionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AuthorizationRequest body = null;
            //var response = instance.RemovePermissions(body);
            //Assert.IsInstanceOf<Response> (response, "response is Response");
        }
    }

}
