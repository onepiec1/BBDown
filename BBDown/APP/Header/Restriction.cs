// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: restriction.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[global::ProtoBuf.ProtoContract()]
public partial class Restriction : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(1)]
    public bool teenagersMode
    {
        get => __pbn__teenagersMode.GetValueOrDefault();
        set => __pbn__teenagersMode = value;
    }
    public bool ShouldSerializeteenagersMode() => __pbn__teenagersMode != null;
    public void ResetteenagersMode() => __pbn__teenagersMode = null;
    private bool? __pbn__teenagersMode;

    [global::ProtoBuf.ProtoMember(2)]
    public bool lessonsMode
    {
        get => __pbn__lessonsMode.GetValueOrDefault();
        set => __pbn__lessonsMode = value;
    }
    public bool ShouldSerializelessonsMode() => __pbn__lessonsMode != null;
    public void ResetlessonsMode() => __pbn__lessonsMode = null;
    private bool? __pbn__lessonsMode;

    [global::ProtoBuf.ProtoMember(3)]
    [global::System.ComponentModel.DefaultValue(Mode.Normal)]
    public Mode mode
    {
        get => __pbn__mode ?? Mode.Normal;
        set => __pbn__mode = value;
    }
    public bool ShouldSerializemode() => __pbn__mode != null;
    public void Resetmode() => __pbn__mode = null;
    private Mode? __pbn__mode;

    [global::ProtoBuf.ProtoMember(4, Name = @"review")]
    public bool Review
    {
        get => __pbn__Review.GetValueOrDefault();
        set => __pbn__Review = value;
    }
    public bool ShouldSerializeReview() => __pbn__Review != null;
    public void ResetReview() => __pbn__Review = null;
    private bool? __pbn__Review;

    [global::ProtoBuf.ProtoContract()]
    public enum Mode
    {
        [global::ProtoBuf.ProtoEnum(Name = @"NORMAL")]
        Normal = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"TEENAGERS")]
        Teenagers = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"LESSONS")]
        Lessons = 2,
    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
