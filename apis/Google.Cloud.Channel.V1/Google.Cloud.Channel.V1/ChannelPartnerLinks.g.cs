// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/channel/v1/channel_partner_links.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Channel.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/channel/v1/channel_partner_links.proto</summary>
  public static partial class ChannelPartnerLinksReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/channel/v1/channel_partner_links.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChannelPartnerLinksReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvY2xvdWQvY2hhbm5lbC92MS9jaGFubmVsX3BhcnRuZXJfbGlu",
            "a3MucHJvdG8SF2dvb2dsZS5jbG91ZC5jaGFubmVsLnYxGhxnb29nbGUvYXBp",
            "L2Fubm90YXRpb25zLnByb3RvGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9y",
            "LnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvGiRnb29nbGUvY2xv",
            "dWQvY2hhbm5lbC92MS9jb21tb24ucHJvdG8aH2dvb2dsZS9wcm90b2J1Zi90",
            "aW1lc3RhbXAucHJvdG8ijwQKEkNoYW5uZWxQYXJ0bmVyTGluaxIRCgRuYW1l",
            "GAEgASgJQgPgQQMSJwoacmVzZWxsZXJfY2xvdWRfaWRlbnRpdHlfaWQYAiAB",
            "KAlCA+BBAhJJCgpsaW5rX3N0YXRlGAMgASgOMjAuZ29vZ2xlLmNsb3VkLmNo",
            "YW5uZWwudjEuQ2hhbm5lbFBhcnRuZXJMaW5rU3RhdGVCA+BBAhIcCg9pbnZp",
            "dGVfbGlua191cmkYBCABKAlCA+BBAxI0CgtjcmVhdGVfdGltZRgFIAEoCzIa",
            "Lmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXBCA+BBAxI0Cgt1cGRhdGVfdGlt",
            "ZRgGIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXBCA+BBAxIWCglw",
            "dWJsaWNfaWQYByABKAlCA+BBAxJcCiNjaGFubmVsX3BhcnRuZXJfY2xvdWRf",
            "aWRlbnRpdHlfaW5mbxgIIAEoCzIqLmdvb2dsZS5jbG91ZC5jaGFubmVsLnYx",
            "LkNsb3VkSWRlbnRpdHlJbmZvQgPgQQM6cupBbwouY2xvdWRjaGFubmVsLmdv",
            "b2dsZWFwaXMuY29tL0NoYW5uZWxQYXJ0bmVyTGluaxI9YWNjb3VudHMve2Fj",
            "Y291bnR9L2NoYW5uZWxQYXJ0bmVyTGlua3Mve2NoYW5uZWxfcGFydG5lcl9s",
            "aW5rfSo+ChZDaGFubmVsUGFydG5lckxpbmtWaWV3Eg8KC1VOU1BFQ0lGSUVE",
            "EAASCQoFQkFTSUMQARIICgRGVUxMEAIqegoXQ2hhbm5lbFBhcnRuZXJMaW5r",
            "U3RhdGUSKgomQ0hBTk5FTF9QQVJUTkVSX0xJTktfU1RBVEVfVU5TUEVDSUZJ",
            "RUQQABILCgdJTlZJVEVEEAESCgoGQUNUSVZFEAISCwoHUkVWT0tFRBADEg0K",
            "CVNVU1BFTkRFRBAEQnkKG2NvbS5nb29nbGUuY2xvdWQuY2hhbm5lbC52MUIY",
            "Q2hhbm5lbFBhcnRuZXJMaW5rc1Byb3RvUAFaPmdvb2dsZS5nb2xhbmcub3Jn",
            "L2dlbnByb3RvL2dvb2dsZWFwaXMvY2xvdWQvY2hhbm5lbC92MTtjaGFubmVs",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.Channel.V1.CommonReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Cloud.Channel.V1.ChannelPartnerLinkView), typeof(global::Google.Cloud.Channel.V1.ChannelPartnerLinkState), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Channel.V1.ChannelPartnerLink), global::Google.Cloud.Channel.V1.ChannelPartnerLink.Parser, new[]{ "Name", "ResellerCloudIdentityId", "LinkState", "InviteLinkUri", "CreateTime", "UpdateTime", "PublicId", "ChannelPartnerCloudIdentityInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// The level of granularity the [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] will display.
  /// </summary>
  public enum ChannelPartnerLinkView {
    /// <summary>
    /// The default / unset value.
    /// The API will default to the BASIC view.
    /// </summary>
    [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// Includes all fields except the
    /// [ChannelPartnerLink.channel_partner_cloud_identity_info][google.cloud.channel.v1.ChannelPartnerLink.channel_partner_cloud_identity_info].
    /// </summary>
    [pbr::OriginalName("BASIC")] Basic = 1,
    /// <summary>
    /// Includes all fields.
    /// </summary>
    [pbr::OriginalName("FULL")] Full = 2,
  }

  /// <summary>
  /// ChannelPartnerLinkState represents state of a channel partner link.
  /// </summary>
  public enum ChannelPartnerLinkState {
    /// <summary>
    /// Not used.
    /// </summary>
    [pbr::OriginalName("CHANNEL_PARTNER_LINK_STATE_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// An invitation has been sent to the reseller to create a channel partner
    /// link.
    /// </summary>
    [pbr::OriginalName("INVITED")] Invited = 1,
    /// <summary>
    /// Status when the reseller is active.
    /// </summary>
    [pbr::OriginalName("ACTIVE")] Active = 2,
    /// <summary>
    /// Status when the reseller has been revoked by the distributor.
    /// </summary>
    [pbr::OriginalName("REVOKED")] Revoked = 3,
    /// <summary>
    /// Status when the reseller is suspended by Google or distributor.
    /// </summary>
    [pbr::OriginalName("SUSPENDED")] Suspended = 4,
  }

  #endregion

  #region Messages
  /// <summary>
  /// Entity representing a link between distributors and their indirect
  /// resellers in an n-tier resale channel.
  /// </summary>
  public sealed partial class ChannelPartnerLink : pb::IMessage<ChannelPartnerLink>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChannelPartnerLink> _parser = new pb::MessageParser<ChannelPartnerLink>(() => new ChannelPartnerLink());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChannelPartnerLink> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Channel.V1.ChannelPartnerLinksReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChannelPartnerLink() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChannelPartnerLink(ChannelPartnerLink other) : this() {
      name_ = other.name_;
      resellerCloudIdentityId_ = other.resellerCloudIdentityId_;
      linkState_ = other.linkState_;
      inviteLinkUri_ = other.inviteLinkUri_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      publicId_ = other.publicId_;
      channelPartnerCloudIdentityInfo_ = other.channelPartnerCloudIdentityInfo_ != null ? other.channelPartnerCloudIdentityInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChannelPartnerLink Clone() {
      return new ChannelPartnerLink(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Output only. Resource name for the channel partner link, in the format
    /// accounts/{account_id}/channelPartnerLinks/{id}.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "reseller_cloud_identity_id" field.</summary>
    public const int ResellerCloudIdentityIdFieldNumber = 2;
    private string resellerCloudIdentityId_ = "";
    /// <summary>
    /// Required. Cloud Identity ID of the linked reseller.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResellerCloudIdentityId {
      get { return resellerCloudIdentityId_; }
      set {
        resellerCloudIdentityId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "link_state" field.</summary>
    public const int LinkStateFieldNumber = 3;
    private global::Google.Cloud.Channel.V1.ChannelPartnerLinkState linkState_ = global::Google.Cloud.Channel.V1.ChannelPartnerLinkState.Unspecified;
    /// <summary>
    /// Required. State of the channel partner link.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Channel.V1.ChannelPartnerLinkState LinkState {
      get { return linkState_; }
      set {
        linkState_ = value;
      }
    }

    /// <summary>Field number for the "invite_link_uri" field.</summary>
    public const int InviteLinkUriFieldNumber = 4;
    private string inviteLinkUri_ = "";
    /// <summary>
    /// Output only. URI of the web page where partner accepts the link invitation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string InviteLinkUri {
      get { return inviteLinkUri_; }
      set {
        inviteLinkUri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. Timestamp of when the channel partner link is created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "update_time" field.</summary>
    public const int UpdateTimeFieldNumber = 6;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updateTime_;
    /// <summary>
    /// Output only. Timestamp of when the channel partner link is updated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdateTime {
      get { return updateTime_; }
      set {
        updateTime_ = value;
      }
    }

    /// <summary>Field number for the "public_id" field.</summary>
    public const int PublicIdFieldNumber = 7;
    private string publicId_ = "";
    /// <summary>
    /// Output only. Public identifier that a customer must use to generate a transfer token
    /// to move to this distributor-reseller combination.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PublicId {
      get { return publicId_; }
      set {
        publicId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "channel_partner_cloud_identity_info" field.</summary>
    public const int ChannelPartnerCloudIdentityInfoFieldNumber = 8;
    private global::Google.Cloud.Channel.V1.CloudIdentityInfo channelPartnerCloudIdentityInfo_;
    /// <summary>
    /// Output only. Cloud Identity info of the channel partner (IR).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Channel.V1.CloudIdentityInfo ChannelPartnerCloudIdentityInfo {
      get { return channelPartnerCloudIdentityInfo_; }
      set {
        channelPartnerCloudIdentityInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChannelPartnerLink);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChannelPartnerLink other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (ResellerCloudIdentityId != other.ResellerCloudIdentityId) return false;
      if (LinkState != other.LinkState) return false;
      if (InviteLinkUri != other.InviteLinkUri) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      if (PublicId != other.PublicId) return false;
      if (!object.Equals(ChannelPartnerCloudIdentityInfo, other.ChannelPartnerCloudIdentityInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (ResellerCloudIdentityId.Length != 0) hash ^= ResellerCloudIdentityId.GetHashCode();
      if (LinkState != global::Google.Cloud.Channel.V1.ChannelPartnerLinkState.Unspecified) hash ^= LinkState.GetHashCode();
      if (InviteLinkUri.Length != 0) hash ^= InviteLinkUri.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (updateTime_ != null) hash ^= UpdateTime.GetHashCode();
      if (PublicId.Length != 0) hash ^= PublicId.GetHashCode();
      if (channelPartnerCloudIdentityInfo_ != null) hash ^= ChannelPartnerCloudIdentityInfo.GetHashCode();
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
      if (ResellerCloudIdentityId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ResellerCloudIdentityId);
      }
      if (LinkState != global::Google.Cloud.Channel.V1.ChannelPartnerLinkState.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) LinkState);
      }
      if (InviteLinkUri.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(InviteLinkUri);
      }
      if (createTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(UpdateTime);
      }
      if (PublicId.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(PublicId);
      }
      if (channelPartnerCloudIdentityInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(ChannelPartnerCloudIdentityInfo);
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
      if (ResellerCloudIdentityId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ResellerCloudIdentityId);
      }
      if (LinkState != global::Google.Cloud.Channel.V1.ChannelPartnerLinkState.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) LinkState);
      }
      if (InviteLinkUri.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(InviteLinkUri);
      }
      if (createTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(UpdateTime);
      }
      if (PublicId.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(PublicId);
      }
      if (channelPartnerCloudIdentityInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(ChannelPartnerCloudIdentityInfo);
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
      if (ResellerCloudIdentityId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResellerCloudIdentityId);
      }
      if (LinkState != global::Google.Cloud.Channel.V1.ChannelPartnerLinkState.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) LinkState);
      }
      if (InviteLinkUri.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(InviteLinkUri);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (updateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateTime);
      }
      if (PublicId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PublicId);
      }
      if (channelPartnerCloudIdentityInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ChannelPartnerCloudIdentityInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChannelPartnerLink other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.ResellerCloudIdentityId.Length != 0) {
        ResellerCloudIdentityId = other.ResellerCloudIdentityId;
      }
      if (other.LinkState != global::Google.Cloud.Channel.V1.ChannelPartnerLinkState.Unspecified) {
        LinkState = other.LinkState;
      }
      if (other.InviteLinkUri.Length != 0) {
        InviteLinkUri = other.InviteLinkUri;
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
      if (other.PublicId.Length != 0) {
        PublicId = other.PublicId;
      }
      if (other.channelPartnerCloudIdentityInfo_ != null) {
        if (channelPartnerCloudIdentityInfo_ == null) {
          ChannelPartnerCloudIdentityInfo = new global::Google.Cloud.Channel.V1.CloudIdentityInfo();
        }
        ChannelPartnerCloudIdentityInfo.MergeFrom(other.ChannelPartnerCloudIdentityInfo);
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
            ResellerCloudIdentityId = input.ReadString();
            break;
          }
          case 24: {
            LinkState = (global::Google.Cloud.Channel.V1.ChannelPartnerLinkState) input.ReadEnum();
            break;
          }
          case 34: {
            InviteLinkUri = input.ReadString();
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
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 58: {
            PublicId = input.ReadString();
            break;
          }
          case 66: {
            if (channelPartnerCloudIdentityInfo_ == null) {
              ChannelPartnerCloudIdentityInfo = new global::Google.Cloud.Channel.V1.CloudIdentityInfo();
            }
            input.ReadMessage(ChannelPartnerCloudIdentityInfo);
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
            ResellerCloudIdentityId = input.ReadString();
            break;
          }
          case 24: {
            LinkState = (global::Google.Cloud.Channel.V1.ChannelPartnerLinkState) input.ReadEnum();
            break;
          }
          case 34: {
            InviteLinkUri = input.ReadString();
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
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 58: {
            PublicId = input.ReadString();
            break;
          }
          case 66: {
            if (channelPartnerCloudIdentityInfo_ == null) {
              ChannelPartnerCloudIdentityInfo = new global::Google.Cloud.Channel.V1.CloudIdentityInfo();
            }
            input.ReadMessage(ChannelPartnerCloudIdentityInfo);
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
