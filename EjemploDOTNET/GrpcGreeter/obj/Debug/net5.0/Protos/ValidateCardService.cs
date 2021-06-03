// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/validate-card-service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ValidateCardService {

  /// <summary>Holder for reflection information generated from Protos/validate-card-service.proto</summary>
  public static partial class ValidateCardServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/validate-card-service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ValidateCardServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJQcm90b3MvdmFsaWRhdGUtY2FyZC1zZXJ2aWNlLnByb3RvEgRDYXJkIjwK",
            "C0NhcmRSZXF1ZXN0Eg8KB251bUNhcmQYASABKAkSDwoHZGF0ZUV4cBgCIAEo",
            "CRILCgNjdnYYAyABKAkiHwoJQ2FyZFJlcGx5EhIKCmlzQWNjZXB0ZWQYASAB",
            "KAgySwoRVmFsaWRhdGVDYXJkQ2hlY2sSNgoQQ2hlY2tDYXJkUmVxdWVzdBIR",
            "LkNhcmQuQ2FyZFJlcXVlc3QaDy5DYXJkLkNhcmRSZXBseUIWqgITVmFsaWRh",
            "dGVDYXJkU2VydmljZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ValidateCardService.CardRequest), global::ValidateCardService.CardRequest.Parser, new[]{ "NumCard", "DateExp", "Cvv" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ValidateCardService.CardReply), global::ValidateCardService.CardReply.Parser, new[]{ "IsAccepted" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CardRequest : pb::IMessage<CardRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CardRequest> _parser = new pb::MessageParser<CardRequest>(() => new CardRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CardRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ValidateCardService.ValidateCardServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardRequest(CardRequest other) : this() {
      numCard_ = other.numCard_;
      dateExp_ = other.dateExp_;
      cvv_ = other.cvv_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardRequest Clone() {
      return new CardRequest(this);
    }

    /// <summary>Field number for the "numCard" field.</summary>
    public const int NumCardFieldNumber = 1;
    private string numCard_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string NumCard {
      get { return numCard_; }
      set {
        numCard_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "dateExp" field.</summary>
    public const int DateExpFieldNumber = 2;
    private string dateExp_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DateExp {
      get { return dateExp_; }
      set {
        dateExp_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "cvv" field.</summary>
    public const int CvvFieldNumber = 3;
    private string cvv_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Cvv {
      get { return cvv_; }
      set {
        cvv_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CardRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CardRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NumCard != other.NumCard) return false;
      if (DateExp != other.DateExp) return false;
      if (Cvv != other.Cvv) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (NumCard.Length != 0) hash ^= NumCard.GetHashCode();
      if (DateExp.Length != 0) hash ^= DateExp.GetHashCode();
      if (Cvv.Length != 0) hash ^= Cvv.GetHashCode();
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
      if (NumCard.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(NumCard);
      }
      if (DateExp.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DateExp);
      }
      if (Cvv.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Cvv);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (NumCard.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(NumCard);
      }
      if (DateExp.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DateExp);
      }
      if (Cvv.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Cvv);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (NumCard.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NumCard);
      }
      if (DateExp.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DateExp);
      }
      if (Cvv.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Cvv);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CardRequest other) {
      if (other == null) {
        return;
      }
      if (other.NumCard.Length != 0) {
        NumCard = other.NumCard;
      }
      if (other.DateExp.Length != 0) {
        DateExp = other.DateExp;
      }
      if (other.Cvv.Length != 0) {
        Cvv = other.Cvv;
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
            NumCard = input.ReadString();
            break;
          }
          case 18: {
            DateExp = input.ReadString();
            break;
          }
          case 26: {
            Cvv = input.ReadString();
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
            NumCard = input.ReadString();
            break;
          }
          case 18: {
            DateExp = input.ReadString();
            break;
          }
          case 26: {
            Cvv = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class CardReply : pb::IMessage<CardReply>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CardReply> _parser = new pb::MessageParser<CardReply>(() => new CardReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CardReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ValidateCardService.ValidateCardServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardReply(CardReply other) : this() {
      isAccepted_ = other.isAccepted_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardReply Clone() {
      return new CardReply(this);
    }

    /// <summary>Field number for the "isAccepted" field.</summary>
    public const int IsAcceptedFieldNumber = 1;
    private bool isAccepted_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsAccepted {
      get { return isAccepted_; }
      set {
        isAccepted_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CardReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CardReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsAccepted != other.IsAccepted) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IsAccepted != false) hash ^= IsAccepted.GetHashCode();
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
      if (IsAccepted != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsAccepted);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (IsAccepted != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsAccepted);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (IsAccepted != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CardReply other) {
      if (other == null) {
        return;
      }
      if (other.IsAccepted != false) {
        IsAccepted = other.IsAccepted;
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
          case 8: {
            IsAccepted = input.ReadBool();
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
          case 8: {
            IsAccepted = input.ReadBool();
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
