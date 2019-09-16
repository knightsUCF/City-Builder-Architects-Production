https://www.youtube.com/watch?v=o5-Y-5Dtg_c


1. Download Steam as a Unity package

2. Import while having the project open

3. Go into finder and check the "steam game id" text file

4. Input game ID found from steam into the first line, and save file

5. The most important file is SteamManager.cs. Make an empty game object "Steam Manager" and drag the SteamManager.cs script as a component here

6. Update the ap ID in Awake() of SteamManager.cs. 480 will be there by default.

7. The SteamManager.cs ensure that the application is launched with steam. If launched outside of Steam will launch back up with Steam.

8. Another important thing is callbacks in Update()


