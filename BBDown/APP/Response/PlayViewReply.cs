// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: playviewreply.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[global::ProtoBuf.ProtoContract()]
public partial class VideoInfo : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(1, Name = @"quality")]
    public uint Quality
    {
        get => __pbn__Quality.GetValueOrDefault();
        set => __pbn__Quality = value;
    }
    public bool ShouldSerializeQuality() => __pbn__Quality != null;
    public void ResetQuality() => __pbn__Quality = null;
    private uint? __pbn__Quality;

    [global::ProtoBuf.ProtoMember(2, Name = @"format")]
    [global::System.ComponentModel.DefaultValue("")]
    public string Format
    {
        get => __pbn__Format ?? "";
        set => __pbn__Format = value;
    }
    public bool ShouldSerializeFormat() => __pbn__Format != null;
    public void ResetFormat() => __pbn__Format = null;
    private string __pbn__Format;

    [global::ProtoBuf.ProtoMember(3, Name = @"timelength")]
    public ulong Timelength
    {
        get => __pbn__Timelength.GetValueOrDefault();
        set => __pbn__Timelength = value;
    }
    public bool ShouldSerializeTimelength() => __pbn__Timelength != null;
    public void ResetTimelength() => __pbn__Timelength = null;
    private ulong? __pbn__Timelength;

    [global::ProtoBuf.ProtoMember(4)]
    public uint videoCodecid
    {
        get => __pbn__videoCodecid.GetValueOrDefault();
        set => __pbn__videoCodecid = value;
    }
    public bool ShouldSerializevideoCodecid() => __pbn__videoCodecid != null;
    public void ResetvideoCodecid() => __pbn__videoCodecid = null;
    private uint? __pbn__videoCodecid;

    [global::ProtoBuf.ProtoMember(5, Name = @"streamList")]
    public global::System.Collections.Generic.List<StreamItem> streamLists { get; } = new global::System.Collections.Generic.List<StreamItem>();

    [global::ProtoBuf.ProtoMember(6, Name = @"dashAudio")]
    public global::System.Collections.Generic.List<DashItem> dashAudioes { get; } = new global::System.Collections.Generic.List<DashItem>();

    [global::ProtoBuf.ProtoMember(7, Name = @"dolby")]
    public DolbyItem Dolby { get; set; }

}

[global::ProtoBuf.ProtoContract()]
public partial class DolbyItem : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(1, Name = @"type")]
    public int Type
    {
        get => __pbn__Type.GetValueOrDefault();
        set => __pbn__Type = value;
    }
    public bool ShouldSerializeType() => __pbn__Type != null;
    public void ResetType() => __pbn__Type = null;
    private int? __pbn__Type;

    [global::ProtoBuf.ProtoMember(2, Name = @"audio")]
    public DashItem Audio { get; set; }

}

[global::ProtoBuf.ProtoContract()]
public partial class PlayAbilityConf : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(1)]
    public bool backgroundPlayDisable
    {
        get => __pbn__backgroundPlayDisable.GetValueOrDefault();
        set => __pbn__backgroundPlayDisable = value;
    }
    public bool ShouldSerializebackgroundPlayDisable() => __pbn__backgroundPlayDisable != null;
    public void ResetbackgroundPlayDisable() => __pbn__backgroundPlayDisable = null;
    private bool? __pbn__backgroundPlayDisable;

    [global::ProtoBuf.ProtoMember(2)]
    public bool flipDisable
    {
        get => __pbn__flipDisable.GetValueOrDefault();
        set => __pbn__flipDisable = value;
    }
    public bool ShouldSerializeflipDisable() => __pbn__flipDisable != null;
    public void ResetflipDisable() => __pbn__flipDisable = null;
    private bool? __pbn__flipDisable;

    [global::ProtoBuf.ProtoMember(3)]
    public bool castDisable
    {
        get => __pbn__castDisable.GetValueOrDefault();
        set => __pbn__castDisable = value;
    }
    public bool ShouldSerializecastDisable() => __pbn__castDisable != null;
    public void ResetcastDisable() => __pbn__castDisable = null;
    private bool? __pbn__castDisable;

    [global::ProtoBuf.ProtoMember(4)]
    public bool feedbackDisable
    {
        get => __pbn__feedbackDisable.GetValueOrDefault();
        set => __pbn__feedbackDisable = value;
    }
    public bool ShouldSerializefeedbackDisable() => __pbn__feedbackDisable != null;
    public void ResetfeedbackDisable() => __pbn__feedbackDisable = null;
    private bool? __pbn__feedbackDisable;

    [global::ProtoBuf.ProtoMember(5)]
    public bool subtitleDisable
    {
        get => __pbn__subtitleDisable.GetValueOrDefault();
        set => __pbn__subtitleDisable = value;
    }
    public bool ShouldSerializesubtitleDisable() => __pbn__subtitleDisable != null;
    public void ResetsubtitleDisable() => __pbn__subtitleDisable = null;
    private bool? __pbn__subtitleDisable;

    [global::ProtoBuf.ProtoMember(6)]
    public bool playbackRateDisable
    {
        get => __pbn__playbackRateDisable.GetValueOrDefault();
        set => __pbn__playbackRateDisable = value;
    }
    public bool ShouldSerializeplaybackRateDisable() => __pbn__playbackRateDisable != null;
    public void ResetplaybackRateDisable() => __pbn__playbackRateDisable = null;
    private bool? __pbn__playbackRateDisable;

    [global::ProtoBuf.ProtoMember(7)]
    public bool timeUpDisable
    {
        get => __pbn__timeUpDisable.GetValueOrDefault();
        set => __pbn__timeUpDisable = value;
    }
    public bool ShouldSerializetimeUpDisable() => __pbn__timeUpDisable != null;
    public void ResettimeUpDisable() => __pbn__timeUpDisable = null;
    private bool? __pbn__timeUpDisable;

    [global::ProtoBuf.ProtoMember(8)]
    public bool playbackModeDisable
    {
        get => __pbn__playbackModeDisable.GetValueOrDefault();
        set => __pbn__playbackModeDisable = value;
    }
    public bool ShouldSerializeplaybackModeDisable() => __pbn__playbackModeDisable != null;
    public void ResetplaybackModeDisable() => __pbn__playbackModeDisable = null;
    private bool? __pbn__playbackModeDisable;

    [global::ProtoBuf.ProtoMember(9)]
    public bool scaleModeDisable
    {
        get => __pbn__scaleModeDisable.GetValueOrDefault();
        set => __pbn__scaleModeDisable = value;
    }
    public bool ShouldSerializescaleModeDisable() => __pbn__scaleModeDisable != null;
    public void ResetscaleModeDisable() => __pbn__scaleModeDisable = null;
    private bool? __pbn__scaleModeDisable;

    [global::ProtoBuf.ProtoMember(10)]
    public bool likeDisable
    {
        get => __pbn__likeDisable.GetValueOrDefault();
        set => __pbn__likeDisable = value;
    }
    public bool ShouldSerializelikeDisable() => __pbn__likeDisable != null;
    public void ResetlikeDisable() => __pbn__likeDisable = null;
    private bool? __pbn__likeDisable;

    [global::ProtoBuf.ProtoMember(11)]
    public bool dislikeDisable
    {
        get => __pbn__dislikeDisable.GetValueOrDefault();
        set => __pbn__dislikeDisable = value;
    }
    public bool ShouldSerializedislikeDisable() => __pbn__dislikeDisable != null;
    public void ResetdislikeDisable() => __pbn__dislikeDisable = null;
    private bool? __pbn__dislikeDisable;

    [global::ProtoBuf.ProtoMember(12)]
    public bool coinDisable
    {
        get => __pbn__coinDisable.GetValueOrDefault();
        set => __pbn__coinDisable = value;
    }
    public bool ShouldSerializecoinDisable() => __pbn__coinDisable != null;
    public void ResetcoinDisable() => __pbn__coinDisable = null;
    private bool? __pbn__coinDisable;

    [global::ProtoBuf.ProtoMember(13)]
    public bool elecDisable
    {
        get => __pbn__elecDisable.GetValueOrDefault();
        set => __pbn__elecDisable = value;
    }
    public bool ShouldSerializeelecDisable() => __pbn__elecDisable != null;
    public void ResetelecDisable() => __pbn__elecDisable = null;
    private bool? __pbn__elecDisable;

    [global::ProtoBuf.ProtoMember(14)]
    public bool shareDisable
    {
        get => __pbn__shareDisable.GetValueOrDefault();
        set => __pbn__shareDisable = value;
    }
    public bool ShouldSerializeshareDisable() => __pbn__shareDisable != null;
    public void ResetshareDisable() => __pbn__shareDisable = null;
    private bool? __pbn__shareDisable;

    [global::ProtoBuf.ProtoMember(15)]
    public bool screenShotDisable
    {
        get => __pbn__screenShotDisable.GetValueOrDefault();
        set => __pbn__screenShotDisable = value;
    }
    public bool ShouldSerializescreenShotDisable() => __pbn__screenShotDisable != null;
    public void ResetscreenShotDisable() => __pbn__screenShotDisable = null;
    private bool? __pbn__screenShotDisable;

    [global::ProtoBuf.ProtoMember(16)]
    public bool lockScreenDisable
    {
        get => __pbn__lockScreenDisable.GetValueOrDefault();
        set => __pbn__lockScreenDisable = value;
    }
    public bool ShouldSerializelockScreenDisable() => __pbn__lockScreenDisable != null;
    public void ResetlockScreenDisable() => __pbn__lockScreenDisable = null;
    private bool? __pbn__lockScreenDisable;

    [global::ProtoBuf.ProtoMember(17)]
    public bool recommendDisable
    {
        get => __pbn__recommendDisable.GetValueOrDefault();
        set => __pbn__recommendDisable = value;
    }
    public bool ShouldSerializerecommendDisable() => __pbn__recommendDisable != null;
    public void ResetrecommendDisable() => __pbn__recommendDisable = null;
    private bool? __pbn__recommendDisable;

    [global::ProtoBuf.ProtoMember(18)]
    public bool playbackSpeedDisable
    {
        get => __pbn__playbackSpeedDisable.GetValueOrDefault();
        set => __pbn__playbackSpeedDisable = value;
    }
    public bool ShouldSerializeplaybackSpeedDisable() => __pbn__playbackSpeedDisable != null;
    public void ResetplaybackSpeedDisable() => __pbn__playbackSpeedDisable = null;
    private bool? __pbn__playbackSpeedDisable;

    [global::ProtoBuf.ProtoMember(19)]
    public bool definitionDisable
    {
        get => __pbn__definitionDisable.GetValueOrDefault();
        set => __pbn__definitionDisable = value;
    }
    public bool ShouldSerializedefinitionDisable() => __pbn__definitionDisable != null;
    public void ResetdefinitionDisable() => __pbn__definitionDisable = null;
    private bool? __pbn__definitionDisable;

    [global::ProtoBuf.ProtoMember(20)]
    public bool selectionsDisable
    {
        get => __pbn__selectionsDisable.GetValueOrDefault();
        set => __pbn__selectionsDisable = value;
    }
    public bool ShouldSerializeselectionsDisable() => __pbn__selectionsDisable != null;
    public void ResetselectionsDisable() => __pbn__selectionsDisable = null;
    private bool? __pbn__selectionsDisable;

    [global::ProtoBuf.ProtoMember(21)]
    public bool nextDisable
    {
        get => __pbn__nextDisable.GetValueOrDefault();
        set => __pbn__nextDisable = value;
    }
    public bool ShouldSerializenextDisable() => __pbn__nextDisable != null;
    public void ResetnextDisable() => __pbn__nextDisable = null;
    private bool? __pbn__nextDisable;

    [global::ProtoBuf.ProtoMember(22)]
    public bool editDmDisable
    {
        get => __pbn__editDmDisable.GetValueOrDefault();
        set => __pbn__editDmDisable = value;
    }
    public bool ShouldSerializeeditDmDisable() => __pbn__editDmDisable != null;
    public void ReseteditDmDisable() => __pbn__editDmDisable = null;
    private bool? __pbn__editDmDisable;

    [global::ProtoBuf.ProtoMember(23)]
    public bool smallWindowDisable
    {
        get => __pbn__smallWindowDisable.GetValueOrDefault();
        set => __pbn__smallWindowDisable = value;
    }
    public bool ShouldSerializesmallWindowDisable() => __pbn__smallWindowDisable != null;
    public void ResetsmallWindowDisable() => __pbn__smallWindowDisable = null;
    private bool? __pbn__smallWindowDisable;

    [global::ProtoBuf.ProtoMember(24)]
    public bool shakeDisable
    {
        get => __pbn__shakeDisable.GetValueOrDefault();
        set => __pbn__shakeDisable = value;
    }
    public bool ShouldSerializeshakeDisable() => __pbn__shakeDisable != null;
    public void ResetshakeDisable() => __pbn__shakeDisable = null;
    private bool? __pbn__shakeDisable;

}

[global::ProtoBuf.ProtoContract()]
public partial class BusinessInfo : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(1)]
    public bool isPreview
    {
        get => __pbn__isPreview.GetValueOrDefault();
        set => __pbn__isPreview = value;
    }
    public bool ShouldSerializeisPreview() => __pbn__isPreview != null;
    public void ResetisPreview() => __pbn__isPreview = null;
    private bool? __pbn__isPreview;

    [global::ProtoBuf.ProtoMember(2, Name = @"bp")]
    public bool Bp
    {
        get => __pbn__Bp.GetValueOrDefault();
        set => __pbn__Bp = value;
    }
    public bool ShouldSerializeBp() => __pbn__Bp != null;
    public void ResetBp() => __pbn__Bp = null;
    private bool? __pbn__Bp;

    [global::ProtoBuf.ProtoMember(3)]
    [global::System.ComponentModel.DefaultValue("")]
    public string marlinToken
    {
        get => __pbn__marlinToken ?? "";
        set => __pbn__marlinToken = value;
    }
    public bool ShouldSerializemarlinToken() => __pbn__marlinToken != null;
    public void ResetmarlinToken() => __pbn__marlinToken = null;
    private string __pbn__marlinToken;

}

[global::ProtoBuf.ProtoContract()]
public partial class Event : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(1, Name = @"shake")]
    public Shake Shake { get; set; }

}

[global::ProtoBuf.ProtoContract()]
public partial class Shake : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(1, Name = @"file")]
    [global::System.ComponentModel.DefaultValue("")]
    public string File
    {
        get => __pbn__File ?? "";
        set => __pbn__File = value;
    }
    public bool ShouldSerializeFile() => __pbn__File != null;
    public void ResetFile() => __pbn__File = null;
    private string __pbn__File;

}

[global::ProtoBuf.ProtoContract()]
public partial class DashItem : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(1, Name = @"id")]
    public uint Id
    {
        get => __pbn__Id.GetValueOrDefault();
        set => __pbn__Id = value;
    }
    public bool ShouldSerializeId() => __pbn__Id != null;
    public void ResetId() => __pbn__Id = null;
    private uint? __pbn__Id;

    [global::ProtoBuf.ProtoMember(2)]
    [global::System.ComponentModel.DefaultValue("")]
    public string baseUrl
    {
        get => __pbn__baseUrl ?? "";
        set => __pbn__baseUrl = value;
    }
    public bool ShouldSerializebaseUrl() => __pbn__baseUrl != null;
    public void ResetbaseUrl() => __pbn__baseUrl = null;
    private string __pbn__baseUrl;

    [global::ProtoBuf.ProtoMember(3, Name = @"backupUrl")]
    public global::System.Collections.Generic.List<string> backupUrls { get; } = new global::System.Collections.Generic.List<string>();

    [global::ProtoBuf.ProtoMember(4, Name = @"bandwidth")]
    public uint Bandwidth
    {
        get => __pbn__Bandwidth.GetValueOrDefault();
        set => __pbn__Bandwidth = value;
    }
    public bool ShouldSerializeBandwidth() => __pbn__Bandwidth != null;
    public void ResetBandwidth() => __pbn__Bandwidth = null;
    private uint? __pbn__Bandwidth;

    [global::ProtoBuf.ProtoMember(5, Name = @"codecid")]
    public uint Codecid
    {
        get => __pbn__Codecid.GetValueOrDefault();
        set => __pbn__Codecid = value;
    }
    public bool ShouldSerializeCodecid() => __pbn__Codecid != null;
    public void ResetCodecid() => __pbn__Codecid = null;
    private uint? __pbn__Codecid;

    [global::ProtoBuf.ProtoMember(6, Name = @"md5")]
    [global::System.ComponentModel.DefaultValue("")]
    public string Md5
    {
        get => __pbn__Md5 ?? "";
        set => __pbn__Md5 = value;
    }
    public bool ShouldSerializeMd5() => __pbn__Md5 != null;
    public void ResetMd5() => __pbn__Md5 = null;
    private string __pbn__Md5;

    [global::ProtoBuf.ProtoMember(7, Name = @"size")]
    public ulong Size
    {
        get => __pbn__Size.GetValueOrDefault();
        set => __pbn__Size = value;
    }
    public bool ShouldSerializeSize() => __pbn__Size != null;
    public void ResetSize() => __pbn__Size = null;
    private ulong? __pbn__Size;

}

[global::ProtoBuf.ProtoContract()]
public partial class StreamItem : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(1)]
    public StreamInfo streamInfo { get; set; }

    [global::ProtoBuf.ProtoMember(2)]
    public DashVideo dashVideo { get; set; }

    [global::ProtoBuf.ProtoMember(3)]
    public SegmentVideo segmentVideo { get; set; }

}

[global::ProtoBuf.ProtoContract()]
public partial class StreamInfo : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(1, Name = @"quality")]
    public uint Quality
    {
        get => __pbn__Quality.GetValueOrDefault();
        set => __pbn__Quality = value;
    }
    public bool ShouldSerializeQuality() => __pbn__Quality != null;
    public void ResetQuality() => __pbn__Quality = null;
    private uint? __pbn__Quality;

    [global::ProtoBuf.ProtoMember(2, Name = @"format")]
    [global::System.ComponentModel.DefaultValue("")]
    public string Format
    {
        get => __pbn__Format ?? "";
        set => __pbn__Format = value;
    }
    public bool ShouldSerializeFormat() => __pbn__Format != null;
    public void ResetFormat() => __pbn__Format = null;
    private string __pbn__Format;

    [global::ProtoBuf.ProtoMember(3, Name = @"description")]
    [global::System.ComponentModel.DefaultValue("")]
    public string Description
    {
        get => __pbn__Description ?? "";
        set => __pbn__Description = value;
    }
    public bool ShouldSerializeDescription() => __pbn__Description != null;
    public void ResetDescription() => __pbn__Description = null;
    private string __pbn__Description;

    [global::ProtoBuf.ProtoMember(4)]
    public uint errCode
    {
        get => __pbn__errCode.GetValueOrDefault();
        set => __pbn__errCode = value;
    }
    public bool ShouldSerializeerrCode() => __pbn__errCode != null;
    public void ReseterrCode() => __pbn__errCode = null;
    private uint? __pbn__errCode;

    [global::ProtoBuf.ProtoMember(5, Name = @"limit")]
    public StreamLimit Limit { get; set; }

    [global::ProtoBuf.ProtoMember(6)]
    public bool needVip
    {
        get => __pbn__needVip.GetValueOrDefault();
        set => __pbn__needVip = value;
    }
    public bool ShouldSerializeneedVip() => __pbn__needVip != null;
    public void ResetneedVip() => __pbn__needVip = null;
    private bool? __pbn__needVip;

    [global::ProtoBuf.ProtoMember(7)]
    public bool needLogin
    {
        get => __pbn__needLogin.GetValueOrDefault();
        set => __pbn__needLogin = value;
    }
    public bool ShouldSerializeneedLogin() => __pbn__needLogin != null;
    public void ResetneedLogin() => __pbn__needLogin = null;
    private bool? __pbn__needLogin;

    [global::ProtoBuf.ProtoMember(8, Name = @"intact")]
    public bool Intact
    {
        get => __pbn__Intact.GetValueOrDefault();
        set => __pbn__Intact = value;
    }
    public bool ShouldSerializeIntact() => __pbn__Intact != null;
    public void ResetIntact() => __pbn__Intact = null;
    private bool? __pbn__Intact;

    [global::ProtoBuf.ProtoMember(9)]
    public bool noRexcode
    {
        get => __pbn__noRexcode.GetValueOrDefault();
        set => __pbn__noRexcode = value;
    }
    public bool ShouldSerializenoRexcode() => __pbn__noRexcode != null;
    public void ResetnoRexcode() => __pbn__noRexcode = null;
    private bool? __pbn__noRexcode;

    [global::ProtoBuf.ProtoMember(10, Name = @"attribute")]
    public ulong Attribute
    {
        get => __pbn__Attribute.GetValueOrDefault();
        set => __pbn__Attribute = value;
    }
    public bool ShouldSerializeAttribute() => __pbn__Attribute != null;
    public void ResetAttribute() => __pbn__Attribute = null;
    private ulong? __pbn__Attribute;

}

[global::ProtoBuf.ProtoContract()]
public partial class DashVideo : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(1)]
    [global::System.ComponentModel.DefaultValue("")]
    public string baseUrl
    {
        get => __pbn__baseUrl ?? "";
        set => __pbn__baseUrl = value;
    }
    public bool ShouldSerializebaseUrl() => __pbn__baseUrl != null;
    public void ResetbaseUrl() => __pbn__baseUrl = null;
    private string __pbn__baseUrl;

    [global::ProtoBuf.ProtoMember(2, Name = @"backupUrl")]
    public global::System.Collections.Generic.List<string> backupUrls { get; } = new global::System.Collections.Generic.List<string>();

    [global::ProtoBuf.ProtoMember(3, Name = @"bandwidth")]
    public uint Bandwidth
    {
        get => __pbn__Bandwidth.GetValueOrDefault();
        set => __pbn__Bandwidth = value;
    }
    public bool ShouldSerializeBandwidth() => __pbn__Bandwidth != null;
    public void ResetBandwidth() => __pbn__Bandwidth = null;
    private uint? __pbn__Bandwidth;

    [global::ProtoBuf.ProtoMember(4, Name = @"codecid")]
    public uint Codecid
    {
        get => __pbn__Codecid.GetValueOrDefault();
        set => __pbn__Codecid = value;
    }
    public bool ShouldSerializeCodecid() => __pbn__Codecid != null;
    public void ResetCodecid() => __pbn__Codecid = null;
    private uint? __pbn__Codecid;

    [global::ProtoBuf.ProtoMember(5, Name = @"md5")]
    [global::System.ComponentModel.DefaultValue("")]
    public string Md5
    {
        get => __pbn__Md5 ?? "";
        set => __pbn__Md5 = value;
    }
    public bool ShouldSerializeMd5() => __pbn__Md5 != null;
    public void ResetMd5() => __pbn__Md5 = null;
    private string __pbn__Md5;

    [global::ProtoBuf.ProtoMember(6, Name = @"size")]
    public ulong Size
    {
        get => __pbn__Size.GetValueOrDefault();
        set => __pbn__Size = value;
    }
    public bool ShouldSerializeSize() => __pbn__Size != null;
    public void ResetSize() => __pbn__Size = null;
    private ulong? __pbn__Size;

    [global::ProtoBuf.ProtoMember(7)]
    public uint audioId
    {
        get => __pbn__audioId.GetValueOrDefault();
        set => __pbn__audioId = value;
    }
    public bool ShouldSerializeaudioId() => __pbn__audioId != null;
    public void ResetaudioId() => __pbn__audioId = null;
    private uint? __pbn__audioId;

    [global::ProtoBuf.ProtoMember(8)]
    public bool noRexcode
    {
        get => __pbn__noRexcode.GetValueOrDefault();
        set => __pbn__noRexcode = value;
    }
    public bool ShouldSerializenoRexcode() => __pbn__noRexcode != null;
    public void ResetnoRexcode() => __pbn__noRexcode = null;
    private bool? __pbn__noRexcode;

}

[global::ProtoBuf.ProtoContract()]
public partial class SegmentVideo : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(1, Name = @"segment")]
    public global::System.Collections.Generic.List<ResponseUrl> Segments { get; } = new global::System.Collections.Generic.List<ResponseUrl>();

}

[global::ProtoBuf.ProtoContract()]
public partial class StreamLimit : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(1, Name = @"title")]
    [global::System.ComponentModel.DefaultValue("")]
    public string Title
    {
        get => __pbn__Title ?? "";
        set => __pbn__Title = value;
    }
    public bool ShouldSerializeTitle() => __pbn__Title != null;
    public void ResetTitle() => __pbn__Title = null;
    private string __pbn__Title;

    [global::ProtoBuf.ProtoMember(2, Name = @"uri")]
    [global::System.ComponentModel.DefaultValue("")]
    public string Uri
    {
        get => __pbn__Uri ?? "";
        set => __pbn__Uri = value;
    }
    public bool ShouldSerializeUri() => __pbn__Uri != null;
    public void ResetUri() => __pbn__Uri = null;
    private string __pbn__Uri;

    [global::ProtoBuf.ProtoMember(3, Name = @"msg")]
    [global::System.ComponentModel.DefaultValue("")]
    public string Msg
    {
        get => __pbn__Msg ?? "";
        set => __pbn__Msg = value;
    }
    public bool ShouldSerializeMsg() => __pbn__Msg != null;
    public void ResetMsg() => __pbn__Msg = null;
    private string __pbn__Msg;

}

[global::ProtoBuf.ProtoContract()]
public partial class ResponseUrl : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(1, Name = @"order")]
    public uint Order
    {
        get => __pbn__Order.GetValueOrDefault();
        set => __pbn__Order = value;
    }
    public bool ShouldSerializeOrder() => __pbn__Order != null;
    public void ResetOrder() => __pbn__Order = null;
    private uint? __pbn__Order;

    [global::ProtoBuf.ProtoMember(2, Name = @"length")]
    public ulong Length
    {
        get => __pbn__Length.GetValueOrDefault();
        set => __pbn__Length = value;
    }
    public bool ShouldSerializeLength() => __pbn__Length != null;
    public void ResetLength() => __pbn__Length = null;
    private ulong? __pbn__Length;

    [global::ProtoBuf.ProtoMember(3, Name = @"size")]
    public ulong Size
    {
        get => __pbn__Size.GetValueOrDefault();
        set => __pbn__Size = value;
    }
    public bool ShouldSerializeSize() => __pbn__Size != null;
    public void ResetSize() => __pbn__Size = null;
    private ulong? __pbn__Size;

    [global::ProtoBuf.ProtoMember(4, Name = @"url")]
    [global::System.ComponentModel.DefaultValue("")]
    public string Url
    {
        get => __pbn__Url ?? "";
        set => __pbn__Url = value;
    }
    public bool ShouldSerializeUrl() => __pbn__Url != null;
    public void ResetUrl() => __pbn__Url = null;
    private string __pbn__Url;

    [global::ProtoBuf.ProtoMember(5, Name = @"backupUrl")]
    public global::System.Collections.Generic.List<string> backupUrls { get; } = new global::System.Collections.Generic.List<string>();

    [global::ProtoBuf.ProtoMember(6, Name = @"md5")]
    [global::System.ComponentModel.DefaultValue("")]
    public string Md5
    {
        get => __pbn__Md5 ?? "";
        set => __pbn__Md5 = value;
    }
    public bool ShouldSerializeMd5() => __pbn__Md5 != null;
    public void ResetMd5() => __pbn__Md5 = null;
    private string __pbn__Md5;

}

[global::ProtoBuf.ProtoContract()]
public partial class PlayViewReply : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(1)]
    public VideoInfo videoInfo { get; set; }

    [global::ProtoBuf.ProtoMember(2)]
    public PlayAbilityConf playConf { get; set; }

    [global::ProtoBuf.ProtoMember(3, Name = @"business")]
    public BusinessInfo Business { get; set; }

    [global::ProtoBuf.ProtoMember(4, Name = @"event")]
    public Event Event { get; set; }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
