using UnityEngine;
using System.Collections;
using System.Collections.Generic;


// probably should be renaimed to State, since this will be unrelated now to DataBaseManager, or any sort of data connected with that class
// we can also initialize a custom starting state in a Start() method of this class -- for example we want the menu buttons toggled off, etc
// to access property: Data.tokens


public class Data : Singleton<Data>
{



    // sims

    public static List<Sim> sims = new List<Sim>();

    
    // same sort of thing as structure IDs, an easy of generating IDs by incrementing the last one

    public static int currentSimID = 0;

    public static int currentlySelectedSimByID;


    public static int workerAvailable = 0; // so that when we click on a workplace structure, we only get the worker assignment if there is a worker available to prevent null error, might be a better way




    // current structure ID

    // so that we increment each structure ID
    // then we save the game we could a foreach structure get ID, and position, so that we can restore ID and position on game restore
    // note that on a new game ID will be zero, so we might have to initialize the ID to the last (biggest number) structure ID of last time

    public static int currentStructureID = 0;


    // hmmm, the idea could also be simply the structure's coordinates in the map, since we can't have two structure on top of each other
    // currently we actually can because we don't have collision detection set up yet, but let's just use this simply integer ID for now


    

    // chart data

    // public static List<int> valueList = new List<int>() { 5, 98, 56, 45, 30, 22, 17, 15, 13, 17, 25, 37, 40, 36, 33 };
    // here we are showing negatives, we could do a hack, where if the number is negative then simply don't show, that might work
    // okay, so everytime when we increment the day, let's then update our stats
    public static List<int> valueList = new List<int>() {10, 20, 30, 100, 40, 30}; // need at least zero to prevent out of bounds, or could do the out of bounds check in the method, but this might be easier

    public static List<int> tokensChartList = new List<int>() {0}; // replace zero with the starting token amount, and likewise for any of the other starting resources

    





    // menu

    public enum ButtonSelection
    {
        BlueCube,
        GreenCube
    }

    public static ButtonSelection buttonSelection;


    // menu

    public enum StructureSelection
    {
        Skyscraper1,
        Skyscraper2,
        Residential1,
        Residential2,
        Road,
        Tree1,
        Tree2,
        House,
        Factory
    }

    public static StructureSelection structureSelection;
    


    



    // R E S O U R C E S



    public static int tokens = 10000;
    public static int land = 0;
    public static int energy = 0;
    public static int water = 0;
    public static int food = 0;
    public static int work = 0;
    public static int entertainment = 0;
    public static int marketResources = 0;
    public static int population = 1000;





    // map data


    /*
    we want a list, where we can just add the x and y coordinates as the index, this way we can decouple the functionality, and just always be able to add new data by the 2D index, so a vector2
    so we want a vector2 as one type, and then an integer as the other type, since we will be using integers instead of strings for a speed difference, if there is one

    USE 

    Vector2 v = new Vector2(0, 0);
    Data.map.Add(v, 1);
    Debug.Log(Data.map[v]);

    1 - house
    2 - skyscraper
    3 - road

    */


    public static Dictionary <Vector2, int> map = new Dictionary<Vector2, int>();

    // public static Dictionary <var, int> map = new Dictionary<var, int>();




    public static bool[] unlockedTechnologies;


    // number of road tiles - for determining when to start traffic

    public static int roadTiles = 0;


    









    // singleton

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }

}
