// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: grafeas/v1/build.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Grafeas.V1 {

  /// <summary>Holder for reflection information generated from grafeas/v1/build.proto</summary>
  public static partial class BuildReflection {

    #region Descriptor
    /// <summary>File descriptor for grafeas/v1/build.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BuildReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZncmFmZWFzL3YxL2J1aWxkLnByb3RvEgpncmFmZWFzLnYxGiJncmFmZWFz",
            "L3YxL2ludG90b19wcm92ZW5hbmNlLnByb3RvGiFncmFmZWFzL3YxL2ludG90",
            "b19zdGF0ZW1lbnQucHJvdG8aG2dyYWZlYXMvdjEvcHJvdmVuYW5jZS5wcm90",
            "byIkCglCdWlsZE5vdGUSFwoPYnVpbGRlcl92ZXJzaW9uGAEgASgJIswBCg9C",
            "dWlsZE9jY3VycmVuY2USLwoKcHJvdmVuYW5jZRgBIAEoCzIbLmdyYWZlYXMu",
            "djEuQnVpbGRQcm92ZW5hbmNlEhgKEHByb3ZlbmFuY2VfYnl0ZXMYAiABKAkS",
            "NwoRaW50b3RvX3Byb3ZlbmFuY2UYAyABKAsyHC5ncmFmZWFzLnYxLkluVG90",
            "b1Byb3ZlbmFuY2USNQoQaW50b3RvX3N0YXRlbWVudBgEIAEoCzIbLmdyYWZl",
            "YXMudjEuSW5Ub3RvU3RhdGVtZW50QlEKDWlvLmdyYWZlYXMudjFQAVo4Z29v",
            "Z2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9ncmFmZWFzL3Yx",
            "O2dyYWZlYXOiAgNHUkFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Grafeas.V1.IntotoProvenanceReflection.Descriptor, global::Grafeas.V1.IntotoStatementReflection.Descriptor, global::Grafeas.V1.ProvenanceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Grafeas.V1.BuildNote), global::Grafeas.V1.BuildNote.Parser, new[]{ "BuilderVersion" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Grafeas.V1.BuildOccurrence), global::Grafeas.V1.BuildOccurrence.Parser, new[]{ "Provenance", "ProvenanceBytes", "IntotoProvenance", "IntotoStatement" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Note holding the version of the provider's builder and the signature of the
  /// provenance message in the build details occurrence.
  /// </summary>
  public sealed partial class BuildNote : pb::IMessage<BuildNote>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BuildNote> _parser = new pb::MessageParser<BuildNote>(() => new BuildNote());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BuildNote> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grafeas.V1.BuildReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BuildNote() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BuildNote(BuildNote other) : this() {
      builderVersion_ = other.builderVersion_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BuildNote Clone() {
      return new BuildNote(this);
    }

    /// <summary>Field number for the "builder_version" field.</summary>
    public const int BuilderVersionFieldNumber = 1;
    private string builderVersion_ = "";
    /// <summary>
    /// Required. Immutable. Version of the builder which produced this build.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string BuilderVersion {
      get { return builderVersion_; }
      set {
        builderVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BuildNote);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BuildNote other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BuilderVersion != other.BuilderVersion) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BuilderVersion.Length != 0) hash ^= BuilderVersion.GetHashCode();
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
      if (BuilderVersion.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(BuilderVersion);
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
      if (BuilderVersion.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(BuilderVersion);
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
      if (BuilderVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BuilderVersion);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BuildNote other) {
      if (other == null) {
        return;
      }
      if (other.BuilderVersion.Length != 0) {
        BuilderVersion = other.BuilderVersion;
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
            BuilderVersion = input.ReadString();
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
            BuilderVersion = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Details of a build occurrence.
  /// </summary>
  public sealed partial class BuildOccurrence : pb::IMessage<BuildOccurrence>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BuildOccurrence> _parser = new pb::MessageParser<BuildOccurrence>(() => new BuildOccurrence());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BuildOccurrence> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grafeas.V1.BuildReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BuildOccurrence() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BuildOccurrence(BuildOccurrence other) : this() {
      provenance_ = other.provenance_ != null ? other.provenance_.Clone() : null;
      provenanceBytes_ = other.provenanceBytes_;
      intotoProvenance_ = other.intotoProvenance_ != null ? other.intotoProvenance_.Clone() : null;
      intotoStatement_ = other.intotoStatement_ != null ? other.intotoStatement_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BuildOccurrence Clone() {
      return new BuildOccurrence(this);
    }

    /// <summary>Field number for the "provenance" field.</summary>
    public const int ProvenanceFieldNumber = 1;
    private global::Grafeas.V1.BuildProvenance provenance_;
    /// <summary>
    /// The actual provenance for the build.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Grafeas.V1.BuildProvenance Provenance {
      get { return provenance_; }
      set {
        provenance_ = value;
      }
    }

    /// <summary>Field number for the "provenance_bytes" field.</summary>
    public const int ProvenanceBytesFieldNumber = 2;
    private string provenanceBytes_ = "";
    /// <summary>
    /// Serialized JSON representation of the provenance, used in generating the
    /// build signature in the corresponding build note. After verifying the
    /// signature, `provenance_bytes` can be unmarshalled and compared to the
    /// provenance to confirm that it is unchanged. A base64-encoded string
    /// representation of the provenance bytes is used for the signature in order
    /// to interoperate with openssl which expects this format for signature
    /// verification.
    ///
    /// The serialized form is captured both to avoid ambiguity in how the
    /// provenance is marshalled to json as well to prevent incompatibilities with
    /// future changes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ProvenanceBytes {
      get { return provenanceBytes_; }
      set {
        provenanceBytes_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "intoto_provenance" field.</summary>
    public const int IntotoProvenanceFieldNumber = 3;
    private global::Grafeas.V1.InTotoProvenance intotoProvenance_;
    /// <summary>
    /// Deprecated. See InTotoStatement for the replacement.
    /// In-toto Provenance representation as defined in spec.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Grafeas.V1.InTotoProvenance IntotoProvenance {
      get { return intotoProvenance_; }
      set {
        intotoProvenance_ = value;
      }
    }

    /// <summary>Field number for the "intoto_statement" field.</summary>
    public const int IntotoStatementFieldNumber = 4;
    private global::Grafeas.V1.InTotoStatement intotoStatement_;
    /// <summary>
    /// In-toto Statement representation as defined in spec.
    /// The intoto_statement can contain any type of provenance. The serialized
    /// payload of the statement can be stored and signed in the Occurrence's
    /// envelope.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Grafeas.V1.InTotoStatement IntotoStatement {
      get { return intotoStatement_; }
      set {
        intotoStatement_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BuildOccurrence);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BuildOccurrence other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Provenance, other.Provenance)) return false;
      if (ProvenanceBytes != other.ProvenanceBytes) return false;
      if (!object.Equals(IntotoProvenance, other.IntotoProvenance)) return false;
      if (!object.Equals(IntotoStatement, other.IntotoStatement)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (provenance_ != null) hash ^= Provenance.GetHashCode();
      if (ProvenanceBytes.Length != 0) hash ^= ProvenanceBytes.GetHashCode();
      if (intotoProvenance_ != null) hash ^= IntotoProvenance.GetHashCode();
      if (intotoStatement_ != null) hash ^= IntotoStatement.GetHashCode();
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
      if (provenance_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Provenance);
      }
      if (ProvenanceBytes.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ProvenanceBytes);
      }
      if (intotoProvenance_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(IntotoProvenance);
      }
      if (intotoStatement_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(IntotoStatement);
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
      if (provenance_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Provenance);
      }
      if (ProvenanceBytes.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ProvenanceBytes);
      }
      if (intotoProvenance_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(IntotoProvenance);
      }
      if (intotoStatement_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(IntotoStatement);
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
      if (provenance_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Provenance);
      }
      if (ProvenanceBytes.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProvenanceBytes);
      }
      if (intotoProvenance_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(IntotoProvenance);
      }
      if (intotoStatement_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(IntotoStatement);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BuildOccurrence other) {
      if (other == null) {
        return;
      }
      if (other.provenance_ != null) {
        if (provenance_ == null) {
          Provenance = new global::Grafeas.V1.BuildProvenance();
        }
        Provenance.MergeFrom(other.Provenance);
      }
      if (other.ProvenanceBytes.Length != 0) {
        ProvenanceBytes = other.ProvenanceBytes;
      }
      if (other.intotoProvenance_ != null) {
        if (intotoProvenance_ == null) {
          IntotoProvenance = new global::Grafeas.V1.InTotoProvenance();
        }
        IntotoProvenance.MergeFrom(other.IntotoProvenance);
      }
      if (other.intotoStatement_ != null) {
        if (intotoStatement_ == null) {
          IntotoStatement = new global::Grafeas.V1.InTotoStatement();
        }
        IntotoStatement.MergeFrom(other.IntotoStatement);
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
            if (provenance_ == null) {
              Provenance = new global::Grafeas.V1.BuildProvenance();
            }
            input.ReadMessage(Provenance);
            break;
          }
          case 18: {
            ProvenanceBytes = input.ReadString();
            break;
          }
          case 26: {
            if (intotoProvenance_ == null) {
              IntotoProvenance = new global::Grafeas.V1.InTotoProvenance();
            }
            input.ReadMessage(IntotoProvenance);
            break;
          }
          case 34: {
            if (intotoStatement_ == null) {
              IntotoStatement = new global::Grafeas.V1.InTotoStatement();
            }
            input.ReadMessage(IntotoStatement);
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
            if (provenance_ == null) {
              Provenance = new global::Grafeas.V1.BuildProvenance();
            }
            input.ReadMessage(Provenance);
            break;
          }
          case 18: {
            ProvenanceBytes = input.ReadString();
            break;
          }
          case 26: {
            if (intotoProvenance_ == null) {
              IntotoProvenance = new global::Grafeas.V1.InTotoProvenance();
            }
            input.ReadMessage(IntotoProvenance);
            break;
          }
          case 34: {
            if (intotoStatement_ == null) {
              IntotoStatement = new global::Grafeas.V1.InTotoStatement();
            }
            input.ReadMessage(IntotoStatement);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
