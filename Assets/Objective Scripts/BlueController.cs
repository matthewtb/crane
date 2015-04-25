using UnityEngine;
using System.Collections;

public class BlueController : MonoBehaviour {

	// Use this for initialization
	public GameObject BlueBox;
	
	void OnTriggerEnter(Collider col){
		BlueBox = GameObject.Find ("BlueBoxWrapper");
		
		if (col.gameObject.name == "BlueCenterTent") {
			BlueBox.gameObject.renderer.material.color = Color.blue;
			BlueBox.AddComponent("BlueMovement");
		}
	}
	
	void Start () {
		BlueBox = GameObject.Find ("BlueBox");
		BlueBox.gameObject.renderer.material.color = Color.red;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
