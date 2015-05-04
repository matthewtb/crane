using UnityEngine;
using System.Collections;

public class ballAndRope : MonoBehaviour {
	
	public bool top = true;
	public bool flo = true;
	public GameObject floorObject;
	public GameObject topBoxObject;
	public GameObject craneBall;
	public Vector3 positionB;
	public Vector3 positionF;
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

	public bool nearTop = false;

	// Use this for initialization
	void Start () {
		topBoxObject = GameObject.Find ("box");
		floorObject = GameObject.Find ("ground");
		craneBall = GameObject.Find ("crane_ball");

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
	
	// Update is called once per frame
	void Update () {
		
		positionB = topBoxObject.gameObject.transform.position;
		positionF = floorObject.gameObject.transform.position;
		positionBall = craneBall.gameObject.transform.position;

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
		
		if ((positionB - positionBall).magnitude < 10) {
			top = false;
		}
		if ((positionB - positionBall).magnitude > 10) {
			top = true;
		}
		
		if ((positionB - positionBall).magnitude < 250) {
			flo = true;
		}
		if ((positionB - positionBall).magnitude > 230) {
			flo = false;
		}

		//ALGO for building bubble position
		if ((bub1pos - positionBall).magnitude < 80 || (bub1apos - positionBall).magnitude < 80 || (bub1bpos - positionBall).magnitude < 80 || (bub2pos - positionBall).magnitude < 80 || (bub2apos - positionBall).magnitude < 80 || (bub14pos - positionBall).magnitude < 80 || (bub3pos - positionBall).magnitude < 80 || (bub4pos - positionBall).magnitude < 80 || (bub5pos - positionBall).magnitude < 80 || (bub6pos - positionBall).magnitude < 80 || (bub7pos - positionBall).magnitude < 80 || (bub8pos - positionBall).magnitude < 80 || (bub9pos - positionBall).magnitude < 80 || (bub10pos - positionBall).magnitude < 80 || (bub11pos - positionBall).magnitude < 80 || (bub12pos - positionBall).magnitude < 80 || (bub13pos - positionBall).magnitude < 80) {
			nearTop = true;
		}	
		else {
			nearTop = false;
		}
		
		if ((SixenseInput.Controllers[0].JoystickY > 0) && top == true) {
			transform.localPosition += transform.up * 30 * Time.deltaTime;
		}
		if ((SixenseInput.Controllers[0].JoystickY < 0) && flo == true && nearTop == false) {
			transform.localPosition += transform.up * -30 * Time.deltaTime;
		}
	}
}
