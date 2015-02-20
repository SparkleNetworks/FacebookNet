﻿
namespace FacebookNet.ServiceDefinition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;

    [Serializable]
    public class ReturnType
    {
        [XmlAttribute]
        public string Name { get; set; }

        public string ApiGroup { get; set; }

        [XmlAttribute]
        public string ClassName { get; set; }

        [XmlAttribute]
        public string Title { get; set; }

        [XmlAttribute]
        public string Remark { get; set; }

        ////[XmlAttribute]
        ////public bool IsDefault { get; set; }

        [XmlElement(ElementName = "Field")]
        public List<Field> Fields { get; set; }

        [XmlElement(ElementName = "FieldSelector")]
        public List<FieldSelector> Selectors { get; set; }

        [XmlElement(ElementName = "IsCollectionOf")]
        public string IsCollectionOf { get; set; }

        [XmlAttribute]
        public bool AutoGenerateFieldSelectors { get; set; }

        [XmlElement(ElementName = "ImportFieldSelectors")]
        public List<ImportFieldSelectors> ImportFieldSelectors { get; set; }

        [XmlElement(ElementName = "Header")]
        public List<Field> Headers { get; set; }

        public override string ToString()
        {
            return string.Format("ReturnType(N='{0}' CN='{1}' F={2} FS={3})", Name, ClassName, Fields != null ? Fields.Count : 0, Selectors != null ? Selectors.Count : 0);
        }
    }
}
