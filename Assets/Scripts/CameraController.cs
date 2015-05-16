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
		int scrollDistance = 5;

		transform.Translate (keyboardX * Time.deltaTime * camSpeed, 0, keyboardY * Time.deltaTime * camSpeed);	// WASD controls for keyboard movement of camera

		// mouse scroll controls
		// work in progress
		if (mouseX < scrollDistance)
		{
			transform.Translate(-1, 0, 0);
		}
		if (mouseX >= Screen.width - scrollDistance)
		{
			transform.Translate (1, 0, 0);
		}
		if (mouseY < scrollDistance)
		{
			transform.Translate (0, 0, -1);
		}
		if (mouseY >= Screen.height - scrollDistance)
		{
			transform.Translate (0, 0, 1);
		}
	}
}
