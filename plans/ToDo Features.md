# ToDo Features

* task of the AI building on snap to grid

* create large box colliders for trees and the mountains, also change color of building block to signify we can't build there

* don't allow building over other buildings, and within the area perimeter

* any worker can build, unless they are inside a building working, then we first have to make them leave the building, before we can click on them to reveal the panel

* create some random people for both AI and player, color code them white or gray, these guys are just walking around, perhaps sometimes they go into a house, just to give illusion other people live there, but they are not workers, workers can only be generated from the employment office

* create difficulty level in the game settings screen, when we create a new game, let's go through this screen first, perhaps we could have a slider from 1 to 10 for difficulty, when the slider gets to 3 the caption changes to "Medium" when the slider moves past value 6, the caption changes to "Hard", so the player can have up to 10 modes. 

* create building rotation

* shake the trees when chopping

* deplete the trees

* set huge box collider on all the trees, and set the individual ones to inactive to save on processing

* then have a ResourceDepletionManager activate the relevant box colliders so we don't activate them all at once

* let's find the wood's position by tag - in the future we should find the closest one out of the array, also on the wood resource if they've been harvested, then take them out of the array, use "FindGameObjectsByTag" to put multiple game objects into the array

* create pause mode (slow down game time to zero)

* create ability to make a pond or small lake, that we can put in the center of a development, this way the player gets a "waterfront" bonus to their houses, and they bring him in more rent, each house brings the player a certain number of rent every game cycle, this will also give nice inherent emergent constrution where the player will build houses around a lake like a real suburban neighborhood, of course the player doesn't have to do this, but they will earn more money, though at the cost of more space

* create ability to purchase land (unlock tiles) 
