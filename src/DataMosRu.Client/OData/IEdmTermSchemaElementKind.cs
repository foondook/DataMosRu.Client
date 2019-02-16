namespace DataMosRu.Client
{
    public enum IEdmTermSchemaElementKind
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"TypeDefinition")]
        TypeDefinition = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Function")]
        Function = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"ValueTerm")]
        ValueTerm = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"EntityContainer")]
        EntityContainer = 4,

    }
}