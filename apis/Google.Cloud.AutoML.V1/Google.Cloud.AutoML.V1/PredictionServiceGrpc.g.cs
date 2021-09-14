// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/automl/v1/prediction_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.AutoML.V1 {
  /// <summary>
  /// AutoML Prediction API.
  ///
  /// On any input that is documented to expect a string parameter in
  /// snake_case or kebab-case, either of those cases is accepted.
  /// </summary>
  public static partial class PredictionService
  {
    static readonly string __ServiceName = "google.cloud.automl.v1.PredictionService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.AutoML.V1.PredictRequest> __Marshaller_google_cloud_automl_v1_PredictRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AutoML.V1.PredictRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.AutoML.V1.PredictResponse> __Marshaller_google_cloud_automl_v1_PredictResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AutoML.V1.PredictResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.AutoML.V1.BatchPredictRequest> __Marshaller_google_cloud_automl_v1_BatchPredictRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AutoML.V1.BatchPredictRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.LongRunning.Operation> __Marshaller_google_longrunning_Operation = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.LongRunning.Operation.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.AutoML.V1.PredictRequest, global::Google.Cloud.AutoML.V1.PredictResponse> __Method_Predict = new grpc::Method<global::Google.Cloud.AutoML.V1.PredictRequest, global::Google.Cloud.AutoML.V1.PredictResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Predict",
        __Marshaller_google_cloud_automl_v1_PredictRequest,
        __Marshaller_google_cloud_automl_v1_PredictResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.AutoML.V1.BatchPredictRequest, global::Google.LongRunning.Operation> __Method_BatchPredict = new grpc::Method<global::Google.Cloud.AutoML.V1.BatchPredictRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "BatchPredict",
        __Marshaller_google_cloud_automl_v1_BatchPredictRequest,
        __Marshaller_google_longrunning_Operation);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.AutoML.V1.PredictionServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PredictionService</summary>
    [grpc::BindServiceMethod(typeof(PredictionService), "BindService")]
    public abstract partial class PredictionServiceBase
    {
      /// <summary>
      /// Perform an online prediction. The prediction result is directly
      /// returned in the response.
      /// Available for following ML scenarios, and their expected request payloads:
      ///
      /// AutoML Vision Classification
      ///
      /// * An image in .JPEG, .GIF or .PNG format, image_bytes up to 30MB.
      ///
      /// AutoML Vision Object Detection
      ///
      /// * An image in .JPEG, .GIF or .PNG format, image_bytes up to 30MB.
      ///
      /// AutoML Natural Language Classification
      ///
      /// * A TextSnippet up to 60,000 characters, UTF-8 encoded or a document in
      /// .PDF, .TIF or .TIFF format with size upto 2MB.
      ///
      /// AutoML Natural Language Entity Extraction
      ///
      /// * A TextSnippet up to 10,000 characters, UTF-8 NFC encoded or a document
      ///  in .PDF, .TIF or .TIFF format with size upto 20MB.
      ///
      /// AutoML Natural Language Sentiment Analysis
      ///
      /// * A TextSnippet up to 60,000 characters, UTF-8 encoded or a document in
      /// .PDF, .TIF or .TIFF format with size upto 2MB.
      ///
      /// AutoML Translation
      ///
      /// * A TextSnippet up to 25,000 characters, UTF-8 encoded.
      ///
      /// AutoML Tables
      ///
      /// * A row with column values matching
      ///   the columns of the model, up to 5MB. Not available for FORECASTING
      ///   `prediction_type`.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.AutoML.V1.PredictResponse> Predict(global::Google.Cloud.AutoML.V1.PredictRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Perform a batch prediction. Unlike the online [Predict][google.cloud.automl.v1.PredictionService.Predict], batch
      /// prediction result won't be immediately available in the response. Instead,
      /// a long running operation object is returned. User can poll the operation
      /// result via [GetOperation][google.longrunning.Operations.GetOperation]
      /// method. Once the operation is done, [BatchPredictResult][google.cloud.automl.v1.BatchPredictResult] is returned in
      /// the [response][google.longrunning.Operation.response] field.
      /// Available for following ML scenarios:
      ///
      /// * AutoML Vision Classification
      /// * AutoML Vision Object Detection
      /// * AutoML Video Intelligence Classification
      /// * AutoML Video Intelligence Object Tracking * AutoML Natural Language Classification
      /// * AutoML Natural Language Entity Extraction
      /// * AutoML Natural Language Sentiment Analysis
      /// * AutoML Tables
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> BatchPredict(global::Google.Cloud.AutoML.V1.BatchPredictRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for PredictionService</summary>
    public partial class PredictionServiceClient : grpc::ClientBase<PredictionServiceClient>
    {
      /// <summary>Creates a new client for PredictionService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public PredictionServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PredictionService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public PredictionServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected PredictionServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected PredictionServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Perform an online prediction. The prediction result is directly
      /// returned in the response.
      /// Available for following ML scenarios, and their expected request payloads:
      ///
      /// AutoML Vision Classification
      ///
      /// * An image in .JPEG, .GIF or .PNG format, image_bytes up to 30MB.
      ///
      /// AutoML Vision Object Detection
      ///
      /// * An image in .JPEG, .GIF or .PNG format, image_bytes up to 30MB.
      ///
      /// AutoML Natural Language Classification
      ///
      /// * A TextSnippet up to 60,000 characters, UTF-8 encoded or a document in
      /// .PDF, .TIF or .TIFF format with size upto 2MB.
      ///
      /// AutoML Natural Language Entity Extraction
      ///
      /// * A TextSnippet up to 10,000 characters, UTF-8 NFC encoded or a document
      ///  in .PDF, .TIF or .TIFF format with size upto 20MB.
      ///
      /// AutoML Natural Language Sentiment Analysis
      ///
      /// * A TextSnippet up to 60,000 characters, UTF-8 encoded or a document in
      /// .PDF, .TIF or .TIFF format with size upto 2MB.
      ///
      /// AutoML Translation
      ///
      /// * A TextSnippet up to 25,000 characters, UTF-8 encoded.
      ///
      /// AutoML Tables
      ///
      /// * A row with column values matching
      ///   the columns of the model, up to 5MB. Not available for FORECASTING
      ///   `prediction_type`.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.AutoML.V1.PredictResponse Predict(global::Google.Cloud.AutoML.V1.PredictRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Predict(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Perform an online prediction. The prediction result is directly
      /// returned in the response.
      /// Available for following ML scenarios, and their expected request payloads:
      ///
      /// AutoML Vision Classification
      ///
      /// * An image in .JPEG, .GIF or .PNG format, image_bytes up to 30MB.
      ///
      /// AutoML Vision Object Detection
      ///
      /// * An image in .JPEG, .GIF or .PNG format, image_bytes up to 30MB.
      ///
      /// AutoML Natural Language Classification
      ///
      /// * A TextSnippet up to 60,000 characters, UTF-8 encoded or a document in
      /// .PDF, .TIF or .TIFF format with size upto 2MB.
      ///
      /// AutoML Natural Language Entity Extraction
      ///
      /// * A TextSnippet up to 10,000 characters, UTF-8 NFC encoded or a document
      ///  in .PDF, .TIF or .TIFF format with size upto 20MB.
      ///
      /// AutoML Natural Language Sentiment Analysis
      ///
      /// * A TextSnippet up to 60,000 characters, UTF-8 encoded or a document in
      /// .PDF, .TIF or .TIFF format with size upto 2MB.
      ///
      /// AutoML Translation
      ///
      /// * A TextSnippet up to 25,000 characters, UTF-8 encoded.
      ///
      /// AutoML Tables
      ///
      /// * A row with column values matching
      ///   the columns of the model, up to 5MB. Not available for FORECASTING
      ///   `prediction_type`.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.AutoML.V1.PredictResponse Predict(global::Google.Cloud.AutoML.V1.PredictRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Predict, null, options, request);
      }
      /// <summary>
      /// Perform an online prediction. The prediction result is directly
      /// returned in the response.
      /// Available for following ML scenarios, and their expected request payloads:
      ///
      /// AutoML Vision Classification
      ///
      /// * An image in .JPEG, .GIF or .PNG format, image_bytes up to 30MB.
      ///
      /// AutoML Vision Object Detection
      ///
      /// * An image in .JPEG, .GIF or .PNG format, image_bytes up to 30MB.
      ///
      /// AutoML Natural Language Classification
      ///
      /// * A TextSnippet up to 60,000 characters, UTF-8 encoded or a document in
      /// .PDF, .TIF or .TIFF format with size upto 2MB.
      ///
      /// AutoML Natural Language Entity Extraction
      ///
      /// * A TextSnippet up to 10,000 characters, UTF-8 NFC encoded or a document
      ///  in .PDF, .TIF or .TIFF format with size upto 20MB.
      ///
      /// AutoML Natural Language Sentiment Analysis
      ///
      /// * A TextSnippet up to 60,000 characters, UTF-8 encoded or a document in
      /// .PDF, .TIF or .TIFF format with size upto 2MB.
      ///
      /// AutoML Translation
      ///
      /// * A TextSnippet up to 25,000 characters, UTF-8 encoded.
      ///
      /// AutoML Tables
      ///
      /// * A row with column values matching
      ///   the columns of the model, up to 5MB. Not available for FORECASTING
      ///   `prediction_type`.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.AutoML.V1.PredictResponse> PredictAsync(global::Google.Cloud.AutoML.V1.PredictRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PredictAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Perform an online prediction. The prediction result is directly
      /// returned in the response.
      /// Available for following ML scenarios, and their expected request payloads:
      ///
      /// AutoML Vision Classification
      ///
      /// * An image in .JPEG, .GIF or .PNG format, image_bytes up to 30MB.
      ///
      /// AutoML Vision Object Detection
      ///
      /// * An image in .JPEG, .GIF or .PNG format, image_bytes up to 30MB.
      ///
      /// AutoML Natural Language Classification
      ///
      /// * A TextSnippet up to 60,000 characters, UTF-8 encoded or a document in
      /// .PDF, .TIF or .TIFF format with size upto 2MB.
      ///
      /// AutoML Natural Language Entity Extraction
      ///
      /// * A TextSnippet up to 10,000 characters, UTF-8 NFC encoded or a document
      ///  in .PDF, .TIF or .TIFF format with size upto 20MB.
      ///
      /// AutoML Natural Language Sentiment Analysis
      ///
      /// * A TextSnippet up to 60,000 characters, UTF-8 encoded or a document in
      /// .PDF, .TIF or .TIFF format with size upto 2MB.
      ///
      /// AutoML Translation
      ///
      /// * A TextSnippet up to 25,000 characters, UTF-8 encoded.
      ///
      /// AutoML Tables
      ///
      /// * A row with column values matching
      ///   the columns of the model, up to 5MB. Not available for FORECASTING
      ///   `prediction_type`.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.AutoML.V1.PredictResponse> PredictAsync(global::Google.Cloud.AutoML.V1.PredictRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Predict, null, options, request);
      }
      /// <summary>
      /// Perform a batch prediction. Unlike the online [Predict][google.cloud.automl.v1.PredictionService.Predict], batch
      /// prediction result won't be immediately available in the response. Instead,
      /// a long running operation object is returned. User can poll the operation
      /// result via [GetOperation][google.longrunning.Operations.GetOperation]
      /// method. Once the operation is done, [BatchPredictResult][google.cloud.automl.v1.BatchPredictResult] is returned in
      /// the [response][google.longrunning.Operation.response] field.
      /// Available for following ML scenarios:
      ///
      /// * AutoML Vision Classification
      /// * AutoML Vision Object Detection
      /// * AutoML Video Intelligence Classification
      /// * AutoML Video Intelligence Object Tracking * AutoML Natural Language Classification
      /// * AutoML Natural Language Entity Extraction
      /// * AutoML Natural Language Sentiment Analysis
      /// * AutoML Tables
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation BatchPredict(global::Google.Cloud.AutoML.V1.BatchPredictRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return BatchPredict(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Perform a batch prediction. Unlike the online [Predict][google.cloud.automl.v1.PredictionService.Predict], batch
      /// prediction result won't be immediately available in the response. Instead,
      /// a long running operation object is returned. User can poll the operation
      /// result via [GetOperation][google.longrunning.Operations.GetOperation]
      /// method. Once the operation is done, [BatchPredictResult][google.cloud.automl.v1.BatchPredictResult] is returned in
      /// the [response][google.longrunning.Operation.response] field.
      /// Available for following ML scenarios:
      ///
      /// * AutoML Vision Classification
      /// * AutoML Vision Object Detection
      /// * AutoML Video Intelligence Classification
      /// * AutoML Video Intelligence Object Tracking * AutoML Natural Language Classification
      /// * AutoML Natural Language Entity Extraction
      /// * AutoML Natural Language Sentiment Analysis
      /// * AutoML Tables
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation BatchPredict(global::Google.Cloud.AutoML.V1.BatchPredictRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_BatchPredict, null, options, request);
      }
      /// <summary>
      /// Perform a batch prediction. Unlike the online [Predict][google.cloud.automl.v1.PredictionService.Predict], batch
      /// prediction result won't be immediately available in the response. Instead,
      /// a long running operation object is returned. User can poll the operation
      /// result via [GetOperation][google.longrunning.Operations.GetOperation]
      /// method. Once the operation is done, [BatchPredictResult][google.cloud.automl.v1.BatchPredictResult] is returned in
      /// the [response][google.longrunning.Operation.response] field.
      /// Available for following ML scenarios:
      ///
      /// * AutoML Vision Classification
      /// * AutoML Vision Object Detection
      /// * AutoML Video Intelligence Classification
      /// * AutoML Video Intelligence Object Tracking * AutoML Natural Language Classification
      /// * AutoML Natural Language Entity Extraction
      /// * AutoML Natural Language Sentiment Analysis
      /// * AutoML Tables
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> BatchPredictAsync(global::Google.Cloud.AutoML.V1.BatchPredictRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return BatchPredictAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Perform a batch prediction. Unlike the online [Predict][google.cloud.automl.v1.PredictionService.Predict], batch
      /// prediction result won't be immediately available in the response. Instead,
      /// a long running operation object is returned. User can poll the operation
      /// result via [GetOperation][google.longrunning.Operations.GetOperation]
      /// method. Once the operation is done, [BatchPredictResult][google.cloud.automl.v1.BatchPredictResult] is returned in
      /// the [response][google.longrunning.Operation.response] field.
      /// Available for following ML scenarios:
      ///
      /// * AutoML Vision Classification
      /// * AutoML Vision Object Detection
      /// * AutoML Video Intelligence Classification
      /// * AutoML Video Intelligence Object Tracking * AutoML Natural Language Classification
      /// * AutoML Natural Language Entity Extraction
      /// * AutoML Natural Language Sentiment Analysis
      /// * AutoML Tables
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> BatchPredictAsync(global::Google.Cloud.AutoML.V1.BatchPredictRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_BatchPredict, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override PredictionServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PredictionServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(PredictionServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Predict, serviceImpl.Predict)
          .AddMethod(__Method_BatchPredict, serviceImpl.BatchPredict).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PredictionServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Predict, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.AutoML.V1.PredictRequest, global::Google.Cloud.AutoML.V1.PredictResponse>(serviceImpl.Predict));
      serviceBinder.AddMethod(__Method_BatchPredict, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.AutoML.V1.BatchPredictRequest, global::Google.LongRunning.Operation>(serviceImpl.BatchPredict));
    }

  }
}
#endregion
