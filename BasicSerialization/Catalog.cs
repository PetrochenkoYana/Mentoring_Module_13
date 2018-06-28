using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BasicSerialization
{
    [XmlRoot(ElementName = "catalog", Namespace = XmlNamespace)]
    public class Catalog : IEquatable<Catalog>
    {
        private const string XmlNamespace = "http://library.by/catalog";

        [XmlElement("book")]
        public List<Book> Books { get; set; }

        [XmlAttribute(AttributeName = "date", DataType = "date")]
        public DateTime Date { get; set; }

        public bool Equals(Catalog other)
        {
            if (other != null)
                return this.Books.SequenceEqual(other.Books) && this.Date.Equals(other.Date);
            return false;

        }
    }
}
