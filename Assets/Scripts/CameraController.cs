using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
	public int camSpeed = 10;	// universal generic camera control speed value

	// Update is called once per frame
	void Update ()
	{
		float keyboardX = Input.GetAxis ("Horizontal");
		float keyboardY = Input.GetAxis("Vertical");
		float mouseX = Input.mousePosition.x;
		float mouseY = Input.mousePosition.y;

		int scrollDistance = 5;	// distance from edge of screen where mouse cursor will start moving the viewport

		transform.Translate (keyboardX * camSpeed, 0, keyboardY * camSpeed);	// WASD controls for keyboard movement of camera

		// mouse scroll controls
		if (mouseX < scrollDistance)
		{
			transform.Translate(-1 * camSpeed, 0, 0);
		}
		if (mouseX >= Screen.width - scrollDistance)
		{
			transform.Translate (1 * camSpeed, 0, 0);
		}
		if (mouseY < scrollDistance)
		{
			transform.Translate (0, 0, -1 * camSpeed);
		}
		if (mouseY >= Screen.height - scrollDistance)
		{
			transform.Translate (0, 0, 1 * camSpeed);
		}
	}
}
