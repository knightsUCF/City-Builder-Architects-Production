# 08 / 16 / 2019


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
