using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MenuSetup : MonoBehaviour
{
	public static List<Texture2D> buildingIconTextures = new List<Texture2D>();
	public static List<Texture2D> buildUnitTextureRollover = new List<Texture2D>();
	public Texture2D iconContainer;

	void OnGUI()
	{
		GUIStyle container = new GUIStyle ();

		container.normal.background = iconContainer;

		GUI.Box (new Rect (Screen.width - 100, Screen.height - 200, 100, 200), "Stuff", container);
	}
}
