namespace DataMosRu.Client
{
    public enum IEdmTypeTypeKind
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Primitive")]
        Primitive = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Entity")]
        Entity = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Complex")]
        Complex = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"Row")]
        Row = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"Collection")]
        Collection = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"EntityReference")]
        EntityReference = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"Enum")]
        Enum = 7,

    }
}