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
		if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.RotateAround(Vector3.zero, Vector3.down, 20 *Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			transform.RotateAround(Vector3.zero, Vector3.up, 20 *Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.UpArrow)) {
			
			gren.gameObject.transform.Translate(transform.forward * (Time.deltaTime * -30),Space.World);
			
		}
		if (Input.GetKey(KeyCode.DownArrow)) {
			
			gren.gameObject.transform.Translate(transform.forward * (Time.deltaTime * 30),Space.World);
			
		}
		if (Input.GetKey(KeyCode.A)) {
			transform.localPosition += transform.up * 30 * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.localPosition += transform.up * -30 * Time.deltaTime;
		}
	}
}