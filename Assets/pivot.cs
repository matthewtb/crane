using UnityEngine;
using System.Collections;

public class pivot : MonoBehaviour {

	public GameObject boxx;
	public GameObject rope;
	public GameObject ball;
	public bool near = true;
	public bool far = true;


	void Start () {
		boxx = GameObject.Find ("box");
		rope = GameObject.Find ("crane_rope");
		ball = GameObject.Find ("crane_ball");
	}

	void OnCollisionEnter (Collision col){
		Debug.Log ("collision works");
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
				boxx.gameObject.renderer.material.color = Color.red;
					boxx.gameObject.transform.Translate(transform.forward * (Time.deltaTime * (-30 * SixenseInput.Controllers[1].JoystickY)),Space.World);
					rope.gameObject.transform.Translate(transform.forward * (Time.deltaTime * (-30 * SixenseInput.Controllers[1].JoystickY)),Space.World);
					ball.gameObject.transform.Translate(transform.forward * (Time.deltaTime * (-30 * SixenseInput.Controllers[1].JoystickY)),Space.World);
					}
				if (SixenseInput.Controllers[1].JoystickY < 0) {
				boxx.gameObject.renderer.material.color = Color.blue;
					boxx.gameObject.transform.Translate(transform.forward * (Time.deltaTime * (30 * -(SixenseInput.Controllers[1].JoystickY))),Space.World);
					rope.gameObject.transform.Translate(transform.forward * (Time.deltaTime * (30 * -(SixenseInput.Controllers[1].JoystickY))),Space.World);
					ball.gameObject.transform.Translate(transform.forward * (Time.deltaTime * (30 * -(SixenseInput.Controllers[1].JoystickY))),Space.World);
					}
			}
		}
	
	}
}

