using UnityEngine;
using System.Collections;

public class GrnController : MonoBehaviour {

	public GameObject GreenBox;
	public bool hitter = true;

	void OnTriggerEnter(Collider col){

		if (hitter == true) {

			GreenBox = GameObject.Find ("GreenBoxWrapper");
			
			if (col.gameObject.name == "GreenCenterTent") {
				hitter = false;
				GreenBox.AddComponent("GrnMovement");
			}

		}
	}
	void Start () {
		GreenBox = GameObject.Find ("GreenBox");
		hitter = true;
	}
	
	// Update is called once per frame
	void Update () {

	}
}
