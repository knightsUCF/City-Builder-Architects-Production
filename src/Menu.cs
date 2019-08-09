using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

 



public class Menu : MonoBehaviour
{



    public void NewGame()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }



    public void Settings()
    {
        // should we load a new scene or toggle a panel here
    }


}



/* MENU System

1. Create Canvas Panel component
    - deactivate panel
    - rename HUD
2. Add Canvas Scaler component
    - UI Scale Mode: Scale with Screen Size
    - Screen Match Mode: 1920 1080
3. Create "Title" Canvas Text Game Object as child of HUD for the title, since this will not be part of the menu options grid layout
    - adjust rect transform to center for all three, do we need all three?
    - make sure to only set the font of the text for scaling, and not the width / height, will distort text
4. Create "Menu" Canvas Panel Game Object Component as child of the HUD
    - turn off the panel
    - adjust rect transform to center for all three, do we need all three?
    - add Grid Layout Group component
        - for current project, cell size: 90, 90
        - Start Corner: Upper Left
        - Start Axis: Vertical
        - Child Alignment: Middle Center
        - Constraint: Flexible (default)
5. Create the first Menu Option, "Start" as a Canvas button, which is a child of the Menu above component
    - leave the rect transform default (upper left for the grid layout, probably don't need to change)
    - turn off the image for the button 
    - Add button OnClick() option
    - Drag a script onto the "Start" child object of the Menu component, then drag the "Start" component into the button slot
    - use the drop down to find the script, and then reference the method appropriate for the button, example: for the start button, we use the method: OnMenuOptionStartClicked()
    - then on the Start button component there should be a child object created called "Text"
    - Type in the text, and choose the font, and font size, and color
    - Select Overflow for both horizontal and vertical overflow (good practice?)
    - finally duplicate the "Start" component for the other menu items and repeat the process



*/


/* 



public class Menu : MonoBehaviour
{


    public void OnMenuOptionStartClicked()
    {
        GameObject.Find("Loading").GetComponentInChildren<Text>().text = "Loading...";
        SceneManager.LoadScene("Character", LoadSceneMode.Single);
    }


    public void OnMenuOptionOptionsClicked()
    {
        Debug.Log("Options!");

        // open options panel, accessible from anywhere in game
        GameObject.Find("Loading").GetComponentInChildren<Text>().text = "Launching options...";
    }


    public void OnMenuOptionMultiplayerClicked()
    {
        Debug.Log("Multiplayer!");

        GameObject.Find("Loading").GetComponentInChildren<Text>().text = "Launching lobby...";
    }


    public void OnMenuOptionDiscordClicked()
    {
        // make sure to use a link which does not expire

        Application.OpenURL("https://discord.gg/fGkDdQU");
        GameObject.Find("Loading").GetComponentInChildren<Text>().text = "Launching Discord...";
    }


    public void OnMenuOptionExitClicked()
    {
        GameObject.Find("Loading").GetComponentInChildren<Text>().text = "Exiting...";
        Application.Quit();
    }

    // two options in the character creation screen - Menu and Start

    public void OnMenu()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    public void OnStartGame()
    {
        SceneManager.LoadScene("Demo", LoadSceneMode.Single);
        // SceneManager.LoadScene("ForestVillage", LoadSceneMode.Single);
    }


}



 */
