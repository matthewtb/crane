using UnityEngine;
using System.Collections;

public class BlueController : MonoBehaviour {

	// Use this for initialization
	public GameObject BlueBox;
	public bool hitter = true;
	
	void OnTriggerEnter(Collider col){
		if (hitter == true) {

			BlueBox = GameObject.Find ("BlueBoxWrapper");
			
			if (col.gameObject.name == "BlueCenterTent") {
				hitter = false;
				BlueBox.AddComponent("BlueMovement");
			}
		}
	}
	
	void Start () {
		hitter = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
