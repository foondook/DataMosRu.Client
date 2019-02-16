namespace DataMosRu.Client
{
    public enum SingleValueNodeKind
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Constant")]
        Constant = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Convert")]
        Convert = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"NonentityRangeVariableReference")]
        NonentityRangeVariableReference = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"BinaryOperator")]
        BinaryOperator = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"UnaryOperator")]
        UnaryOperator = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"SingleValuePropertyAccess")]
        SingleValuePropertyAccess = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"CollectionPropertyAccess")]
        CollectionPropertyAccess = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"SingleValueFunctionCall")]
        SingleValueFunctionCall = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"Any")]
        Any = 9,

        [System.Runtime.Serialization.EnumMember(Value = @"CollectionNavigationNode")]
        CollectionNavigationNode = 10,

        [System.Runtime.Serialization.EnumMember(Value = @"SingleNavigationNode")]
        SingleNavigationNode = 11,

        [System.Runtime.Serialization.EnumMember(Value = @"SingleValueOpenPropertyAccess")]
        SingleValueOpenPropertyAccess = 12,

        [System.Runtime.Serialization.EnumMember(Value = @"SingleEntityCast")]
        SingleEntityCast = 13,

        [System.Runtime.Serialization.EnumMember(Value = @"All")]
        All = 14,

        [System.Runtime.Serialization.EnumMember(Value = @"EntityCollectionCast")]
        EntityCollectionCast = 15,

        [System.Runtime.Serialization.EnumMember(Value = @"EntityRangeVariableReference")]
        EntityRangeVariableReference = 16,

        [System.Runtime.Serialization.EnumMember(Value = @"SingleEntityFunctionCall")]
        SingleEntityFunctionCall = 17,

        [System.Runtime.Serialization.EnumMember(Value = @"CollectionFunctionCall")]
        CollectionFunctionCall = 18,

        [System.Runtime.Serialization.EnumMember(Value = @"EntityCollectionFunctionCall")]
        EntityCollectionFunctionCall = 19,

        [System.Runtime.Serialization.EnumMember(Value = @"NamedFunctionParameter")]
        NamedFunctionParameter = 20,

    }
}