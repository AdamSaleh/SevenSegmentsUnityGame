using UnityEngine;
using System.Collections.Generic;
/// <summary>
/// Title screen script
/// </summary>
public class MenuScript : MonoBehaviour
{
  private GUISkin skin;

	public static SevenSegments.SevenSegments Tracking; 
  void Start()
  {
		Debug.Log("STARTING");
		Tracking = new SevenSegments.SevenSegments("d5b474ce-61b8-11e4-8f55-0cc47a049482","https://api.7segments.com",
	                                           "testplayer000004");
		Debug.Log("IDENTIFYING");
		Tracking.Identify (
			"testplayer000004",new Dictionary<string,string> () {{"email","player4@b.com"}});

    skin = Resources.Load("GUISkin") as GUISkin;
  }

  void OnGUI()
  {
    const int buttonWidth = 128;
    const int buttonHeight = 60;

    GUI.skin = skin;

    // Draw a button to start the game
    if (GUI.Button(
      // Center in X, 2/3 of the height in Y
      new Rect(Screen.width / 2 - (buttonWidth / 2), (2 * Screen.height / 3) - (buttonHeight / 2), buttonWidth, buttonHeight),
      "START"
      ))
    {
		//	MenuScript.Tracking.Track("started");
      // On Click, load the first level.
      Application.LoadLevel("Stage1"); // "Stage1" is the scene name
    }
  }
}