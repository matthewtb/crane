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
		if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.RotateAround(Vector3.zero, Vector3.down, 20 *Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			transform.RotateAround(Vector3.zero, Vector3.up, 20 *Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.UpArrow) && far == true) {
			boxx.gameObject.renderer.material.color = Color.red;
			boxx.gameObject.transform.Translate(transform.forward * (Time.deltaTime * -30),Space.World);
			rope.gameObject.transform.Translate(transform.forward * (Time.deltaTime * -30),Space.World);
			ball.gameObject.transform.Translate(transform.forward * (Time.deltaTime * -30),Space.World);
		}
		if (Input.GetKey(KeyCode.DownArrow) && near == true) {
			boxx.gameObject.renderer.material.color = Color.blue;
			boxx.gameObject.transform.Translate(transform.forward * (Time.deltaTime * 30),Space.World);
			rope.gameObject.transform.Translate(transform.forward * (Time.deltaTime * 30),Space.World);
			ball.gameObject.transform.Translate(transform.forward * (Time.deltaTime * 30),Space.World);
		}
	}
}
