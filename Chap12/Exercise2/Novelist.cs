using System;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise2
{
    [XmlRoot("novelist")]
    [DataContract]
    public class Novelist
    {
        [XmlElement(ElementName ="name")]
        [DataMember(Name ="name")]
        public string Name { get; set; }

        [XmlElement(ElementName ="birth")]
        [DataMember(Name ="birth")]
        public DateTime Birth { get; set; }

        [XmlArray("masterpieces")]
        [DataMember(Name ="masterpieces")]
        [XmlArrayItem("title", typeof(string))]
        public string[] Masterpieces { get; set; }
    }
}
