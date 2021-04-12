// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/bigquery/storage/v1/arrow.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.BigQuery.Storage.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/bigquery/storage/v1/arrow.proto</summary>
  public static partial class ArrowReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/bigquery/storage/v1/arrow.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ArrowReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cixnb29nbGUvY2xvdWQvYmlncXVlcnkvc3RvcmFnZS92MS9hcnJvdy5wcm90",
            "bxIgZ29vZ2xlLmNsb3VkLmJpZ3F1ZXJ5LnN0b3JhZ2UudjEiKAoLQXJyb3dT",
            "Y2hlbWESGQoRc2VyaWFsaXplZF9zY2hlbWEYASABKAwiRgoQQXJyb3dSZWNv",
            "cmRCYXRjaBIfChdzZXJpYWxpemVkX3JlY29yZF9iYXRjaBgBIAEoDBIRCgly",
            "b3dfY291bnQYAiABKAMixQEKGUFycm93U2VyaWFsaXphdGlvbk9wdGlvbnMS",
            "aAoSYnVmZmVyX2NvbXByZXNzaW9uGAIgASgOMkwuZ29vZ2xlLmNsb3VkLmJp",
            "Z3F1ZXJ5LnN0b3JhZ2UudjEuQXJyb3dTZXJpYWxpemF0aW9uT3B0aW9ucy5D",
            "b21wcmVzc2lvbkNvZGVjIj4KEENvbXByZXNzaW9uQ29kZWMSGwoXQ09NUFJF",
            "U1NJT05fVU5TUEVDSUZJRUQQABINCglMWjRfRlJBTUUQAULDAQokY29tLmdv",
            "b2dsZS5jbG91ZC5iaWdxdWVyeS5zdG9yYWdlLnYxQgpBcnJvd1Byb3RvUAFa",
            "R2dvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvY2xvdWQv",
            "YmlncXVlcnkvc3RvcmFnZS92MTtzdG9yYWdlqgIgR29vZ2xlLkNsb3VkLkJp",
            "Z1F1ZXJ5LlN0b3JhZ2UuVjHKAiBHb29nbGVcQ2xvdWRcQmlnUXVlcnlcU3Rv",
            "cmFnZVxWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.BigQuery.Storage.V1.ArrowSchema), global::Google.Cloud.BigQuery.Storage.V1.ArrowSchema.Parser, new[]{ "SerializedSchema" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.BigQuery.Storage.V1.ArrowRecordBatch), global::Google.Cloud.BigQuery.Storage.V1.ArrowRecordBatch.Parser, new[]{ "SerializedRecordBatch", "RowCount" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.BigQuery.Storage.V1.ArrowSerializationOptions), global::Google.Cloud.BigQuery.Storage.V1.ArrowSerializationOptions.Parser, new[]{ "BufferCompression" }, null, new[]{ typeof(global::Google.Cloud.BigQuery.Storage.V1.ArrowSerializationOptions.Types.CompressionCodec) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Arrow schema as specified in
  /// https://arrow.apache.org/docs/python/api/datatypes.html
  /// and serialized to bytes using IPC:
  /// https://arrow.apache.org/docs/format/Columnar.html#serialization-and-interprocess-communication-ipc
  ///
  /// See code samples on how this message can be deserialized.
  /// </summary>
  public sealed partial class ArrowSchema : pb::IMessage<ArrowSchema>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ArrowSchema> _parser = new pb::MessageParser<ArrowSchema>(() => new ArrowSchema());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ArrowSchema> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.BigQuery.Storage.V1.ArrowReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArrowSchema() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArrowSchema(ArrowSchema other) : this() {
      serializedSchema_ = other.serializedSchema_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArrowSchema Clone() {
      return new ArrowSchema(this);
    }

    /// <summary>Field number for the "serialized_schema" field.</summary>
    public const int SerializedSchemaFieldNumber = 1;
    private pb::ByteString serializedSchema_ = pb::ByteString.Empty;
    /// <summary>
    /// IPC serialized Arrow schema.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString SerializedSchema {
      get { return serializedSchema_; }
      set {
        serializedSchema_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ArrowSchema);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ArrowSchema other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SerializedSchema != other.SerializedSchema) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SerializedSchema.Length != 0) hash ^= SerializedSchema.GetHashCode();
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
      if (SerializedSchema.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(SerializedSchema);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (SerializedSchema.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(SerializedSchema);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SerializedSchema.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(SerializedSchema);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ArrowSchema other) {
      if (other == null) {
        return;
      }
      if (other.SerializedSchema.Length != 0) {
        SerializedSchema = other.SerializedSchema;
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
            SerializedSchema = input.ReadBytes();
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
            SerializedSchema = input.ReadBytes();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Arrow RecordBatch.
  /// </summary>
  public sealed partial class ArrowRecordBatch : pb::IMessage<ArrowRecordBatch>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ArrowRecordBatch> _parser = new pb::MessageParser<ArrowRecordBatch>(() => new ArrowRecordBatch());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ArrowRecordBatch> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.BigQuery.Storage.V1.ArrowReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArrowRecordBatch() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArrowRecordBatch(ArrowRecordBatch other) : this() {
      serializedRecordBatch_ = other.serializedRecordBatch_;
      rowCount_ = other.rowCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArrowRecordBatch Clone() {
      return new ArrowRecordBatch(this);
    }

    /// <summary>Field number for the "serialized_record_batch" field.</summary>
    public const int SerializedRecordBatchFieldNumber = 1;
    private pb::ByteString serializedRecordBatch_ = pb::ByteString.Empty;
    /// <summary>
    /// IPC-serialized Arrow RecordBatch.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString SerializedRecordBatch {
      get { return serializedRecordBatch_; }
      set {
        serializedRecordBatch_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "row_count" field.</summary>
    public const int RowCountFieldNumber = 2;
    private long rowCount_;
    /// <summary>
    /// The count of rows in `serialized_record_batch`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long RowCount {
      get { return rowCount_; }
      set {
        rowCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ArrowRecordBatch);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ArrowRecordBatch other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SerializedRecordBatch != other.SerializedRecordBatch) return false;
      if (RowCount != other.RowCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SerializedRecordBatch.Length != 0) hash ^= SerializedRecordBatch.GetHashCode();
      if (RowCount != 0L) hash ^= RowCount.GetHashCode();
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
      if (SerializedRecordBatch.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(SerializedRecordBatch);
      }
      if (RowCount != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(RowCount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (SerializedRecordBatch.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(SerializedRecordBatch);
      }
      if (RowCount != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(RowCount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SerializedRecordBatch.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(SerializedRecordBatch);
      }
      if (RowCount != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RowCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ArrowRecordBatch other) {
      if (other == null) {
        return;
      }
      if (other.SerializedRecordBatch.Length != 0) {
        SerializedRecordBatch = other.SerializedRecordBatch;
      }
      if (other.RowCount != 0L) {
        RowCount = other.RowCount;
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
            SerializedRecordBatch = input.ReadBytes();
            break;
          }
          case 16: {
            RowCount = input.ReadInt64();
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
            SerializedRecordBatch = input.ReadBytes();
            break;
          }
          case 16: {
            RowCount = input.ReadInt64();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Contains options specific to Arrow Serialization.
  /// </summary>
  public sealed partial class ArrowSerializationOptions : pb::IMessage<ArrowSerializationOptions>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ArrowSerializationOptions> _parser = new pb::MessageParser<ArrowSerializationOptions>(() => new ArrowSerializationOptions());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ArrowSerializationOptions> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.BigQuery.Storage.V1.ArrowReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArrowSerializationOptions() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArrowSerializationOptions(ArrowSerializationOptions other) : this() {
      bufferCompression_ = other.bufferCompression_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArrowSerializationOptions Clone() {
      return new ArrowSerializationOptions(this);
    }

    /// <summary>Field number for the "buffer_compression" field.</summary>
    public const int BufferCompressionFieldNumber = 2;
    private global::Google.Cloud.BigQuery.Storage.V1.ArrowSerializationOptions.Types.CompressionCodec bufferCompression_ = global::Google.Cloud.BigQuery.Storage.V1.ArrowSerializationOptions.Types.CompressionCodec.CompressionUnspecified;
    /// <summary>
    /// The compression codec to use for Arrow buffers in serialized record
    /// batches.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.BigQuery.Storage.V1.ArrowSerializationOptions.Types.CompressionCodec BufferCompression {
      get { return bufferCompression_; }
      set {
        bufferCompression_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ArrowSerializationOptions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ArrowSerializationOptions other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BufferCompression != other.BufferCompression) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (BufferCompression != global::Google.Cloud.BigQuery.Storage.V1.ArrowSerializationOptions.Types.CompressionCodec.CompressionUnspecified) hash ^= BufferCompression.GetHashCode();
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
      if (BufferCompression != global::Google.Cloud.BigQuery.Storage.V1.ArrowSerializationOptions.Types.CompressionCodec.CompressionUnspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) BufferCompression);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (BufferCompression != global::Google.Cloud.BigQuery.Storage.V1.ArrowSerializationOptions.Types.CompressionCodec.CompressionUnspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) BufferCompression);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (BufferCompression != global::Google.Cloud.BigQuery.Storage.V1.ArrowSerializationOptions.Types.CompressionCodec.CompressionUnspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) BufferCompression);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ArrowSerializationOptions other) {
      if (other == null) {
        return;
      }
      if (other.BufferCompression != global::Google.Cloud.BigQuery.Storage.V1.ArrowSerializationOptions.Types.CompressionCodec.CompressionUnspecified) {
        BufferCompression = other.BufferCompression;
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
          case 16: {
            BufferCompression = (global::Google.Cloud.BigQuery.Storage.V1.ArrowSerializationOptions.Types.CompressionCodec) input.ReadEnum();
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
          case 16: {
            BufferCompression = (global::Google.Cloud.BigQuery.Storage.V1.ArrowSerializationOptions.Types.CompressionCodec) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ArrowSerializationOptions message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Compression codec's supported by Arrow.
      /// </summary>
      public enum CompressionCodec {
        /// <summary>
        /// If unspecified no compression will be used.
        /// </summary>
        [pbr::OriginalName("COMPRESSION_UNSPECIFIED")] CompressionUnspecified = 0,
        /// <summary>
        /// LZ4 Frame (https://github.com/lz4/lz4/blob/dev/doc/lz4_Frame_format.md)
        /// </summary>
        [pbr::OriginalName("LZ4_FRAME")] Lz4Frame = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code