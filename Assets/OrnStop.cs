using UnityEngine;
using System.Collections;

public class OrnStop : MonoBehaviour {

	public GameObject BlueBox;
	public GameObject GreenBox;
	public GameObject Gbox;
	public GameObject Box;
	
	void OnTriggerEnter(Collider col){
		BlueBox = GameObject.Find ("BlueBoxWrapper");
		Box = GameObject.Find ("BlueBox");
		GreenBox = GameObject.Find ("GreenBoxWrapper");
		Gbox = GameObject.Find ("GreenBox");
		
		if (col.gameObject.name == "BlueBox") {
			Box.gameObject.renderer.material.color = Color.gray;
			Destroy (BlueBox.GetComponent("BlueController"));
			Destroy(BlueBox.GetComponent("BlueMovement"));
		}

		if (col.gameObject.name == "GreenBox") {
			Box.gameObject.renderer.material.color = Color.gray;
			Destroy (GreenBox.GetComponent("GrnController"));
			Destroy(GreenBox.GetComponent("GrnMovement"));
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
