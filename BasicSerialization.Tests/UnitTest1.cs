using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicSerialization.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange- deserialize
            var deserializedCatalog = SerializeCatalog.Deserialize("books.xml"); 
             
            //Act - serialize and deserrialize again
            SerializeCatalog.Serialize("serialized_books.xml",deserializedCatalog);
            var newDeserializedCatalog = SerializeCatalog.Deserialize("serialized_books.xml");

            //Assert
            Assert.IsTrue(deserializedCatalog.Equals(newDeserializedCatalog));

        }
    }
}
