using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BasicSerialization
{
    public enum Genre
    {
        [XmlEnum("Computer")]
        Computer = 1,
        [XmlEnum("Fantasy")]
        Fantasy = 2,
        [XmlEnum("Romance")]
        Romance = 3,
        [XmlEnum("Horror")]
        Horror = 4,
        [XmlEnum("Science Fiction")]
        ScienceFiction = 5
    }
    [Serializable]
    public class Book : IEquatable<Book>
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "isbn")]
        public string Isbn { get; set; }
        [XmlElement(ElementName = "author")]
        public string Author { get; set; }
        [XmlElement(ElementName = "title")]
        public string Title { get; set; }
        [XmlElement(ElementName = "genre")]
        public Genre Genre { get; set; }
        [XmlElement(ElementName = "publisher")]
        public string Publisher { get; set; }
        [XmlElement(ElementName = "publish_date", DataType = "date")]
        public DateTime Publish_Date { get; set; }
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
        [XmlElement(ElementName = "registration_date", DataType = "date")]
        public DateTime Registration_Date { get; set; }

        public bool Equals(Book other)
        {
            if (other != null)
                return this.Id.Equals(other.Id) && this.Isbn == other.Isbn && this.Author.Equals(other.Author);
            return false;
        }
    }
}
