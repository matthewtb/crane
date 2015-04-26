using UnityEngine;
using System.Collections;

public class GrnMovement : MonoBehaviour {
	public GameObject gren;
	// Use this for initialization
	void Start () {
		gren = GameObject.Find ("GreenBoxWrapper");
	}
	
	// Update is called once per frame
	void Update () {
		for ( uint i = 0; i < 2; i++ )
		{
			if ( SixenseInput.Controllers[i] != null )
			{
				uint controllerNumber = i + 1;
				if (SixenseInput.Controllers[1].JoystickX < 0) {
					transform.RotateAround(Vector3.zero, Vector3.down, -(SixenseInput.Controllers[1].JoystickX) * 20 *Time.deltaTime);
				}
				if (SixenseInput.Controllers[1].JoystickX > 0) {
					transform.RotateAround(Vector3.zero, Vector3.up, (SixenseInput.Controllers[1].JoystickX) * 20 *Time.deltaTime);
				}
				if (SixenseInput.Controllers[1].JoystickY > 0) {
					
					gren.gameObject.transform.Translate(transform.forward * (Time.deltaTime * (-30 * SixenseInput.Controllers[1].JoystickY)),Space.World);
					
				}
				if (SixenseInput.Controllers[1].JoystickY < 0) {
					
					gren.gameObject.transform.Translate(transform.forward * (Time.deltaTime * (30 * -(SixenseInput.Controllers[1].JoystickY))),Space.World);
					
				}
				if (SixenseInput.Controllers[0].JoystickY > 0) {
					transform.localPosition += transform.up * 30 * Time.deltaTime;
				}
				if (SixenseInput.Controllers[0].JoystickY < 0) {
					transform.localPosition += transform.up * -30 * Time.deltaTime;
				}
			}
		}
	}
}