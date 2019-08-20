* add the rest of the buildings in the build panel, get building working

* set them against a dark background and then simply take a screenshot png for now, use an on screen center market to get the consistent angle

* when we click on a store let's bring up a panel with the goods we can sell at the store

* the goods that we select, perhaps with a simple selection box for now, will be the goods we will be selling

* we will also need a global market panel, which will include wood, and power, electronics, etc, maybe for now we can have just one large panel, the goods which can be sold at the store will be above, or perhaps we don't have to make the resources fluctuate in value for now

* also have the AI build a store, and select a few goods to sell

* when we place the power plant, allow the worker to go work there, and start leveling up the worker and then power plant energy production

* create a win condition by selling the right kind of goods



///////////////////////////////////////////////////////////////////


# 1) Building Different Structures

* add code to instantiate another prefab, do this for a few buildings, or for all

# 2) Store Panel

* like the code in the Employment Office, bring up a panel when clicked for selling goods

* create an "Art" folder for the png icons of goods off the Internet

* create a simple transparanet panel that gets put over the selected icons, structures

* each panel can have a numerical reference point, if panel 1 is togged, then we are selling bananas, etc

* we will have electronics represented by chips

* the question is whether we want to have separate stores, perhaps a store can sell goods in a range of items, so electronics can't be sold with bananas

* have some sort of basic supply and demand mechanism

# 3) Placing Workers

* place workers at power plant, they begin generating power, and start leveling up their engineering level

* also worker will disapear right outside structure when entering, turn off their parent prefab to inactive, and deselect them so they cannot be moved, when a player exits a worker by clicking on the building's panel functionality, we will activate the worker near the entrance of the building

* we would like to be able to click on the building, get the stats on the worker there, their updated level namely


# 3.3) Before moving on to further features

* generate more workers

* have them level up separately at different structures

* allow placing a worker at a store, and level up their commerce skill

* create a hover over icon over the pie charts for detailed numbers

* create a hover over panel over the factory and store to view which workers are there (maybe just one worker for now), and check out their worker level, and whether there is a worker there, need a panel with a worker icon, and worker level, also show the worker's name, for this we need to figure out how to grab the worker reference and attach that to the factory, perhaps we can simply do this with GameObject worker = invisible worker

# 4) Further Features

* go through GDDs and outline desired game features, such as purchasing land


# 5) After Further Featerures are Implemented

* traffic




/////////////////////////////////////////////////////////////////////













* create a simple on screen log of what the AI is doing, a nice log would have some kind of scroll, or perhaps we can just move up the last two messages to the upper two

* create a few houses for the AI, will run into the order of the event building problem, and also will need to set aside later task of the AI building on snap to grid

* create a simple win condition

* create ability to build stores

* once we click on stores show a panel of what we can sell (find some nice graphics for this)

* for now make the simplest possible solution, so out of all the items we can select 2 items to sell 

* create a global market condition with the AI also selling items

* create ability to buy and sell goods, there will be the goods that we manufacture that we can sell, and then there will be global market goods we can buy, review Offworld Trading Company for this

* create a new win condition based on the demand and supply of the market, maybe based on whoever reaches an x amount of money

* create a nice building panel menu, maybe at the bottom of the screen, somehow nicely flowing with the resources count

* this panel will show all the available buildings we can build set against a black panel

* create the basic types, house 1, 2, 3, store, office building, etc, for now just have all the types on one panel, later we will subdivide them to show by type, so if you click on the house you get all the house types, etc

* one simple way of creating a build panel, is to place the panel right above the resource panel, aligned to the left, and make the build panel shorter then the bottom resource panel and wider, create a gray small panel line to separate the two, Cities Skylines went through many iterations, and just something with an assortment of black rectangular panels

* this pane would show up whenever we click on a worker, any worker can build, unless they are inside a building working, then we first have to make them leave the building, before we can click on them to reveal the panel

* nice color for the background frame panel of the market panel: C7FF92

# ToDo

* task of the AI building on snap to grid

* create large box colliders for trees and the mountains, also change color of building block to signify we can't build there

* don't allow building over other buildings, and within the area perimeter

* any worker can build, unless they are inside a building working, then we first have to make them leave the building, before we can click on them to reveal the panel

* create some random people for both AI and player, color code them white or gray, these guys are just walking around, perhaps sometimes they go into a house, just to give illusion other people live there, but they are not workers, workers can only be generated from the employment office

* create difficulty level in the game settings screen, when we create a new game, let's go through this screen first, perhaps we could have a slider from 1 to 10 for difficulty, when the slider gets to 3 the caption changes to "Medium" when the slider moves past value 6, the caption changes to "Hard", so the player can have up to 10 modes. 

* create building rotation

# Bugs

* investigate workers moving through buildings, need to add collider, and figure out "carving" navmesh issue
