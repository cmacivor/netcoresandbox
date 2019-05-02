using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

public class BingServer
{
    public class Point
        {
            public string type { get; set; }
            public List<double> coordinates { get; set; }
        }

        [DataContract(Name = "Address" )]
        public class Address
        {
            
            [DataMember(Name = "addressLine")]
            public string addressLine { get; set; }

            [DataMember(Name = "adminDistrict")]
            public string adminDistrict { get; set; }

            [DataMember(Name = "adminDistrict2")]
            public string adminDistrict2 { get; set; }

            [DataMember(Name = "countryRegion")]
            public string countryRegion { get; set; }

            [DataMember(Name = "formattedAddress")]
            public string formattedAddress { get; set; }

            [DataMember(Name = "locality")]
            public string locality { get; set; }

            [DataMember(Name = "postalCode")]
            public string postalCode { get; set; }
        }

        public class GeocodePoint
        {
            public string type { get; set; }
            public List<double> coordinates { get; set; }
            public string calculationMethod { get; set; }
            public List<string> usageTypes { get; set; }
        }

        [DataContract(Name = "Resource" )]
        public class Resource
        {
            public string __type { get; set; }
            public List<double> bbox { get; set; }

            [DataMember(Name = "name")]
            public string name { get; set; }
            public Point point { get; set; }

            [DataMember(Name = "address")]
            public Address address { get; set; }
            public string confidence { get; set; }
            public string entityType { get; set; }
            public List<GeocodePoint> geocodePoints { get; set; }
            public List<string> matchCodes { get; set; }
        }

        [DataContract(Name = "ResourceSet" )]
        public class ResourceSet
        {
            [DataMember(Name = "estimatedTotal")]
            public int? estimatedTotal { get; set; }

            //[DataMember(Name = "resources")]
            public List<Resource> resources { get; set; }
        }

        [DataContract(Name = "RootObject" )]
        public class RootObject
        {
            [DataMember(Name = "authenticationResultCode")]
            public string authenticationResultCode { get; set; }

            [DataMember(Name = "brandLogoUri")]
            public string brandLogoUri { get; set; }

            [DataMember(Name = "copyright")]
            public string copyright { get; set; }

            [DataMember(Name = "resourceSets")]
            public List<ResourceSet> resourceSets { get; set; }
            public int? statusCode { get; set; }
            public string statusDescription { get; set; }
            public string traceId { get; set; }
        }

}