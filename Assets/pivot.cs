using UnityEngine;
using System.Collections;

public class pivot : MonoBehaviour {
	
	public GameObject boxx;
	public GameObject rope;
	public GameObject ball;
	public GameObject farH;
	public GameObject neaH;
	public bool near = true;
	public bool far = true; 
	public Vector3 positionN;
	public Vector3 positionF;
	public Vector3 positionB;
	public Vector3 positionBall;

	//creation of the building bubbles
	public GameObject bub1;
	public GameObject bub1a;
	public GameObject bub1b;
	public GameObject bub2;
	public GameObject bub2a;
	public GameObject bub3;
	public GameObject bub4;
	public GameObject bub5;
	public GameObject bub6;
	public GameObject bub7;
	public GameObject bub8;
	public GameObject bub9;
	public GameObject bub10;
	public GameObject bub11;
	public GameObject bub12;
	public GameObject bub13;
	public GameObject bub14;

	public Vector3 bub1pos;
	public Vector3 bub1apos;
	public Vector3 bub1bpos;
	public Vector3 bub2pos;
	public Vector3 bub2apos;
	public Vector3 bub3pos;
	public Vector3 bub4pos;
	public Vector3 bub5pos;
	public Vector3 bub6pos;
	public Vector3 bub7pos;
	public Vector3 bub8pos;
	public Vector3 bub9pos;
	public Vector3 bub10pos;
	public Vector3 bub11pos;
	public Vector3 bub12pos;
	public Vector3 bub13pos;
	public Vector3 bub14pos;

	//creation of the crane ball object

	public bool nearBuild = false;
	public bool nearBuildOpp = false;
	
	void Start () {
		boxx = GameObject.Find ("box");
		ball = GameObject.Find ("crane_ball");
		rope = GameObject.Find ("crane_rope");
		ball = GameObject.Find ("crane_ball");
		farH = GameObject.Find ("collide_far");
		neaH = GameObject.Find ("collide_near");
		
		positionB = boxx.gameObject.transform.position;
		positionN = neaH.gameObject.transform.position;
		positionF = farH.gameObject.transform.position;

		//find position of the bubbles
		bub1 = GameObject.Find ("bubble1");
		bub1a = GameObject.Find ("bubble1a");
		bub1b = GameObject.Find ("bubble1b");
		bub2 = GameObject.Find ("bubble2");
		bub2a = GameObject.Find ("bubble2a");
		bub3 = GameObject.Find ("bubble3");
		bub4 = GameObject.Find ("bubble4");
		bub5 = GameObject.Find ("bubble5");
		bub6 = GameObject.Find ("bubble6");
		bub7 = GameObject.Find ("bubble7");
		bub8 = GameObject.Find ("bubble8");
		bub9 = GameObject.Find ("bubble9");
		bub10 = GameObject.Find ("bubble10");
		bub11 = GameObject.Find ("bubble11");
		bub12 = GameObject.Find ("bubble12");
		bub13 = GameObject.Find ("bubble13");
		bub14 = GameObject.Find ("bubble14");

	}
	
	void OnCollisionEnter (Collision col){
		Debug.Log ("collision works");
	}
	
	// Update is called once per frame
	void Update () {
		positionB = boxx.gameObject.transform.position;
		positionN = neaH.gameObject.transform.position;
		positionF = farH.gameObject.transform.position;
		positionBall = ball.gameObject.transform.position;

		//find the positions of the bubbles
		bub1pos = bub1.gameObject.transform.position;
		bub1apos = bub1a.gameObject.transform.position;
		bub1bpos = bub1b.gameObject.transform.position;
		bub2pos = bub2.gameObject.transform.position;
		bub2apos = bub2a.gameObject.transform.position;		
		bub3pos = bub3.gameObject.transform.position;
		bub4pos = bub4.gameObject.transform.position;
		bub5pos = bub5.gameObject.transform.position;
		bub6pos = bub6.gameObject.transform.position;
		bub7pos = bub7.gameObject.transform.position;
		bub8pos = bub8.gameObject.transform.position;
		bub9pos = bub9.gameObject.transform.position;
		bub10pos = bub10.gameObject.transform.position;
		bub11pos = bub11.gameObject.transform.position;
		bub12pos = bub12.gameObject.transform.position;
		bub13pos = bub13.gameObject.transform.position;
		bub14pos = bub14.gameObject.transform.position;

		
		if ((positionF - positionB).magnitude < 10) {
			far = false;
		}
		if ((positionF - positionB).magnitude > 10) {
			far = true;
		}
		
		if ((positionB - positionN).magnitude < 10) {
			near = false;
		}
		if ((positionB - positionN).magnitude > 10) {
			near = true;
		}


		//ALGO for building bubble position
		if ((bub3pos - positionBall).magnitude < 70 || (bub4pos - positionBall).magnitude < 70 || (bub5pos - positionBall).magnitude < 70 || (bub6pos - positionBall).magnitude < 70 || (bub7pos - positionBall).magnitude < 70 || (bub8pos - positionBall).magnitude < 70 || (bub9pos - positionBall).magnitude < 70 || (bub10pos - positionBall).magnitude < 70 || (bub11pos - positionBall).magnitude < 70 || (bub12pos - positionBall).magnitude < 70 || (bub13pos - positionBall).magnitude < 70) {
			nearBuild = true;
		}

		else {
			nearBuild = false;	
		}

		//ALGO for opposite side of the building 
		if ((bub1pos - positionBall).magnitude < 70 || (bub1apos - positionBall).magnitude < 70 || (bub1bpos - positionBall).magnitude < 70 || (bub2pos - positionBall).magnitude < 70 || (bub2apos - positionBall).magnitude < 70 || (bub14pos - positionBall).magnitude < 70) {
				nearBuildOpp = true;
		} 

		else {
			nearBuildOpp = false;
		}

		if ((SixenseInput.Controllers[1].JoystickX < 0) && nearBuild == false) {
			transform.RotateAround(Vector3.zero, Vector3.down, 15 *-(SixenseInput.Controllers[1].JoystickX)*Time.deltaTime);
		}
		if ((SixenseInput.Controllers[1].JoystickX > 0) && nearBuildOpp == false) {
			transform.RotateAround(Vector3.zero, Vector3.up, 15 * SixenseInput.Controllers[1].JoystickX *Time.deltaTime);
		}
		if ((SixenseInput.Controllers[1].JoystickY > 0) && far == true && nearBuild == false && nearBuildOpp == false) {
			boxx.gameObject.renderer.material.color = Color.red;
			boxx.gameObject.transform.Translate(transform.forward * (Time.deltaTime * -25 * (SixenseInput.Controllers[1].JoystickY)),Space.World);
			rope.gameObject.transform.Translate(transform.forward * (Time.deltaTime * -25 * (SixenseInput.Controllers[1].JoystickY)),Space.World);
			ball.gameObject.transform.Translate(transform.forward * (Time.deltaTime * -25 * (SixenseInput.Controllers[1].JoystickY)),Space.World);
		}
		if ((SixenseInput.Controllers[1].JoystickY < 0) && near == true) {
			boxx.gameObject.renderer.material.color = Color.blue;
			boxx.gameObject.transform.Translate(transform.forward * (Time.deltaTime * 25 * -(SixenseInput.Controllers[1].JoystickY)),Space.World);
			rope.gameObject.transform.Translate(transform.forward * (Time.deltaTime * 25 * -(SixenseInput.Controllers[1].JoystickY)),Space.World);
			ball.gameObject.transform.Translate(transform.forward * (Time.deltaTime * 25 * -(SixenseInput.Controllers[1].JoystickY)),Space.World);
		}
	}
}

