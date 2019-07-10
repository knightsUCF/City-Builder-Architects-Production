07 / 10 


- finalize building
  - add check mark and x, for options
  - x will clear out the build selection
- add carrot snap sound to the build icon
- possibly add drag over grid sounds
- add gamestate to Data.cs (instead of events for now
  - gamestate.building
  - during building game state, we will disable the zoom and pan
- add a way to destroy the built game object
- for later: instead of checking state on everyupdate, use an event to send this out for the camera to toggle between build mode and placement mode
- we will also want some way later to adjust the camera while we are building, so don't let the building move around, while we are moving the camera around, one crude way is to provide a camera toggle when we are building, there might be a better way


07 / 11

- fine tune build code
- allow for placing different colored cubes


07 / 12

- build roads, we want to build a few roads concurrently, so will need separate ruleset, perhaps even make a separate BuildRoads class to decouple code and keep things simple, or until figure out where the difference between the two lies, and toggle that for road building


07 / 13

- impose build constraints with colliders
- we can only build cubes within some x distance of a road 
