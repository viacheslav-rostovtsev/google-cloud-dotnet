// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/feature.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/feature.proto</summary>
  public static partial class FeatureReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/feature.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeatureReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cihnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9mZWF0dXJlLnByb3RvEhpn",
            "b29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52MRofZ29vZ2xlL2FwaS9maWVsZF9i",
            "ZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90bxo5Z29v",
            "Z2xlL2Nsb3VkL2FpcGxhdGZvcm0vdjEvZmVhdHVyZV9tb25pdG9yaW5nX3N0",
            "YXRzLnByb3RvGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvGhxn",
            "b29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIq8FCgdGZWF0dXJlEhEKBG5h",
            "bWUYASABKAlCA+BBBRITCgtkZXNjcmlwdGlvbhgCIAEoCRJJCgp2YWx1ZV90",
            "eXBlGAMgASgOMi0uZ29vZ2xlLmNsb3VkLmFpcGxhdGZvcm0udjEuRmVhdHVy",
            "ZS5WYWx1ZVR5cGVCBuBBAuBBBRI0CgtjcmVhdGVfdGltZRgEIAEoCzIaLmdv",
            "b2dsZS5wcm90b2J1Zi5UaW1lc3RhbXBCA+BBAxI0Cgt1cGRhdGVfdGltZRgF",
            "IAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXBCA+BBAxJECgZsYWJl",
            "bHMYBiADKAsyLy5nb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52MS5GZWF0dXJl",
            "LkxhYmVsc0VudHJ5QgPgQQESDAoEZXRhZxgHIAEoCRotCgtMYWJlbHNFbnRy",
            "eRILCgNrZXkYASABKAkSDQoFdmFsdWUYAiABKAk6AjgBIqQBCglWYWx1ZVR5",
            "cGUSGgoWVkFMVUVfVFlQRV9VTlNQRUNJRklFRBAAEggKBEJPT0wQARIOCgpC",
            "T09MX0FSUkFZEAISCgoGRE9VQkxFEAMSEAoMRE9VQkxFX0FSUkFZEAQSCQoF",
            "SU5UNjQQCRIPCgtJTlQ2NF9BUlJBWRAKEgoKBlNUUklORxALEhAKDFNUUklO",
            "R19BUlJBWRAMEgkKBUJZVEVTEA06mgHqQZYBCiFhaXBsYXRmb3JtLmdvb2ds",
            "ZWFwaXMuY29tL0ZlYXR1cmUScXByb2plY3RzL3twcm9qZWN0fS9sb2NhdGlv",
            "bnMve2xvY2F0aW9ufS9mZWF0dXJlc3RvcmVzL3tmZWF0dXJlc3RvcmV9L2Vu",
            "dGl0eVR5cGVzL3tlbnRpdHlfdHlwZX0vZmVhdHVyZXMve2ZlYXR1cmV9QtAB",
            "Ch5jb20uZ29vZ2xlLmNsb3VkLmFpcGxhdGZvcm0udjFCDEZlYXR1cmVQcm90",
            "b1ABWkRnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Ns",
            "b3VkL2FpcGxhdGZvcm0vdjE7YWlwbGF0Zm9ybaoCGkdvb2dsZS5DbG91ZC5B",
            "SVBsYXRmb3JtLlYxygIaR29vZ2xlXENsb3VkXEFJUGxhdGZvcm1cVjHqAh1H",
            "b29nbGU6OkNsb3VkOjpBSVBsYXRmb3JtOjpWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.AIPlatform.V1.FeatureMonitoringStatsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.Feature), global::Google.Cloud.AIPlatform.V1.Feature.Parser, new[]{ "Name", "Description", "ValueType", "CreateTime", "UpdateTime", "Labels", "Etag" }, null, new[]{ typeof(global::Google.Cloud.AIPlatform.V1.Feature.Types.ValueType) }, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Feature Metadata information that describes an attribute of an entity type.
  /// For example, apple is an entity type, and color is a feature that describes
  /// apple.
  /// </summary>
  public sealed partial class Feature : pb::IMessage<Feature>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Feature> _parser = new pb::MessageParser<Feature>(() => new Feature());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Feature> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.FeatureReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Feature() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Feature(Feature other) : this() {
      name_ = other.name_;
      description_ = other.description_;
      valueType_ = other.valueType_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      labels_ = other.labels_.Clone();
      etag_ = other.etag_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Feature Clone() {
      return new Feature(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Immutable. Name of the Feature.
    /// Format:
    /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}/features/{feature}`
    ///
    /// The last part feature is assigned by the client. The feature can be up to
    /// 64 characters long and can consist only of ASCII Latin letters A-Z and a-z,
    /// underscore(_), and ASCII digits 0-9 starting with a letter. The value will
    /// be unique given an entity type.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 2;
    private string description_ = "";
    /// <summary>
    /// Description of the Feature.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "value_type" field.</summary>
    public const int ValueTypeFieldNumber = 3;
    private global::Google.Cloud.AIPlatform.V1.Feature.Types.ValueType valueType_ = global::Google.Cloud.AIPlatform.V1.Feature.Types.ValueType.Unspecified;
    /// <summary>
    /// Required. Immutable. Type of Feature value.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.AIPlatform.V1.Feature.Types.ValueType ValueType {
      get { return valueType_; }
      set {
        valueType_ = value;
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. Timestamp when this EntityType was created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "update_time" field.</summary>
    public const int UpdateTimeFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updateTime_;
    /// <summary>
    /// Output only. Timestamp when this EntityType was most recently updated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdateTime {
      get { return updateTime_; }
      set {
        updateTime_ = value;
      }
    }

    /// <summary>Field number for the "labels" field.</summary>
    public const int LabelsFieldNumber = 6;
    private static readonly pbc::MapField<string, string>.Codec _map_labels_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 50);
    private readonly pbc::MapField<string, string> labels_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Optional. The labels with user-defined metadata to organize your Features.
    ///
    /// Label keys and values can be no longer than 64 characters
    /// (Unicode codepoints), can only contain lowercase letters, numeric
    /// characters, underscores and dashes. International characters are allowed.
    ///
    /// See https://goo.gl/xmQnxf for more information on and examples of labels.
    /// No more than 64 user labels can be associated with one Feature (System
    /// labels are excluded)."
    /// System reserved label keys are prefixed with "aiplatform.googleapis.com/"
    /// and are immutable.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Labels {
      get { return labels_; }
    }

    /// <summary>Field number for the "etag" field.</summary>
    public const int EtagFieldNumber = 7;
    private string etag_ = "";
    /// <summary>
    /// Used to perform a consistent read-modify-write updates. If not set, a blind
    /// "overwrite" update happens.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Etag {
      get { return etag_; }
      set {
        etag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Feature);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Feature other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Description != other.Description) return false;
      if (ValueType != other.ValueType) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      if (!Labels.Equals(other.Labels)) return false;
      if (Etag != other.Etag) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (ValueType != global::Google.Cloud.AIPlatform.V1.Feature.Types.ValueType.Unspecified) hash ^= ValueType.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (updateTime_ != null) hash ^= UpdateTime.GetHashCode();
      hash ^= Labels.GetHashCode();
      if (Etag.Length != 0) hash ^= Etag.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Description);
      }
      if (ValueType != global::Google.Cloud.AIPlatform.V1.Feature.Types.ValueType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) ValueType);
      }
      if (createTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(UpdateTime);
      }
      labels_.WriteTo(output, _map_labels_codec);
      if (Etag.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Etag);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Description);
      }
      if (ValueType != global::Google.Cloud.AIPlatform.V1.Feature.Types.ValueType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) ValueType);
      }
      if (createTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(UpdateTime);
      }
      labels_.WriteTo(ref output, _map_labels_codec);
      if (Etag.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Etag);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (ValueType != global::Google.Cloud.AIPlatform.V1.Feature.Types.ValueType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ValueType);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (updateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateTime);
      }
      size += labels_.CalculateSize(_map_labels_codec);
      if (Etag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Etag);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Feature other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.ValueType != global::Google.Cloud.AIPlatform.V1.Feature.Types.ValueType.Unspecified) {
        ValueType = other.ValueType;
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      if (other.updateTime_ != null) {
        if (updateTime_ == null) {
          UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        UpdateTime.MergeFrom(other.UpdateTime);
      }
      labels_.Add(other.labels_);
      if (other.Etag.Length != 0) {
        Etag = other.Etag;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            Description = input.ReadString();
            break;
          }
          case 24: {
            ValueType = (global::Google.Cloud.AIPlatform.V1.Feature.Types.ValueType) input.ReadEnum();
            break;
          }
          case 34: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 42: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 50: {
            labels_.AddEntriesFrom(input, _map_labels_codec);
            break;
          }
          case 58: {
            Etag = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            Description = input.ReadString();
            break;
          }
          case 24: {
            ValueType = (global::Google.Cloud.AIPlatform.V1.Feature.Types.ValueType) input.ReadEnum();
            break;
          }
          case 34: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 42: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 50: {
            labels_.AddEntriesFrom(ref input, _map_labels_codec);
            break;
          }
          case 58: {
            Etag = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Feature message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// An enum representing the value type of a feature.
      /// </summary>
      public enum ValueType {
        /// <summary>
        /// The value type is unspecified.
        /// </summary>
        [pbr::OriginalName("VALUE_TYPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for Feature that is a boolean.
        /// </summary>
        [pbr::OriginalName("BOOL")] Bool = 1,
        /// <summary>
        /// Used for Feature that is a list of boolean.
        /// </summary>
        [pbr::OriginalName("BOOL_ARRAY")] BoolArray = 2,
        /// <summary>
        /// Used for Feature that is double.
        /// </summary>
        [pbr::OriginalName("DOUBLE")] Double = 3,
        /// <summary>
        /// Used for Feature that is a list of double.
        /// </summary>
        [pbr::OriginalName("DOUBLE_ARRAY")] DoubleArray = 4,
        /// <summary>
        /// Used for Feature that is INT64.
        /// </summary>
        [pbr::OriginalName("INT64")] Int64 = 9,
        /// <summary>
        /// Used for Feature that is a list of INT64.
        /// </summary>
        [pbr::OriginalName("INT64_ARRAY")] Int64Array = 10,
        /// <summary>
        /// Used for Feature that is string.
        /// </summary>
        [pbr::OriginalName("STRING")] String = 11,
        /// <summary>
        /// Used for Feature that is a list of String.
        /// </summary>
        [pbr::OriginalName("STRING_ARRAY")] StringArray = 12,
        /// <summary>
        /// Used for Feature that is bytes.
        /// </summary>
        [pbr::OriginalName("BYTES")] Bytes = 13,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
