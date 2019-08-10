# City-Builder-Architects-Production


# Cityopoly

# App store description

- "Grow your realm, build alliances, and explore one of the deepest idle RPGs ever!" from realm grinder

- also use this kind of language, "explore one of the deepest city builders ever!" The kind of descriptions that makes the player's adrenaline race... 

# Japanese Gamemaking

“The most important thing I want a player to experience when playing our games is a sense of achievement.” - Eichi Nakajima,, Senior Managing Director FromSoftware

“From software’s philosophy is not to get caught up chasing what’s popular, but rather make games based on what we value. This is the most basic principle. We put enormous emphasis on simply making the kinds of games we want to make.”

“Focus on creating an experience that user will enjoy. Have tunnel vision and don’t even be aware of how other games are received.”

“For me the West is polarized between super AAA titles and indie games, whereas in Japan, as we’re not in a position to create AAA games, the best we could do is fall into this middle ground. I think we’re lucky in that sense.” - Ebb and Flow documentary

“I value atmosphere over realism.”

“When I make a game I don’t try to rely on something Japanese or European, but rather on the roots or the essence of what makes us human. But I may have adopted that Japanese way of thinking. There may be aspects of zen or haiku. We often say draw between the lines. We are told to imagine something by reading between the lines in the blank spaces. How to spur imagination with the fewest words possible, in a very high context. There may be that aspect.”

“Americans think in terms of logic and reason. But we tried to include many unreasonable elements. 

For example there is a choice you have to make, based solely for the purpose of entertainment. 

I think one thing that’s important is your ideas and what you want to create. I feel the players won’t enjoy games without these preferences and peculiarities. So that’s something I keep in mind when making games.

ON the polar opposite end, there needs to objectivity. You can’t completely ignore what the players want. When I’m create a game, I hav eto be aware of what we want to do with our ideas. , and what the fans want and maintain a balance between the two. 

We may be inferior in terms of scale, but attention to detail is a different evaluation point. I think that’s what makes japanese games appealing.

The development in the West is more systematic than in Japan. Every job is clearly assigned, middleware is streamlined. Level designers know exactly what to do. Japan has failed to form this kind of systematic environment. We’re still in the stages of trial and error. In japan the director encourages the team to use old fashioned elbow grease to get the job done. Directors have to be prideful and selfish or else the final stages will never be reached. In the end I think that’s what makes the difference. In a positive sense you could say we have a lot of freedom in our work. 

For the struggle against big worlds, we focused density, where you find objects that would advance the gameplay. 





CITYOPOLY

CITYOPOLY game design document, source documentation, and all supporting materials. Copyright 2018. All rights reserved.





























CONTENTS


Scope
Roadmap
Game mechanics
Multiplayer
Code structure
Graphics
Advertising
In App Purchases
ToDo
Log



























Scope

Cityopoly is a real time strategy city building game. 


Style

The style aims to strive for the high aesthetic in classic building toys, like Lego, Playmobil, well designed, the function is the design, everything has a purpose, and is elegant to contribute to the overall style of the game. You can almost smell the packing of the polish of the fine class toy.

Cityopoly strives for a minimalistic and elegant design style. The game features a light stylish minimalistic interface. Like Nintendo self suggesting graphics are used to convey information without relying on text.

The tiles forming the common ground in the beginning are of a video game greenish pleasant hue. The background is a light blue / violet video game-ish background color. The colors give you the sense of a simulation. These are also the kind of intro colors that can be tolerated on multiple replays.

The interface is also in the style of an elegant simulation control panel, with vector icons, and classy data and menu displays.

The gameplay mechanics following the elegant style of a simulation are also minimalistic, stylistic, expansive and emergent. The game feels like a good classic board game, but with all the full dimensional excitement of a tactical territorial warfare real time strategy game.

Even the intro music is heroic in the style of the high aesthetic. The score evokes the feeling of beginning a unique gameplay session. The game score has Danny Elfman influences of modulating keys for that sense of wonder, and magic.

The gang warfare style is an important aspect of multiplayer. Teams of 4 vs 4 can be formed, and even more. Gangs increase game points by controlling zones.


On sekaikan, or the mood and feel of the game:

“The word sekaikan includes everything, it’s the magic that attracts players into the world of that arcade game. How can we get players immersed in the world, using the surroundings? The sekaikan is the most essential part of any game. Because that represents the entire attraction the title might have. When people play games, they only have a limited space and time… You are surrounded by a certain world in your imagination. That way people can be attracted to something more easily, and become absorbed much more easily. 

Sekaikan is the key to attract the player, get them absorbed, totally immersed in the new environment and value system, the surroundings represented in the world of that game by that screen.”



Audience

This game is targeted towards a wide audience, both advanced RTS power games, and casual gamers.


Game Mechanics

Cityopoly is a competitive city building RTS. In the style of RTS games resource gathering is a large component of the game. Primarily resources are gathered by inhabitants of city. The more attractive the architecture of the city, the more likely the citizens are willing to stay, and generate Cityopoly tokens per unit of turn time.

Since the population is free to leave, a competitor can win population units by creating attractive environments near an opponent’s city. (Territorial warfare) (When people leave they are indicated by a minus sign, and a plus sign when they move in. The sign is next to an icon of the character used for population number. Once more leave a group sign shows. If just one character then one person icon, but if more than one then the multiple, after five. Up to five show accurately. After five just do the five people and the plus sign.

The players manage heroes, and build a city to compete for resources through strategy and skill.  At each stage a certain type of strategy is required to achieve a high score.


Architecture Mechanics


A win/lose condition.
A menu
A way to choose options on a menu
A way to go from the menu screen to the gameplay screen
A way to go back to the main menu from the gameplay screen
A way to restart the gameplay screen from zero (ie: no points)
A way to keep track of score.
A way to restart the gameplay without resetting score
A way to tell the users who won.
A way to play sounds to provide feedback.


Communicating between components with reference

https://unity3d.com/learn/tutorials/topics/scripting/how-communicate-between-scripts-and-gameobjects

“When game objects are destroyed, they need to reference themselves with the game controller and game controller will count points off, update score… when instantiated, find game object with tag for game controller, and then get component on that controller, and make a reference that way, or can push data…”

// path finding isometric mechanism: https://gamedev.stackexchange.com/questions/124279/traffic-system-in-isometric-game


45:00














ROADMAP

MVP 1: map
MVP 2: build
MVP 3: score
MVP 4: menu
MVP 5: hero
MVP 6: interface
MVP 7: items
MVP 8: roads detection
MVP 9: people + cars animations
MVP 10: procedural map generation
MVP 11: saving game state
MVP 12: item hero interaction, fun factor
MVP 13: heroes collection / team
MVP 14: score
MVP 15: tile expansion - tiles 2.0 - find better models
MVP 16: start new game hero customization
MVP 17: take a step back - polish - new MVP
MVP 18: overhead level ups, birds + clouds animations
MVP 19: tile stats
MVP 20: multiplayer

Further MVP Ideas









MVP 1

Objective: map

Milestones

Define tile palette
Ex. 0 = ground_one
Create map (4 x 4, 8 x 8)
Note for later: irregular map is still uniform. Empty space is filled with default background color tile
Read from level_one.txt, level_two.txt

MVP 1 is done! :) 



Grid Code:

using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class map : MonoBehaviour {
    
    
    // THE TILE

   public GameObject tile_ground_one_model; // 1 model is a prefab -> must match name on Map draggable instance
   public GameObject tile_home_one_model; // 2
   public GameObject tile_office_one_model; // 3
    
    // properties
   int rows = 10; // these can be less than the actual 2d matrix -- useful when using fog of war
   int columns = 10;

   float x_offset = 0.49f;
   float y_offset = 0.28f; // the distance between the y component of the next row

  
    // THE WORLD MAP

   int[,] world = new int[10, 10] // first number is length of rows, second length of columns
   {
       {0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
       {1, 1, 1, 1, 1, 1, 1, 1, 0, 0},
       {1, 1, 1, 1, 1, 1, 1, 2, 1, 0},
       {1, 1, 1, 1, 3, 3, 1, 0, 0, 0},
       {1, 1, 1, 1, 1, 3, 1, 0, 0, 0},
       {1, 1, 1, 1, 2, 1, 1, 0, 0, 0},
       {0, 1, 1, 1, 1, 1, 0, 0, 0, 0},
       {0, 1, 1, 1, 1, 0, 0, 0, 0, 0},
       {0, 1, 1, 1, 0, 0, 0, 0, 0, 0},
       {0, 1, 1, 1, 1, 1, 1, 0, 0, 0},
   };


   // ARRANGE

   void arrange()
   {
       for (int x = 0; x < rows; x++)
       {
           for (int y = 0; y < columns; y++)
           {
               float x_pos = x;
               if (y % 2 == 1)
               {
                   x_pos += x_offset;
               }
               // tileType = levelData[i][j];
               // placetile(tileType, x, y)
               int tile_type = world[x, y];
               // if empty space, we just simply don't paint the 0
               if (tile_type == 1) Instantiate(tile_ground_one_model, new Vector3(x_pos, y * y_offset, 0), Quaternion.identity);
               if (tile_type == 2) Instantiate(tile_home_one_model, new Vector3(x_pos, y * y_offset, 0), Quaternion.identity);
               if (tile_type == 3) Instantiate(tile_office_one_model, new Vector3(x_pos, y * y_offset, 0), Quaternion.identity);
           }
       }
   }

   void Start() { arrange(); }

}

Final grid code:

using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class map : MonoBehaviour
{


    // THE TILE 

    public GameObject tile_ground_one_model; // 1 model is a prefab -> must match name on Map draggable instance
    public GameObject tile_home_one_model; // 2
    public GameObject tile_office_one_model; // 3

    float x_offset = 0.49f;
    float y_offset = 0.28f; // the distance between the y component of the next row



    // THE WORLD MAP

    int rows = 10; // these can be less than the actual 2d matrix -- useful when using fog of war
    int columns = 10;

    int[,] world = new int[10, 10] // first number is length of rows, second length of columns
    {
        {3, 1, 1, 1, 1, 1, 1, 1, 1, 3},
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
        {2, 1, 1, 1, 1, 1, 1, 1, 1, 2},
    };


    // ARRANGE

    void arrange() // in the future check whether the tile ID has changed before instantiating new object, that can help with processing speed
    {
        for (int y = 0; y < rows; y++)
        {
            for (int x = 0; x < columns; x++)
            {
                float x_pos = x;
                if (y % 2 == 1)
                {
                    x_pos += x_offset;
                }
                // tileType = levelData[i][j];
                // placetile(tileType, x, y)
                int tile_type = world[x, y];
                // if empty space, we just simply don't paint the 0, also in the future check if tile already exists to prevent repainting, and also destroy the object in memory eventually
                if (tile_type == 1) Instantiate(tile_ground_one_model, new Vector3(x_pos, y * y_offset, 0), Quaternion.identity);
                if (tile_type == 2) Instantiate(tile_home_one_model, new Vector3(x_pos, y * y_offset, 0), Quaternion.identity);
                if (tile_type == 3) Instantiate(tile_office_one_model, new Vector3(x_pos, y * y_offset, 0), Quaternion.identity);
            }
        }
    }

    void Start() { arrange(); }

}



















MVP 2

Objective: build

Milestones

Get player input
Select grid cell (hex helper, Sokoban, modify for isometric, plus look for isometric resources)
Place tile there
Note in inventory
Tile palette menu system
Organize tile by type







MVP 3

Objective: score

Milestones

Display score (score tracking mechanism)
Create timing mechanism for turns
Place turn building limitations
Display time to build something
Show how many points needed to build something
Simply gray out tile from palette if unavailable
Show cost at bottom
Create Cityopoly Tokens ™ 



MVP 4

Objective: menu

Milestones

Create a) menu scene b) play scene
Menu
new (working)
load (dummy button)
continue (dummy)
Settings
Ability to access menu from play scene


MVP 5

Objective: hero

Milestones

Select hero
Name hero
Assign RPG points
Construction speed
Capital gain
Social power
Level 0 - 100
Keep track of hero leveling up through game turns




MVP 6

Objective: interface

Milestones

Interface:
a) main menu
b) game + player stats
c) build menu
Hero stats
Display level underneath hero overlay on bottom center of screen

MVP 7

Objective: inventory items

Milestones

Inventory hero panel
Nice empty looking area
Create inventory list + graphics
Running inventory of:
(building + heros + items + tokens inventory)






Further MVP Ideas


Outposts capture
Tile highlighting (where tile can be placed)
Player can choose background tile color
Detailed tile placement mechanics
Where road can be placed
Business have to be close to roads
Proximity bonus
Trees density for procedural generation
+ 2 or / 2 for fun factor, core engine polish
Multiplayer stuff
Gangs
Tutorial mode
Build speed aesthetics
Animations
Cars, people, clouds, birds
Build progress
Plant trees
City satisfaction stats
Population size
Relative satisfaction
Hero leveling up powers
Items combined with required level = magic
Fight for office space with entrepreneurs
Zones / sphere of influence
Advanced resource generation
Character stats
Research / upgrade
Biotech - lab / microscope symbol
Science - atom symbol
Dna symbol - biotech
Tech - innovation symbol
Point spending mechanism
Cityopoly tokens refinement
How many required for each facet of game
Numismatics
Individual building stats
Affected by proximity, zones, spheres of influence, which can come from characters inhabiting these buildings
Hero building inhabiting mechanism
Emotional symbolic inter player communication
Emoticons?
Other graphical ways of showing emotions?
Improving the fun factor / core gameplay
Dopamine response
Frequency + intervals of response
Response can be good or bad, (pleasure or stress)
intervals between both is the focus








MVP LOGISTICS

MVP 1

Objective: map

Milestones

Define tile palette
Ex. 0 = ground_one
Create map (4 x 4, 8 x 8)
Note for later: irregular map is still uniform. Empty space is filled with default background color tile
Read from level_one.txt, level_two.txt

BACKGROUND GRAPHICS

A set of 10 tiles
A game grid of 100 x 100
Tile pixel size:
X pixel (cartesian) width ______
Y pixel (caresian) height ______

ISOMETRIC LAYOUT




FIG. 1 - ISOMETRIC LAYOUT


TILE PALETTE (10)

0 - background_color
1 - ground_one
2 - ground_two
3 - home_one
4 - home_two
5 - store_one
6 - store_two
7 - office_one
8 - office_two
9 - tree_one


GRID LAYOUT (100 x 100)

Input order

Left to right, then skip a row starting on the left again, (like reading)

Example of input:

[1, 0, 1, 0,
 0, 0, 0, 0,
 1, 0, 0, 1,
 1, 1, 1, 1]

This is a 4 by 4 world.

https://connect.unity.com/p/articles-what-i-learned-from-trying-to-make-an-isometric-game-in-unity

https://www.reddit.com/r/Unity3D/comments/3flpps/what_is_the_best_method_for_making_an_isometric/


https://gamedevelopment.tutsplus.com/tutorials/unity-2d-tile-based-isometric-and-hexagonal-sokoban-game--cms-29715












# map module


# 2D to ISO, and ISO to 2D
# https://gamedevelopment.tutsplus.com/tutorials/creating-isometric-worlds-a-primer-for-game-developers--gamedev-6511





map_arrangement = [[1, 1, 1, 1],
                  [1, 0, 0, 0],
                  [0, 0, 0, 0],
                  [0, 1, 1, 1]]




def place_tiles(rows, columns):
   tile_width = 3.14
   tile_height = 3.14
   for i in rows:
       for j in columns:
           x = j * tile width
           y = i * tile height
           tile_type = map_arrangement[i][j]
           set_tile(tile_type, cartesian_to_isometric(x, y))






def cartesian_to_isometric(cartesian_x, cartesian_y):
   isometric_point = []
   isometric_point.x = cartesian_x - cartesian_y
   isometric_point.y = (cartesian_x + cartesian_y) / 2
   return isometric_point






def isometric_to_cartesian(isometric_x, isometric_y):
   cartesian_point = []
   cartesian_point.x = (2 * isometric_y + isometric_x) / 2
   cartesian_point.y = (2 * isometric_y - isometric_x) / 2
   return cartesian_point




def set_tile():
   # send to graphix
   pass




def place_tiles():
   tile_width = 3.14
   tile_height = 3.14
   for i in rows:
       for j in columns:
           x = j * tile width
           y = i * tile height
           tile_type = map_arrangement[i][j]
           set_tile(tile_type, cartesian_to_isometric(x, y))





def get_tile_coordinates(2D_point, tile_height): # assumes height and width coordinates are equal
   point = []
   point.x = Math.floor(point.x / tile_height)
   point.y = Math.floor(point.y / tile_height)
   return point





# finding from a pair of isometric coordinates, the 2D coordinates
get_tile_coordinates(isometric_to_cartesian(screen_point), tile_height)






def y_isometric_movement():
   y = y + speed
   place_tile(cartesian_to_isometric(new_point.x, new_point.y))





def depth_sorting():
   # The simplest depth sorting method is simply to use the Cartesian y-coordinate value, as mentioned in this Quick Tip: the further up the screen the object is, the earlier it should be drawn. This work well as long as we do not have any sprites that occupy more than a single tile space.
   # The most efficient way of depth sorting for isometric worlds is to break all the tiles into standard single-tile dimensions and not to allow larger images. For example, here is a tile which does not fit into the standard tile size - see how we can split it into multiple tiles which each fit the tile dimensions:
   pass





'''

Shortcuts

In the demo, I simply redraw the scene again each frame based on the new position of the hero. We find the tile which the hero occupies and draw the hero on top of the ground tile when the rendering loops reach those tiles.

But if we look closer, we will find that there is no need to loop through all the tiles in this case. The grass tiles and the top and left wall tiles are always drawn before the hero is drawn, so we don't ever need to redraw them at all. Also, the bottom and right wall tiles are always in front of the hero and hence drawn after the hero is drawn.

Essentially, then, we only need to perform depth sorting between the wall inside the active area and the hero - that is, two tiles. Noticing these kinds of shortcuts will help you save a lot of processing time, which can be crucial for performance.

'''



















''' example:

2D point = [100, 100];
// twoDToIso(2D point) will be calculated as below
isoX = 100 - 100; // = 0
isoY = (100 + 100) / 2;  // = 100
Iso point == [0, 100]

'''























TILER

First design Tiler in Python as a prototype. Tyler should be able to do these things:


tiler.input_map_arrangement()
tiler.iso_to_cart()
tiler.cart_to_iso()
tiler.place_tiles()
tiler.set_tile()
tiler.get_tile_coordinates()


Selecting over tiles. (helpful for build)

https://www.youtube.com/watch?v=og8S3NEzzGM

START HERE NEXT TIME

Go over Sokoban too, and a few others to see how things are accomplished.

Great tutorial on isometric movement. Shows how to use vectors well to get overall direction from x, and y:

https://www.youtube.com/watch?v=XhliRnzJe5g







Code Logistics


map.cs central file module

map module allows:

Basic flow: read from level_one.txt, draw on screen
Conversion between Cartesian and Isometric




Main methods of map:


map.arrange(cell_grid)

The main method of the map module. Takes an array of a grid layout and does everything in between to output the map arrangement on the screen.

Cell grid: [0, 1, 0, 2, 3]

map.draw()

Manages the drawing graphic functions. Uses map.arange() to figure out layout before drawing. The main and only method called from entire module.


Helper methods:


map.isometric_to_cartesian()

Converts between map layout numbering system, and the x and y surface of the game screen.

map.cartesian_to_isometric()

Converts between map layout numbering system, and the x and y surface of the game screen.

map.calculate_offset()

Calculates the x and y offset.

map.iterate_layout()

Uses a double for loop to plot over x and y.


The ISO Code (Completes MVP1)

using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class map : MonoBehaviour { // create the map object as an empty gameplay object in scene
// then see part 2



    // THE TILE 


    // the tile game object
    public GameObject tile_ground_one_model; // part 2: model is a prefab -> must match name on Map draggable instance

    // properties
    int rows = 8;
    int columns = 8;

    float x_offset = 0.49f;
    float y_offset = 0.28f; // the distance between the y component of the next row



    // ARRANGE


    void arrange()
    {
        for (int x = 0; x < rows; x++)
        {
            for (int y = 0; y < columns; y++)
            {
                float x_pos = x;
                if (y % 2 == 1)
                {
                    x_pos += x_offset;
                }
                Instantiate(tile_ground_one_model, new Vector3(x_pos, y * y_offset, 0), Quaternion.identity);
            }
        }
    }

    /*
    void arrange() {
        for (int x = 0; x < rows; x++)
        {
            for (int y = 0; y < columns; y++)
            {
                float x_position = x;
                if (x % 2 == 1) { // odd row
                    x_position += odd_row_x_offset;
                }
                // this is adding padding vertically
                // Instantiate(tile_ground_one_model, new Vector3(x, y * z_offset, 0), Quaternion.identity);

                // experimenting with multiplying the x component instead
                Instantiate(tile_ground_one_model, new Vector3(x, y, 0), Quaternion.identity);

                // Instantiate(tile_ground_one_model, new Vector3(x, 0, y * z_offset), Quaternion.identity);
                // tileType = levelData[i][j];
                // placetile(tileType, x, y);
            }
        }
    }
    */



    // run
    void Start() { arrange(); }
    
    
    // Update is called once per frame
    void Update() {}
}



MVP 1: Progress!



Considerable progress has been made, even though there were challenges.

Now do 2 things:

Go through the rest of Quil’s tutorials with pen and paper
Create the ability to generate a map from a text 2d array







Map with world data:

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// path finding isometric mechanism: https://gamedev.stackexchange.com/questions/124279/traffic-system-in-isometric-game



public class map : MonoBehaviour {



    // THE TILE 


    // the tile game object
    public GameObject tile_ground_one_model; // 1 model is a prefab -> must match name on Map draggable instance
    public GameObject tile_home_one_model; // 2
    public GameObject tile_office_one_model; // 3


    // properties
    int rows = 10; // these can be less than the actual 2d matrix -- useful when using fog of war
    int columns = 10;

    float x_offset = 0.49f;
    float y_offset = 0.28f; // the distance between the y component of the next row


    // int[,] a = new int[3, 4] {
    // {0, 1, 2, 3} ,   /*  initializers for row indexed by 0 */
    // {4, 5, 6, 7} ,   /*  initializers for row indexed by 1 */
    // {8, 9, 10, 11}   /*  initializers for row indexed by 2 */
    // };


    int[,] world = new int[10, 10]
    {
        {0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
        {1, 1, 1, 1, 1, 1, 1, 1, 0, 0},
        {1, 1, 1, 1, 1, 1, 1, 2, 1, 0},
        {1, 1, 1, 1, 1, 1, 1, 0, 0, 0},
        {1, 1, 1, 1, 1, 1, 1, 0, 0, 0},
        {1, 1, 1, 1, 2, 1, 1, 0, 0, 0},
        {0, 1, 1, 1, 1, 1, 0, 0, 0, 0},
        {0, 1, 1, 1, 1, 0, 0, 0, 0, 0},
        {0, 1, 1, 1, 0, 0, 0, 0, 0, 0},
        {0, 1, 1, 1, 1, 1, 1, 0, 0, 0},
    };

    // access: int tile_type = world[2,3];





    // ARRANGE


    void arrange()
    {
        for (int x = 0; x < rows; x++)
        {
            for (int y = 0; y < columns; y++)
            {
                float x_pos = x;
                if (y % 2 == 1)
                {
                    x_pos += x_offset;
                }
                // tileType = levelData[i][j];
                // placetile(tileType, x, y)
                int tile_type = world[x, y];
                // if (tile_type == 0) break; // empty space
                if (tile_type == 1) Instantiate(tile_ground_one_model, new Vector3(x_pos, y * y_offset, 0), Quaternion.identity);
                if (tile_type == 2) Instantiate(tile_home_one_model, new Vector3(x_pos, y * y_offset, 0), Quaternion.identity);
                if (tile_type == 3) Instantiate(tile_office_one_model, new Vector3(x_pos, y * y_offset, 0), Quaternion.identity);
            }
        }
    }


    // run
    void Start() { arrange(); }
    
    
    // Update is called once per frame
    void Update() {}
}





An few notes together:

For logo use clouds and birds animation. Against bright baby blue, with white clouds moving. That will fullfill the animation logo interest. Also birds are chirping.
Start music intro loop during menu screen. Keep looping. If user moves into gain, keep music going until the track is finished. 
4 procedurally zones to start from
Convert graphics to vectors, to easily scale up to retina display.
Clouds tend to stick around to skyscrapers and houses.

Next phase: build.


Building Features

Create a palette to choose tiles from. Use Unity’s GridLayout feature
To do so, we need some sort of early navigation system. Use a sphere in the lower left corner.
In the sphere show Cityopoly tokens (CTs, show symbol), and population size.
Tokens on the left, population on the right.
To do this will have to push up development phase of the interface. Develop the interface first, and then the build buttons.









INTERFACE

Structure
Circle forms the main body of the interface.
At the bottom are two stats:
Cityopoly tokens (use game coin symbol)
0 / 100 population (person symbol)
Shows how many out of available vacancy
For more occupation, player needs to build more structures, especially homes / apartments, although to get the optimal amount of population you need a 1:3 ratio of commercial to residences
The Menu Circle has four different elements:
Menu
Stats
Build
Heroes
We could display what’s selected in the circle area, after the interface choice has been clicked
Can give player ability to spin around interface items on the wheel
If a player selects a structure, the menu shows up on the sphere, and if the structure has for example, just one choice, that choice shows up as a sphere on the circle, could be the only one, or be separated by a light white thin line, from the rest of the interface, so pops up at the front of the line of sphere selections.


LOOK AND FEEL

BACKGROUND
The background plays a big part if the game is minimalistic.
Use a light blue / purple background
Giver the user 3 choices of backgrounds:
Light blueish / purple (default)
Black
White
A way to toggle the interface off / on, hide out of view, for minimalism Seikakan

This is a nice design for Cityopoly Tokens, as they would appear on the front interface:



https://www.shutterstock.com/image-vector/vector-gold-coin-198755876?irgwc=1&utm_medium=Affiliate&utm_campaign=Graphic%20resources%20SL&utm_source=39422&utm_term=2124206172.1524052881


Also a good one:

https://www.shutterstock.com/image-vector/gold-medal-games-golden-coin-star-335455103?irgwc=1&utm_medium=Affiliate&utm_campaign=Graphic%20resources%20SL&utm_source=39422&utm_term=2124206172.1524052881


This is a nice one for the population number. Use the 12th one, without the extra two people on the sides. So three people total. Or use them all. Looks great. Would look nice as white for the standard interface, and would also look nice as white against a black background, with white font for the score.

There are some nice things to use here from these icons. The dialogue could be a symbol of increased social interactions in the area. Thumbs up could be that people are happy. Thumbs down unhappy. There is a way to turn off / on thumbs up for advanced players in the options / settings screen, denoted by a simple Gear icon.

The people can also be used, especially for tutorials.

Could also be one person for small population, two for medium, and three for large. Or can find this number out by city selected. Player at all times is selecting one city, and only one. So then the person icon changes, with different number of people if the city is a different size. Also we can see how many out of available occupancy there are.

The number of people indicated is low due to being in a simulation. 

So if you have a house, that’s between 1 - 5 people. The simulation shows accurate numbers. You can have up to 5 people in a house. If you build more housing those people will automatically (or let player do) spread out. If there is a more attractive zone near by, they will move to that zone and you will lose people. So if the opponent builds a more attractive zone, they will take people, and as a result you’ll miss the people’s generating money ability. For every person you get one coin per minute.

There are multiple ways of generating revenue. This is a basic one core one. Show the user in the tutorial, that one person equals one gold coin per turn. Or just tell them, more people, more Cityopoly tokens they generate for you. Don’t reveal the turn based mechanism, in this case of per unit of time, generate one coin for each person. Fine tune the unit of time for the fun factor. Can also put a negative feedback limit if the money gets out of hand in anyway. Per buildable units per area.





Use the icon of the person waving buy, to indicate to player that they are leaving the building. So simple either in the center or in the top right hand corner, show that icon flashing slowly three times, that they are leaving that residential area, (one discrete tile, or even a group of residential area, looking interconnected, but at programming level this would just be by unit, and including adjacent units bonus, to simulate a wave of people leaving.) 

So in a simulation, if you just wait with one house, the person will leave, and you will eventually see in the simulation: 0 / 5(per one house standing).

You start the game with 5/5, per the one standard house you get to start with. You also start with 1000, or so of capital, a big number to offset the first slow generation of tokens from people per unit.

Make fun looking, comic book style loading screens. Even a fake loading screen, to have a few seconds to look at these random scenes. Hire a comic book artist to draw these. These would show the stories of the sims in the city. The loading could also move somehow interestingly. Or try to find some really nice images to look like props. Probably some realistic looking art of city life. Play also very interesting music during loading screen, that transitions smoothly into gameplay.




 





https://www.shutterstock.com/image-vector/social-icons-137212535?src=Fx2phu-vYvSw_ruptV_zqw-1-12
This one is more minimalistic. Either take the one, or just use all three.





https://www.shutterstock.com/image-vector/people-vector-icon-378571234?src=Fx2phu-vYvSw_ruptV_zqw-1-0
















MVP 2

Objective: build

Milestones

Get player input
Select grid cell (hex helper, Sokoban, modify for isometric, plus look for isometric resources)
Place tile there
Note in inventory
Tile palette menu system
Organize tile by type


Some notes:
Work toward two goals: maximum player fun (gameplay)and minimum player frustration (random events, poor interface, bugs) from the team of Age of Empires
There are no real do’s and don’ts. You simply rely on your instincts and thousands of hours of testing different types of game players. We use this evolutionary process because it gives us the best chance of developing a game that’s a lot of fun to play and is deep. 
Provide the layer with interesting decisions, not trivial or random ones. This is the essence of gameplay. 
Analyze what the competition is doing very well and plan how you will meet or exceed them; determine where the competition is weak and plan how you can be very strong in those areas. That’s what the team did for Age of Empires
You have a lot of advantages -- the most successful professional game designers are usually the ones who both design the games and write the code personally. If you’ve got a cool idea for a game, no one can bring it to life the way you can. 
Play your game nd see which parts are fun, what are the strong and weak areas. Then get back into the code, improve the strong points, and eliminate the weak points.(or sometimes start all over with a different idea. We create a working prototype in the first few of weeks of a project, and then play and revise and play and revise and play and revise for the rest of the project. We call this “prototyping” and the “iterative” design process, and it really works. If you want to end up with a game that’s really fun, there's no substitute for playing it yourself.
Let the player pick the strategy. If your game can be won using not just one, but a whole variety of strategies, people will want to play it more than once. 
Principles like not designing it all up front, working with the team, experimentation, paying attention to the market, breaking some rules, not being afraid of copying what the competition has proven to be fun, and not being afraid of throwing stuff away that sucks!






This seems like a helpful building isometric tile editor in Unity:

https://forum.unity.com/threads/2d-isometric-tile-editor.299781/

https://gamedevelopment.tutsplus.com/tutorials/creating-isometric-worlds-primer-for-game-developers-updated--cms-28392











Finally got the grid to work with 3D cubic mathematics. Now the organization seems neater. That was worth the effort even though the challenge was not easy.

There are a number of wins here:
Code will be easier to work with movement math
The tile is now a class instead of residing in Map
I can follow along with Quil’s tutorials and benefit further:
Menu system
Movement in isometric grid (something not to be understated)
Other features from Quil’s system
Programming skill in C#
Unity further tutorials
And all in this in a short span of time


This should take the project closer to getting the mapping and building modules out of the way. And of getting a start on the interface system.


Remember if you’re clever you will make things really simple. 











Here is the code:

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile
{

    public readonly int Q;
    public readonly int R;
    public readonly int S;

    public float x_offset = 0.8f;
    public float y_offset = 0.4f;

    static float WIDTH_MULTIPLIER = Mathf.Sqrt(3) / 2;

    public Tile(int q, int r)
    {
        this.Q = q;
        this.R = r;
        this.S = -(q + r);
    }

    public Vector3 Position()
    {
        float radius = 1f;
        float height = radius * 2;
        float width = WIDTH_MULTIPLIER * height;

        float vert = height * 0.75f;
        float horiz = width;

        return new Vector3(
            (this.Q + this.R / 2f) * x_offset,
            this.R * y_offset,
            0f
            );

   }

}




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{

    // Tile
    public GameObject tile_ground_one_model;

    // Map
    int rows = 10;
    int columns = 10;

    // Arrange
    public void Arrange()
    {
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                Tile t = new Tile(column, row);
                Instantiate(tile_ground_one_model, t.Position(), Quaternion.identity, this.transform);
            }
        }
    }

    // Run
    void Start()
    {
        Arrange();
    }

}

 



So here we have a Tile and a Map module. The tile’s offset and vector coordinates are stored here. This doesn’t connect to Unity, instead this is just a standalone module which converts our vector space dimensions with cubic mathematics.

I am including this article in the appendix.

Here is the code redone:

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{

    // Tile
    public GameObject tile_ground_one;
    public GameObject tile_ground_two;
    public GameObject tile_ground_three;
    public GameObject tile_home_one;
    public GameObject tile_home_two;
    public GameObject tile_office_one;
    public GameObject tile_office_two;

    // Map
    int rows = 10;
    int columns = 10;

    int[,] world = new int[10, 10]
    {
        {1, 1, 7, 1, 3, 3, 3, 3, 3, 1},
        {1, 1, 6, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 5, 1, 1, 0, 1, 6, 6, 1},
        {1, 1, 4, 1, 0, 0, 1, 1, 7, 1},
        {1, 1, 3, 1, 0, 0, 1, 1, 7, 1},
        {1, 1, 2, 1, 0, 0, 1, 2, 6, 1},
        {1, 1, 1, 1, 1, 1, 1, 2, 7, 1},
        {1, 1, 1, 1, 1, 1, 1, 2, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 1, 3, 3, 3, 3, 3, 1}
    };

    // Arrange
    public void Arrange()
    {
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                Tile t = new Tile(column, row);
                int tile_type = world[row, column];
                if (tile_type == 1) Instantiate(tile_ground_one, t.Position(), Quaternion.identity, this.transform);
                if (tile_type == 2) Instantiate(tile_ground_two, t.Position(), Quaternion.identity, this.transform);
                if (tile_type == 3) Instantiate(tile_ground_three, t.Position(), Quaternion.identity, this.transform);
                if (tile_type == 4) Instantiate(tile_home_one, t.Position(), Quaternion.identity, this.transform);
                if (tile_type == 5) Instantiate(tile_home_two, t.Position(), Quaternion.identity, this.transform);
                if (tile_type == 6) Instantiate(tile_office_one, t.Position(), Quaternion.identity, this.transform);
                if (tile_type == 7) Instantiate(tile_office_two, t.Position(), Quaternion.identity, this.transform);
            }
        }
    }

    void Start()
    {
        Arrange();
    }

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile
{
    public readonly int Q;
    public readonly int R;
    public readonly int S;

    // static float WIDTH_MULTIPLIER = Mathf.Sqrt(3) / 2;
    static float WIDTH_MULTIPLIER = 0.5f; // half of a tile

    public Tile(int q, int r)
    {
        this.Q = q;
        this.R = r;
        this.S = -(q + r);
    }

    public Vector3 Position()
    {
        float radius = 1f;
        float height = radius * 2;
        float width = WIDTH_MULTIPLIER * height;

        float vert = height * 0.17f; // the height multiplier 
        float horiz = width;

        return new Vector3(
            horiz * (this.Q + this.R / 2f),
            vert * this.R,
            0f
            );
    }
}


MVP 2 Continued Ludum Dare Weekend



Got some really nice progress going. Mostly thanks to this guy: https://www.twitch.tv/videos/252349455

He was in turn inspired by a new RTS game called Tooth and Tail to create a prototype for an RTS game

The code is so good that I’m posting here afraid I’ll lose progress. The big advantages so far is assigning an agent controller to each of the tile, that denotes the type, the HP, and the coordinates. There is also a state for whether the component is selected, which will be useful in bringing up options for the structure. For this I think a good solution would be to create a class for each type, and initialize either within the Agent, which would be a generic wrapper for all agents, or agents of type building / character in the game. And then in that class, Ground for example initialize all the ground type stuff. So if tile would be a class Office tile, the class Office would contain the specific Office information, including HP, and other details centric to Office type buildings.

The nice thing also is that after you establish the three different types, you can initialize them from the prefab. Click on the prefab, and then select ground, home, or office from the dropdown. And that seems to be the only place to specify the type, other than tagging them with the specific class. A pretty cool technique that can be used in a lot of different ways, namely selecting the types of prefabs in a similar group. 






Attach this script to each prefabbed tile:

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentCtrl : MonoBehaviour {

    public Agent agent = new Agent(100); // public agent object instance per agent

    public Vector3 coordinates;
    public bool selected;
    public float showHP;
    public enum type {Ground, Home, Office};
    public type Type;
    
    // Material[] myMats = new Material[2];


	void Start () {
        coordinates = transform.position;
        // nav = gameObject.AddComponent<NavMeshAgent>();
	}

	void Update () {
        showHP = agent.hp; // can see the hp at run time
        // nav.destination = des;

	}

    public void set_click_destination(Vector3 d) // so we can't change this in other scripts
    {
        coordinates = d;
    }
}




Here is the class Agent:

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent
{
    float _hp;
    public float hp { get { return _hp; } }

    public Agent(float HP)
    {
        _hp = HP;
    }

    public void RemoveHP(float value)
    {
            _hp -= value;
    }
}




Here is the Controller. This is the central place we process user input from to be efficient.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// this is the master controller which registers the clicks and sends to all selected agents for efficiency 

public class Controller : MonoBehaviour {


    public List<AgentCtrl> AgentInventory = new List<AgentCtrl>();

    /*
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            if (hit.collider.tag == "Agent")
            {
                AgentCtrl sel = hit.transform.GetComponent<AgentCtrl>();
                bool pass = false;


                if (sel.Type == AgentCtrl.type.Trainer)
                {
                    pass = true;
                }
                else if (sel.Type == AgentCtrl.type.Creature)
                {
                    continue;
                }

                if (pass)
                {
                    // checks to see if selected agent is in list, if not adds and removes them based on selected state
                    if (AgentInventory.Contains(sel)) add_remove_agent_in_inventory(false, sel);
                    else
                    {
                        add_remove_agent_in_inventory(true, sel);
                    }

                }
            }
        }
	}

    void add_remove_agent_in_inventory(bool add, AgentCtrl sel)
    {
        if (add)
        {
            AgentInventory.Add(sel);
        }
        else
        {
            AgentInventory.Remove(sel);
        }
        sel.selected = add;
    }
    */
}



And finally to keep things in one place, here are Tile and Map:


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile
{
    public readonly int Q;
    public readonly int R;
    public readonly int S;

    static float width_multiplier = 0.5f; // half of a tile

    float radius = 1f;
    bool allowWrapEastWest = true;
    bool allowWrapNorthSouth = false;

    public Tile(int q, int r)
    {
        this.Q = q;
        this.R = r;
        this.S = -(q + r);
    }

    public Vector3 Position()
    {
        return new Vector3(
            tile_horizontal_spacing() * (this.Q + this.R / 2f),
            tile_vertical_spacing() * this.R,
            0f
            );
    }

    public float tile_height()
    {
        return radius * 2;
    }

    public float tile_width()
    {
        return width_multiplier * tile_height();
    }

    public float tile_vertical_spacing()
    {
        return tile_height() * 0.17f;
    }

    public float tile_horizontal_spacing()
    {
        return tile_width();
    }

    /*

    public Vector3 PositionFromCamera(Vector3 cameraPosition, float numRows, float numColumns)
    {
        // float mapHeight = numRows * HexVerticalSpacing();
        float mapWidth = numColumns * HexHorizontalSpacing();

        Vector3 position = Position();

        int mapHeight = 10;

        if (allowWrapEastWest)
        {
            float howManyWidthsFromCamera = (position.x - cameraPosition.x) / mapWidth;


            if (howManyWidthsFromCamera > 0)
                howManyWidthsFromCamera += 0.5f;
            else
                howManyWidthsFromCamera -= 0.5f;

            int howManyWidthsToFix = (int)howManyWidthsFromCamera;

            position.x -= howManyWidthsToFix * mapWidth;
        }

        if (allowWrapNorthSouth)
        {
            float howManyHeightsFromCamera = (position.y - cameraPosition.y) / mapHeight;


            if (howManyHeightsFromCamera > 0)
                howManyHeightsFromCamera += 0.5f;
            else
                howManyHeightsFromCamera -= 0.5f;

            int howManyWidthsToFix = (int)howManyHeightsFromCamera;

            position.y -= howManyWidthsToFix * mapWidth;
        }

        return position;


    }

    */
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{

    // Tile
    public GameObject tile_ground_one;
    public GameObject tile_ground_two;
    public GameObject tile_ground_three;
    public GameObject tile_home_one;
    public GameObject tile_home_two;
    public GameObject tile_office_one;
    public GameObject tile_office_two;

    // Map
    int rows = 10;
    int columns = 10;

    int[,] world = new int[10, 10]
    {
        {0, 0, 0, 1, 1, 1, 1, 1, 1, 4},
        {0, 0, 1, 1, 1, 1, 1, 1, 1, 1},
        {0, 0, 0, 5, 4, 1, 1, 1, 1, 1},
        {0, 0, 0, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 7, 1, 4, 3, 1, 1, 1},
        {4, 1, 1, 1, 1, 1, 2, 1, 1, 1},
        {4, 4, 1, 1, 5, 7, 1, 1, 1, 1},
        {4, 4, 1, 1, 1, 1, 7, 1, 1, 1},
        {4, 4, 1, 1, 5, 6, 7, 1, 1, 1},
        {4, 4, 1, 1, 1, 1, 1, 1, 1, 1}
    };

    // Arrange
    public void Arrange()
    {
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                Tile t = new Tile(column, row);
                int tile_type = world[column, row];
                if (tile_type == 1) Instantiate(tile_ground_one, t.Position(), Quaternion.identity, this.transform);
                if (tile_type == 2) Instantiate(tile_ground_two, t.Position(), Quaternion.identity, this.transform);
                if (tile_type == 3) Instantiate(tile_ground_three, t.Position(), Quaternion.identity, this.transform);
                if (tile_type == 4) Instantiate(tile_home_one, t.Position(), Quaternion.identity, this.transform);
                if (tile_type == 5) Instantiate(tile_home_two, t.Position(), Quaternion.identity, this.transform);
                if (tile_type == 6) Instantiate(tile_office_one, t.Position(), Quaternion.identity, this.transform);
                if (tile_type == 7) Instantiate(tile_office_two, t.Position(), Quaternion.identity, this.transform);
            }
        }
    }

    void Start()
    {
        Arrange();
    }

}















CASE STUDIES

Examples:
ZigZag
Aapora 2.5D
Armankara (perfect)
FakeSimCity (perfect)
CityBuilder starter kit
OpenWorldBuilder (good)
Dungeon architect (advanced)
CityBuildingKit for unity ($)

Armankara Case Study






































GRAPHICS

Interface
Sets
People
Buildings
Automobiles


2D sprite lighting: 

https://www.youtube.com/watch?v=IjP2MeSozIs

Use shadows, like occlusion:

https://www.youtube.com/watch?v=mCCC9hQm6MM

The first step in making things look more real with shadows

Ambient Occlusion - using standard Unity light map generation

Gradient Overlay

Sometimes linear, sometimes circular, depends, brings the image to life


Apply vignette around the edges, to look  more like printed artwork, subtle effect

Didn’t want to use directional lights.

Instead use mesh renderer with prebuilt lights.

Mesh renderer settings:





https://www.youtube.com/watch?v=mCCC9hQm6MM

Those colors are the light colors from different direction. Having just one material makes things easy. This is critical to getting the final look of the game, allowed artists to play with colors.

The thing with making your level out of a lot of small pieces, you end up with a lot of game object in the hierarchy. So you have to optimize for that. Export objects before they go into the final build, to take the whole massive list and condense to a combined mesh.

So how do we get the look?
2 main images
Textures
Shadows (lighting applied to textures)
Combine the two
That’s the basic look, but somehow feels dead, what we want is for this to feel like a 3d world, an 
First step to making things look more real
Apply Ambient Occlusion, this is just using standard unity light map generation tools
We cheat by grouping up the different areas, baking them in groups away from each other
Things that move don’t end up affecting
Getting that to work is tricky, because sometimes you have to turn off light maps for certain parts of the level
3 point lighting, from each of the angles
If you add up the light sources with a dot product, that’s equivalent to having standard directional lights, that’s not what this scene is, this scene is lit up a sky dome effectively, and that should be a smooth interpolation of that color, and that’s not the same thing as having five different colored spotlights, because then you get weird overlaps of color, so every shader in the game is a custom one that we wrote, and so for rotation we have something that takes care of the weird interpolation, that gets the smooth color change, rather than getting the peak in color as the two lights overlap. 
Second thing, is a trick
Apply semi transparent quad over the whole thing, with some weird blending material
This is known as Gradient Overlay
Can use multiple, radial, depends
Brings the photo to life
Finally we apply vignette around the edges
That is rr things feel more real, like a printed artwork
You can use fancy shaders, but we are just using a texture with darker color on the sides, and apply that over the screen, with some interesting blend modes / shaders.
https://www.youtube.com/watch?v=aF3Idj_PeYY
https://www.youtube.com/watch?v=u5RTVMBWabg
Long story short you can create normal maps from sprites using Illustrator or Photoshop pretty easily by layering your sprites as you develop them.  You then apply those normal maps onto your sprites normal map layer. In order to do this you’ll need to make sure you have a custom sprite shader that takes in both a sprite and a normal map.
http://blackseaodyssey.com/2015/07/29/using-normal-maps-to-create-lighting-for-2d-sprites/
http://wiki.polycount.com/wiki/Normal_map
Pretty cool random fantasy map tutorial
https://design.tutsplus.com/tutorials/create-a-fantasy-map-illustration--psd-5821
Sorry I suppose I should have elaborated. I thought the idea of creating a normal map from a sprite would be self explanatory, there isn't an automatic method that does a high quality job as far as I'm aware so you have to do it all by hand. I'll elaborate below.
What we do is create layers for every direction we imagine our objects to be facing. So imagine we have a layer for top, bottom, left, and right. We then use a normal map color pallet to automatically assign normal map colors to those layers. Then when we import the sprite with normal map colors we convert that sprite into a normal map. Here is an example of a normal map color pallet. here
While it's true that yes normal maps are intended to help objects look more three dimensional, I didn't think they we're intended(I could be mistaken) to be as powerful as they are in a 2D environment for Unity. Hence my surprise.
Yeah, I set the lighting level to max so it might look a bit distorted. I promise it looks pretty good though in the game in real time. I'll share a video later.
When it comes to highly detailed organic sprites you could apply the same logic we're using to create normal maps but instead of layering your sprites based on it's geometry and filling it in with normal map colors you could use a paint brush style method and color your normal map in directly, however it would be difficult and time consuming. The layering method works best on sprites like the one we use in the example. Sprites that are non-organic.
 
[–]-TwiiK- 1 point 2 years ago 
I see. I'm not really any wiser as to how you approach this in Photoshop/Illustrator. Seems like something that would be time consuming to do for more organic sprites like characters etc.?
I see Sprite Lamp and similar tools as something you use to automate or speed up the manual process you're describing here.
As for Unity and normal maps there's no difference between using them in a 2D environment or a 3D one. You could even add height maps, parallax mapping, relief mapping or displacement maps to your sprites as well just like you would in 3D to get an even "deeper" sense of 3D for your sprites. You could even have self-shadowing on your sprites.
 
Sprite lamp and other tools are definitely powerful and can ease the process. (We were using sprite lamp originally) but we found that they lacked the same precision and quality when compared to using hand painted normal maps. We found it was easier to do the editing we needed inside of Photoshop and Illustrator as oppose to other automated toolkits. It's seemingly difficult for an automated toolkit to be very accurate right of the box, especially when color is the tool-kits only indicator of where to apply normal maps. This may be in part because the shapes we needed normal mapped we're in fact not organic and relied more on perfect symmetry.
Yeah we actually want to add self shadowing on our sprites but haven't got to that yet. Any idea how to implement this? Or a link for where I could do some research on it? I've dug a bit into it myself and it doesn't seem like a simple task.
Bump mapping
https://answers.unity.com/questions/20086/bumpmap-colors.html
3D bumpmap tutorial ;https://www.youtube.com/watch?v=_3CG-lzy0RA
Simple tutorial to get started with light maps:
https://www.youtube.com/watch?v=gF2bQd9nn6U
Create three things:
Height map
Normal map
Occlusion map


THE CAMERA


Moving the Camera Around in an RTS
https://forum.unity.com/threads/moving-main-camera-with-mouse.119525/







INTERFACE


Title font

https://graphicriver.net/item/cube-font/17617824?s_rank=104



SETS

Prototype

https://opengameart.org/content/isometric-city-0


https://www.freepik.com/index.php?goto=2&k=isometric%20city&order=2&searchform=1&vars=2


https://graphicriver.net/item/set-of-isometric-building-in-spring/6869749?ref=cisyveify&clickthrough_id=1234496431&redirect_back=true


https://www.shutterstock.com/image-vector/megapolis-3d-isometric-threedimensional-view-city-478790959?src=LsgyeLBmji1u6V7-k_G0Hw-1-1

SMALL GENERIC

https://www.freepik.com/free-vector/mapmaker-for-cities-in-isometric-view_911187.htm#term=isometric%20city&page=3&position=1




BUILDINGS


Houses 1

https://www.freepik.com/free-vector/modern-house-collection-in-isometric-style_1924661.htm#term=isometric%20city&page=2&position=11

Houses 2 

https://www.freepik.com/free-vector/house-collection-of-four-in-isometric-style_1924657.htm#term=isometric%20city&page=2&position=14

Houses 3

https://www.freepik.com/free-vector/set-of-vector-isometric-residential-houses-cottages_1215903.htm#term=isometric%20city&page=2&position=14

Houses 4

https://www.freepik.com/free-vector/house-collection-in-isometric-style_1924658.htm#term=isometric%20city&page=2&position=31

FOUR GENERIC HOUSES

https://www.freepik.com/free-vector/set-of-isometric-block-houses_1164068.htm#term=isometric%20city&page=3&position=41



PEOPLE


Mini People

https://www.freepik.com/free-vector/people-standing-together-in-shape-of-an-arrow_1311194.htm#term=people%20icon&page=1&position=8


Alert Arrow, Bubble, and Nature

https://www.freepik.com/premium-vector/city-map-top-view_1225867.htm#term=isometric%20city&page=2&position=42

Nature

https://www.freepik.com/premium-vector/isometric-buildings-collection_1226629.htm#term=isometric%20city&page=2&position=39


AUTOMOBILES

https://www.shutterstock.com/image-vector/transport-isometric-set-bus-car-bicycle-512597281?irgwc=1&utm_medium=Affiliate&utm_campaign=Graphic%20resources%20SL&utm_source=39422&utm_term=1500771463.1523663802


Lots of Automobiles

https://www.shutterstock.com/image-vector/transport-isometric-set-bus-car-bicycle-512597281?irgwc=1&utm_medium=Affiliate&utm_campaign=Graphic%20resources%20SL&utm_source=39422&utm_term=1500771463.1523663802






















MENU

At the start of the game for the first time the player is greeted with these choices:

New pet


New Pet Option

Create your new pocket pet! 

Give your pet a name:

____________

Set the personality of your pet. (Like an RPG but with a simple and beautiful interface)

A total of 10 points can be used on these player stats:

Mana
Strength




GRAPHICS

Graphics consist of vectors taken from this collection:




The pets blink, wave their arms and wiggle their bodies to give the illusion of animation. 









GAME MECHANICS


The game starts with choosing and naming your character. The player then assigns a total of 10 RPG points for the following categories:

Education
Entrepreneurial


HEROES

Heroes is where the in app purchases take place
This way a user has very wide spending options
10 Heroes standard (or five) + 100 to purchase
That feeling of being a kid and collecting action figures
You don’t directly buy them, but purchase them with “in game credits”


TYPES OF GAME MECHANICS

Building
Heroes
Upgrading
Power ups
Items
Road terrain
Strategical city layout
Social
Selling / buying items from players
Turf warfare
Co-op bonus
Opportunities for aggression




















ADVICE ON GAME MECHANICS


OVERVIEW

Predictable games are not fun
Skills should contribute to victory
Expert gamers will deduce the core mechanics
Core mechanics are mostly hidden


INTERNAL ECONOMY

Mechanics of transactions
Collected, consumed, traded
Not limited to tokens
Life energy
Popularity
Etc

TYPES OF GAME MECHANICS IN CITYOPOLY

Managing internal economy
Proximity bonus
Have to build next to road
How to strategically arrange city?
Keeping the population happy
Heroes have range they can move
This is the speed in their RPG settings
Upgrades
Unit / hero upgrades
Building upgrades
Upgraded cities produce money, that can be used to research new technology to convert into luxuries to make the population happy
The choices the player makes will determine how fast your city will grow, and how sophisticated your technology is (to deal with further problems in novel ways)
Some structures / heroes cost a few tokens per turn but will keep your population happy, and provide other long term benefits, like maintaining a park / wilderness area (that way the game will use emergent behavior to keep lots of green around
Prototype tuning for fun factor by seeing how a player who has lots of conservation land fairs, across someone who has a lot of buildings and councrouchers on their territory
Heroes
Some heroes have special abilities
Certain heroes can be used to build certain units, plus add bonus points when they reside in certain units
Also certain heroes can be used to mess with the enemy at a distance
Units are produced / maintained by structure -> consuming vital resources that could have been used towards other means
A hero can leave the city if unhappy
Hire them back with an opportunity
Have to pay regular tokens for heroes upkeep
Building roads negates movement points
This is how new fog of war / darkness territory is revealed
Building roads requires investment of time and resources but allows to deploy the forces more efficiently (which reduces some needs)
Researching new technology upgrades, units + buildings
Producing tokens
Social interaction
Gifting
Inviting new friends to join
Participating in social interactions
Strategy rules forming or breaking alliances
Can attack or befriend (co-op bonus)






DERIVING GAMEPLAY

Economy
Tactics (maneuvering)
Strategy (long term)
Social dynamics


GAMEPLAY MECHANISMS

Action
Physics
Movement (traffic jam mini game)
Economy
Power ups
Collectibles
Lives
Progression
Increasing difficulty
Strategy
Unit building
Resource harvesting
Unit upgrading
Risking units in combat
You can “risk” heroes, if the building they reside in falls below threshold you lose that hero, have to spend tokens to regenerate them + time, (cool down period)
New sets of challenges
Positioning of units to gain offensive or defensive strategies
Coordinated actions, alliances and competition between players

Adventure

Managing player’s inventory (RPG)
What sort of adventure-esque items are out there?
Story to drive game
Locks + key to control progress

Puzzle

Short levels
Mini games
Directing a traffic jam in the city, the puzzle is controlling the lights

Social

Resources spent on personalized content (heroes) like League of Legends and Injustice
Side Quests
”Clean up the city” to give player a purpose and goal, quests and challenges, overlaps with puzzles
Players exchange in game resources, mechanics, encourage cooperation and conflict


DESIGN OPPORTUNITIES FOR INNOVATION

Skill + dexterity become an important aspect of the interaction
Identifying weak spots + formulating a plan
Simulate city phenomena
Show player connects are made at certain points
Allow novel and fresh ways of game elements to be combined (blocking in another player with a certain type of resource building unit











GAMEPLAY DESIGN

Gameplay - The challenge the game imposes on the player

The mechanics generate gameplay
Design the mechanics with gameplay in mind!
3 stages of gameplay design
Concept stage
General idea
Target audience
Player’s role
document
Elaboration stage
Tuning stage
Focus on the magic, make the thing shine
Tuning can take as long as concept design
Gameplay design document starts with:
Concept description
Target audience
Core mechanics
Style (seikakan)
A good design document doesn’t waste energy















CREATING GAME MECHANICS

Make the toy first!
Goal: get the core mechanics working and balance them
To get the mechanics right you must build them
Complex systems require a delicate balance
Hard to tell in advance if fun in gameplay emerges from mechanics
Also can find out from people play testing the game
Prototyping
Build prototypes, and iterate as much as you can to create games with balanced novel mechanics
A high fidelity prototype can be time consuming
Consider speed of paper prototyping!
When starting prototype choose one thing to focus on
Ex. balanced economy power ups

PROTOTYPING GAME ECONOMY TIPS

Is the game balanced?
Is there a dominant strategy that wins the whole time?
Do the players have interesting choices?
Can they sufficiently foresee the consequences of their choices
Ask power gamers to break the game


PROTOTYPING THE INTERFACE

Can they perform actions correctly?
Are there other actions they want / need?
Are you giving them the correct confirmation to make proper decisions?
Is the control scheme intuitive?
Do they notice when they take dadmange, or when a vital game state changes?
Notifications on when important game states have changed


STRATEGY GAME EMERGENCE BEHAVIOR TRADE OFFS

Acquiring lots of heros early will allow you to capture a lot of the map but will take a toll on other developments, which might set you back in the long term
Players have to often switch between strategies as the game progresses
Early on important to expand territory so city can grow
Develop technology to identify and capture vital resources during this stage


GAMEPLAY STAGES

Stages of gameplay
Early expansion
Investing in your economy
Violent conflict
Or:
Expansion
Consolidation
Turf war
Competing by both building / stores / offices in shared fought after territorial space (where zones will make a difference)


“If you are clever you keep all the elements as simple as possible.”


FEEDBACK LOOPS

Feedback loops occur at different scales and speeds
Test these game mechanics with a prototype


THE MISSION

Graph the mission like the Zelda diagram, novel ways of accomplishing the same task
“In the past lack of solid theory of what game mechanics are and how are they structured”


EMERGENCE

Games of emergence tend to be shorter than games of progression
Bigger learning curve
Games of emergence are characterized with a wide possibility space
Have high replay value
Somewhat paradoxical because emerges afterward
Different ways of overcoming challenges
Players can act in a wide range of expressive ways
More games should be designed around freedom and creativity what expressive systems allow
High replay value
Challenges and actions are different
Unique session between players and game
The relationship between complexity of rules and gameplay is not linear
Designing emergence is a Zen activity, since we don’t know exactly the details we are going for


CELLULAR AUTOMATA

Offspring generations of progressive states
Simple cells rules are defined locally
Systems must allow for long term communication (affecting neighbors)
Cellular automata teaches us that the threshold for complexity is quite low


ECOSYSTEM AS A SYSTEM WITH A FEEDBACK LOOP

Predator vs prey
City development vs nature forest
As cities grow they demand more food and resources
Causes growing at stable size that is supported by terrain and technology


NEGATIVE FEEDBACK LOOPS


Can use negative feedback loops as a way to govern machines (prevent unexpected and unwanted chaos)
Example: limit how many resources a building unit can produce
Negative feedback can work towards a balance in a complex chaotic system


MULTIPLE EMERGENCE

Feedback transverses the different levels of organization
Ex. markets


SUMMARY: QUALITIES OF COMPLEX SYSTEMS

What contributes to emergence?
Active + interconnected parts
Feedback loops
Interactions at different scales




INTERNAL ECONOMY 


An economy is a system in which:
Goods / resources / produced / consumed and exchanged in quantifiable amounts
In games:
Health 
Skill
Experience
Money
Goods
Services
Players can create their own fair market price to sell goods / services to other players
Collecting vital resources to conquer zones!
To understand a game’s gameplay it is essential to understand its economy
This is the core of the game designers trade:
You craft mechanics to create a game system that is fun and challenging to interact with

RESOURCES

All economies revolve around the flow of resources
Types
Money
Energy
Time
Units under player’s control
Items
Power ups
Enemies that oppose the player
Not all resources are under a player’s control (time)
Tangible resources
Buildings
Intangible resources
Skill points
An abstract thing a technology produces (like science research)
Any type of points
Sometimes useful to identify as whether abstract or concrete
Strategic advantage -> abstract resource


START BY IDENTIFYING THE RESOURCES

Pg 61




Random idea:
You can build seperated city bases, a new city, and eventually as inhabiting requirements are met, relocating your heroes there
Missions
Defeating enemy base
Surviving under harsh conditions and harvesting resources in the meantime
Protecting your civilian residence
Happy level
Protecting routes
How?
Players can choose the order of their missions









































CODE STRUCTURE


CORONA COMPOSER SCENES

Composer

https://docs.coronalabs.com/api/library/composer/index.html

https://docs.coronalabs.com/guide/system/composer/index.html







Development Stages

Each development state requires a different sort of strategy to reach an optimal score index. Each state of development requires consistent strategy to achieve the full game score.




GAME MECHANICS


Multiplayer Backend

https://www.gamesparks.com/product/

Corona + GameSparks

https://coronalabs.com/blog/2017/03/08/welcome-gamesparks-to-the-corona-plugin-suite/




ADVERTISING


Mobile Advertising

http://www.mobyaffiliates.com/guides/mobile-advertising-companies/
































In App Purchases


How do you make the game fair, and yet raise the ceiling on revenue through in app purchases? Follow the model from the game Injustice, and partly also League of Legends: hero upgrades


HERO UPGRADES

Hero upgrades are a way to perform in app purchases on additional content of hero characters. This presents the players a way to have figure collectibles. 

And at the same time, the game play is equal in every sense. So paying your way up in the game you don’t increase any sort of unfair advantages over non-paying users.









Tips for Making a Game in 48 Hours
Never Fall in Love. The second theorem of destruction says “as love and effort increase, the probability of self-destruction approaches 1”. Maintain a healthy distance to your game and do not be afraid to fail spectacularly.
Harmony. Visuals, music, movement. Think economically: Less time means less assets means focus on harmony of what you have.
Shh… Audio is half the game experience.
Make The Toy First. Try out your game mechanic first. Once you are convinced that this is fun to play, you can flesh out the game.
Feel Something. Art games create feelings in the player, they have subtext and theme. If you lack the craftsmanship, at least give your game an artistic name.
Create a Low Barrier of Entry. A game must be fun within the first 15 seconds. If you are one of the cool kids, you include title and instruction screens in the game (as for example Braid).
Adjust Expectations. Introduce only ONE new concept to the world of gaming as fast and as clear as you possibly can.




























LOG


4/19/2018 9:07 PM

I’m feeling pretty good about the progress made recently even though at first finding myself struggling with the seemingly insurmountable challenges.

I finally succeeded (struggling with this problem for two days felt like eternity), in laying out the tiles in the game. I can now take a 2D map, and graph the game world on the screen.

I am now a dungeon master adept. I can now lay out the dungeon tiles for the players. This was no easy feat, and I’m sure a classic struggle for all dungeon master’s have had to overcome in order to figure out the mechanics of dungeon tile laying.

Recently I saw a curious documentary on mathematics and the state of reality. The documentary said that mathematics is the very nature of reality. Likewise in struggling with trying to figure out how to simulate a game reality, I was losing sight of the forest for the trees.

With mathematics I can have faith I can eventually model a game universe, even though the programming might not be apparent at first. I can relax when knowing that like dungeon master from the cartoon show said when his adepts tried chasing after him for answers, “The way is with you.”

I am also exceedingly satisfied on progress being made the Game Design Document. The Game Design Document is a pretty powerful tool. Studying the PoP design document really got me going with own design document. 

There has been lots of things I have been able to diagram on paper, and then in the game design document, that feel like they will contribute greatly to the game in the end, significantly because of the expansive form of the game design document.


Even now I am writing a log in the game design document. There is a lot to be said for writing, proper grammar, proper structure and organization, that can reach out into the ether and make things come together.

A curious article on the unexpected benefits of being a dungeon master:

http://meta-punk.com/2017/09/10/being-a-dungeon-master-helps-in-being-a-teacher/


Dungeon Master Tips:


Try to make critical failures as fun, or more fun than critical successes
Build out the NPCs to enrichen the world for players (random characters living in the city)
Prioritize the game experience over the rules
Steal Everything, Never Apologise
https://kotaku.com/how-to-be-a-great-dungeon-master-1766262559
Don’t worry, keep playing
You can recover from lost momentum in a game, but in my experience, once everyone’s out of the right headspace, difficult to pull them back. That’s just the way our brains work.
Hit ‘em where it hurts
http://johnwickpresents.com/updates/livejournal/hit-em-where-it-hurts/
Look for a hero’s greatest weakness, and exploit that weakness.
For those of you who don’t recognize DNPC, it stands for “Dependent Non-Player Character”. I understand it’s a fairly common Disadvantage among players, but after this little stunt, I had a severe shortage of DNPCs in my campaign.
http://johnwickpresents.com/market/products/playdirty.html




The Dungeon Master















Dungeon Master Tips


https://kotaku.com/how-to-be-a-great-dungeon-master-1766262559
Never control your player’s character.
Telling your players what their characters see around them is the bulk of what a DM does, but don’t forget to explain what their other senses are picking up as well.
Keep your descriptions detailed, but short. D&D is a shared fantasy between the players and you, which means that the closer everyone is to imagining the same game, the more accurate and more fun the game is
During the game, keep careful track of the XP that each character earns 
Start with published, working game mechanics
Basically, Pathfinder (role playing) puts very few limitations on player characters as long as they stay within the rules
No matter what system you choose, you’ll have a good time.
If your past gaming experience includes hardcore, complicated board games, tactical grid-based video games, and wargames like Warhammer, you value strategy over character development or story, or tend to thrive in math-heavy rule systems: go with Pathfinder.
“Tactical grid based games”
Focus on NPCs to give the feeling of an expansive world





Log Continued























APPENDIX


Hexagonal Grids
from Red Blob Games
Home
Blog
Links
Twitter
About
 
 
Mar 2013, updated in Mar 2015, Mar 2018

Hexagonal grids are used in some games but aren’t quite as straightforward or common as square grids. I’ve been collecting hex grid resources for over 20 years, and wrote this guide to the most elegant approaches that lead to the simplest code, largely based on the guides by Charles Fu and Clark Verbrugge. I’ll describe the various ways to make hex grids, the relationships between them, as well as some common algorithms. Most parts of this page are interactive.
Angles, size, spacing
Coordinate systems
Conversions
Neighbors
Distances
Line drawing
Range
Rotation
Rings
Field of view
Hex to pixel
Pixel to hex
Rounding
Map storage
Wraparound maps
Pathfinding
More reading
The code samples on this page are written in pseudo-code; they’re meant to be easy to read and understand. The implementation guide has code in C++, Javascript, C#, Python, Java, Typescript, and more.

#Geometry
centercornersideflatpointy
Hexagons are 6-sided polygons. Regular hexagons have all the sides the same length. I’ll assume all the hexagons we’re working with here are regular. The typical orientations for hex grids are vertical columns (flat topped) and horizontal rows (pointy topped).
Hexagons have 6 sides and 6 corners. Each side is shared by 2 hexagons. Each corner is shared by 3 hexagons. For more about centers, sides, and corners, see my article on grid parts (squares, hexagons, and triangles).
Angles#
In a regular hexagon the interior angles are 120°. There are six “wedges”, each an equilateral triangle with 60° angles inside. Each corner is size units away from the center. In code:
function pointy_hex_corner(center, size, i):
    var angle_deg = 60 * i - 30°
    var angle_rad = PI / 180 * angle_deg
    return Point(center.x + size * cos(angle_rad),
                 center.y + size * sin(angle_rad))
0°30°60°90°120°150°180°210°240°270°300°330°60°60°60°120°flatpointy
To fill a hexagon, gather the polygon vertices at hex_corner(…, 0) through hex_corner(…, 5). To draw a hexagon outline, use those vertices, and then draw a line back to hex_corner(…, 0).
The difference between the two orientations is a rotation, and that causes the angles to change: flat topped angles are 0°, 60°, 120°, 180°, 240°, 300° and pointy topped angles are 30°, 90°, 150°, 210°, 270°, 330°. Note that the diagrams on this page use the y axis pointing down (angles increase clockwise); you may have to make some adjustments if your y axis points up (angles increase counterclockwise).
Size and Spacing#
Next we want to put several hexagons together. In the pointy orientation, a hexagon has width w = sqrt(3) * size and height h = 2 * size.
0w¼w½w¾w1w1¼w1½w1¾w2w2¼w2½w0h¼h½h¾h1h1¼h1½h1¾h2hflatpointy
The horizontal distance between adjacent hexagon centers is w. The vertical distance between adjacent hexagon centers is h * 3/4.
Some games use pixel art for hexagons that does not match an exactly regular polygon. The angles and spacing formulas I describe in this section won’t match the sizes of your hexagons. The rest of the article, describing algorithms on hex grids, will work even if your hexagons are stretched or shrunk a bit.
#Coordinate Systems
Now let’s assemble hexagons into a grid. With square grids, there’s one obvious way to do it. With hexagons, there are multiple approaches. I recommend using cube coordinates as the primary representation. Use either axial or offset coordinates for map storage, and displaying coordinates to the user.
Offset coordinates#
The most common approach is to offset every other column or row. Columns are named col (q). Rows are named row (r). You can either offset the odd or the even column/rows, so the horizontal and vertical hexagons each have two variants.
0, 00, 10, 20, 30, 40, 50, 61, 01, 11, 21, 31, 41, 51, 62, 02, 12, 22, 32, 42, 52, 63, 03, 13, 23, 33, 43, 53, 64, 04, 14, 24, 34, 44, 54, 65, 05, 15, 25, 35, 45, 55, 66, 06, 16, 26, 36, 46, 56, 6“odd-r” horizontal layout
shoves odd rows right0, 00, 10, 20, 30, 40, 50, 61, 01, 11, 21, 31, 41, 51, 62, 02, 12, 22, 32, 42, 52, 63, 03, 13, 23, 33, 43, 53, 64, 04, 14, 24, 34, 44, 54, 65, 05, 15, 25, 35, 45, 55, 66, 06, 16, 26, 36, 46, 56, 6“even-r” horizontal layout
shoves even rows right0, 00, 10, 20, 30, 40, 51, 01, 11, 21, 31, 41, 52, 02, 12, 22, 32, 42, 53, 03, 13, 23, 33, 43, 54, 04, 14, 24, 34, 44, 55, 05, 15, 25, 35, 45, 56, 06, 16, 26, 36, 46, 57, 07, 17, 27, 37, 47, 5“odd-q” vertical layout
shoves odd columns down0, 00, 10, 20, 30, 40, 51, 01, 11, 21, 31, 41, 52, 02, 12, 22, 32, 42, 53, 03, 13, 23, 33, 43, 54, 04, 14, 24, 34, 44, 55, 05, 15, 25, 35, 45, 56, 06, 16, 26, 36, 46, 57, 07, 17, 27, 37, 47, 5“even-q” vertical layout
shoves even columns down
Cube coordinates#
Another way to look at hexagonal grids is to see that there are three primary axes, unlike the two we have for square grids. There’s an elegant symmetry with these.
Let’s take a cube grid and slice out a diagonal plane at x + y + z = 0. This is a weird idea but it helps us make hex grid algorithms simpler. In particular, we can reuse standard operations from cartesian coordinates: adding coordinates, subtracting coordinates, multiplying or dividing by a scalar, and distances.
Notice the three six hex grid directions are halfway between two of the cube axes. We’ll see this in the neighbors section, where moving along one of the six hex grid directions involves changing two of the coordinates.
Because we already have algorithms for square and cube grids, using cube coordinates allows us to adapt those algorithms to hex grids. I will be using this system for most of the algorithms on the page. To use the algorithms with another coordinate system, I’ll convert to cube coordinates, run the algorithm, and convert back.
+z-x+y-z+x-y
Switch to hexagons
Study how the cube coordinates work on the hex grid. Selecting the hexes will highlight the cube coordinates corresponding to the three axes.
-30+3-3+1+2-3+2+1-3+30-2-1+3-20+2-2+1+1-2+20-2+3-1-1-2+3-1-1+2-10+1-1+10-1+2-1-1+3-20-3+30-2+20-1+1xzy0+1-10+2-20+3-3+1-3+2+1-2+1+1-10+10-1+1+1-2+1+2-3+2-3+1+2-20+2-1-1+20-2+2+1-3+3-30+3-2-1+3-1-2+30-3flatpointy
Each direction on the cube grid corresponds to a line on the hex grid. Try highlighting a hex with z at 0, 1, 2, 3 to see how these are related. The row is marked in blue. Try the same for x (green) and y (purple).
Each direction on the hex grid is a combination of two directions on the cube grid. For example, northwest on the hex grid lies between the +y and -z, so every step northwest involves adding 1 to y and subtracting 1 from z.
The cube coordinates are a reasonable choice for a hex grid coordinate system. The constraint is that x + y + z = 0 so the algorithms must preserve that. The constraint also ensures that there’s a canonical coordinate for each hex.
There are many different valid cube hex coordinate systems. Some of them have constraints other than x + y + z = 0. I’ve shown only one of the many systems. You can also construct cube coordinates with x-y, y-z, z-x, and that has its own set of interesting properties, which I don’t explore here.
“But Amit!” you say, “I don’t want to store 3 numbers for coordinates. I don’t know how to store a map that way.”
Axial coordinates#
The axial coordinate system, sometimes called “trapezoidal”, is built by taking two of the three coordinates from a cube coordinate system. Since we have a constraint x + y + z = 0, there’s some redundancy, and we don’t need to store all three coordinates. This diagram is the same as the previous one, except I don’t show y:
-30-3+1-3+2-3+3-2-1-20-2+1-2+2-2+3-1-2-1-1-10-1+1-1+2-1+30-30-20-1qr0+10+20+3+1-3+1-2+1-1+10+1+1+1+2+2-3+2-2+2-1+20+2+1+3-3+3-2+3-1+30flatpointy
There are many choices of cube coordinate system, and many choices of axial coordinate system. I’m not going to show all of the combinations in this guide. I’ve chosen q for “column” = x and r as “row” = z. This choice is arbitary, as you can rotate and flip the diagrams to make many different assignments of ±x,±y,±z to q,r.
The advantage of this system over offset grids is that the algorithms are cleaner when you can use add, subtract, multiply, and divide on hex coordinates. The disadvantage of this system is that storing a rectangular map is a little weird; see the map storage section for ways to handle that. In my projects, I name the axes q, r, s so that I have the constraint q + r + s = 0, and then I can calculate s = -q - r when I need the third coordinate for algorithms that work better with cube coordinates.
Axes#
Offset coordinates are the first thing people think of, because they match the standard cartesian coordinates used with square grids. Unfortunately one of the two axes has to go “against the grain”, and ends up complicating things. The cube and axial systems go “with the grain” and have simpler algorithms, but slightly more complicated map storage. There’s also another system, called interlaced or doubled, that I haven’t explored here; some people say it’s easier to work with than cube/axial.
OffsetCubeAxial
The axis is the direction in which that coordinate increases. Perpendicular to the axis is a line where that coordinate stays constant. The grid diagrams above show the perpendicular line.
#Coordinate conversion
It is likely that you will use axial or offset coordinates in your project, but many algorithms are simpler to express in cube coordinates. Therefore you need to be able to convert back and forth.
Axial coordinates#
Axial coordinates are closely connected to cube coordinates. Axial discards the third coordinate and cube calculates the third coordinate from the other two:
function cube_to_axial(cube):
    var q = cube.x
    var r = cube.z
    return Hex(q, r)

function axial_to_cube(hex):
    var x = hex.q
    var z = hex.r
    var y = -x-z
    return Cube(x, y, z)
Offset coordinates#
Determine which type of offset system you use; *-r are pointy top; *-q are flat top:
 odd-r  shoves odd rows by +½ column
 even-r  shoves even rows by +½ column
 odd-q  shoves odd columns by +½ row
 even-q  shoves even columns by +½ row
function cube_to_oddr(cube):
    var col = cube.x + (cube.z - (cube.z&1)) / 2
    var row = cube.z
    return OffsetCoord(col, row)

function oddr_to_cube(hex):
    var x = hex.col - (hex.row - (hex.row&1)) / 2
    var z = hex.row
    var y = -x-z
    return Cube(x, y, z)
Implementation note: I use a&1 (bitwise and) instead of a%2 (modulo) to detect whether something is even (0) or odd (1), because it works with negative numbers too. See a longer explanation on my implementation notes page.
#Neighbors
Given a hex, which 6 hexes are neighboring it? As you might expect, the answer is simplest with cube coordinates, still pretty simple with axial coordinates, and slightly trickier with offset coordinates. We might also want to calculate the 6 “diagonal” hexes.
Cube coordinates#
Moving one space in hex coordinates involves changing one of the 3 cube coordinates by +1 and changing another one by -1 (the sum must remain 0). There are 3 possible coordinates to change by +1, and 2 remaining that could be changed by -1. This results in 6 possible changes. Each corresponds to one of the hexagonal directions. The simplest and fastest approach is to precompute the permutations and put them into a table of Cube(dx, dy, dz)at compile time:
var cube_directions = [
    Cube(+1, -1, 0), Cube(+1, 0, -1), Cube(0, +1, -1),
    Cube(-1, +1, 0), Cube(-1, 0, +1), Cube(0, -1, +1), 
]

function cube_direction(direction):
    return cube_directions[direction]

function cube_neighbor(cube, direction):
    return cube_add(cube, cube_direction(direction))
-10+1-1+100-1+1xzy0+1-1+1-10+10-1flatpointy
Axial coordinates#
As before, we'll use the cube system as a starting point. Take the table of Cube(dx, dy, dz) and convert into a table of Hex(dq, dr):
var axial_directions = [
    Hex(+1, 0), Hex(+1, -1), Hex(0, -1),
    Hex(-1, 0), Hex(-1, +1), Hex(0, +1), 
]

function hex_direction(direction):
    return axial_directions[direction]

function hex_neighbor(hex, direction):
    var dir = hex_direction(direction)
    return Hex(hex.q + dir.q, hex.r + dir.r)
-1, 0-1, 10, -1q, r0, 11, -11, 0flatpointy
Offset coordinates#
With offset coordinates, the change depends on where in the grid we are. If we’re on an offset column/row then the rule is different than if we’re on a non-offset column/row.
As above, we’ll build a table of the numbers we need to add to col and row. However offset coordinates can’t be safely added and subtracted. Instead, the results are different for odd and even columns/rows, so we will need two separate lists of neighbors. Look at (1,1) on the grid map above and see how col and row change as you move in each of the six directions. Then do this again for (2,2). The tables and code are different for each of the four offset grid types, so pick a grid type to see the corresponding code.
var oddr_directions = [
    [[+1,  0], [ 0, -1], [-1, -1],
     [-1,  0], [-1, +1], [ 0, +1]],
    [[+1,  0], [+1, -1], [ 0, -1],
     [-1,  0], [ 0, +1], [+1, +1]],
]

function oddr_offset_neighbor(hex, direction):
    var parity = hex.row & 1
    var dir = oddr_directions[parity][direction]
    return OffsetCoord(hex.col + dir[0], hex.row + dir[1])
Pick a grid type:  odd-r  even-r  odd-q  even-q 
-1, 0-1, +1-1, -1EVEN row0, +10, -1+1, 0-1, 00, +10, -1ODD row+1, +1+1, -1+1, 0
Using the above lookup tables is the easiest way to to calculate neighbors. It’s also possible to derive these numbers, for those of you who are curious.
Diagonals#
Moving to a “diagonal” space in hex coordinates changes one of the 3 cube coordinates by ±2 and the other two by ∓1 (the sum must remain 0).
var cube_diagonals = [
    Cube(+2, -1, -1), Cube(+1, +1, -2), Cube(-1, +2, -1),
    Cube(-2, +1, +1), Cube(-1, -1, +2), Cube(+1, -2, +1), 
]

function cube_diagonal_neighbor(cube, direction):
    return cube_add(cube, cube_diagonals[direction])
As before, you can convert these into axial by dropping one of the three coordinates, or convert to offset by precalculating the results.
-10+1-1+100-1+1xzy0+1-1+1-10+10-1+2-1-1+1-2+1-1-1+2-2+1+1-1+2-1+1+1-2flatpointy
#Distances
Cube coordinates#
In the cube coordinate system, each hexagon is a cube in 3d space. Adjacent hexagons are distance 1 apart in the hex grid but distance 2 apart in the cube grid. This makes distances simple. In a square grid, Manhattan distances are abs(dx) + abs(dy). In a cube grid, Manhattan distances are abs(dx) + abs(dy) + abs(dz). The distance on a hex grid is half that:
function cube_distance(a, b):
    return (abs(a.x - b.x) + abs(a.y - b.y) + abs(a.z - b.z)) / 2
An equivalent way to write this is by noting that one of the three coordinates must be the sum of the other two, then picking that one as the distance. You may prefer the “divide by two” form above, or the “max” form here, but they give the same result:
function cube_distance(a, b):
    return max(abs(a.x - b.x), abs(a.y - b.y), abs(a.z - b.z))
In the diagram, the max is highlighted. Also notice that each color indicates one of the 6 “diagonal” directions.
-40+4-4+1+3-4+2+2-4+3+1-4+40-3-1+4-30+3-3+1+2-3+2+1-3+30-3+4-1-2-2+4-2-1+3-20+2-2+1+1-2+20-2+3-1-2+4-2-1-3+4-1-2+3-1-1+2-10+1-1+10-1+2-1-1+3-2-1+4-30-4+40-3+30-2+20-1+1xzy0+1-10+2-20+3-30+4-4+1-4+3+1-3+2+1-2+1+1-10+10-1+1+1-2+1+2-3+1+3-4+2-4+2+2-3+1+2-20+2-1-1+20-2+2+1-3+2+2-4+3-4+1+3-30+3-2-1+3-1-2+30-3+3+1-4+4-40+4-3-1+4-2-2+4-1-3+40-4flatpointy
Axial coordinates#
In the axial system, the third coordinate is implicit. Let’s convert axial to cube to calculate distance:
function hex_distance(a, b):
    var ac = axial_to_cube(a)
    var bc = axial_to_cube(b)
    return cube_distance(ac, bc)
If your compiler inlines axial_to_cube and cube_distance, it will generate this code:
function hex_distance(a, b):
    return (abs(a.q - b.q) 
          + abs(a.q + a.r - b.q - b.r)
          + abs(a.r - b.r)) / 2
There are lots of different ways to write hex distance in axial coordinates, but no matter which way you write it, axial hex distance is derived from the Mahattan distance on cubes. For example, the “difference of differences” described here results from writing a.q + a.r - b.q - b.r as a.q - b.q + a.r - b.r, and using “max” form instead of the “divide by two” form of cube_distance. They’re all equivalent once you see the connection to cube coordinates.
Offset coordinates#
As with axial coordinates, we’ll convert offset coordinates to cube coordinates, then use cube distance.
function offset_distance(a, b):
    var ac = offset_to_cube(a)
    var bc = offset_to_cube(b)
    return cube_distance(ac, bc)
We’ll use the same pattern for many of the algorithms: convert hex to cube, run the cube version of the algorithm, and convert any cube results back to hex coordinates (whether axial or offset).
#Line drawing
How do we draw a line from one hex to another? I use linear interpolation for line drawing. Evenly sample the line at N+1 points, and figure out which hexes those samples are in.
flatpointy
First we calculate N=10 to be the hex distance between the endpoints.
Then evenly sample N+1 points between point A and point B. Using linear interpolation, each point will be A + (B - A) * 1.0/N * i, for values of ifrom 0 to N, inclusive. In the diagram these sample points are the dark blue dots. This results in floating point coordinates.
Convert each sample point (float) back into a hex (int). The algorithm is called cube_round.
Putting these together to draw a line from A to B:
function lerp(a, b, t): # for floats
    return a + (b - a) * t

function cube_lerp(a, b, t): # for hexes
    return Cube(lerp(a.x, b.x, t), 
                lerp(a.y, b.y, t),
                lerp(a.z, b.z, t))

function cube_linedraw(a, b):
    var N = cube_distance(a, b)
    var results = []
    for each 0 ≤ i ≤ N:
        results.append(cube_round(cube_lerp(a, b, 1.0/N * i)))
    return results
More notes:
There are times when cube_lerp will return a point that’s exactly on the side between two hexes. Then cube_round will push it one way or the other. The lines will look better if it’s always pushed in the same direction. You can do this by adding an “epsilon” hex Cube(1e-6, 2e-6, -3e-6) to one or both of the endpoints before starting the loop. This will “nudge” the line in one direction to avoid landing on side boundaries.
The DDA Algorithm on square grids sets N to the max of the distance along each axis. We do the same in cube space, which happens to be the same as the hex grid distance.
The cube_lerp function needs to return a cube with float coordinates. If you’re working in a statically typed language, you won’t be able to use the Cube type but instead could define FloatCube, or inline the function into the line drawing code if you want to avoid defining another type.
You can optimize the code by inlining cube_lerp, and then calculating B.x-A.x, B.x-A.y, and 1.0/N outside the loop. Multiplication can be turned into repeated addition. You’ll end up with something like the DDA algorithm.
I use axial or cube coordinates for line drawing, but if you want something for offset coordinates, take a look at this article.
There are many variants of line drawing. Sometimes you’ll want “super cover”. Someone sent me hex super cover line drawing code but I haven’t studied it yet.
#Movement Range
Coordinate range#
Given a hex center and a range N, which hexes are within N steps from it?
We can work backwards from the hex distance formula, distance = max(abs(x), abs(y), abs(z)). To find all hexes within N steps, we need max(abs(x), abs(y), abs(z)) ≤ N. This means we need all three to be true: abs(x) ≤ N and abs(y) ≤ N and abs(z) ≤ N. Removing absolute value, we get -N ≤ x ≤ N and -N ≤ y ≤ N and -N ≤ z ≤ N. In code it’s a nested loop:
var results = []
for each -N ≤ x ≤ N:
    for each -N ≤ y ≤ N:
        for each -N ≤ z ≤ N:
            if x + y + z = 0:
                results.append(cube_add(center, Cube(x, y, z)))
This loop will work but it’s somewhat inefficient. Of all the values of z we loop over, only one of them actually satisfies the x + y + z = 0 constraint on cubes. Instead, let’s directly calculate the value of z that satisfies the constraint:
var results = []
for each -N ≤ x ≤ N:
    for each max(-N, -x-N) ≤ y ≤ min(N, -x+N):
        var z = -x-y
        results.append(cube_add(center, Cube(x, y, z)))
This loop iterates over exactly the needed coordinates. In the diagram, each range is a pair of lines. Each line is an inequality. We pick all the hexes that satisfy all six inequalities.
-50+5-5+1+4-5+2+3-5+3+2-5+4+1-5+50-4-1+5-40+4-4+1+3-4+2+2-4+3+1-4+40-4+5-1-3-2+5-3-1+4-30+3-3+1+2-3+2+1-3+30-3+4-1-3+5-2-2-3+5-2-2+4-2-1+3-20+2-2+1+1-2+20-2+3-1-2+4-2-2+5-3-1-4+5-1-3+4-1-2+3-1-1+2-10+1-1+10-1+2-1-1+3-2-1+4-3-1+5-40-5+50-4+40-3+30-2+20-1+1xzy0+1-10+2-20+3-30+4-40+5-5+1-5+4+1-4+3+1-3+2+1-2+1+1-10+10-1+1+1-2+1+2-3+1+3-4+1+4-5+2-5+3+2-4+2+2-3+1+2-20+2-1-1+20-2+2+1-3+2+2-4+2+3-5+3-5+2+3-4+1+3-30+3-2-1+3-1-2+30-3+3+1-4+3+2-5+4-5+1+4-40+4-3-1+4-2-2+4-1-3+40-4+4+1-5+5-50+5-4-1+5-3-2+5-2-3+5-1-4+50-5y ≥ -3z ≤ 3x ≥ -3y ≤ 3z ≥ -3x ≤ 3flatpointy
Intersecting ranges#
If you need to find hexes that are in more than one range, you can intersect the ranges before generating a list of hexes.
You can either think of this problem algebraically or geometrically. Algebraically, each region is expressed as inequality constraints of the form -N ≤ dx ≤ N, and we’re going to solve for the intersection of those constraints. Geometrically, each region is a cube in 3D space, and we’re going to intersect two cubes in 3D space to form a cuboid in 3D space, then project back to the x + y + z = 0 plane to get hexes. I’m going to solve it algebraically:
First, we rewrite constraint -N ≤ dx ≤ N into a more general form, xmin ≤ x ≤ xmax, and set xmin = center.x - N and xmax = center.x + N. We’ll do the same for y and z, and end up with this generalization of the code from the previous section:
var results = []
for each xmin ≤ x ≤ xmax:
    for each max(ymin, -x-zmax) ≤ y ≤ min(ymax, -x-zmin):
        var z = -x-y
        results.append(Cube(x, y, z))
The intersection of two ranges a ≤ x ≤ b and c ≤ x ≤ d is max(a, c) ≤ x ≤ min(b, d). Since a hex region is expressed as ranges over x, y, z, we can separately intersect each of the x, y, z ranges then use the nested loop to generate a list of hexes in the intersection. For one hex region we set xmin = H.x - N and xmax = H.x + N and likewise for y and z. For intersecting two hex regions we set xmin = max(H1.x - N, H2.x - N) and xmax = min(H1.x + N, H2.x + N), and likewise for y and z. The same pattern works for intersecting three or more regions.
flatpointy
Obstacles#
If there are obstacles, the simplest thing to do is a distance-limited flood fill (breadth first search). In this diagram, the limit is set to moves. In the code, fringes[k] is an array of all hexes that can be reached in k steps. Each time through the main loop, we expand level k-1 into level k.
function cube_reachable(start, movement):
    var visited = set() # set of cubes
    add start to visited
    var fringes = [] # array of arrays of cubes
    fringes.append([start])

    for each 1 < k ≤ movement:
        fringes.append([])
        for each cube in fringes[k-1]:
            for each 0 ≤ dir < 6:
                var neighbor = cube_neighbor(cube, dir)
                if neighbor not in visited and not blocked:
                    add neighbor to visited
                    fringes[k].append(neighbor)

    return visited
555515544414145433131313543213121212654111111176510110101165212910543389544456785555678666678flatpointy
Limit movement = 4
#Rotation
Given a hex vector (difference between one hex and another), we might want to rotate it to point to a different hex. This is simple with cube coordinates if we stick with rotations of 1/6th of a circle.
A rotation 60° right shoves each coordinate one slot to the right:
         [ x,  y,  z]
to    [-z, -x, -y]
to [y,  z,  x]
A rotation 60° left shoves each coordinate one slot to the left:
     [ x,  y,  z]
to        [-y, -z, -x]
to           [  z,  x,  y]
-50+5-5+1+4-5+2+3-5+3+2-5+4+1-5+50-4-1+5-40+4-4+1+3-4+2+2-4+3+1-4+40-4+5-1-3-2+5-3-1+4-30+3-3+1+2-3+2+1-3+30-3+4-1-3+5-2-2-3+5-2-2+4-2-1+3-20+2-2+1+1-2+20-2+3-1-2+4-2-2+5-3-1-4+5-1-3+4-1-2+3-1-1+2-10+1-1+10-1+2-1-1+3-2-1+4-3-1+5-40-5+50-4+40-3+30-2+20-1+1xzy0+1-10+2-20+3-30+4-40+5-5+1-5+4+1-4+3+1-3+2+1-2+1+1-10+10-1+1+1-2+1+2-3+1+3-4+1+4-5+2-5+3+2-4+2+2-3+1+2-20+2-1-1+20-2+2+1-3+2+2-4+2+3-5+3-5+2+3-4+1+3-30+3-2-1+3-1-2+30-3+3+1-4+3+2-5+4-5+1+4-40+4-3-1+4-2-2+4-1-3+40-4+4+1-5+5-50+5-4-1+5-3-2+5-2-3+5-1-4+50-5flatpointy
As you play with diagram, notice that each 60° rotation flips the signs and also physically “rotates” the coordinates. After a 120° rotation the signs are flipped back to where they were. A 180° rotation flips the signs but the coordinates have rotated back to where they originally were.
Here’s the full recipe for rotating a position P around a center position C to result in a new position R:
Convert positions P and C to cube coordinates.
Calculate a vector by subtracting the center: P_from_C = P - C = Cube(P.x - C.x, P.y - C.y, P.z - C.z).
Rotate the vector P_from_C as described above, and call the resulting vector R_from_C.
Convert the vector back to a position by adding the center: R = R_from_C + C = Cube(R_from_C.x + C.x, R_from_C.y + C.y, R_from_C.z + C.z).
Convert the cube position R back to to your preferred coordinate system.
It’s several conversion steps but each step is simple. You can shortcut some of these steps by defining rotation directly on axial coordinates, but hex vectors don’t work for offset coordinates and I don’t know a shortcut for offset coordinates. Also see this stackexchange discussion for other ways to calculate rotation.
#Rings
Single ring#
To find out whether a given hex is on a ring of a given radius, calculate the distance from that hex to the center and see if it’s radius. To get a list of all such hexes, take radius steps away from the center, then follow the rotated vectors in a path around the ring.
function cube_ring(center, radius):
    var results = []
    # this code doesn't work for radius == 0; can you see why?
    var cube = cube_add(center, 
                        cube_scale(cube_direction(4), radius))
    for each 0 ≤ i < 6:
        for each 0 ≤ j < radius:
            results.append(cube)
            cube = cube_neighbor(cube, i)
    return results
In this code, cube starts out on the ring, shown by the large arrow from the center to the corner in the diagram. I chose corner 4 to start with because it lines up the way my direction numbers work but you may need a different starting corner. At each step of the inner loop, cube moves one hex along the ring. After 6 * radius steps it ends up back where it started.
flatpointy
Spiral rings#
Traversing the rings one by one in a spiral pattern, we can fill in the interior:
function cube_spiral(center, radius):
    var results = [center]
    for each 1 ≤ k ≤ radius:
        results = results + cube_ring(center, k)
    return results
flatpointy
The area of the larger hexagon will be the sum of the circumferences, plus 1 for the center; use this formula to help you calculate the area.
Visiting the hexes this way can also be used to calculate movement range.
#Field of view
Given a location and a distance, what is visible from that location, not blocked by obstacles? The simplest way to do this is to draw a line to every hex that’s in range. If the line doesn’t hit any walls, then you can see the hex. Mouse over a hex to see the line being drawn to that hex, and which walls it hits.
This algorithm can be slow for large areas but it’s so easy to implement that it’s what I recommend starting with.
flatpointy
There are many different ways to define what’s “visible”. Do you want to be able to see the center of the other hex from the center of the starting hex? Do you want to see any part of the other hex from the center of the starting point? Maybe any part of the other hex from any part of the starting point? Are there obstacles that occupy less than a complete hex? Field of view turns out to be trickier and more varied than it might seem at first. Start with the simplest algorithm, but expect that it may not compute exactly the answer you want for your project. There are even situations where the simple algorithm produces results that are illogical.
Clark Verbrugge’s guide describes a “start at center and move outwards” algorithm to calculate field of view. Also see the Duelo project, which has an an online demo of directional field of view and code on Github. Also see my article on 2d visibility calculation for an algorithm that works on polygons, including hexagons. For grids, the roguelike community has a nice set of algorithms for square grids (see this and this and this); some of them might be adapted for hex grids.
#Hex to pixel
For hex to pixel, it’s useful to review the size and spacing diagram at the top of the page.
Axial coordinates#
For axial coordinates, the way to think about hex to pixel conversion is to look at the basis vectors. The arrow (0,0)→(1,0) is the q basis vector (x=sqrt(3), y=0) and (0,0)→(0,1) is the r basis vector (x=sqrt(3)/2, y=3/2). The pixel coordinate is q_basis * q + r_basis * r. For example, the hex at (1,1) is the sum of 1 q vector and 1 r vector. A hex at (3,2) would be the sum of 3 q vectors and 2 r vectors.
0, 01, 00, 11, 1
The code for flat top or pointy top is:
function pointy_hex_to_pixel(hex):
    var x = size * (sqrt(3) * hex.q  +  sqrt(3)/2 * hex.r)
    var y = size * (                         3./2 * hex.r)
    return Point(x, y)
This can also be viewed as a matrix multiply, where the basis vectors are the columns of the matrix:
⎡x⎤            ⎡ sqrt(3)   sqrt(3)/2 ⎤   ⎡q⎤
⎢ ⎥  =  size × ⎢                     ⎥ × ⎢ ⎥
⎣y⎦            ⎣    0          3/2   ⎦   ⎣r⎦
The matrix approach will come in handy later when we want to convert pixel coordinates back to hex coordinates. To invert the process of hex-to-pixel into a pixel-to-hex process, we will invert the hex-to-pixel matrix into a pixel-to-hex matrix.
Offset coordinates#
For offset coordinates, we need to offset either the column or row number (it will no longer be an integer).
function oddr_offset_to_pixel(hex):
    var x = size * sqrt(3) * (hex.col + 0.5 * (hex.row&1))
    var y = size * 3/2 * hex.row
    return Point(x, y)
Offset coordinates:   odd-r  even-r  odd-q  even-q 
Unfortunately offset coordinates don’t have basis vectors that we can use with a matrix. This is one reason pixel-to-hex conversions are harder with offset coordinates.
Another approach is to convert the offset coordinates into cube/axial coordinates, then use the cube/axial to pixel conversion. By inlining the conversion code then optimizing, it will end up being the same as above.
#Pixel to Hex
One of the most common questions is, how do I take a pixel location (such as a mouse click) and convert it into a hex grid coordinate? I'll show how to do this for axial or cube coordinates. For offset coordinates, the simplest thing to do is to convert the cube to offset at the end.
-7, -3-7, -2-7, -1-7, 0-7, 1-7, 2-7, 3-7, 4-7, 5-7, 6-7, 7-7, 8-7, 9-7, 10-7, 11-6, -4-6, -3-6, -2-6, -1-6, 0-6, 1-6, 2-6, 3-6, 4-6, 5-6, 6-6, 7-6, 8-6, 9-6, 10-5, -4-5, -3-5, -2-5, -1-5, 0-5, 1-5, 2-5, 3-5, 4-5, 5-5, 6-5, 7-5, 8-5, 9-5, 10-4, -5-4, -4-4, -3-4, -2-4, -1-4, 0-4, 1-4, 2-4, 3-4, 4-4, 5-4, 6-4, 7-4, 8-4, 9-3, -5-3, -4-3, -3-3, -2-3, -1-3, 0-3, 1-3, 2-3, 3-3, 4-3, 5-3, 6-3, 7-3, 8-3, 9-2, -6-2, -5-2, -4-2, -3-2, -2-2, -1-2, 0-2, 1-2, 2-2, 3-2, 4-2, 5-2, 6-2, 7-2, 8-1, -6-1, -5-1, -4-1, -3-1, -2-1, -1-1, 0-1, 1-1, 2-1, 3-1, 4-1, 5-1, 6-1, 7-1, 80, -70, -60, -50, -40, -30, -20, -10, 00, 10, 20, 30, 40, 50, 60, 71, -71, -61, -51, -41, -31, -21, -11, 01, 11, 21, 31, 41, 51, 61, 72, -82, -72, -62, -52, -42, -32, -22, -12, 02, 12, 22, 32, 42, 52, 63, -83, -73, -63, -53, -43, -33, -23, -13, 03, 13, 23, 33, 43, 53, 64, -94, -84, -74, -64, -54, -44, -34, -24, -14, 04, 14, 24, 34, 44, 55, -95, -85, -75, -65, -55, -45, -35, -25, -15, 05, 15, 25, 35, 45, 56, -106, -96, -86, -76, -66, -56, -46, -36, -26, -16, 06, 16, 26, 36, 47, -107, -97, -87, -77, -67, -57, -47, -37, -27, -17, 07, 17, 27, 37, 4
First we invert the hex to pixel conversion. This will give us a fractionalhex coordinate, shown as a small red circle in the diagram.
Then we find the hex containing the fractional hex coordinate, shown as the highlighted hex in the diagram.
To convert from hex coordinates to pixel coordinates, we multiplied q, r by basis vectors to get x, y. This was a matrix multiply:
⎡x⎤            ⎡ sqrt(3)   sqrt(3)/2 ⎤   ⎡q⎤
⎢ ⎥  =  size × ⎢                     ⎥ × ⎢ ⎥
⎣y⎦            ⎣    0          3/2   ⎦   ⎣r⎦
Matrix for: flat top or pointy top
To invert the hex-to-pixel process into a pixel-to-hex process we invert the pointy-top hex-to-pixel matrix into a pixel-to-hex matrix:
⎡q⎤     ⎡ sqrt(3)/3     -1/3 ⎤   ⎡x⎤
⎢ ⎥  =  ⎢                    ⎥ × ⎢ ⎥ ÷ size
⎣r⎦     ⎣     0          2/3 ⎦   ⎣y⎦
This calculation will give us fractional axial coordinates (floats) for q and r. The hex_round() function will convert the fractional axial coordinates into integer axial hex coordinates. Here’s the code:
function pixel_to_pointy_hex(point):
    var q = (sqrt(3)/3 * point.x  -  1./3 * point.y) / size
    var r = (                        2./3 * point.y) / size
    return hex_round(Hex(q, r))
Code for: flat top or pointy top
That’s three lines of code to convert a pixel location into an axial hex coordinate. If you use offset coordinates, use return cube_to_{odd,even}{r,q}(cube_round(Cube(q, -q-r, r))).
There are many other ways to convert pixel to hex; see this page for the ones I know of.
#Rounding to nearest hex
Sometimes we’ll end up with a floating-point cube coordinate (x, y, z), and we’ll want to know which hex it should be in. This comes up in line drawingand pixel to hex. Converting a floating point value to an integer value is called rounding so I call this algorithm cube_round.
With cube coordinates, x + y + z = 0, even with floating point cube coordinates. So let’s round each component to the nearest integer, (rx, ry, rz). However, although x + y + z = 0, after rounding we do not have a guarantee that rx + ry + rz = 0. So we reset the component with the largest change back to what the constraint rx + ry + rz = 0 requires. For example, if the y-change abs(ry-y) is larger than abs(rx-x) and abs(rz-z), then we reset ry = -rx-rz. This guarantees that rx + ry + rz = 0. Here’s the algorithm:
function cube_round(cube):
    var rx = round(cube.x)
    var ry = round(cube.y)
    var rz = round(cube.z)

    var x_diff = abs(rx - cube.x)
    var y_diff = abs(ry - cube.y)
    var z_diff = abs(rz - cube.z)

    if x_diff > y_diff and x_diff > z_diff:
        rx = -ry-rz
    else if y_diff > z_diff:
        ry = -rx-rz
    else:
        rz = -rx-ry

    return Cube(rx, ry, rz)
For non-cube coordinates, the simplest thing to do is to convert to cube coordinates, use the rounding algorithm, then convert back:
function hex_round(hex):
    return cube_to_axial(cube_round(axial_to_cube(hex)))
The same would work if you have oddr, evenr, oddq, or evenq instead of axial.
Implementation note: cube_round and hex_round take float coordinates instead of int coordinates. If you’ve written a Cube and Hex class, they’ll work fine in dynamically typed languages where you can pass in floats instead of ints, and they’ll also work fine in statically typed languages with a unified number type. However, in most statically typed languages, you’ll need a separate class/struct type for float coordinates, and cube_round will have type FloatCube → Cube. If you also need hex_round, it will be FloatHex → Hex, using helper function floatcube_to_floathex instead of cube_to_hex. In languages with parameterized types (C++, Haskell, etc.) you might define Cube<T> where T is either int or float. Alternatively, you could write cube_round to take three floats as inputs instead of defining a new type just for this function.
#Map storage in axial coordinates
One of the common complaints about the axial coordinate system is that it leads to wasted space when using a rectangular map; that's one reason to favor an offset coordinate system. However all the hex coordinate systems lead to wasted space when using a triangular or hexagonal map. We can use the same strategies for storing all of them.
0, 30, 40, 50, 61, 21, 31, 41, 51, 62, 12, 22, 32, 42, 52, 63, 03, 13, 23, 33, 43, 53, 64, 04, 14, 24, 34, 44, 55, 05, 15, 25, 35, 46, 06, 16, 26, 3r = 00, 01, 02, 03, 04, 05, 06, 0r = 10, 11, 12, 13, 14, 15, 16, 1r = 20, 21, 22, 23, 24, 25, 26, 2r = 30, 31, 32, 33, 34, 35, 36, 3r = 40, 41, 42, 43, 44, 45, 46, 4r = 50, 51, 52, 53, 54, 55, 56, 5r = 60, 61, 62, 63, 64, 65, 66, 6q = 0q = 1q = 2q = 3q = 4q = 5q = 6
Shape: rectangle triangle hexagon rhombus 
array[r][q - max(0, N-r)] → array[2][q - 1] → array[2][2]
Notice in the diagram that the wasted space is on the left and right sides of each row (except for rhombus maps) This gives us three strategies for storing the map:
Ignore the problem. Use a dense array with nulls or some other sentinel at the unused spaces. At most there’s a factor of two for these common shapes; it may not be worth using a more complicated solution.
Use a hash table instead of dense array. This allows arbitrarily shaped maps, including ones with holes. When you want to access the hex at q,ryou access hash_table(hash(q,r)) instead. Encapsulate this into the getter/setter in a map class so that the rest of the game doesn’t need to know about it.
Slide the rows to the left, by starting the arrays at the leftmost column instead of at 0. This removes the waste on the left. Optionally, use variable sized rows. In many languages a 2D array is an array of arrays; there’s no reason the arrays have to be the same length. This removes the waste on the right.
Let’s take a closer look at how to use an array of arrays. There’s an array for each row, but we need to know the first column of that row. Map hex q,r is stored at array[r - first_row][q - first_column(r)]. Encapsulate this into the getter/setter in a map class so that the rest of the game doesn’t need to know about it.
For the rectangle shaped map shown here, first_column(r) == -floor(r/2), so Hex(q, r) is stored at array[r][q + floor(r/2)]. This turns out to be equivalent to converting the coordinates into odd-r offset grid coordinates.
For the triangle shaped map shown here, first_column(r) == 0, so you’d access array[r][q] — how convenient! For triangle shaped maps that are oriented the other way (not shown in the diagram), it’s array[r][q+r].
For hexagon shaped maps of radius N centered at Hex(N, N, -2*N), first_column(r) == max(0, N-r), so you’d access array[r][q - max(0, N-r)].
For the rhombus shaped map here, everything matches nicely, so you can use array[r][q].
Your maps won’t look exactly like the ones here so you’ll need to adapt first_row and first_column(r) to your own maps. If you are using flat-topped hexes, it will be easier to swap the roles of the rows and columns, and use array[q - first_column][r - first_row(q)].
#Wraparound maps
In some games you want the map to “wrap” around the edges. In a square map, you can either wrap around the x-axis only (roughly corresponding to a sphere) or both x- and y-axes (roughly corresponding to a torus). Wraparound depends on the map shape, not the tile shape. To wrap around a rectangular map is easy with offset coordinates. I’ll show how to wrap around a hexagon-shaped map with cube coordinates.
Corresponding to the center of the map, there are six “mirror” centers. When you go off the map, you subtract the mirror center closest to you until you are back on the main map. In the diagram, try exiting the center map, and watch one of the mirrors enter the map on the opposite side.
The simplest implementation is to precompute the answers. Make a lookup table storing, for each hex just off the map, the corresponding cube on the other side. For each of the six mirror centers M, and each of the locations on the map L, store mirror_table[cube_add(M, L)] = L. Then any time you calculate a hex that’s in the mirror table, replace it by the unmirrored version. See stackoverflow for another approach.
For a hexagonal shaped map with radius N, the mirror centers will be Cube(2*N+1, -N, -N-1) and its six rotations.
flatpointy
#Pathfinding
If you’re using graph-based pathfinding such as A* or Dijkstra’s algorithm or Floyd-Warshall, pathfinding on hex grids isn’t different from pathfinding on square grids. The explanations and code from my pathfinding tutorial will work equally well on hexagonal grids.
flatpointy
Mouse over a hex in the diagram to see the path to it. Click or drag to toggle walls.
Neighbors. The sample code I provide in the pathfinding tutorial calls graph.neighbors to get the neighbors of a location. Use the function in the neighbors section for this. Filter out the neighbors that are impassable.
Heuristic. The sample code for A* uses a heuristic function that gives a distance between two locations. Use the distance formula, scaled to match the movement costs. For example if your movement cost is 5 per hex, then multiply the distance by 5.
#More
I have an guide to implementing your own hex grid library, including sample code in C++, Java, C#, Javascript, Haxe, and Python.
In my Guide to Grids, I cover axial coordinate systems to address square, triangle, and hexagon sides and corners, and algorithms for the relationships among tiles, sides, and corners. I also show how square and hex grids are related.
The best early guide I saw to the axial coordinate system was Clark Verbrugge’s guide, written in 1996.
The first time I saw the cube coordinate system was from Charles Fu’s posting to rec.games.programmer in 1994.
DevMag has a nice visual overview of hex math including how to represent areas such as half-planes, triangles, and quadrangles. There’s a PDF version here that goes into more detail. Highly reocmmended! The GameLogic Grids library implements these and many other grid types in Unity.
James McNeill has a nice visual explanation of grid transformations.
Overview of hex coordinate types: staggered (offset), interlaced, 3d (cube), and trapezoidal (axial).
The Rot.js library has a list of hex coordinate systems: non-orthogonal (axial), odd shift (offset), double width (interlaced), cube.
Range for cube coordinates: given a distance, which hexagons are that distance from the given one?
Distances on hex grids using cube coordinates, and reasons to use cube coordinates instead of offset.
This guide explains the basics of measuring and drawing hexagons, using an offset grid.
Convert cube hex coordinates to pixel coordinates.
This thread explains how to generate rings.
The HexPart system uses both hexes and rectangles to make some of the algorithms easier to work with.
Are there pros and cons of “pointy topped” and “flat topped” hexagons?
Line of sight in a hex grid with offset coordinates, splitting hexes into triangles
Hexnet explains how the correspondence between hexagons and cubesgoes much deeper than what I described on this page, generalizing to higher dimensions.
I used the PDF hex grids from this page while working out some of the algorithms.
Generalized Balanced Ternary for hex coordinates seems interesting; I haven’t studied it.
Hex-Grid Utilities is a C# library for hex grid math, with neighbors, grids, range finding, path finding, field of view. Open source, MIT license.
The Reddit discussion and Hacker News discussion and MetaFilter discussion have more comments and links.
The code that powers this page is partially procedurally generated! The core algorithms are in lib.js, generated from my guide to implementation. There are a few more algorithms in hex-algorithms.js. The interactive diagrams are in hex-diagrams.js, using Vue.js to inject into the templates in index.bxml(xhtml I feed into a preprocessor).
There are more things I want to do for this guide. I’m keeping a list on Trello. Do you have suggestions for things to change or add? Comment below.
Email me at redblobgames@gmail.com, or tweet to @redblobgames, or post a public comment:
Copyright © 2018 Red Blob Games
  Created 11 Mar 2013 with Haxe and D3.js ; updated in 2018 to use Vue.js ;  Last modified: 19 Apr 2018



# Relatively Old

URBAN ARCHITECT 

Gameplay Manual 









































Game Overview

Urban Architect is a city engine building and worker management sim game. Players can build structures, recruit workers, and manage their urban centers.


Basic Resource List

Capital
Land
Energy (power plants)
Water (water filtering plant)
Food (grocery markets)
Work (workplaces that can hire workers)
Entertainment (all sorts of buildings can contribute)
Market Resources (tradeable)


Some planning for implementation

Even simpler core loop

Build house - get access to worker
Build factory
Click on house - click on worker that pops up
Assign worker to factory
Get factory resource generating



Simple core loop

Generate a worker and deduct cost
Generating worker requirements:
Need to build a residence
Perhaps we don’t need money to generate a worker, just the residence requirement
The worker then has some sort of saving they use to start paying for the residence, maybe the first month, but then they need employment for their bills
In the beginning the worker residence will be indicated just like the employment vacancy, with a LOTR circle
Allow to place worker at building (need to build the power plant building first as an example)
We click on the power plant and then the vacant spots open up, in which we can place the worker
We place the worker there and then they begin to generate power according to the end of the day night cycle


Worker Placement Core Mechanisms

WORKER GENERATION
Randomized stats when generating a new worker
TENSION of a potential vs future action, we don’t want to overzealously generate too many workers and cramp our resources, best way is to adapt to how our workers are performing and how many resources they are bringing in, just like in urban development theory try to adapt instead of trying to predict
Can get workers cheaper if x mechanic
Can only put workers out a little at a time (Viticulture)
Sometimes we will also lose workers, leveled up workers are a precious resource
Some structures / resources can be used to get workers at a discount, perhaps some keep on giving bonuses 
WORKER PLACEMENT
TENSION: There is more decision and risk going on with worker placement (Viticulture)
TENSION: can spend something x number of times to get something or wait to spend another x number of times to get something better, nice tension of should we wait to maximize resources or need resources right away, nice tension of the potential of a present vs future action (Viticulture seasons)
As workers level up and specialize by their history of their worker placement, the player can thematically place workers in specific places and or areas (area bonus for other workers, and even structures)
We can unlock special building abilities based on how many workers we place there. (Example: 3 workers unlocks ability x or bonus y.) We also are able to unlock another ability at let’s say 10 workers. Good to categorize actions to the player by the number of workers required. This is interesting in creating TENSION where we have to decide whether to increase the bonus by placing the required number of workers there or spread out elsewhere and get other good stuff. Give the player many good choices vs better choices.
Study Tzolkin for tough choices, has a wonderful decision space
Two levels of cost (Tzolkin), some buildings will level up workers faster but they might not initially really pay that well
TENSION Tough choices of how long to place workers there, maybe they get old, or more experience and are underpaid for their skills and should be moved elsewhere, maybe there are negative points, when a worker should be fired, or perhaps managed as they adapt and move to another area that suits more of their skill, and then we take along this experience and bonuses the workers learned from a building
Buildings have their own requirements, so to place workers there not only do we need workers of certain level, but perhaps also requirement X
Can pick something better later if have patience, could be a good mechanism to not waste workers right away, somehow try to convey this intuitively to the player, so they can easily grasp the required mechanics and strategy on the first few playthroughs, leave lots of the game to be explored
TENSION building up what you can, powers and abilities which manipulate what you can do (Lewis and Clar)
Perhaps we have to take something “off the board” when we place a worker down, some choices
Lots of places to place workers (Viticulture Essential Edition)
Perhaps when we fire a worker, we can get the money back for the budget we planned for that year’s end to pay those workers, perhaps we have to even fire a batch of good workers in times of crisis if we have mismanaged the funds TENSION
Resource mechanism: place worker at spot to get resources, and use those specific resources to get other things (Scythe). TENSION: resources to utilize later on and not immediately
WORKER DIFFERENTIATION
Workers with different and varied skills which can be leveled up and focused on particulars
Putting out a worker does multiple things, affects different parameters (Automania)
Leveling up workers
We want to strategically level up workers along with the random stats that were generated for us
We can build up skills in certain workers, almost like in Pokemon
Workers in an area can all level up based on some sort of area bonus that is performed by a worker (which is cool TENSION when we recall that worker and put them in another area to level up another set of workers, can even be used as a single strategy to win the game), or the area bonus can come from an inanimate resource, or even both, this is a big one BIG ONE
Can get workers cheaper if X mechanic
Unlike Agricula, Caverna doesn't force you to balance things, so don’t force the player to play the game a kind of gray balanced way, but instead give them choices to play how they want
WORKER ACTIONS
Actions get better the more workers you have, provides a nice progression (can also get other people’s workers in multiplayer mode)
Reacting to what is going on is a big one
Also have to choose one action at the exclusion of other abilities for a Sim, or perhaps there is a timer mechanism cool down, so we can only just one ability out of these 4, and then the timer mechanism runs to when we can reset
Placing new buildings unlocks new potential worker actions there (study Rajas of the Ganges, has very different and lots of action spots, require specific things, very nice variety of actions)
Placing a worker at a spot requires special things, which are not just straightforward
Workers get available actions once placed in building
Types of actions affected by worker level and special abilities
More workers, more actions
Actions and workers work together
Workers can perform actions that other workers can use, and affect other workers in area
A number of different actions per worker like in Automania
MATING WORKERS
Workers have families and generate workers for us for free, since generating a worker can be pretty expensive, make the mating part worth the time
EMERGENT BEHAVIOUR
If somethings are left unchecked they can spiral out of control and have emergent behaviour effects, like for example if the cost of living is too high for the worker and they are not getting paid enough, that could disrupt the whole supply chain
Not to say this conflicts with restricting the player on how to play the game, they can still play how they want and choose their own assortment of strategies, but certain things still have to be managed like in urban planning, such as distance to work, (as more work areas rise up perhaps the cost of rent has to go up to a certain minimum), and also cost of rent factors, quality of life, or if we don’t supply the power plant with the right type of workers we could lose power to our city, where that would lose us the game
AREA BONUS
WEIRD BONUSES
Can have artificial upgrade requirements: 2 workers of level type x, and a structure of level y that produces x, will give this certain unlockable bonus
Can also have “weird bonuses” combined with worker vs worker interactions, and even interactions that cannot be forced, but instead induced, so bringing a number of workers into an area with another, and then eventually at the roll of the dice they will unlock some sort of special ability, area bonus, etc
Perhaps these bonus requirements are randomly generated each game
So generate a special ability unlock by giving the player a recipe: icon x of 2, and 3 of icon y will give this kind of bonus, and this changes every game to make every game unique, and uniquely exploitable with strategy, perhaps this might seem like a gimmick to some players, but should be received well if the icons are fresh and clear, so perhaps we just simply present them with icons, something that is rather doable, but of course something that they don’t have to do
FEEDING / TAKING CARE OF WORKERS
Need a high enough of a salary for their level, give the player a range the worker will usually stay in, but nothing is guaranteed, workers have a mind of their own! Tell the player. Perhaps we can detect this with some sort of meter or gauge.
Workers need enough grocery stores in area
In turn, we can specialize workers at the grocery stores to make them more efficient
Perhaps we can show the workers there with circles around the building like in LOTR, we can even do the circles with a worker icon for the prototype
Workers also need water and electric plants, and also entertainment, these are general things all workers need
Workers also need a normal rent, we can set the custom rent on the tenements, we will get more money up to a point, where workers will leave if the cost of living is too high, perhaps if rent is more than 30% / 50% of their income
TENSION: the interesting thing is that we can adapt to our population needs like in u urban theory, so if we see workers struggling we can temporarily lower the cost of rent so we will not lose workers (which will deterministically happen to let the player know that’s how things are), and then as the workers make more money we raise the price of rent. We can raise the price of rent per building area. So we can place the workers that we want to level up faster or in a different way at a lower cost of living area, while we keep our other workers at a higher cost of living area, since raising the cost of living is a perfectly valid strategy, and just one of the ways in which the game can be won. Lots of TENSION here.
WORKER VS WORKER INTERACTIONS
Bonus interactions with workers
TIMER MECHANISM
Workers leave because of too high stress
When there are not enough workers at their job
When they are not making enough money
Their quality of life suffers




Worker Placement Strategies

Many Strategies
Gotta spend money to make money
Worker investment
With proper amount of slow planning all of a sudden you can get a lot in a turn
Open, do whatever you want, no guidance (A Feast for Odin)
Fun to do step 1 2 3 4 to get to 5 (Viticulture), lots of ways to work your vineyard
Big puzzles
elegant




Engine Building




Buying Land

First we need to buy land to build structures and then hire workers. Structures also require to be placed near roads. 


Generating Income

Income is generated by workers. Resources which affect income are generated by structures. Not sure yet how to convert the income generated by a worker to the player’s bank capital. Leave as 1:1 for now. 

Workers generate income plus resources, and even have skills, which are a kind of resource. So in the game Architects of the West Kingdom, a Woodcutter worker generates 1 wood. So for example at a power plant, a worker with level 4 would help generate power on top of the base power generated by the power plant. Or perhaps there is no base value. So the power is helped being generated by the worker, which makes sense like real life, a building doesn’t just produce stuff on their own, we need workers to power up the building. OR perhaps we need x out of required workers to work there for the power plant to generate resources. So the workers are a requirement for the power plant to work. Perhaps we need 5 workers. We might not need to label them as engineers and get too specific.

Sims

Not all sims (NPCS) are workers, but many are. A sim can be a worker if they are 18+. In apartment and house buildings we can have families of sims up to 5 people. A house will give us 5 units available and 


Inhabitable Buildings

A house can have a maximum occupancy of 5. And an apartment / condo building can vary x 5 per unit.




Worker Recruitment

If workers do not have the proper food, energy, water, entertainment, and work resources, they will slowly begin to move out. And leave the buildings vacant. 

Building and Technology Upgrades


Networks of Production





CASE STUDIES: WORKER PLACEMENT

Some Case Studies for worker placement

Viticulture Essential Edition

https://www.youtube.com/watch?v=FueNctM_RMA


Game end can be simply reaching a number of victory points, which can be acquired through a number of ways, in Viticulture this is 20 victory points, perhaps we can have 100 victory points
Big aspect of Viticulture is the TENSION generated by choosing (player choice!) between present and future actions of which season to place a worker in
Can have artificial upgrade requirements: 2 workers of level type x, and a structure of level y that produces x, will give this certain unlockable bonus
Big thing is also that there is no major competition / sabotage going on, so all players can enjoy
Also another big thing is that Viticulture has “mature” art, which any adult can be not ashamed to like vs a kid looking game, something that might not be so obvious
Big focus on replayability, seems like this is almost essential for a game, huh. You start with different resources (different abilities in our game)
Seems like the art is very mature, something that perhaps we can emulate with a combination of Brass Birmingham, and Anno the older games, they also seem to have this endearing but mature art style that transport us into the world of the game
The different paths to victory are well balanced
And seems like the author of the game is acutely aware of the worker placement mechanism, which really generates the core of the game, because he has even said this is his favorite mechanism, next to engine building, and cut the deck, and also he even made a video on youtube listing his favorite worker placement games, so there must be something there
The game can usually just take 30 minutes to play, which is also nice for my game, in that we can win and then replay, but somehow we need to incorporate in app purchases, whether this is through expansions, ads, or combinations, look up the guy from trees and tents, he said his monetization went through the roof when he from simple ads to monetizing the in game currency
The game is not nasty, competitive without being cut throat
There is more decision and risk going on with worker placement
Like a reviewer said, the game is classy as fuck!
Realistic art also has to have more of a staying power than cartoony fashionable designs
At 1:51:40 this track is very classy, would sound superb arranged for orchestra: 
https://youtu.be/ZE0So9z9QCM?t=6711
Chill Out Cafe Music 10 Hours - Soft Jazz and Bossa Nova for Coffee Break, Studying, Relax, would sound great with this sort of bossa nova beat, a very relaxing game for people, where we don’t stress them, but still give them healthy competition



Manhattan Project Energy Empire

Can send out workers, which gather a specific type of resource
Start off with a different ability class, not starting vanilla is important
Can recall workers also, to place them at more strategic points, and use them to level up there and acquire abilities on their worker journey
Basically an energy resource worker placement game





Automania 

Great combination of engine building and worker placement
Accessible so you can do something right away on turn 1, this is important, don’t have to go in debt, or wait
Good game to study intricate engine building along with worker placement interactions


Charterstone





Everdell



Lewis and Clark

Don’t punish the player with slowness by the things they acquire, not fun


Anachrony


Tzolkin




Relaxing Music

https://youtu.be/ZE0So9z9QCM?t=25073


At 6:58, seems like a nice theme, could do something like this with guitar

Chill Out Cafe Music 10 Hours - Soft Jazz and Bossa Nova for Coffee Break, Studying, Relax




# Newer Old Stuff

# Scope / Focus

* favorite games growing up where always building toys, like Lego, K'Nex, Playmobil, and also evolving toys like Pokemon, and Tamagotchi, along with RTS computers games like Age of Empires and Battle for Middle Earth, this game is inspired by these toys, also the game is more of a "toy" rather than a game
* focus on a simple mobile game like Crossy Road but a building simulator
* a mix between Crossy Road, Tamagotchi, and Sim City

# Monetization

* study the monetization techniques of Crossy Road -- this might influence character design, since perhaps characters will be unlockable through watching video ads, etc, perhaps we can play as a different hero character, architect, mayor, etc, and these will give different abilities / advantages in the game. The hero character could have a detailed design as the avatar, but then the NPCs roaming around could have a generic design. 

* a free mobile game is almost guaranteed to get downloads, can put on resume 50K downloads

* research the monetization of the below games sooner rather than later. Some players in the reviews are very upset about having to pay money to play the game. So find a balance. Play the games and take notes. 


# Examples

* Designer City: building game
* Megapolis: city building simulator. Urban strategy
* SimCity Mobile
* Little Big City 2
* Research as many as you can find on the App Store, and also Steam


Two key things to take from examples:

1) What inspirations can be expanded upon
2) What can be done different to stand out?

Create a list. 

Some of the things that will be different with the game will be the synthetic intelligence, Tamagotchi simulation aspect. Where each person has their own life they go on about.

The player can search for people by name, perhaps they can access a list of all their character to check where they are. The characters will have ages, (they will even die), and new characters will be born in the city, or move in. This is a big thing. So more of a combination of Sims and Tamagotchi.

One thing that can go into both categories, is the art. All the popular apps have superior art, and many models. So follow that but raise the bar a notch, and create even more appealing buildings. How to do that? Study lots of architecture. Get good at modeling, lol. Wish I could use some post processing effects. Maybe that will be allowed in the future. Maybe will be able to push out an update once the technology arrives, or check the system requirements for post processing. Perhaps there is also a way to activate that on mobile currently.


# MVP Features


* build out entire prototype with simple shapes

* perhaps also provide a AR experience on OS X, and maybe Google phones if can get the hardware to test on, write them an email to get free hardware to test on?


# Building types

* Commercial
* Residential


# Other objects

* road tiles
* cars 
* possibly people (represented as moving capsules, maybe too much for MVP, or maybe worth including)


# Toward an MVP

These things will make a good first prototype

* building menu system
* placing down different buildings
* inventory, subtracting money for placing buildings
* zoning areas?
* roads, and traffic

# Roads

* can use raycasts to check how to connect a road, so each tile will have four sides, we can send a raycast to check the segment, and then decide whether we can connect that segment

# Traffic System

* need some sort of self organizing traffic system, use boxes for cars
* perhaps use capsules for pedestrians, and have them wait for the cars before crossing the street, perhaps they will also disappear into the buildings

# Zoning Mechanism

* we want to be able to zone residential and commercial? 

# Aesthetic

* go for a simulation type aesthetic, where the pedestrians will not have that many features, and will disappear into buildings

# Data

* use a GameManager.cs or the singleton method to create the data file, GameManager, might be simple enough and fine
* here we store tokens, and other state info
* make sure all data is separated and lives here

# Non Functional Decorations

* clouds
* sounds of nature, city
* score
* sound fx

# Game Strategy and Mechanics

* go through the urban planning book to determine how to arrange the strategy, example: per 3 commercial buildings we want 10 residential buildings

# Advertising

* create media press kit to send out to all the major reviewers, look up the wikipedia page of successful games like Crossy Road for where the reviews are coming from

# MVP Steps

Phase 1 - Basics

* create grid building system
* create menu building selection
* create road system and populate with traffic
* create little walking people, they can randomly go into buildings, will probably need a navmesh, everytime we place something down we could update the navmesh - these people could have state info, easy to do and could make a big impact, so we click on them and get their profession, their networth, their randomized name, etc, kind of like in the space simulation game, perhaps some could say "unemployed", these people will also evolve over time just like Tamagotchis

Phase 2 - UI / Game State

* show how many tokens are available and subtract based on building
* adjust the population counter
* create a Tamagotchi type simulation system, where we can leave the simulation alone, and the city will go about their own business
* create some starter rules, so need x number of residential buildings for population, happier population with certain types of ratios, etc, study the urban development book

Phase 3 - Monetization

Phase x - 

Phase 4 - Models

* drop in the models, go for Crossy Road style 

Phase 5 - ?

Phase 6 - ? 

Phase 8 - Polish & Testing

Phase 9 - Deployment


# Detailed Steps 

Phase 1 - Create Building System

* test the grid system from the tutorial

* can the grid system be applied to a mini grid, meaning we can drag the buildings irregularly

* create a simple menu selection system, by pressing 1 or 2, to select the building type, then place that building

* we already have some code written to place buildings from the space game, only ensure buildings don't get placed perpendicularly 

* when selecting a building we want an albedo outline (simply apply a glow material to the object), this material will flash green if we can build there, and perhaps grey (or blue) if we cannot build there, number one reason being there is already a building there

* how to check whether we can build there? well we could create a data structure, or send out a raycast, perhaps the data structure might be easier? we could also simply place a collider on the structure. the collider might be the easiest solution, we could place a slightly larger collider to indicate this. will there be any speed concerns by checking for a collider in the update method?

* based on the collider response we can either apply the material or instantiate that prefab there at runtime, perhaps easiest to just apply that texture, since we don't want to keep instantiating, even though we could (and should) do a check for already instantiated 

* so in the end of this part we want to be able to select different buildings, check whether they can be placed, and place them

* also before we do the traffic system below, perhaps get the state machine going, and keep track of what buildings we are placing, we can just do this through a GameManager -- how to tally up the points -- perhaps once the turn comes, we can add up the points with a simple decoupled system, of searching all the objects in the scene by tag, if we don't do this in udpate we will be fine, the advantage of this, this is a very simple system, of course we could also make a data structure that we add, a JSON list, or some type of dictionary array, perhaps even an array would be better, and then just subtract and add as we place / destroy. Yes, the dictionary might be the best, a string identifier, and the number of buildings. We also probably don't want to increment all the resources at the same time on one turn, so simply create an illusion behind the scenes by setting up different time cycles for each resource, and maybe even randomize some time cycles within a range, so the player doesn't catch on to the logic, but they will still be vaguely aware of the resorouces generating. Perhaps the resrouce time cycle starts when we place the building down, so the time cycles will naturally be offset from one another. This is probably the correct solution, and what Battle for Middle Earth does. 

* on the whole grid issue whether to snap 1:1 or 1:10, or whatever, wait with that, and just create the basic grid snapping mechanism first, even in the 1:1 snapping, the buildings base might be 1:1 equal to others, but the actual structure placed on the prefab (smaller than the base), can have an irregular size

 * we also want to be able to plant trees, and at least start with a tree landscape, with which we contruct, and mow down trees
 
 * when we build we will want smoke and some building posts going up to simbolize building, these can just be wooden shapes, does not have to be complicated, but this will really add an extra level of dimension -- "game feel / juice", so we could simply create rectangular objects, and put a wooden material on them, then arrange them to the shape of the building, in 3 stages, so this would actually be very doable, so first build the base, then the supports, and then the structure, and then show the building, with some pleasant building noises, on building, and on completing the building, also perhaps some flash of the outline of the building to signalize to the player the building is done


Phase 1 - Create Traffic System

* this might be the most difficult part of the entire game

* we want to be able to smoothly run our finger (the mouse cursor in the meantime) and "paint" the road on, along with smart curves, meaning if we move our finger perpendicularly then curve the road

* first be able to move the cursor along, and paint (instantiate) the tiles flat on the plane surface

* we also want a mechanism of course to detect where legally the roads can be placed

* roads are the first essential thing to build, since we can only place buildings along roads

* the first main road should stretch out beyond the horizon, so the cars can drive out into the darkness (fog of war)

* then we can connect roads to the main road, so automatically if we build another road, that road will smoothly connect (the appropriate connector tile will be instantiated)

* resources for road making: https://github.com/MicroGSD/RoadArchitect
* and https://github.com/JPBotelho/Unity-Road-Generator

* more examples:

"I ran into this problem a couple of months ago. What I do is create a quad (4 vertices) and then only move two of those to follow the mouse. I limit the direction to 0, 90, 180 or 270 degrees only so only straight roads are allowed, my scripts wouldn't work for anything else. Basically I draw the road in realtime with a texture, the problem is it doesn't look or blend with the terrain very well. Once the player releases the mouse button the road is painted directly on the terrain alphamap, it blends flawlessly and really looks good."

Here is the BuildRoad class that I made: http://pastebin.com/m1F4tJUX

And here is the UpdateTextureWithinBounds function: http://pastebin.com/vMeF3pa1

Phase 1 - Avatars and NPCs

* essential to study the monetization mechanics of Crossy Road and other free to play games

* the core mechanic of free to play games seems like "unlocking" things in the game -- research if there are other monetization mechanics that are not based on unlocking mechanisms 

* we can either unlock features in the game by paying money, (or watching video ads), or by leveling up in the game

* so we want to be able to provide all content to be unlockable by the players if they just grind and don't pay

* but if the player wants to spend money they can unlock characters with in game currency

* (unrelated: thoroughly study the game mechanics book, since seems like most of that book while aiming to be a general book on game mechanis, seems to be drawn to in game economies as a way of creating gameplay, there are also many notes done before on Cityopoly, so definitely go through that, and also provide different tokens in the game for variety and interesting gameplay, so even things that might not seem like tokens, but are resources collected by the player, humans are naturally hoarders so use this to create addictive gameplay) 

* creating custom avatars (maybe 10?) will of course require extra modeling work, but that will go a huge way in terms of monetization. Crossy Road made 10M in 3 months of release, probably mostly with unlockable content, so again study Crossy Road and other games. Could we even make the game multiplayer? Maybe in version 2.0. So we would create gang type of mentality like in Eve and Clash of Clans, at that point we might have more money to pay an artist to create really appealing unlockable content

* we want to give the player full interaction with the avatar they purchase to get their money's worth, so the avatar can walk around, etc -- now does this mean we will provide extra detail for the random NPCs or make them generic, and risk the avatar standing out too much, in either case we want the avatar to walk around, and occupy buildings, so we will build the avatar a home, (this is starting to seem like SIMS - oh, study the monetization techniques of SIMS since they also offer a free to play model on mobile), so then we want the avatar to have their own house, and even their own building they work at. Of course once the player reaches a certain milestone(s) and beats the game (perhaps the game can be beaten, or unlocked with different metrics.) So the player does not necessarily beat the game, but just reach a checkpoint, at which they unlock a character. Make this difficult enough where the player will be tempted to spend money on unlockable content. 

* as the avatar occupies different buildings there is interaction there, where being in different buildings gives them different upgrades, perhaps they go to work, like the mayor would be working in city hall, etc

* also offer a skill element, so a player without money can still feel like they are improving at unlocking content in the game, also time this scientifically, how many hours are players willing to grind for unlockable content, research some stuff on this 

* now we also have NPCs, which will be generic characters roaming around, they have names, and levels, professions, ages, etc, and they take on a life of their own, a type of synthetic intelligence like in the book Tricks of the Programming Gurus. Just like the book says, even to this day, this is an area rarely taken advantage of, while the programming is not that difficult. So seems like one of the main types of mechanics is to create these probability functions, like for type of character A, they have a 30% of doing something, etc. This goes toward the Tamagotchi simulation and would be a very fun type of mechanic.


# ToDo

- create the basic core gameplay MVP, which allows building and road placement

- this will involve first getting Road.cs to work, if this works we can proceed, if not we have to explore other options, either purchasing the $36 asset pack Road Creator, or creating a solution from scratch

- if we can get Road.cs to work, then move on to Grid.cs and incorporate that with the Road, not sure yet how to make the road building snap to grid

- in the end of this phase we want to have road building and building placement, this will be huge



# Very Old Stuff

POCKET CITIES 1 (2-D)
POCKET CITIES 2 (3-D)

Pocket Cities is a real time strategy game mixed with rpg elements and Tamagotchi. In Pocket Cities you start building a city from scratch. You start building in darkness against the stars and slowly expand.

The player is given different ways to play and win the game. Here are a few ways to play the game:

- enterpreneur - gang warfare - political influence - civic / social points - good city building - research - hospital good ratio - restaurant ratio - good living ratios - farmer - ... ?
[Tamagotchi] Pets have a Hunger meter, Happy meter, Bracelet meter and Discipline meter to determine how healthy and well behaved the pet is.

Likewise for Pocket Cities:
A) Hunger meter
B) Satisfaction meter

C) Health meter

D) Average age (if not enough inhabitants say not enough data: attract more inhabitants)

E) Quality of living meter

CREATE NEW CITY
choose city name
choose map (future option)
CHARACTER
choose starting character
some characters cannot be chosen in the beginning, for example you cannot start the game with the major
player can choose and earn new characters
characters act as rpg characters, meaning different characters excel at different abilities
in a team effort, one player can be the major, another player can be the entrepreneur
team play can strategize between character abilities
as character level up they unlock new abilities
MAP
start with sexy black canvas and white thin grid outline
turn on / turn off grid button
clouds and birds and music to set the initial mood
trees
BUILD
RTS style building
timer shows how much time lapsed, look up open source rts for ways
special buildings and arrangmenets of buildings unlock characters
capital to build
capital is earned by inhabitants
more aparment buildings + houses = more inhabitants = more capital = more building ability
BUILDINGS
allow the user to pick the colors of the buildings he builds
display stats under each building in scroll view picker
INHABITANTS
100 inhabitants max per apartment building
inhabitants will move into aparment buildings when there are jobs created and grocery stores, department stores, a threshold number for each new wave of inhabitants
COMPETITON
Earn a penalty for competition
MONOPOLY
Construct buildings in close proximity and earn a bonus

GANGS
can wage turf warfare
MULTIPLAYER
multiplayer on the net established
play huge multiplayer games


# Old Stuff

Magic of Brass Birmingham


- contained art in box

- building upgrades, like technology, sequential

- networks of production

- likeable avatars, and different ones to choose from

- markets we can sell goods to, if the demand is there

- first time when you have no networks you can place your resource anywhere, but then have to connect next to networks

- costs money to place anything

- then the resource generates things for you, per turn

- the market then can buy what you're producing right away, if there is space / demand, and then the market pays you the going price

- can establish a link  as an action

- at the end of the action draw up to 11 cards

- final step is getting income



Architects of the West Kingdom

- intro: "Players will need to collect raw materials, hire apprecentices and keep and a watchful eye on their workforce."

- placing worker at different buildings generates different resources

- need money to recruit apprecentices, might need not just money but a combination of resources and or requirements

- also have different choices of different workers to recruit, more dimensional worker recruitment

- Resources: "Clay, Wood, Stone, Silver, Gold, Marble"

- have lots of different resources


MAKE THE TOY FIRST

TO UNDERSTAND A GAME'S PLAY UNDERSTAND THE ECONOMY

START BY IDENTIFYING RESOURCES



Abstract Resources

- time
- research upgrades
- character skills



Concrete Resources

- capital
- mining resources
    - gold
    - electricity (energy)
    - nuclear energy
    - food (grocery market)

- building abilities
- trading market acquired resources
- 



Basic Resource List

- Capital
- Energy (power plants)
- Food (grocery markets)
- Water (water filtering plant)
- Entertainment (all sorts of builldings contribute)
- Work (workplaces that can hire workers)
- Market Resources (tradable)



Worker Investment



Capturing Workers

- recruitment
- differement methods of recruitment to spice up gameplay







Character Employment









- To get the mechanics right you must build them
- build prototypes and iterate as much as you can
- ask power games to break game
- players have to adapt and switch between strategies as the game progresses


Game Mechanicss

Transactions

- collected, consumed, traded

Tokens

- not limited to just money


Deriving Gameplay

- economy
- tactics (maneuvering)
- strategy (long term)
- social dynamics


Economy

- power ups
- collectibles
- lives


Economy Resources

- health
- skill
- experience
- money
- goods
- services (characters can offer unique services that are like power ups, which can also be temporary)

All Economies Revolve Around the Flow of Resources

- Money
- Energy
- Time
- Unit's under player's control
- Items
- Power Ups
- Enemies

Not all resourc es are under player's control (time)







Decrypto
Sheriff of Nottingham
Kemet
Food Chain Magnate
Infinity



# Game Titles

- like Castles of Ludvig, can do a title such as: Cities of X, there have to be many possibilities here

# Starting Capital

- can adjust starting capital amount in settings for tight and different gameplay like in LOTR


# Worker Inventory

- one thing that is easy to pass over just by studying board games, is worker inventory like in an rpg

- so have an inventory for each worker

- when beginning the game, if want the worker to be a construction worker, have to purchase a hammer, and place into their inventory

- we can change out limitless inventory like in many RPG games with make belief no limits, or large limits

- this will be also useful for placing all the worker items there, like sunglasses and hats


# Castles of Ludvig

- major puzzly aspects of putting rooms next to each other for scoring points

- study how buildings come together to gain points for proximity bonus

- set the prices on your turn, and people pay you the money, trying to find the right price so not to low, not to high, powerful mechanism

- each building gives you all sorts of different stuff, think lateraly here about all the possibilities

- some buildings could even score you negative points, but not sure if should punish the player

- once you complete some buildings will get a bonus, this is a cool idea, different bonuses for different buildings complete, or even different abilities, and definitely worker actions

- can even get two bonuses for one building!

- can get bonuses for collections of buildings! perhaps somehow this is indicated somehwere so the player knows

- or perhaps combine this with research trees, so to reach a next level in a research tree, perhaps we have to build a combination of buildings

- perhaps can even choose own rewards for completing buildings of certain types

- biggest fun is watching the castle grow, same sort of fun with city building

- also gameplay of competing intermediate steps, like needing X and Y building, which don't give you any bonuses to get to Z building which will give you a bonus

- four unique victory point conditions, this could be used as a winning mode: 
  - most buildings of X type
  - most money
  - biggest square footage
  - having the most round rooms
  - there are all different sorts of victory conditions that can be combined into 4 combinations! huge replayability
  - and this is just one way to get points
- 


# Suburbia plus expansion

- from the makers of Castles of Ludvig, (came after)

- study the proximity bonus, and how the designers ideas evolved into Castles of Ludvig proximity bonus


# Between Two Cities

- city building game to study 


# Chinatown

- players try to negotiate with other players to trade OR to purchase their tiles, so they can build up multiple building units of the same thing for some special bonus

- this is a fun mechanic which could be used

# Five Tribes - artisants expansion

- how to maximize stuff - nice timed almost chaotic possibility space, "OMG This is the best option ever, i will get 40 points!" 

- mankala mechanism of placing meeples


# Time Stories

- more of an experience than a game

- experiences that will really elevate game play could include:

  - beautiful score
  
  - birds flying, clouds
  
  - ocean sounds, forest sounds, night sounds
  
  - night time mode with buildings lighting up
  
  - any others?

# Dominion

- all the choices are available to the players

- up to the player in which direction they want to go

# Alchemists + expansion

- worker placement.

- have different recipes / ingredients for building

- so for a building we might need 2 wood and 3 steel, low quantities like in FTL, but perhaps we might just up to 10 wood, and 20 steel

- these different ingredient recipes are cool because they are like a puzzle onto themselves, so if we have x wood, and x steel, should we build this structure, or should we save up a little more wood for that structure, test gameplay just to bring out this puzzle aspect, and also how much time will this require to build, and what kind of worker do we have, and how leveled up they are for this construction, like in LOTR, probably just one worker per structure

# Race for the Galacy

- how are you going to manage your hand of cards? How are you going to manage your city and workers? Because things can give you choices? But again, give players good choices, a good choice versus a better choice like La Havre. 

- great tension in what you want to deplete, whether to spend money quickly, or to save up money for something, likewise with different resources

# Alhambra + expansion


# Puerto Rico

Also have random birds flying. Even do flocks of birds flying.

When you have tall skyscrapers, have the clouds move through them. 

Like players often say, once you build everything in a city builder there is nothing to do and the game gets boring. Well, be a completely different game than this. Focus on involved social simulation, worker sim management like Tamagotchi, and multiplayer.

Perhaps even create a feature where you can place a swimming pool on top of a building.

Have random lights flash on and off in buildings during the night. Perhaps even some lights might flicker? Or at least they will shut off. And then as the dead of the night comes most lights will be off. The player will be able to build street lamps anywhere to light up the world. And there will be moonlight of course to light up the rest.

One way of getting around, "how come we don't have hundreds of workers populating offices", perhaps we will have a large number up to 50, or however many we can support on the mobile device. Run tests to determine. So we are an entrepreneur, so we are hiring and recruiting workers at the employment office. 

Also on the rounded workers, and how come they don't drive cars: well, we want to go for an almost whimsical style like Machi Koro, and there are hardly any city building games that are just "fun", and even less so any that are focused on worker placement. Also there are even less games that have sheer "gameplay". The kind of involved management we find in board games. And definitely none that are multiplayer. 


Kind of cool effect when we place the first starting building structure a few units above y. And then with gravity when the player sets down the building, they come sliding down from slightly above. But don't do this with the initial outline, since that will show where the final thing go. Do this only with the final structure. And then with the intermediate structure, use some gravity and force to wobble them around as they are being built.

We could create a very simple tornado effect, by turning off gravity for rigid bodies, they will (float up), and even apply some circular force to spin them, and push them farther, and then we could simply get a tornado effect off the asset store. Not sure if we want to destroy the player's work, but the effect looks cool.

When we buy new land, we also get the trees along with the new land, which we can turn into wood... don't necessarily need a sawmill, can just click and select on the trees to harvest them, perhaps need a sawmill to convert the wood, but can still click on them wherever they are on the map, with the click-enlarge features from the camera code store asset. 



Main issue with the sim city games is that they get old after the first 10 hours or so, even with Cities Skylines, one of the few ways to solve this is to introduce multiplayer. Or some increasingly hard puzzle aspect. Or make the sims like Tamagotchis for replayability. 


The entire SimCity design is based heavily around the fact that there is no “right
answer”. Every option has positive and negative consequences.

"We consistently touted SimCity as a “bottom up” simulation (meaning that the
high level simulation was not predetermined, but happened organically based on the aggregate actions of
each individual citizens). However the entire design process was heavily “top down”. We started with this
overview document and over the course of the project continuously drilled down into the details of each
section."

Need a tech tree! Even a simple one!

Resource chains, pg 77: http://www.stonetronix.com/gdc-2013/SimCity-OnePage.pdf

Good resource chains on page 78.

Player unlocks buildings over time. Classic.


Selecting a Region

- Game starts by letting the player select a region

Page 11 shows different road types: http://www.stonetronix.com/gdc-2013/SimCity-OnePage.pdf

# Gameplay Timeline

"This is one of my favorite diagrams from the project. It describes play patterns in more detail and how they
change through time. I strongly believe that every game designer should make a timeline like this early in
the development process. At this phase in the project we didn’t have exact timings figured out, but we can
still approximate it by breaking up the gameplay into early, mid, late and end game phases."

"Most games have a very linear structure, which means that it will be simpler to create a traditonal timeline.
Unfortunately, there is no “right way” to play SimCity which made the process much more difficult. One
timeline can’t represent the thousands of ways that a player can construct a city.

To get around that problem, I decided to show off two extreme cases as book ends. If we can understand
the extremes then we can assume that most cities will be shades of these extremes in varying proportions."


In mid game players are starting to specialize.


Remember that your designs don’t need to be complex to be effective. They only need
to be as complex as the idea you are trying to communicate

Great flow on agents and resources on page 33: http://www.stonetronix.com/gdc-2013/SimCity-OnePage.pdf

Agent types:

- workers
- commuters
- shoppers

Buildings:

- factories
- stores
- houses
- (also offices)
- and others


Another good sim flow on page 38: http://www.stonetronix.com/gdc-2013/SimCity-OnePage.pdf





MAXIS SIM
GAME REQUIREMENTS


SUMMARY

The Maxis marketing department recently studied customer expectations
of Maxis Sim games. The study revealed seven descriptions of what the
Maxis Sim player thought a Sim game should be. While the “Seven Points
of Sim” descriptions reflect customer expectations, they are not all
necessarily the ingredients for a Sim game. To understand why Sim
players perceive Sim games the way they do, we can look at the key
factors that make a game a “Sim”.

REQUIREMENTS FOR A MAXIS SIM GAME

Dilemma

Players must always grapple with difficult decisions. In SimCity, pollution
may be a problem, but there might be a strong industrial demand. In
SimTower, condo-dwellers will need elevators heading down, while office
workers will need elevators heading up.

Crisis

Crisis can also mean disasters. Players occasionally need to abandon
long term strategy in favor of short-term success. If a fire is burning in
SimCity or SimTower, players might need to destroy all their creations in
the surrounding area.

Budgeting

The amount of funding a player has acts as both a limiting factor and a
kind of score. Every action by the player costs money - even mistakes -
and there are no refunds. “Cheats” to gain more money are the most
popular cheats.

Aesthetics

Artwork is important for players to admire their creations. Also, the ability
to place buildings, zones, crops, etc. in various places that may not have
relevance to the Sim, fakes players into believing that their city or tower
designs are “better” than other’s. Finally, aesthetics are a form of reward
for the player. In SimTower, an aesthetic reward for reaching the 100th
floor is the ability to place a cathedral. This is akin to “winning”.

Change in Rules over Time

Rule changes cause players to change their playing strategy. In SimCity,
demand for Industry is high at first, but then swings to Commerce. In 


SimTower, the placement of condos is important at first, but nearly
irrelevant after the 3rd Star.

Visual/Graphical Feedback

A Simulator is nothing but formulae operating on a data set. The player’s
main interpretation of the change in data is graphical, in the form of tall
buildings in SimCity, and long elevator lines in SimTower. An example
failure in graphical feedback is Outpost from Sierra, where player
feedback is in the form of numbers in a dialog box.

Cause & Effect are not Immediately Apparent

Because of the interleaving data sets in the simulators, players may not
initially understand why certain actions have unexpected effects. One of
the compelling reasons to play is to discover and understand various
causes and effects.

Players are allowed to destroy their Creations

Who says there is no violence in Sim games? A favorite activity of the
Sim player is to save a “masterpiece” copy of their creation, then unleash
disaster after disaster, and bulldoze like crazy.

https://donhopkins.com/home/TheSimsDesignDocuments/

http://www.stonetronix.com/gdc-2013/SimCity-OnePage.pdf



# Simulating a Sim City

- Starting Out

- Harvesting Resources

- Simulating a City

- Trading with Neighbors

- Constructing Buildings

- Manufacturing Goods

- Global Markets




# Set up production ready project to do

- touch screen mobile controls, guided camera

- green landscape with trees as starting point

- splash screen

- menu screen

- music playing for game start

- building roads
  - roads can detect if they're placed down correctly with the slightly larger physics colliders, can have a front facing physics collider, and a back facing physics collider
  - if a back and a front, or a back, and a back (since tiles can be rotated touches), we can place a road there
  - player can also make an intersection, or a curved road, which is a separate tile for now, ease of use
  
- once roads are built we want to populate traffic

- once roads are built we can build other structures that have to be touching or within area of the roads

- those are the major things

- now to fine tune gameplay:




# Production To Do

- Logo
- Games studio splash screen
- Game menu
- Score
- SFX
- Apple / Android publishing guidelines


# Art

Takes care of all models: https://sketchfab.com/3d-models/voxel-city-d6a64ed19ee842ac8a4f4e4c1fef293b


