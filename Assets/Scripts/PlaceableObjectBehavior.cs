using UnityEngine;
using System.Collections;

/* Work in progress
 * 
 * Currently this script just instantiates an object of the type set in the designer and nothing more.
 * I think it may be beneficial to make a superclass that all the other interactive objects will inherit from
 * since everything will have some similarities like HP, attack power, defense strength, etc. This script is 
 * very temporary and I don't intend for it to be the final script for the job.
 * 
 * To do:
 * 1. Object needs to attach to the cursor
 * 2. Object needs to determine where it is on the terrain object
 * 3. Object should detach from cursor once placed
 * 4. Object should fix itself to the terrain at the point where player positioned it
 * 5. Object should detect whether it is in collision with another objects' dead zone and alert the player
 * 6. Object should expand the building area once placed
 */
public class PlaceableObjectBehavior : MonoBehaviour
{
	public GameObject building;
	public int hp = 100;
	public int atk = 10;
	public int def = 10;
	public int range = 5;
	public int buildRadius = 10;
	public int deadZoneRadius = 5;

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		Vector3 objectPosition = this.transform.position;
		float mouseX = Input.GetAxis ("Mouse X");
		float mouseY = Input.GetAxis ("Mouse Y");

		transform.Translate (mouseX, mouseY, 0);
		transform.position = new Vector3(Mathf.Clamp(transform.position.x, -80f, 80f), Mathf.Clamp(transform.position.y, 12f, 90f), transform.position.z);
	}
}
