/*
 * Conductor API Server
 *
 * Conductor API Server
 *
 * The version of the OpenAPI document: v0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;
using Org.OpenAPITools.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Test.Model
{
    /// <summary>
    ///  Class for testing Task
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TaskTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Task
        //private Task instance;

        public TaskTests()
        {
            // TODO uncomment below to create an instance of Task
            //instance = new Task();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Task
        /// </summary>
        [Fact]
        public void TaskInstanceTest()
        {
            // TODO uncomment below to test "IsType" Task
            //Assert.IsType<Task>(instance);
        }


        /// <summary>
        /// Test the property 'TaskType'
        /// </summary>
        [Fact]
        public void TaskTypeTest()
        {
            // TODO unit test for the property 'TaskType'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'InputData'
        /// </summary>
        [Fact]
        public void InputDataTest()
        {
            // TODO unit test for the property 'InputData'
        }
        /// <summary>
        /// Test the property 'ReferenceTaskName'
        /// </summary>
        [Fact]
        public void ReferenceTaskNameTest()
        {
            // TODO unit test for the property 'ReferenceTaskName'
        }
        /// <summary>
        /// Test the property 'RetryCount'
        /// </summary>
        [Fact]
        public void RetryCountTest()
        {
            // TODO unit test for the property 'RetryCount'
        }
        /// <summary>
        /// Test the property 'Seq'
        /// </summary>
        [Fact]
        public void SeqTest()
        {
            // TODO unit test for the property 'Seq'
        }
        /// <summary>
        /// Test the property 'CorrelationId'
        /// </summary>
        [Fact]
        public void CorrelationIdTest()
        {
            // TODO unit test for the property 'CorrelationId'
        }
        /// <summary>
        /// Test the property 'PollCount'
        /// </summary>
        [Fact]
        public void PollCountTest()
        {
            // TODO unit test for the property 'PollCount'
        }
        /// <summary>
        /// Test the property 'TaskDefName'
        /// </summary>
        [Fact]
        public void TaskDefNameTest()
        {
            // TODO unit test for the property 'TaskDefName'
        }
        /// <summary>
        /// Test the property 'ScheduledTime'
        /// </summary>
        [Fact]
        public void ScheduledTimeTest()
        {
            // TODO unit test for the property 'ScheduledTime'
        }
        /// <summary>
        /// Test the property 'StartTime'
        /// </summary>
        [Fact]
        public void StartTimeTest()
        {
            // TODO unit test for the property 'StartTime'
        }
        /// <summary>
        /// Test the property 'EndTime'
        /// </summary>
        [Fact]
        public void EndTimeTest()
        {
            // TODO unit test for the property 'EndTime'
        }
        /// <summary>
        /// Test the property 'UpdateTime'
        /// </summary>
        [Fact]
        public void UpdateTimeTest()
        {
            // TODO unit test for the property 'UpdateTime'
        }
        /// <summary>
        /// Test the property 'StartDelayInSeconds'
        /// </summary>
        [Fact]
        public void StartDelayInSecondsTest()
        {
            // TODO unit test for the property 'StartDelayInSeconds'
        }
        /// <summary>
        /// Test the property 'RetriedTaskId'
        /// </summary>
        [Fact]
        public void RetriedTaskIdTest()
        {
            // TODO unit test for the property 'RetriedTaskId'
        }
        /// <summary>
        /// Test the property 'Retried'
        /// </summary>
        [Fact]
        public void RetriedTest()
        {
            // TODO unit test for the property 'Retried'
        }
        /// <summary>
        /// Test the property 'Executed'
        /// </summary>
        [Fact]
        public void ExecutedTest()
        {
            // TODO unit test for the property 'Executed'
        }
        /// <summary>
        /// Test the property 'CallbackFromWorker'
        /// </summary>
        [Fact]
        public void CallbackFromWorkerTest()
        {
            // TODO unit test for the property 'CallbackFromWorker'
        }
        /// <summary>
        /// Test the property 'ResponseTimeoutSeconds'
        /// </summary>
        [Fact]
        public void ResponseTimeoutSecondsTest()
        {
            // TODO unit test for the property 'ResponseTimeoutSeconds'
        }
        /// <summary>
        /// Test the property 'WorkflowInstanceId'
        /// </summary>
        [Fact]
        public void WorkflowInstanceIdTest()
        {
            // TODO unit test for the property 'WorkflowInstanceId'
        }
        /// <summary>
        /// Test the property 'WorkflowType'
        /// </summary>
        [Fact]
        public void WorkflowTypeTest()
        {
            // TODO unit test for the property 'WorkflowType'
        }
        /// <summary>
        /// Test the property 'TaskId'
        /// </summary>
        [Fact]
        public void TaskIdTest()
        {
            // TODO unit test for the property 'TaskId'
        }
        /// <summary>
        /// Test the property 'ReasonForIncompletion'
        /// </summary>
        [Fact]
        public void ReasonForIncompletionTest()
        {
            // TODO unit test for the property 'ReasonForIncompletion'
        }
        /// <summary>
        /// Test the property 'CallbackAfterSeconds'
        /// </summary>
        [Fact]
        public void CallbackAfterSecondsTest()
        {
            // TODO unit test for the property 'CallbackAfterSeconds'
        }
        /// <summary>
        /// Test the property 'WorkerId'
        /// </summary>
        [Fact]
        public void WorkerIdTest()
        {
            // TODO unit test for the property 'WorkerId'
        }
        /// <summary>
        /// Test the property 'OutputData'
        /// </summary>
        [Fact]
        public void OutputDataTest()
        {
            // TODO unit test for the property 'OutputData'
        }
        /// <summary>
        /// Test the property 'WorkflowTask'
        /// </summary>
        [Fact]
        public void WorkflowTaskTest()
        {
            // TODO unit test for the property 'WorkflowTask'
        }
        /// <summary>
        /// Test the property 'Domain'
        /// </summary>
        [Fact]
        public void DomainTest()
        {
            // TODO unit test for the property 'Domain'
        }
        /// <summary>
        /// Test the property 'RateLimitPerFrequency'
        /// </summary>
        [Fact]
        public void RateLimitPerFrequencyTest()
        {
            // TODO unit test for the property 'RateLimitPerFrequency'
        }
        /// <summary>
        /// Test the property 'RateLimitFrequencyInSeconds'
        /// </summary>
        [Fact]
        public void RateLimitFrequencyInSecondsTest()
        {
            // TODO unit test for the property 'RateLimitFrequencyInSeconds'
        }
        /// <summary>
        /// Test the property 'ExternalInputPayloadStoragePath'
        /// </summary>
        [Fact]
        public void ExternalInputPayloadStoragePathTest()
        {
            // TODO unit test for the property 'ExternalInputPayloadStoragePath'
        }
        /// <summary>
        /// Test the property 'ExternalOutputPayloadStoragePath'
        /// </summary>
        [Fact]
        public void ExternalOutputPayloadStoragePathTest()
        {
            // TODO unit test for the property 'ExternalOutputPayloadStoragePath'
        }
        /// <summary>
        /// Test the property 'WorkflowPriority'
        /// </summary>
        [Fact]
        public void WorkflowPriorityTest()
        {
            // TODO unit test for the property 'WorkflowPriority'
        }
        /// <summary>
        /// Test the property 'ExecutionNameSpace'
        /// </summary>
        [Fact]
        public void ExecutionNameSpaceTest()
        {
            // TODO unit test for the property 'ExecutionNameSpace'
        }
        /// <summary>
        /// Test the property 'IsolationGroupId'
        /// </summary>
        [Fact]
        public void IsolationGroupIdTest()
        {
            // TODO unit test for the property 'IsolationGroupId'
        }
        /// <summary>
        /// Test the property 'Iteration'
        /// </summary>
        [Fact]
        public void IterationTest()
        {
            // TODO unit test for the property 'Iteration'
        }
        /// <summary>
        /// Test the property 'SubWorkflowId'
        /// </summary>
        [Fact]
        public void SubWorkflowIdTest()
        {
            // TODO unit test for the property 'SubWorkflowId'
        }
        /// <summary>
        /// Test the property 'SubworkflowChanged'
        /// </summary>
        [Fact]
        public void SubworkflowChangedTest()
        {
            // TODO unit test for the property 'SubworkflowChanged'
        }
        /// <summary>
        /// Test the property 'TaskDefinition'
        /// </summary>
        [Fact]
        public void TaskDefinitionTest()
        {
            // TODO unit test for the property 'TaskDefinition'
        }
        /// <summary>
        /// Test the property 'LoopOverTask'
        /// </summary>
        [Fact]
        public void LoopOverTaskTest()
        {
            // TODO unit test for the property 'LoopOverTask'
        }
        /// <summary>
        /// Test the property 'QueueWaitTime'
        /// </summary>
        [Fact]
        public void QueueWaitTimeTest()
        {
            // TODO unit test for the property 'QueueWaitTime'
        }

    }

}
