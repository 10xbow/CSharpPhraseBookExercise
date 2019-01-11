using System;
using System.Xml;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Exercise1
{
    [DataContract]
    public class Employee2
    {
        public int Id { get; set; }

        [DataMember(Name ="name")]
        public string Name { get; set; }

        [DataMember(Name = "hireDate")]
        public DateTime HireDate { get; set; }
    }
}
