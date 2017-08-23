using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System;

public class GenerateLevel : MonoBehaviour
{
    public GameObject canonPrefub;
    public GameObject targetPrefub;

    private XmlDocument xmlDoc = new XmlDocument();
    private string xmlName = "Assets/Scripts/LevelsXml.xml";

    public int level = 1;

    // Use this for initialization
    void Start()
    {
        MakeLevel(level);
    }

    private void MakeLevel(int levelNum)
    {
        xmlDoc.Load(xmlName); // Load the xml file with the path - xmlName
        XmlNodeList Levels = xmlDoc.GetElementsByTagName("Level"); // Get the "level" nodes from the xml file

        print(Levels.Count); // ## For testing
        /*
        foreach (XmlNode level in Levels)
        {
            print("This is level number " + level.Attributes["number"].Value);
            print(">> This level had " + level.SelectNodes("Canon").Count + " Canons");
        }
        */

        XmlNode curr = Levels[levelNum - 1]; // The current level with the value given. -1 Because list start from 0 ->> use the "number" attribute!!
        print("This is level " + curr.Attributes["number"].Value); // ## For testing

        // Instantiate all the canons
        foreach (XmlNode canon in curr.SelectNodes("Canon"))
        {
            Instantiate<GameObject>(canonPrefub
                , new Vector3(
                    float.Parse(canon.Attributes["positionX"].Value) // Gets the value of the position in the X axis
                    , float.Parse(canon.Attributes["positionY"].Value) // Gets the value of the position in the Y axis
                    , float.Parse(canon.Attributes["positionZ"].Value)) // Gets the value of the position in the Z axis
                , new Quaternion(0, 0, 0, 0));
        }
        // Instantiate all the targets
        foreach (XmlNode target in curr.SelectNodes("Target"))
        {
            Instantiate<GameObject>(targetPrefub
                , new Vector3(
                    float.Parse(target.Attributes["positionX"].Value) // Gets the value of the position in the X axis
                    , float.Parse(target.Attributes["positionY"].Value) // Gets the value of the position in the Y axis
                    , float.Parse(target.Attributes["positionZ"].Value)) // Gets the value of the position in the Z axis
                , new Quaternion(0, 0, 0, 0));
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
