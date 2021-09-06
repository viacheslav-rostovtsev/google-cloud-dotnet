// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/extended_operations.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud {

  /// <summary>Holder for reflection information generated from google/cloud/extended_operations.proto</summary>
  public static partial class ExtendedOperationsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/extended_operations.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExtendedOperationsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZnb29nbGUvY2xvdWQvZXh0ZW5kZWRfb3BlcmF0aW9ucy5wcm90bxIMZ29v",
            "Z2xlLmNsb3VkGiBnb29nbGUvcHJvdG9idWYvZGVzY3JpcHRvci5wcm90bypi",
            "ChhPcGVyYXRpb25SZXNwb25zZU1hcHBpbmcSDQoJVU5ERUZJTkVEEAASCAoE",
            "TkFNRRABEgoKBlNUQVRVUxACEg4KCkVSUk9SX0NPREUQAxIRCg1FUlJPUl9N",
            "RVNTQUdFEAQ6XwoPb3BlcmF0aW9uX2ZpZWxkEh0uZ29vZ2xlLnByb3RvYnVm",
            "LkZpZWxkT3B0aW9ucxj9CCABKA4yJi5nb29nbGUuY2xvdWQuT3BlcmF0aW9u",
            "UmVzcG9uc2VNYXBwaW5nOj8KF29wZXJhdGlvbl9yZXF1ZXN0X2ZpZWxkEh0u",
            "Z29vZ2xlLnByb3RvYnVmLkZpZWxkT3B0aW9ucxj+CCABKAk6QAoYb3BlcmF0",
            "aW9uX3Jlc3BvbnNlX2ZpZWxkEh0uZ29vZ2xlLnByb3RvYnVmLkZpZWxkT3B0",
            "aW9ucxj/CCABKAk6OgoRb3BlcmF0aW9uX3NlcnZpY2USHi5nb29nbGUucHJv",
            "dG9idWYuTWV0aG9kT3B0aW9ucxjhCSABKAk6QQoYb3BlcmF0aW9uX3BvbGxp",
            "bmdfbWV0aG9kEh4uZ29vZ2xlLnByb3RvYnVmLk1ldGhvZE9wdGlvbnMY4gkg",
            "ASgIQnkKEGNvbS5nb29nbGUuY2xvdWRCF0V4dGVuZGVkT3BlcmF0aW9uc1By",
            "b3RvUAFaQ2dvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMv",
            "Y2xvdWQvZXh0ZW5kZWRvcHM7ZXh0ZW5kZWRvcHOiAgRHQVBJYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.Reflection.DescriptorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Cloud.OperationResponseMapping), }, new pb::Extension[] { ExtendedOperationsExtensions.OperationField, ExtendedOperationsExtensions.OperationRequestField, ExtendedOperationsExtensions.OperationResponseField, ExtendedOperationsExtensions.OperationService, ExtendedOperationsExtensions.OperationPollingMethod }, null));
    }
    #endregion

  }
  /// <summary>Holder for extension identifiers generated from the top level of google/cloud/extended_operations.proto</summary>
  public static partial class ExtendedOperationsExtensions {
    /// <summary>
    /// A field annotation that maps fields in an API-specific Operation object to
    /// their standard counterparts in google.longrunning.Operation. See
    /// OperationResponseMapping enum definition.
    /// </summary>
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, global::Google.Cloud.OperationResponseMapping> OperationField =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, global::Google.Cloud.OperationResponseMapping>(1149, pb::FieldCodec.ForEnum(9192, x => (int) x, x => (global::Google.Cloud.OperationResponseMapping) x, global::Google.Cloud.OperationResponseMapping.Undefined));
    /// <summary>
    /// A field annotation that maps fields in the initial request message
    /// (the one which started the LRO) to their counterparts in the polling
    /// request message. For non-standard LRO, the polling response may be missing
    /// some of the information needed to make a subsequent polling request. The
    /// missing information (for example, project or region ID) is contained in the
    /// fields of the initial request message that this annotation must be applied
    /// to. The string value of the annotation corresponds to the name of the
    /// counterpart field in the polling request message that the annotated field's
    /// value will be copied to.
    /// </summary>
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string> OperationRequestField =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string>(1150, pb::FieldCodec.ForString(9202, ""));
    /// <summary>
    /// A field annotation that maps fields in the polling request message to their
    /// counterparts in the initial and/or polling response message. The initial
    /// and the polling methods return an API-specific Operation object. Some of
    /// the fields from that response object must be reused in the subsequent
    /// request (like operation name/ID) to fully identify the polled operation.
    /// This annotation must be applied to the fields in the polling request
    /// message, the string value of the annotation must correspond to the name of
    /// the counterpart field in the Operation response object whose value will be
    /// copied to the annotated field.
    /// </summary>
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string> OperationResponseField =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string>(1151, pb::FieldCodec.ForString(9210, ""));
    /// <summary>
    /// A method annotation that maps an LRO method (the one which starts an LRO)
    /// to the service, which will be used to poll for the operation status. The
    /// annotation must be applied to the method which starts an LRO, the string
    /// value of the annotation must correspond to the name of the service used to
    /// poll for the operation status.
    /// </summary>
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MethodOptions, string> OperationService =
      new pb::Extension<global::Google.Protobuf.Reflection.MethodOptions, string>(1249, pb::FieldCodec.ForString(9994, ""));
    /// <summary>
    /// A method annotation that marks methods that can be used for polling
    /// operation status (e.g. the MyPollingService.Get(MyPollingRequest) method).
    /// </summary>
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MethodOptions, bool> OperationPollingMethod =
      new pb::Extension<global::Google.Protobuf.Reflection.MethodOptions, bool>(1250, pb::FieldCodec.ForBool(10000, false));
  }

  #region Enums
  /// <summary>
  /// An enum to be used to mark the essential (for polling) fields in an
  /// API-specific Operation object. A custom Operation object may contain many
  /// different fields, but only few of them are essential to conduct a successful
  /// polling process.
  /// </summary>
  public enum OperationResponseMapping {
    /// <summary>
    /// Do not use.
    /// </summary>
    [pbr::OriginalName("UNDEFINED")] Undefined = 0,
    /// <summary>
    /// A field in an API-specific (custom) Operation object which carries the same
    /// meaning as google.longrunning.Operation.name.
    /// </summary>
    [pbr::OriginalName("NAME")] Name = 1,
    /// <summary>
    /// A field in an API-specific (custom) Operation object which carries the same
    /// meaning as google.longrunning.Operation.done. If the annotated field is of
    /// an enum type, `annotated_field_name == EnumType.DONE` semantics should be
    /// equivalent to `Operation.done == true`. If the annotated field is of type
    /// boolean, then it should follow the same semantics as Operation.done.
    /// Otherwise, a non-empty value should be treated as `Operation.done == true`.
    /// </summary>
    [pbr::OriginalName("STATUS")] Status = 2,
    /// <summary>
    /// A field in an API-specific (custom) Operation object which carries the same
    /// meaning as google.longrunning.Operation.error.code.
    /// </summary>
    [pbr::OriginalName("ERROR_CODE")] ErrorCode = 3,
    /// <summary>
    /// A field in an API-specific (custom) Operation object which carries the same
    /// meaning as google.longrunning.Operation.error.message.
    /// </summary>
    [pbr::OriginalName("ERROR_MESSAGE")] ErrorMessage = 4,
  }

  #endregion

}

#endregion Designer generated code
