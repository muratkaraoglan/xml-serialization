using System.Xml.Serialization;

namespace XmlSerializationBasics.SerializationWithXmlElement;

[XmlRoot(ElementName = "book")]
public class BookInfo
{
    [XmlElement("book-title")]
    public string? Title { get; set; }

    [XmlElement("book-price")]
    public decimal Price { get; set; }

    [XmlElement("book-genre")]
    public string? Genre { get; set; }

    [XmlElement("book-isbn")]
    public string? Isbn { get; set; }

    [XmlElement("book-publication-date")]
    public string? PublicationDate { get; set; }
}
