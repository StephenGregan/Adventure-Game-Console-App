using AdventureGame.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AdventureGame.Static
{
    public static class GameController
    {
        public static Character character;
        public static void Init()
        {
            character = new Character();
        }

        public static void CreateSaveFile()
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode root = xmlDoc.CreateElement("saves");
            xmlDoc.AppendChild(root);
            XmlNode saveNode = xmlDoc.CreateElement("save");
            XmlAttribute attribute = xmlDoc.CreateAttribute("name");
            attribute.Value = character.Name;
            saveNode.Attributes.Append(attribute);
            attribute = xmlDoc.CreateAttribute("gender");
            attribute.Value = character.Gender;
            saveNode.Attributes.Append(attribute);
            root.AppendChild(saveNode);
            xmlDoc.Save("Saves.xml");
        }
    }
}
