

namespace ProductShop.Dtos.Import
{

    using System.Xml.Serialization;
    //<Category>
    //    <name>Adult</name>
    //</Category>
    [XmlType("Category")]
    public class ImportCategoryDto
    {
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
