using UnityEngine;
using System.Collections;

public class GrnController : MonoBehaviour {

	public GameObject GreenBox;

	void OnTriggerEnter(Collider col){
		GreenBox = GameObject.Find ("GreenBoxWrapper");

		if (col.gameObject.name == "GreenCenterTent") {
				GreenBox.gameObject.renderer.material.color = Color.blue;
				GreenBox.AddComponent("GrnMovement");
		}
	}

	void Start () {
		GreenBox = GameObject.Find ("GreenBox");
		GreenBox.gameObject.renderer.material.color = Color.red;
	}
	
	// Update is called once per frame
	void Update () {

	}
}
