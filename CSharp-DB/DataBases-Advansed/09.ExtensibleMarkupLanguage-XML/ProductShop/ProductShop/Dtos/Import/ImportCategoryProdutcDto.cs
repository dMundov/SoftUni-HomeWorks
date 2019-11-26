namespace ProductShop.Dtos.Import
{
    using System.Xml.Serialization;

    //<CategoryProduct>
    //    <CategoryId>4</CategoryId>
    //    <ProductId>1</ProductId>
    //</CategoryProduct>

    [XmlType("CategoryProduct")]
    public class ImportCategoryProdutcDto
    {
        [XmlElement("CategoryId")]
        public int CategoryId { get; set; }
        [XmlElement("ProductId")]
        public int ProductId { get; set; }
    }
}
