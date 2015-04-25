using UnityEngine;
using System.Collections;

public class ballAndRope : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A)) {
			transform.localPosition += transform.up * 30 * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.S)) {
			transform.localPosition += transform.up * -30 * Time.deltaTime;
		}
	}
}
