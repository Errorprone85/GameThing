using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MenuSetup : MonoBehaviour
{
	public static List<Texture2D> buildingIconTextures = new List<Texture2D>();
	public static List<Texture2D> buildingUnitTextureRollover = new List<Texture2D>();
	public Texture2D iconContainer;

	private GUIStyle container = new GUIStyle ();

	void OnGUI()
	{
		container.normal.background = iconContainer;	// sets the default background of the container

		// create main GUI box
		GUI.Box (new Rect (Screen.width - 100, Screen.height - 200, 100, 200), "", container);

		// creates GUI buttons
		// SlideMenu method takes the name of the button as an argument and creates a contextual menu based on that
		if (GUI.Button (new Rect(Screen.width - 100, Screen.height - 80, 100, 30), "?"))
		{
			print("?");
		}
		if (GUI.Button (new Rect(Screen.width - 100, Screen.height - 120, 100, 30), "Resources"))
		{
			print ("Resources");
		}
		if (GUI.Button (new Rect(Screen.width - 100, Screen.height - 160, 100, 30), "Barracks"))
		{
			print ("Barracks");
		}
		if (GUI.Button (new Rect(Screen.width - 100, Screen.height - 200, 100, 30), "Towers"))
		{
			 print ("Towers");
		}
	}
}
