using System;
using System.Xml;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Exercise1
{
    [XmlRoot("employee")]
    public class Employee
    {
        [XmlElement(ElementName="id")]
        public int Id { get; set; }

        [XmlElement(ElementName="name")]
        public string Name { get; set; }

        [XmlElement(ElementName="hireDate")]
        public DateTime HireDate { get; set; }
    }
}
