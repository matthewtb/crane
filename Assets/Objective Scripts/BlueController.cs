using UnityEngine;
using System.Collections;

public class BlueController : MonoBehaviour {

	// Use this for initialization
	public GameObject BlueBox;
	
	void OnTriggerEnter(Collider col){
		BlueBox = GameObject.Find ("BlueBoxWrapper");
		
		if (col.gameObject.name == "BlueCenterTent") {

			BlueBox.AddComponent("BlueMovement");
		}
	}
	
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
