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

* create ability to make a pond or small lake, that we can put in the center of a development, this way the player gets a "waterfront" bonus to their houses, and they bring him in more rent, each house brings the player a certain number of rent every game cycle, this will also give nice inherent emergent constrution where the player will build houses around a lake like a real suburban neighborhood, of course the player doesn't have to do this, but they will earn more money, though at the cost of more space, we would also rather have the lake be toward the back of a house, we can simply make the lake work by having colliders on the lake so there has to be a fair distance from the lake and a structure, (we can call this a retention pond), and then have a proximity bonus on the lake, that hands out bonuses, perhaps we first see this bonus when the lake is built, some sort of particle effect

* create ability to purchase land (unlock tiles) 

* eventually we will want to generate an extra worker at the employment office or use an idle worker to go explore the fog of war, at first we will not be able to see what the other player is doing because they will be shrouded in a fog of war, not until we send out a worker and explore the area will the fog of war lift, and this is very useful for disguising the first few minutes of what the player is doing for their strategy, because then the game would feel like rock paper scissors too quickly

* create build shortcuts, such as H for house, although might save this for a later version in early access, perhaps we would allow the worker to create their own shortcuts, also if we hover over a structure for a while, let's reveal a pop up panel to the side of the bar, perhaps on the right, or right above, a panel to show the info on the structure

* not sure if should use save mode for early access, probably need save mode for MVP

* will also need an in game chat for multiplayer, and team mode, also a way to message opponents (global), or to message team mates, perhaps we can reveal the chat with a space bar, and then close the chat with something other than a space bar, space bar should be used to just open chat

* create a complete state logging solution for sending back the game state when a player wins, we will need this to balanace, the game, so check how fast they won, how many resources they had starting out, starting class, the progression of their resources, the number of the different buildings they built, etc, send this back on the server which will not be a problem, since the server will run the gameplay

* set up AWS server: https://www.reddit.com/r/gamedev/comments/cqvkx0/so_we_built_our_own_worldwide_matchmaking_system/

https://medium.com/plapadoo/spawning-game-servers-on-aws-a391ca78e4ee

They used Fargate to minimize server costs, since server is just booted up when the multiplayer game starts

More in the multiplayer folder

* rotate buildings on build

* night cycle, game time (turn night cycle off in features)

* save mode
