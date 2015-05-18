using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
	public int camSpeed = 100;	// universal generic camera control speed value
	public int rotationSpeed = 100;	// public rotation speed of the camera can be set in the editor
	public int zoomSpeed = 100;	// change this to make the camera zoom in and out faster
	public Camera camera;	// needs a camera object assigned to work

	// Update is called once per frame
	void Update ()
	{
		float keyboardX = Input.GetAxis ("Horizontal");
		float keyboardY = Input.GetAxis("Vertical");
		float mouseX = Input.mousePosition.x;
		float mouseY = Input.mousePosition.y;

		keyboardX *= Time.deltaTime;
		keyboardY *= Time.deltaTime;

		int scrollDistance = 5;	// distance from edge of screen where mouse cursor will start moving the viewport

		transform.Translate (keyboardX * camSpeed, 0, keyboardY * camSpeed);	// WASD controls for keyboard movement of camera

		// handles camera keyboard rotation
		if (Input.GetKey(KeyCode.Q))
		{
			transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
		}
		if (Input.GetKey (KeyCode.E))
		{
			transform.Rotate (0, rotationSpeed * Time.deltaTime, 0);
		}

		// mouse scroll controls
		if (mouseX < scrollDistance)
		{
			transform.Translate(-1 * camSpeed * Time.deltaTime, 0, 0);
		}
		if (mouseX >= Screen.width - scrollDistance)
		{
			transform.Translate (1 * camSpeed * Time.deltaTime, 0, 0);
		}
		if (mouseY < scrollDistance)
		{
			transform.Translate (0, 0, -1 * camSpeed * Time.deltaTime);
		}
		if (mouseY >= Screen.height - scrollDistance)
		{
			transform.Translate (0, 0, 1 * camSpeed * Time.deltaTime);
		}

		// camera zoom controls
		if (Input.GetAxis ("Mouse ScrollWheel") > 0)
		{
			camera.fieldOfView -= zoomSpeed * Time.deltaTime;
		}
		if (Input.GetAxis ("Mouse ScrollWheel") < 0)
		{
			camera.fieldOfView += zoomSpeed * Time.deltaTime;
		}
	}
}
