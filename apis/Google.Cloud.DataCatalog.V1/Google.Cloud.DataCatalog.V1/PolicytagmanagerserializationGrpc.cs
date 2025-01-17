// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/datacatalog/v1/policytagmanagerserialization.proto
// </auto-generated>
// Original file comments:
// Copyright 2021 Google LLC
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

namespace Google.Cloud.DataCatalog.V1 {
  /// <summary>
  /// Policy Tag Manager serialization API service allows clients to manipulate
  /// their policy tags and taxonomies in serialized format, where taxonomy is a
  /// hierarchical group of policy tags.
  /// </summary>
  public static partial class PolicyTagManagerSerialization
  {
    static readonly string __ServiceName = "google.cloud.datacatalog.v1.PolicyTagManagerSerialization";

    static readonly grpc::Marshaller<global::Google.Cloud.DataCatalog.V1.ImportTaxonomiesRequest> __Marshaller_google_cloud_datacatalog_v1_ImportTaxonomiesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.DataCatalog.V1.ImportTaxonomiesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.DataCatalog.V1.ImportTaxonomiesResponse> __Marshaller_google_cloud_datacatalog_v1_ImportTaxonomiesResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.DataCatalog.V1.ImportTaxonomiesResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.DataCatalog.V1.ExportTaxonomiesRequest> __Marshaller_google_cloud_datacatalog_v1_ExportTaxonomiesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.DataCatalog.V1.ExportTaxonomiesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.DataCatalog.V1.ExportTaxonomiesResponse> __Marshaller_google_cloud_datacatalog_v1_ExportTaxonomiesResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.DataCatalog.V1.ExportTaxonomiesResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Cloud.DataCatalog.V1.ImportTaxonomiesRequest, global::Google.Cloud.DataCatalog.V1.ImportTaxonomiesResponse> __Method_ImportTaxonomies = new grpc::Method<global::Google.Cloud.DataCatalog.V1.ImportTaxonomiesRequest, global::Google.Cloud.DataCatalog.V1.ImportTaxonomiesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ImportTaxonomies",
        __Marshaller_google_cloud_datacatalog_v1_ImportTaxonomiesRequest,
        __Marshaller_google_cloud_datacatalog_v1_ImportTaxonomiesResponse);

    static readonly grpc::Method<global::Google.Cloud.DataCatalog.V1.ExportTaxonomiesRequest, global::Google.Cloud.DataCatalog.V1.ExportTaxonomiesResponse> __Method_ExportTaxonomies = new grpc::Method<global::Google.Cloud.DataCatalog.V1.ExportTaxonomiesRequest, global::Google.Cloud.DataCatalog.V1.ExportTaxonomiesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ExportTaxonomies",
        __Marshaller_google_cloud_datacatalog_v1_ExportTaxonomiesRequest,
        __Marshaller_google_cloud_datacatalog_v1_ExportTaxonomiesResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.DataCatalog.V1.PolicytagmanagerserializationReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PolicyTagManagerSerialization</summary>
    [grpc::BindServiceMethod(typeof(PolicyTagManagerSerialization), "BindService")]
    public abstract partial class PolicyTagManagerSerializationBase
    {
      /// <summary>
      /// Creates new taxonomies (including their policy tags) by importing from
      /// inlined source or cross-regional source. New taxonomies will be created in
      /// a given parent project.
      ///
      /// If using the cross-regional source, a new taxonomy is created by copying
      /// from a source in another region.
      ///
      /// If using the inlined source, this method provides a way to bulk create
      /// taxonomies and policy tags using nested proto structure.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.DataCatalog.V1.ImportTaxonomiesResponse> ImportTaxonomies(global::Google.Cloud.DataCatalog.V1.ImportTaxonomiesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Exports taxonomies as the requested type and returns the taxonomies
      /// including their policy tags. The requested taxonomies must belong to one
      /// project.
      ///
      /// SerializedTaxonomy protos with nested policy tags that are generated by
      /// this method can be used as input for future ImportTaxonomies calls.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.DataCatalog.V1.ExportTaxonomiesResponse> ExportTaxonomies(global::Google.Cloud.DataCatalog.V1.ExportTaxonomiesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for PolicyTagManagerSerialization</summary>
    public partial class PolicyTagManagerSerializationClient : grpc::ClientBase<PolicyTagManagerSerializationClient>
    {
      /// <summary>Creates a new client for PolicyTagManagerSerialization</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public PolicyTagManagerSerializationClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PolicyTagManagerSerialization that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public PolicyTagManagerSerializationClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected PolicyTagManagerSerializationClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected PolicyTagManagerSerializationClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Creates new taxonomies (including their policy tags) by importing from
      /// inlined source or cross-regional source. New taxonomies will be created in
      /// a given parent project.
      ///
      /// If using the cross-regional source, a new taxonomy is created by copying
      /// from a source in another region.
      ///
      /// If using the inlined source, this method provides a way to bulk create
      /// taxonomies and policy tags using nested proto structure.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.DataCatalog.V1.ImportTaxonomiesResponse ImportTaxonomies(global::Google.Cloud.DataCatalog.V1.ImportTaxonomiesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ImportTaxonomies(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates new taxonomies (including their policy tags) by importing from
      /// inlined source or cross-regional source. New taxonomies will be created in
      /// a given parent project.
      ///
      /// If using the cross-regional source, a new taxonomy is created by copying
      /// from a source in another region.
      ///
      /// If using the inlined source, this method provides a way to bulk create
      /// taxonomies and policy tags using nested proto structure.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.DataCatalog.V1.ImportTaxonomiesResponse ImportTaxonomies(global::Google.Cloud.DataCatalog.V1.ImportTaxonomiesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ImportTaxonomies, null, options, request);
      }
      /// <summary>
      /// Creates new taxonomies (including their policy tags) by importing from
      /// inlined source or cross-regional source. New taxonomies will be created in
      /// a given parent project.
      ///
      /// If using the cross-regional source, a new taxonomy is created by copying
      /// from a source in another region.
      ///
      /// If using the inlined source, this method provides a way to bulk create
      /// taxonomies and policy tags using nested proto structure.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.DataCatalog.V1.ImportTaxonomiesResponse> ImportTaxonomiesAsync(global::Google.Cloud.DataCatalog.V1.ImportTaxonomiesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ImportTaxonomiesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates new taxonomies (including their policy tags) by importing from
      /// inlined source or cross-regional source. New taxonomies will be created in
      /// a given parent project.
      ///
      /// If using the cross-regional source, a new taxonomy is created by copying
      /// from a source in another region.
      ///
      /// If using the inlined source, this method provides a way to bulk create
      /// taxonomies and policy tags using nested proto structure.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.DataCatalog.V1.ImportTaxonomiesResponse> ImportTaxonomiesAsync(global::Google.Cloud.DataCatalog.V1.ImportTaxonomiesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ImportTaxonomies, null, options, request);
      }
      /// <summary>
      /// Exports taxonomies as the requested type and returns the taxonomies
      /// including their policy tags. The requested taxonomies must belong to one
      /// project.
      ///
      /// SerializedTaxonomy protos with nested policy tags that are generated by
      /// this method can be used as input for future ImportTaxonomies calls.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.DataCatalog.V1.ExportTaxonomiesResponse ExportTaxonomies(global::Google.Cloud.DataCatalog.V1.ExportTaxonomiesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ExportTaxonomies(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Exports taxonomies as the requested type and returns the taxonomies
      /// including their policy tags. The requested taxonomies must belong to one
      /// project.
      ///
      /// SerializedTaxonomy protos with nested policy tags that are generated by
      /// this method can be used as input for future ImportTaxonomies calls.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.DataCatalog.V1.ExportTaxonomiesResponse ExportTaxonomies(global::Google.Cloud.DataCatalog.V1.ExportTaxonomiesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ExportTaxonomies, null, options, request);
      }
      /// <summary>
      /// Exports taxonomies as the requested type and returns the taxonomies
      /// including their policy tags. The requested taxonomies must belong to one
      /// project.
      ///
      /// SerializedTaxonomy protos with nested policy tags that are generated by
      /// this method can be used as input for future ImportTaxonomies calls.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.DataCatalog.V1.ExportTaxonomiesResponse> ExportTaxonomiesAsync(global::Google.Cloud.DataCatalog.V1.ExportTaxonomiesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ExportTaxonomiesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Exports taxonomies as the requested type and returns the taxonomies
      /// including their policy tags. The requested taxonomies must belong to one
      /// project.
      ///
      /// SerializedTaxonomy protos with nested policy tags that are generated by
      /// this method can be used as input for future ImportTaxonomies calls.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.DataCatalog.V1.ExportTaxonomiesResponse> ExportTaxonomiesAsync(global::Google.Cloud.DataCatalog.V1.ExportTaxonomiesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ExportTaxonomies, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override PolicyTagManagerSerializationClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PolicyTagManagerSerializationClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(PolicyTagManagerSerializationBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ImportTaxonomies, serviceImpl.ImportTaxonomies)
          .AddMethod(__Method_ExportTaxonomies, serviceImpl.ExportTaxonomies).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PolicyTagManagerSerializationBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ImportTaxonomies, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.DataCatalog.V1.ImportTaxonomiesRequest, global::Google.Cloud.DataCatalog.V1.ImportTaxonomiesResponse>(serviceImpl.ImportTaxonomies));
      serviceBinder.AddMethod(__Method_ExportTaxonomies, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.DataCatalog.V1.ExportTaxonomiesRequest, global::Google.Cloud.DataCatalog.V1.ExportTaxonomiesResponse>(serviceImpl.ExportTaxonomies));
    }

  }
}
#endregion
