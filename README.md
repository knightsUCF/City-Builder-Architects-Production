# City-Builder-Architects-Production


alchemists.


Also study Alhambra, plus expansion.

Really study Peurto Rico for the classic elements.

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


