// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/talent/v4beta1/company.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Talent.V4Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/talent/v4beta1/company.proto</summary>
  public static partial class CompanyReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/talent/v4beta1/company.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CompanyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cilnb29nbGUvY2xvdWQvdGFsZW50L3Y0YmV0YTEvY29tcGFueS5wcm90bxIb",
            "Z29vZ2xlLmNsb3VkLnRhbGVudC52NGJldGExGh9nb29nbGUvYXBpL2ZpZWxk",
            "X2JlaGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvGihn",
            "b29nbGUvY2xvdWQvdGFsZW50L3Y0YmV0YTEvY29tbW9uLnByb3RvGhxnb29n",
            "bGUvYXBpL2Fubm90YXRpb25zLnByb3RvIvwECgdDb21wYW55EgwKBG5hbWUY",
            "ASABKAkSGQoMZGlzcGxheV9uYW1lGAIgASgJQgPgQQISGAoLZXh0ZXJuYWxf",
            "aWQYAyABKAlCA+BBAhI2CgRzaXplGAQgASgOMiguZ29vZ2xlLmNsb3VkLnRh",
            "bGVudC52NGJldGExLkNvbXBhbnlTaXplEhwKFGhlYWRxdWFydGVyc19hZGRy",
            "ZXNzGAUgASgJEhUKDWhpcmluZ19hZ2VuY3kYBiABKAgSEAoIZWVvX3RleHQY",
            "ByABKAkSEwoLd2Vic2l0ZV91cmkYCCABKAkSFwoPY2FyZWVyX3NpdGVfdXJp",
            "GAkgASgJEhEKCWltYWdlX3VyaRgKIAEoCRIwCihrZXl3b3JkX3NlYXJjaGFi",
            "bGVfam9iX2N1c3RvbV9hdHRyaWJ1dGVzGAsgAygJEksKDGRlcml2ZWRfaW5m",
            "bxgMIAEoCzIwLmdvb2dsZS5jbG91ZC50YWxlbnQudjRiZXRhMS5Db21wYW55",
            "LkRlcml2ZWRJbmZvQgPgQQMSFgoJc3VzcGVuZGVkGA0gASgIQgPgQQMaUwoL",
            "RGVyaXZlZEluZm8SRAoVaGVhZHF1YXJ0ZXJzX2xvY2F0aW9uGAEgASgLMiUu",
            "Z29vZ2xlLmNsb3VkLnRhbGVudC52NGJldGExLkxvY2F0aW9uOoEB6kF+Chtq",
            "b2JzLmdvb2dsZWFwaXMuY29tL0NvbXBhbnkSN3Byb2plY3RzL3twcm9qZWN0",
            "fS90ZW5hbnRzL3t0ZW5hbnR9L2NvbXBhbmllcy97Y29tcGFueX0SJnByb2pl",
            "Y3RzL3twcm9qZWN0fS9jb21wYW5pZXMve2NvbXBhbnl9QoIBCh9jb20uZ29v",
            "Z2xlLmNsb3VkLnRhbGVudC52NGJldGExQhRDb21wYW55UmVzb3VyY2VQcm90",
            "b1ABWkFnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Ns",
            "b3VkL3RhbGVudC92NGJldGExO3RhbGVudKICA0NUU2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.Talent.V4Beta1.CommonReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Talent.V4Beta1.Company), global::Google.Cloud.Talent.V4Beta1.Company.Parser, new[]{ "Name", "DisplayName", "ExternalId", "Size", "HeadquartersAddress", "HiringAgency", "EeoText", "WebsiteUri", "CareerSiteUri", "ImageUri", "KeywordSearchableJobCustomAttributes", "DerivedInfo", "Suspended" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Talent.V4Beta1.Company.Types.DerivedInfo), global::Google.Cloud.Talent.V4Beta1.Company.Types.DerivedInfo.Parser, new[]{ "HeadquartersLocation" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A Company resource represents a company in the service. A company is the
  /// entity that owns job postings, that is, the hiring entity responsible for
  /// employing applicants for the job position.
  /// </summary>
  public sealed partial class Company : pb::IMessage<Company> {
    private static readonly pb::MessageParser<Company> _parser = new pb::MessageParser<Company>(() => new Company());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Company> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Talent.V4Beta1.CompanyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Company() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Company(Company other) : this() {
      name_ = other.name_;
      displayName_ = other.displayName_;
      externalId_ = other.externalId_;
      size_ = other.size_;
      headquartersAddress_ = other.headquartersAddress_;
      hiringAgency_ = other.hiringAgency_;
      eeoText_ = other.eeoText_;
      websiteUri_ = other.websiteUri_;
      careerSiteUri_ = other.careerSiteUri_;
      imageUri_ = other.imageUri_;
      keywordSearchableJobCustomAttributes_ = other.keywordSearchableJobCustomAttributes_.Clone();
      derivedInfo_ = other.derivedInfo_ != null ? other.derivedInfo_.Clone() : null;
      suspended_ = other.suspended_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Company Clone() {
      return new Company(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Required during company update.
    ///
    /// The resource name for a company. This is generated by the service when a
    /// company is created.
    ///
    /// The format is
    /// "projects/{project_id}/tenants/{tenant_id}/companies/{company_id}", for
    /// example, "projects/foo/tenants/bar/companies/baz".
    ///
    /// If tenant id is unspecified, the default tenant is used. For
    /// example, "projects/foo/companies/bar".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 2;
    private string displayName_ = "";
    /// <summary>
    /// Required. The display name of the company, for example, "Google LLC".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "external_id" field.</summary>
    public const int ExternalIdFieldNumber = 3;
    private string externalId_ = "";
    /// <summary>
    /// Required. Client side company identifier, used to uniquely identify the
    /// company.
    ///
    /// The maximum number of allowed characters is 255.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ExternalId {
      get { return externalId_; }
      set {
        externalId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "size" field.</summary>
    public const int SizeFieldNumber = 4;
    private global::Google.Cloud.Talent.V4Beta1.CompanySize size_ = global::Google.Cloud.Talent.V4Beta1.CompanySize.Unspecified;
    /// <summary>
    /// The employer's company size.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Talent.V4Beta1.CompanySize Size {
      get { return size_; }
      set {
        size_ = value;
      }
    }

    /// <summary>Field number for the "headquarters_address" field.</summary>
    public const int HeadquartersAddressFieldNumber = 5;
    private string headquartersAddress_ = "";
    /// <summary>
    /// The street address of the company's main headquarters, which may be
    /// different from the job location. The service attempts
    /// to geolocate the provided address, and populates a more specific
    /// location wherever possible in [DerivedInfo.headquarters_location][google.cloud.talent.v4beta1.Company.DerivedInfo.headquarters_location].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string HeadquartersAddress {
      get { return headquartersAddress_; }
      set {
        headquartersAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "hiring_agency" field.</summary>
    public const int HiringAgencyFieldNumber = 6;
    private bool hiringAgency_;
    /// <summary>
    /// Set to true if it is the hiring agency that post jobs for other
    /// employers.
    ///
    /// Defaults to false if not provided.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HiringAgency {
      get { return hiringAgency_; }
      set {
        hiringAgency_ = value;
      }
    }

    /// <summary>Field number for the "eeo_text" field.</summary>
    public const int EeoTextFieldNumber = 7;
    private string eeoText_ = "";
    /// <summary>
    /// Equal Employment Opportunity legal disclaimer text to be
    /// associated with all jobs, and typically to be displayed in all
    /// roles.
    ///
    /// The maximum number of allowed characters is 500.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string EeoText {
      get { return eeoText_; }
      set {
        eeoText_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "website_uri" field.</summary>
    public const int WebsiteUriFieldNumber = 8;
    private string websiteUri_ = "";
    /// <summary>
    /// The URI representing the company's primary web site or home page,
    /// for example, "https://www.google.com".
    ///
    /// The maximum number of allowed characters is 255.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string WebsiteUri {
      get { return websiteUri_; }
      set {
        websiteUri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "career_site_uri" field.</summary>
    public const int CareerSiteUriFieldNumber = 9;
    private string careerSiteUri_ = "";
    /// <summary>
    /// The URI to employer's career site or careers page on the employer's web
    /// site, for example, "https://careers.google.com".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CareerSiteUri {
      get { return careerSiteUri_; }
      set {
        careerSiteUri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "image_uri" field.</summary>
    public const int ImageUriFieldNumber = 10;
    private string imageUri_ = "";
    /// <summary>
    /// A URI that hosts the employer's company logo.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ImageUri {
      get { return imageUri_; }
      set {
        imageUri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "keyword_searchable_job_custom_attributes" field.</summary>
    public const int KeywordSearchableJobCustomAttributesFieldNumber = 11;
    private static readonly pb::FieldCodec<string> _repeated_keywordSearchableJobCustomAttributes_codec
        = pb::FieldCodec.ForString(90);
    private readonly pbc::RepeatedField<string> keywordSearchableJobCustomAttributes_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// A list of keys of filterable [Job.custom_attributes][google.cloud.talent.v4beta1.Job.custom_attributes], whose
    /// corresponding `string_values` are used in keyword searches. Jobs with
    /// `string_values` under these specified field keys are returned if any
    /// of the values match the search keyword. Custom field values with
    /// parenthesis, brackets and special symbols are not searchable as-is,
    /// and those keyword queries must be surrounded by quotes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> KeywordSearchableJobCustomAttributes {
      get { return keywordSearchableJobCustomAttributes_; }
    }

    /// <summary>Field number for the "derived_info" field.</summary>
    public const int DerivedInfoFieldNumber = 12;
    private global::Google.Cloud.Talent.V4Beta1.Company.Types.DerivedInfo derivedInfo_;
    /// <summary>
    /// Output only. Derived details about the company.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Talent.V4Beta1.Company.Types.DerivedInfo DerivedInfo {
      get { return derivedInfo_; }
      set {
        derivedInfo_ = value;
      }
    }

    /// <summary>Field number for the "suspended" field.</summary>
    public const int SuspendedFieldNumber = 13;
    private bool suspended_;
    /// <summary>
    /// Output only. Indicates whether a company is flagged to be suspended from
    /// public availability by the service when job content appears suspicious,
    /// abusive, or spammy.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Suspended {
      get { return suspended_; }
      set {
        suspended_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Company);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Company other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (DisplayName != other.DisplayName) return false;
      if (ExternalId != other.ExternalId) return false;
      if (Size != other.Size) return false;
      if (HeadquartersAddress != other.HeadquartersAddress) return false;
      if (HiringAgency != other.HiringAgency) return false;
      if (EeoText != other.EeoText) return false;
      if (WebsiteUri != other.WebsiteUri) return false;
      if (CareerSiteUri != other.CareerSiteUri) return false;
      if (ImageUri != other.ImageUri) return false;
      if(!keywordSearchableJobCustomAttributes_.Equals(other.keywordSearchableJobCustomAttributes_)) return false;
      if (!object.Equals(DerivedInfo, other.DerivedInfo)) return false;
      if (Suspended != other.Suspended) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (ExternalId.Length != 0) hash ^= ExternalId.GetHashCode();
      if (Size != global::Google.Cloud.Talent.V4Beta1.CompanySize.Unspecified) hash ^= Size.GetHashCode();
      if (HeadquartersAddress.Length != 0) hash ^= HeadquartersAddress.GetHashCode();
      if (HiringAgency != false) hash ^= HiringAgency.GetHashCode();
      if (EeoText.Length != 0) hash ^= EeoText.GetHashCode();
      if (WebsiteUri.Length != 0) hash ^= WebsiteUri.GetHashCode();
      if (CareerSiteUri.Length != 0) hash ^= CareerSiteUri.GetHashCode();
      if (ImageUri.Length != 0) hash ^= ImageUri.GetHashCode();
      hash ^= keywordSearchableJobCustomAttributes_.GetHashCode();
      if (derivedInfo_ != null) hash ^= DerivedInfo.GetHashCode();
      if (Suspended != false) hash ^= Suspended.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (ExternalId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ExternalId);
      }
      if (Size != global::Google.Cloud.Talent.V4Beta1.CompanySize.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Size);
      }
      if (HeadquartersAddress.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(HeadquartersAddress);
      }
      if (HiringAgency != false) {
        output.WriteRawTag(48);
        output.WriteBool(HiringAgency);
      }
      if (EeoText.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(EeoText);
      }
      if (WebsiteUri.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(WebsiteUri);
      }
      if (CareerSiteUri.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(CareerSiteUri);
      }
      if (ImageUri.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(ImageUri);
      }
      keywordSearchableJobCustomAttributes_.WriteTo(output, _repeated_keywordSearchableJobCustomAttributes_codec);
      if (derivedInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(DerivedInfo);
      }
      if (Suspended != false) {
        output.WriteRawTag(104);
        output.WriteBool(Suspended);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (ExternalId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ExternalId);
      }
      if (Size != global::Google.Cloud.Talent.V4Beta1.CompanySize.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Size);
      }
      if (HeadquartersAddress.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(HeadquartersAddress);
      }
      if (HiringAgency != false) {
        size += 1 + 1;
      }
      if (EeoText.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EeoText);
      }
      if (WebsiteUri.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(WebsiteUri);
      }
      if (CareerSiteUri.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CareerSiteUri);
      }
      if (ImageUri.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ImageUri);
      }
      size += keywordSearchableJobCustomAttributes_.CalculateSize(_repeated_keywordSearchableJobCustomAttributes_codec);
      if (derivedInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DerivedInfo);
      }
      if (Suspended != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Company other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.ExternalId.Length != 0) {
        ExternalId = other.ExternalId;
      }
      if (other.Size != global::Google.Cloud.Talent.V4Beta1.CompanySize.Unspecified) {
        Size = other.Size;
      }
      if (other.HeadquartersAddress.Length != 0) {
        HeadquartersAddress = other.HeadquartersAddress;
      }
      if (other.HiringAgency != false) {
        HiringAgency = other.HiringAgency;
      }
      if (other.EeoText.Length != 0) {
        EeoText = other.EeoText;
      }
      if (other.WebsiteUri.Length != 0) {
        WebsiteUri = other.WebsiteUri;
      }
      if (other.CareerSiteUri.Length != 0) {
        CareerSiteUri = other.CareerSiteUri;
      }
      if (other.ImageUri.Length != 0) {
        ImageUri = other.ImageUri;
      }
      keywordSearchableJobCustomAttributes_.Add(other.keywordSearchableJobCustomAttributes_);
      if (other.derivedInfo_ != null) {
        if (derivedInfo_ == null) {
          DerivedInfo = new global::Google.Cloud.Talent.V4Beta1.Company.Types.DerivedInfo();
        }
        DerivedInfo.MergeFrom(other.DerivedInfo);
      }
      if (other.Suspended != false) {
        Suspended = other.Suspended;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
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
            DisplayName = input.ReadString();
            break;
          }
          case 26: {
            ExternalId = input.ReadString();
            break;
          }
          case 32: {
            Size = (global::Google.Cloud.Talent.V4Beta1.CompanySize) input.ReadEnum();
            break;
          }
          case 42: {
            HeadquartersAddress = input.ReadString();
            break;
          }
          case 48: {
            HiringAgency = input.ReadBool();
            break;
          }
          case 58: {
            EeoText = input.ReadString();
            break;
          }
          case 66: {
            WebsiteUri = input.ReadString();
            break;
          }
          case 74: {
            CareerSiteUri = input.ReadString();
            break;
          }
          case 82: {
            ImageUri = input.ReadString();
            break;
          }
          case 90: {
            keywordSearchableJobCustomAttributes_.AddEntriesFrom(input, _repeated_keywordSearchableJobCustomAttributes_codec);
            break;
          }
          case 98: {
            if (derivedInfo_ == null) {
              DerivedInfo = new global::Google.Cloud.Talent.V4Beta1.Company.Types.DerivedInfo();
            }
            input.ReadMessage(DerivedInfo);
            break;
          }
          case 104: {
            Suspended = input.ReadBool();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Company message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Derived details about the company.
      /// </summary>
      public sealed partial class DerivedInfo : pb::IMessage<DerivedInfo> {
        private static readonly pb::MessageParser<DerivedInfo> _parser = new pb::MessageParser<DerivedInfo>(() => new DerivedInfo());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<DerivedInfo> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.Talent.V4Beta1.Company.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public DerivedInfo() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public DerivedInfo(DerivedInfo other) : this() {
          headquartersLocation_ = other.headquartersLocation_ != null ? other.headquartersLocation_.Clone() : null;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public DerivedInfo Clone() {
          return new DerivedInfo(this);
        }

        /// <summary>Field number for the "headquarters_location" field.</summary>
        public const int HeadquartersLocationFieldNumber = 1;
        private global::Google.Cloud.Talent.V4Beta1.Location headquartersLocation_;
        /// <summary>
        /// A structured headquarters location of the company, resolved from
        /// [Company.headquarters_address][google.cloud.talent.v4beta1.Company.headquarters_address] if provided.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Google.Cloud.Talent.V4Beta1.Location HeadquartersLocation {
          get { return headquartersLocation_; }
          set {
            headquartersLocation_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as DerivedInfo);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(DerivedInfo other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (!object.Equals(HeadquartersLocation, other.HeadquartersLocation)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (headquartersLocation_ != null) hash ^= HeadquartersLocation.GetHashCode();
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
          if (headquartersLocation_ != null) {
            output.WriteRawTag(10);
            output.WriteMessage(HeadquartersLocation);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (headquartersLocation_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(HeadquartersLocation);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(DerivedInfo other) {
          if (other == null) {
            return;
          }
          if (other.headquartersLocation_ != null) {
            if (headquartersLocation_ == null) {
              HeadquartersLocation = new global::Google.Cloud.Talent.V4Beta1.Location();
            }
            HeadquartersLocation.MergeFrom(other.HeadquartersLocation);
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 10: {
                if (headquartersLocation_ == null) {
                  HeadquartersLocation = new global::Google.Cloud.Talent.V4Beta1.Location();
                }
                input.ReadMessage(HeadquartersLocation);
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
