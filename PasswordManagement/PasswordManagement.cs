using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PasswordManagement
{
    [System.Xml.Serialization.XmlRoot("items")]
    public class ItemsModel
    {
        [System.Xml.Serialization.XmlElement("item")]
        public List<ItemModel> Items { get; set; }

        public static ItemsModel ConvertXMLToInstance(TextReader xml)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(ItemsModel));
            ItemsModel model = (ItemsModel)serializer.Deserialize(xml);

            return model;
        }
    }

    public class ItemModel
    {
        [System.Xml.Serialization.XmlAttribute("id")]
        public string ID { get; set; }

        [System.Xml.Serialization.XmlElement("title")]
        public string Title { get; set; }

        [System.Xml.Serialization.XmlElement("userid")]
        public string UserID { get; set; }

        [System.Xml.Serialization.XmlElement("password")]
        public string Password { get; set; }

        
    }
}
