namespace DataMosRu.Client
{
    public enum FeatureCollectionType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Point")]
        Point = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"MultiPoint")]
        MultiPoint = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"LineString")]
        LineString = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"MultiLineString")]
        MultiLineString = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"Polygon")]
        Polygon = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"MultiPolygon")]
        MultiPolygon = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"GeometryCollection")]
        GeometryCollection = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"Feature")]
        Feature = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"FeatureCollection")]
        FeatureCollection = 8,

    }
}