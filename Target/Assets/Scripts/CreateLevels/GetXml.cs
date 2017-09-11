using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;

public class GetXml : MonoBehaviour
{
    /// <summary>
    /// This script is for making new levels without much effort.
    /// The only thing you need to do is create the level in the editor and the xml will appear.
    /// In the future we can let people build their oun levels and play with that.
    /// </summary>

    private string xmlName = "Assets/Scripts/NewXmlFile.xml"; // The name and the location of the new Xml file.

        // This is how a level looks like in a basic Xml file.
        /*
        <Level number="1">
        <Canon positionX = "-3" positionY = "-3.5" positionZ = "-1">
        </Canon>
        <Canon positionX = "2" positionY = "-3.5" positionZ = "-1">
        </Canon>
        <Target positionX = "-3" positionY = "3.5" positionZ = "-1">
        </Target>
        <Target positionX = "2" positionY = "3.5" positionZ = "-1">
        </Target>
        </Level>
        */

    // Update is called once per frame
    void Update()
    {
        // You Save the Xml file only when you press the 'X' key on the keyboard.
        if (Input.GetKeyDown(KeyCode.X))
        {
            print("Writing to Xml"); // Let you know that you are writing.
            XmlDocument xmlDoc = new XmlDocument(); // Create a new Xml file.
            XmlNode rootNode = xmlDoc.CreateElement("Level"); // Create a new "Level" element.
            XmlAttribute attribute = xmlDoc.CreateAttribute("number"); // Add the attribute "number" to the "Level" element.
            attribute.Value = "5"; // Set the attribute's value.
            rootNode.Attributes.Append(attribute); // Append the attribute to the element
            xmlDoc.AppendChild(rootNode); // Append the element to the Xml file.

            // Append each "canon" to the Xml file with the require attributes.
            foreach (GameObject  canon in GameObject.FindGameObjectsWithTag("Respawn"))
            {
                XmlNode canonNode = xmlDoc.CreateElement("Canon");

                XmlAttribute positionX = xmlDoc.CreateAttribute("positionX");
                positionX.Value = canon.transform.position.x.ToString();
                canonNode.Attributes.Append(positionX);

                XmlAttribute positionY = xmlDoc.CreateAttribute("positionY");
                positionY.Value = canon.transform.position.y.ToString();
                canonNode.Attributes.Append(positionY);

                XmlAttribute positionZ = xmlDoc.CreateAttribute("positionZ");
                positionZ.Value = "-1";
                canonNode.Attributes.Append(positionZ);

                canonNode.InnerText = "";
                rootNode.AppendChild(canonNode);
            }

            // Append each "target" to the Xml file with the require attributes.
            foreach (GameObject target in GameObject.FindGameObjectsWithTag("Finish"))
            {
                XmlNode targetNode = xmlDoc.CreateElement("Target");

                XmlAttribute positionX = xmlDoc.CreateAttribute("positionX");
                positionX.Value = target.transform.position.x.ToString();
                targetNode.Attributes.Append(positionX);

                XmlAttribute positionY = xmlDoc.CreateAttribute("positionY");
                positionY.Value = target.transform.position.y.ToString();
                targetNode.Attributes.Append(positionY);

                XmlAttribute positionZ = xmlDoc.CreateAttribute("positionZ");
                positionZ.Value = "-1";
                targetNode.Attributes.Append(positionZ);

                targetNode.InnerText = "";
                rootNode.AppendChild(targetNode);
            }

            // Append each "triangle" to the Xml file with the require attributes.
            foreach (GameObject triangle in GameObject.FindGameObjectsWithTag("Triangle"))
            {
                XmlNode triangleNode = xmlDoc.CreateElement("Triangle");

                XmlAttribute positionX = xmlDoc.CreateAttribute("positionX");
                positionX.Value = triangle.transform.position.x.ToString();
                triangleNode.Attributes.Append(positionX);

                XmlAttribute positionY = xmlDoc.CreateAttribute("positionY");
                positionY.Value = triangle.transform.position.y.ToString();
                triangleNode.Attributes.Append(positionY);

                XmlAttribute positionZ = xmlDoc.CreateAttribute("positionZ");
                positionZ.Value = "-1";
                triangleNode.Attributes.Append(positionZ);

                triangleNode.InnerText = "";
                rootNode.AppendChild(triangleNode);
            }

            xmlDoc.Save(xmlName); // Save the Xml file.

        }
    }
}
