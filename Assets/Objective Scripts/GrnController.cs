using UnityEngine;
using System.Collections;

public class GrnController : MonoBehaviour {

	public GameObject GreenBox;

	void OnTriggerEnter(Collider col){
		GreenBox = GameObject.Find ("GreenBoxWrapper");

		if (col.gameObject.name == "GreenCenterTent") {
				
				GreenBox.AddComponent("GrnMovement");
		}
		/*if (col.gameObject.name == "landing zone 1") {
			GreenBox.gameObject.renderer.material.color = Color.gray;
			Destroy(GetComponent("GrnController"));
		}*/
	}
	void Start () {
		GreenBox = GameObject.Find ("GreenBox");

	}
	
	// Update is called once per frame
	void Update () {

	}
}
