using UnityEngine;
using System.Collections;

public class ballAndRope : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		for ( uint i = 0; i < 2; i++ )
		{
			if ( SixenseInput.Controllers[i] != null )
			{
				uint controllerNumber = i + 1;
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
