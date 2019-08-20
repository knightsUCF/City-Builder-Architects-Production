# Bugs

* investigate workers moving through buildings, need to add collider, and figure out "carving" navmesh issue

* Adding fog revealed box below selector, get rid of

* Selector working even though worker is not selected, only activate once worker is selected

* Only show the selection worker box once we click on the worker

* Also add deselect ability, so we can for example move around in the map without moving workers

* When we will be able to deselect workers then also hide the build panel for each worker

* Prevent the worker from moving toward the button UI when clicked, if can’t recognize clicking on buttons, can create an invisible panel there with the mesh turned off, so we could if the tag != invisible panel, as one of the conditions added to moving the worker

* When entering set building position mode, then stop moving the worker, because the worker will move to where we want to move the cube around

* For now double tapping works well, especially with slightly larger objects, but perhaps will need to also create a confirm checkmark option also to help users

* Selecting the worker and moving them away while gathering wood, break the wood gathering process

* Will need a separate LumberMill.cs for AI, so that the worker doesn't deliver the lumber to the AI, so LumberMillAI.cs

* For some reason the worker keeps walking instead of stopping at idle, after we deliver the wood and then turn back at the lumber mill

* All AI workers drop off wood together, the first drop off accesses the wood harvest ai component on all workers, and then clears out those values, so we should only access the components on the individual workers

* when workers are placed into a building, they leave behind their selector

* we want to adjust the level on the worker when they are leveling up, maybe we just need some sort of reference

* sometimes the worker gets blocked and doesn't keep moving to the selected destination, to fix this observe the vector3 of the destination

* failed to compute ray on camera -- if this somehow happens we should have a fail safe method to set the camera back to the nearest edge, or limit the camera movement outside of this to prevent crashing the game
