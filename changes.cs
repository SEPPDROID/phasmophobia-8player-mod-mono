//
//
// all the changes in one list. This isnt a compilable csharp file. Im just using this for the syntax highlighting.
// As you can see it was a low effort ctrl+f mod changing all the max player variables i could find
// Modifying games is allot of fun but NEVER EVER steal someones work. NEVER. It's fun to learn how the Unity scripting engine works
// Let me know if i forgot one, it was some time ago... Never knew my low effort mod would reach that many players.
//
//


// change to

// ---

// Constants.cs
// line 10 
public const int serverMaxPlayers = 8;  

// ---

// LobbyManager.cs
// line 181
    if (!info.IsOpen || info.PlayerCount == 8 || !info.IsVisible) 

// line 221
      MaxPlayers = 8,

// ---

// ServerListItem.cs / is optional, only changes the /4 max players to /8 on the lobby Canvas screen (UI).
// line 25
    this.serverPopulation.text = population + "/8";

//---

// MainManager.cs 
// line 224
        MaxPlayers = 8,

// line 239
      MaxPlayers = 8,
	  
// line 275
      MaxPlayers = 8,
		
// ---

// MultiplayerController.cs
// line 40
      MaxPlayers = 8
	  
// ---

	  
//
// This last patch is something im not really sure of... It should be handled better but it works. I havent found any issues with this one... (yet) If you can find a better way then that's more prefferable.
//
// The issue is that players 5 - 8 dont get their ready statement checked, thus preventing the game to load. 
// Note that empty slots always have a ready status
//

// ServerManager.cs
// line 453
        this.startGameButton.interactable = true;
		
// i cant remember if i forgot one. if thats the case let me know.