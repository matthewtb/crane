using UnityEngine;
using System.Collections;

public class trackAndBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.localPosition += transform.forward * -10 * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.UpArrow)) {

		}
	}
}
