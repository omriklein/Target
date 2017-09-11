using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{

    public Image levelsBackgroung;
    public Image level; // TODO Replace to Button

    // Use this for initialization
    void Start()
    {
        levelsBackgroung.enabled = false; // Enable the image so you can see everything else
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void getLevels(float levelImageScale = 0.15f)
    {
        levelsBackgroung.enabled = true;

        // Position x
        // Image Scale = 0.15 , *** 5 IMAGES PER ROW ***
        // Distance between Images = 0.03 = Scale / 5
        // Distance from border = what is left / 2 = [ 1 - 5*Scale(0.15) - 4*Distance(Scale/5 = 0.03) ] / 2

        // Position y
        // Image Scale * 2 

        for (int i = 0; i < 5; i++)
        {
            Image levelImage = Image.Instantiate<Image>(level, this.levelsBackgroung.transform); // Insantiate a level button
            levelImage.color = Color.blue;
            levelImage.transform.localScale = new Vector3(levelImageScale, levelImageScale / Screen.height * Screen.width, 0f);
            levelImage.transform.localPosition = new Vector3(-100 + i * 50, 100, 0);
        }

    }

    /// <summary>
    /// Close the game
    /// </summary>
    public void Exit()
    {
        Application.Quit();
    }
}
