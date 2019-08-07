# City-Builder-Architects-Production


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


