using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Start or quit the game
/// </summary>
public class GameOverScript : MonoBehaviour
{
  private GUISkin skin;

  void Start()
  {
    skin = Resources.Load("GUISkin") as GUISkin;
  }

  void OnGUI()
  {
    const int buttonWidth = 140;
    const int buttonHeight = 60;

    GUI.skin = skin;

    if (GUI.Button(
      // Center in X, 1/3 of the height in Y
      new Rect(Screen.width / 2 - (buttonWidth / 2), (1 * Screen.height / 3) - (buttonHeight / 2), buttonWidth, buttonHeight),
      "RETRY"
      ))
    {
      // Reload the level
			MenuScript.Tracking.Track("RETRIED",new Dictionary<string,string>(){{"looser","has not given up"}});

      Application.LoadLevel("Stage1");
    }

    if (GUI.Button(
      // Center in X, 2/3 of the height in Y
      new Rect(Screen.width / 2 - (buttonWidth / 2), (2 * Screen.height / 3) - (buttonHeight / 2), buttonWidth, buttonHeight),
      "BACK"
      ))
    {
      // Reload the level
      Application.LoadLevel("Menu");
    }
  }
}