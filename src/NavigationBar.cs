using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// this is on the UI, and not the NavigationBar GameObject element

// can only have one button controller (or at least we should) on each game object, to then drag into the button slot

// make sure to set the sort order to a higher number (1 if the only other element is zero) to bring that canvas element on top so we can click the buttons


public class NavigationBar : MonoBehaviour
{

    

    Build build;

    public AudioSource speakers;
    
    public AudioClip select;


    public GameObject buildMenu;

    // build menu options which work with the click queue

    public GameObject buildMenu1;
    public GameObject buildMenu2;
    public GameObject buildMenu3;

    public GameObject border; 
    bool toggleBuildMenu = true; // also known as the palette bar, palette bar is the general term, and build menu is what we fill the palette bar with if the building icon is selected

    int clickQueue = 1; // replaces a simple on and off toggle, although the last click Queue will replace the toggle in that we will vanish the bar, might not be the best solution, but will work for now


    void Awake()
    {
        build = FindObjectOfType<Build>();
        // audioSource = GetComponent<AudioSource>();

        speakers.clip = select;
        speakers.volume = 1.0f;


    }




    public void OnSelectBuildingMenu()
    {
        
        speakers.Play();

        build.BuyLandEvent();

        // Events interfere with sounds?s
        // EventManager.TriggerEvent("BuyLand");
        // EventManager.TriggerEvent("BuildHouse");

    }



    public void OnToggleBuildMenu()
    {
        // so now instead of toggling the build menu we want to go through a count of 1 - 3, for each of the building menus


        Debug.Log(clickQueue);


        speakers.Play();
        
        // buildMenu.SetActive(toggleBuildMenu);


        clickQueue += 1;

        if (clickQueue > 3) clickQueue = 1;



        if (clickQueue == 0)
        {
            buildMenu1.SetActive(false);
            buildMenu2.SetActive(false);
            buildMenu3.SetActive(false);
            // border.SetActive(false);
        }



        if (clickQueue == 1)
        {
            buildMenu1.SetActive(true);
            buildMenu2.SetActive(false);
            buildMenu3.SetActive(false);
            // border.SetActive(true);
        }



        if (clickQueue == 2)
        {
            buildMenu1.SetActive(false);
            buildMenu2.SetActive(true);
            buildMenu3.SetActive(false);
            // border.SetActive(true);
        }



        if (clickQueue == 3)
        {
            buildMenu1.SetActive(false);
            buildMenu2.SetActive(false);
            buildMenu3.SetActive(true);
            // border.SetActive(false);
        }
        
        // old toggle
        // we will always be turning on the border
        // border.SetActive(toggleBuildMenu);
        // toggleBuildMenu = !toggleBuildMenu;


    }





}
