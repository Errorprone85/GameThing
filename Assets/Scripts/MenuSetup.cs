using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MenuSetup : MonoBehaviour
{
	public static List<Texture2D> buildingIconTextures = new List<Texture2D>();
	public static List<Texture2D> buildingUnitTextureRollover = new List<Texture2D>();
	public Texture2D iconContainer;

	void OnGUI()
	{
		string[] buttonNames = { "?", "Barracks", "Resources", "Towers" };	// List of names to be used by the main buttons
		GUIStyle container = new GUIStyle ();

		container.normal.background = iconContainer;	// sets the default background of the container

		// create main GUI box
		GUI.Box (new Rect (Screen.width - 100, Screen.height - 200, 100, 200), "", container);

		// set the initial position of the GUI buttons
		int y = 80;

		// creates GUI buttons
		for (int i = 0; i < 4; i++)
		{
			GUI.Button (new Rect (Screen.width - 100, Screen.height - y, 100, 30), buttonNames[i]);
			y = y + 40;
		}
	}
}
