// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/metadata_schema.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/metadata_schema.proto</summary>
  public static partial class MetadataSchemaReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/metadata_schema.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MetadataSchemaReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9tZXRhZGF0YV9zY2hlbWEu",
            "cHJvdG8SGmdvb2dsZS5jbG91ZC5haXBsYXRmb3JtLnYxGh9nb29nbGUvYXBp",
            "L2ZpZWxkX2JlaGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnBy",
            "b3RvGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvGhxnb29nbGUv",
            "YXBpL2Fubm90YXRpb25zLnByb3RvIoAECg5NZXRhZGF0YVNjaGVtYRIRCgRu",
            "YW1lGAEgASgJQgPgQQMSFgoOc2NoZW1hX3ZlcnNpb24YAiABKAkSEwoGc2No",
            "ZW1hGAMgASgJQgPgQQISUgoLc2NoZW1hX3R5cGUYBCABKA4yPS5nb29nbGUu",
            "Y2xvdWQuYWlwbGF0Zm9ybS52MS5NZXRhZGF0YVNjaGVtYS5NZXRhZGF0YVNj",
            "aGVtYVR5cGUSNAoLY3JlYXRlX3RpbWUYBSABKAsyGi5nb29nbGUucHJvdG9i",
            "dWYuVGltZXN0YW1wQgPgQQMSEwoLZGVzY3JpcHRpb24YBiABKAkicwoSTWV0",
            "YWRhdGFTY2hlbWFUeXBlEiQKIE1FVEFEQVRBX1NDSEVNQV9UWVBFX1VOU1BF",
            "Q0lGSUVEEAASEQoNQVJUSUZBQ1RfVFlQRRABEhIKDkVYRUNVVElPTl9UWVBF",
            "EAISEAoMQ09OVEVYVF9UWVBFEAM6mQHqQZUBCihhaXBsYXRmb3JtLmdvb2ds",
            "ZWFwaXMuY29tL01ldGFkYXRhU2NoZW1hEmlwcm9qZWN0cy97cHJvamVjdH0v",
            "bG9jYXRpb25zL3tsb2NhdGlvbn0vbWV0YWRhdGFTdG9yZXMve21ldGFkYXRh",
            "X3N0b3JlfS9tZXRhZGF0YVNjaGVtYXMve21ldGFkYXRhX3NjaGVtYX1C1wEK",
            "HmNvbS5nb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52MUITTWV0YWRhdGFTY2hl",
            "bWFQcm90b1ABWkRnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVh",
            "cGlzL2Nsb3VkL2FpcGxhdGZvcm0vdjE7YWlwbGF0Zm9ybaoCGkdvb2dsZS5D",
            "bG91ZC5BSVBsYXRmb3JtLlYxygIaR29vZ2xlXENsb3VkXEFJUGxhdGZvcm1c",
            "VjHqAh1Hb29nbGU6OkNsb3VkOjpBSVBsYXRmb3JtOjpWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.MetadataSchema), global::Google.Cloud.AIPlatform.V1.MetadataSchema.Parser, new[]{ "Name", "SchemaVersion", "Schema", "SchemaType", "CreateTime", "Description" }, null, new[]{ typeof(global::Google.Cloud.AIPlatform.V1.MetadataSchema.Types.MetadataSchemaType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Instance of a general MetadataSchema.
  /// </summary>
  public sealed partial class MetadataSchema : pb::IMessage<MetadataSchema>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MetadataSchema> _parser = new pb::MessageParser<MetadataSchema>(() => new MetadataSchema());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MetadataSchema> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.MetadataSchemaReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MetadataSchema() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MetadataSchema(MetadataSchema other) : this() {
      name_ = other.name_;
      schemaVersion_ = other.schemaVersion_;
      schema_ = other.schema_;
      schemaType_ = other.schemaType_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      description_ = other.description_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MetadataSchema Clone() {
      return new MetadataSchema(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Output only. The resource name of the MetadataSchema.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "schema_version" field.</summary>
    public const int SchemaVersionFieldNumber = 2;
    private string schemaVersion_ = "";
    /// <summary>
    /// The version of the MetadataSchema. The version's format must match
    /// the following regular expression: `^[0-9]+[.][0-9]+[.][0-9]+$`, which would
    /// allow to order/compare different versions. Example: 1.0.0, 1.0.1, etc.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SchemaVersion {
      get { return schemaVersion_; }
      set {
        schemaVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "schema" field.</summary>
    public const int SchemaFieldNumber = 3;
    private string schema_ = "";
    /// <summary>
    /// Required. The raw YAML string representation of the MetadataSchema. The combination
    /// of [MetadataSchema.version] and the schema name given by `title` in
    /// [MetadataSchema.schema] must be unique within a MetadataStore.
    ///
    /// The schema is defined as an OpenAPI 3.0.2
    /// [MetadataSchema
    /// Object](https://github.com/OAI/OpenAPI-Specification/blob/master/versions/3.0.2.md#schemaObject)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Schema {
      get { return schema_; }
      set {
        schema_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "schema_type" field.</summary>
    public const int SchemaTypeFieldNumber = 4;
    private global::Google.Cloud.AIPlatform.V1.MetadataSchema.Types.MetadataSchemaType schemaType_ = global::Google.Cloud.AIPlatform.V1.MetadataSchema.Types.MetadataSchemaType.Unspecified;
    /// <summary>
    /// The type of the MetadataSchema. This is a property that identifies which
    /// metadata types will use the MetadataSchema.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AIPlatform.V1.MetadataSchema.Types.MetadataSchemaType SchemaType {
      get { return schemaType_; }
      set {
        schemaType_ = value;
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. Timestamp when this MetadataSchema was created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 6;
    private string description_ = "";
    /// <summary>
    /// Description of the Metadata Schema
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MetadataSchema);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MetadataSchema other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (SchemaVersion != other.SchemaVersion) return false;
      if (Schema != other.Schema) return false;
      if (SchemaType != other.SchemaType) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (Description != other.Description) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (SchemaVersion.Length != 0) hash ^= SchemaVersion.GetHashCode();
      if (Schema.Length != 0) hash ^= Schema.GetHashCode();
      if (SchemaType != global::Google.Cloud.AIPlatform.V1.MetadataSchema.Types.MetadataSchemaType.Unspecified) hash ^= SchemaType.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (SchemaVersion.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(SchemaVersion);
      }
      if (Schema.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Schema);
      }
      if (SchemaType != global::Google.Cloud.AIPlatform.V1.MetadataSchema.Types.MetadataSchemaType.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) SchemaType);
      }
      if (createTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(CreateTime);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Description);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (SchemaVersion.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(SchemaVersion);
      }
      if (Schema.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Schema);
      }
      if (SchemaType != global::Google.Cloud.AIPlatform.V1.MetadataSchema.Types.MetadataSchemaType.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) SchemaType);
      }
      if (createTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(CreateTime);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Description);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (SchemaVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SchemaVersion);
      }
      if (Schema.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Schema);
      }
      if (SchemaType != global::Google.Cloud.AIPlatform.V1.MetadataSchema.Types.MetadataSchemaType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) SchemaType);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MetadataSchema other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.SchemaVersion.Length != 0) {
        SchemaVersion = other.SchemaVersion;
      }
      if (other.Schema.Length != 0) {
        Schema = other.Schema;
      }
      if (other.SchemaType != global::Google.Cloud.AIPlatform.V1.MetadataSchema.Types.MetadataSchemaType.Unspecified) {
        SchemaType = other.SchemaType;
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
            SchemaVersion = input.ReadString();
            break;
          }
          case 26: {
            Schema = input.ReadString();
            break;
          }
          case 32: {
            SchemaType = (global::Google.Cloud.AIPlatform.V1.MetadataSchema.Types.MetadataSchemaType) input.ReadEnum();
            break;
          }
          case 42: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 50: {
            Description = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
            SchemaVersion = input.ReadString();
            break;
          }
          case 26: {
            Schema = input.ReadString();
            break;
          }
          case 32: {
            SchemaType = (global::Google.Cloud.AIPlatform.V1.MetadataSchema.Types.MetadataSchemaType) input.ReadEnum();
            break;
          }
          case 42: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 50: {
            Description = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the MetadataSchema message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Describes the type of the MetadataSchema.
      /// </summary>
      public enum MetadataSchemaType {
        /// <summary>
        /// Unspecified type for the MetadataSchema.
        /// </summary>
        [pbr::OriginalName("METADATA_SCHEMA_TYPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// A type indicating that the MetadataSchema will be used by Artifacts.
        /// </summary>
        [pbr::OriginalName("ARTIFACT_TYPE")] ArtifactType = 1,
        /// <summary>
        /// A typee indicating that the MetadataSchema will be used by Executions.
        /// </summary>
        [pbr::OriginalName("EXECUTION_TYPE")] ExecutionType = 2,
        /// <summary>
        /// A state indicating that the MetadataSchema will be used by Contexts.
        /// </summary>
        [pbr::OriginalName("CONTEXT_TYPE")] ContextType = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code