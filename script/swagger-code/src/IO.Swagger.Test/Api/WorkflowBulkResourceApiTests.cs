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
    ///  Class for testing WorkflowBulkResourceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class WorkflowBulkResourceApiTests
    {
        private WorkflowBulkResourceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WorkflowBulkResourceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WorkflowBulkResourceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' WorkflowBulkResourceApi
            //Assert.IsInstanceOfType(typeof(WorkflowBulkResourceApi), instance, "instance is a WorkflowBulkResourceApi");
        }

        /// <summary>
        /// Test PauseWorkflow1
        /// </summary>
        [Test]
        public void PauseWorkflow1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> body = null;
            //var response = instance.PauseWorkflow1(body);
            //Assert.IsInstanceOf<BulkResponse> (response, "response is BulkResponse");
        }
        /// <summary>
        /// Test Restart1
        /// </summary>
        [Test]
        public void Restart1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> body = null;
            //bool? useLatestDefinitions = null;
            //var response = instance.Restart1(body, useLatestDefinitions);
            //Assert.IsInstanceOf<BulkResponse> (response, "response is BulkResponse");
        }
        /// <summary>
        /// Test ResumeWorkflow1
        /// </summary>
        [Test]
        public void ResumeWorkflow1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> body = null;
            //var response = instance.ResumeWorkflow1(body);
            //Assert.IsInstanceOf<BulkResponse> (response, "response is BulkResponse");
        }
        /// <summary>
        /// Test Retry1
        /// </summary>
        [Test]
        public void Retry1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> body = null;
            //var response = instance.Retry1(body);
            //Assert.IsInstanceOf<BulkResponse> (response, "response is BulkResponse");
        }
        /// <summary>
        /// Test Terminate
        /// </summary>
        [Test]
        public void TerminateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> body = null;
            //string reason = null;
            //var response = instance.Terminate(body, reason);
            //Assert.IsInstanceOf<BulkResponse> (response, "response is BulkResponse");
        }
    }

}
