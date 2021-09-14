// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/texttospeech/v1/cloud_tts.proto
// </auto-generated>
// Original file comments:
// Copyright 2019 Google LLC.
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
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.TextToSpeech.V1 {
  /// <summary>
  /// Service that implements Google Cloud Text-to-Speech API.
  /// </summary>
  public static partial class TextToSpeech
  {
    static readonly string __ServiceName = "google.cloud.texttospeech.v1.TextToSpeech";

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
    static readonly grpc::Marshaller<global::Google.Cloud.TextToSpeech.V1.ListVoicesRequest> __Marshaller_google_cloud_texttospeech_v1_ListVoicesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.TextToSpeech.V1.ListVoicesRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.TextToSpeech.V1.ListVoicesResponse> __Marshaller_google_cloud_texttospeech_v1_ListVoicesResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.TextToSpeech.V1.ListVoicesResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechRequest> __Marshaller_google_cloud_texttospeech_v1_SynthesizeSpeechRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechResponse> __Marshaller_google_cloud_texttospeech_v1_SynthesizeSpeechResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.TextToSpeech.V1.ListVoicesRequest, global::Google.Cloud.TextToSpeech.V1.ListVoicesResponse> __Method_ListVoices = new grpc::Method<global::Google.Cloud.TextToSpeech.V1.ListVoicesRequest, global::Google.Cloud.TextToSpeech.V1.ListVoicesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListVoices",
        __Marshaller_google_cloud_texttospeech_v1_ListVoicesRequest,
        __Marshaller_google_cloud_texttospeech_v1_ListVoicesResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechRequest, global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechResponse> __Method_SynthesizeSpeech = new grpc::Method<global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechRequest, global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SynthesizeSpeech",
        __Marshaller_google_cloud_texttospeech_v1_SynthesizeSpeechRequest,
        __Marshaller_google_cloud_texttospeech_v1_SynthesizeSpeechResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.TextToSpeech.V1.CloudTtsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of TextToSpeech</summary>
    [grpc::BindServiceMethod(typeof(TextToSpeech), "BindService")]
    public abstract partial class TextToSpeechBase
    {
      /// <summary>
      /// Returns a list of Voice supported for synthesis.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.TextToSpeech.V1.ListVoicesResponse> ListVoices(global::Google.Cloud.TextToSpeech.V1.ListVoicesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Synthesizes speech synchronously: receive results after all text input
      /// has been processed.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechResponse> SynthesizeSpeech(global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for TextToSpeech</summary>
    public partial class TextToSpeechClient : grpc::ClientBase<TextToSpeechClient>
    {
      /// <summary>Creates a new client for TextToSpeech</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public TextToSpeechClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for TextToSpeech that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public TextToSpeechClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected TextToSpeechClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected TextToSpeechClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns a list of Voice supported for synthesis.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.TextToSpeech.V1.ListVoicesResponse ListVoices(global::Google.Cloud.TextToSpeech.V1.ListVoicesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListVoices(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns a list of Voice supported for synthesis.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.TextToSpeech.V1.ListVoicesResponse ListVoices(global::Google.Cloud.TextToSpeech.V1.ListVoicesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListVoices, null, options, request);
      }
      /// <summary>
      /// Returns a list of Voice supported for synthesis.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.TextToSpeech.V1.ListVoicesResponse> ListVoicesAsync(global::Google.Cloud.TextToSpeech.V1.ListVoicesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListVoicesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns a list of Voice supported for synthesis.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.TextToSpeech.V1.ListVoicesResponse> ListVoicesAsync(global::Google.Cloud.TextToSpeech.V1.ListVoicesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListVoices, null, options, request);
      }
      /// <summary>
      /// Synthesizes speech synchronously: receive results after all text input
      /// has been processed.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechResponse SynthesizeSpeech(global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SynthesizeSpeech(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Synthesizes speech synchronously: receive results after all text input
      /// has been processed.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechResponse SynthesizeSpeech(global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SynthesizeSpeech, null, options, request);
      }
      /// <summary>
      /// Synthesizes speech synchronously: receive results after all text input
      /// has been processed.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechResponse> SynthesizeSpeechAsync(global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SynthesizeSpeechAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Synthesizes speech synchronously: receive results after all text input
      /// has been processed.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechResponse> SynthesizeSpeechAsync(global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SynthesizeSpeech, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override TextToSpeechClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new TextToSpeechClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(TextToSpeechBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListVoices, serviceImpl.ListVoices)
          .AddMethod(__Method_SynthesizeSpeech, serviceImpl.SynthesizeSpeech).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, TextToSpeechBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ListVoices, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.TextToSpeech.V1.ListVoicesRequest, global::Google.Cloud.TextToSpeech.V1.ListVoicesResponse>(serviceImpl.ListVoices));
      serviceBinder.AddMethod(__Method_SynthesizeSpeech, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechRequest, global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechResponse>(serviceImpl.SynthesizeSpeech));
    }

  }
}
#endregion
