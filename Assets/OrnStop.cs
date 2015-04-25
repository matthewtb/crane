using UnityEngine;
using System.Collections;

public class OrnStop : MonoBehaviour {

	public GameObject BlueBox;
	public GameObject Box;
	
	void OnTriggerEnter(Collider col){
		BlueBox = GameObject.Find ("BlueBoxWrapper");
		Box = GameObject.Find ("BlueBox");
		
		if (col.gameObject.name == "BlueBox") {
			Box.gameObject.renderer.material.color = Color.gray;
			Destroy (BlueBox.GetComponent("BlueController"));
			Destroy(BlueBox.GetComponent("BlueMovement"));
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
