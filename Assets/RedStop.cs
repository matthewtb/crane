using UnityEngine;
using System.Collections;

public class RedStop : MonoBehaviour {

	public GameObject GreenBox;
	public GameObject Box;
	public GameObject BlueBox;
	public GameObject Bbox;
	
	void OnTriggerEnter(Collider col){
		GreenBox = GameObject.Find ("GreenBoxWrapper");
		Box = GameObject.Find ("GreenBox");
		BlueBox = GameObject.Find ("BlueBoxWrapper");
		Bbox = GameObject.Find ("BlueBox");
		
		if (col.gameObject.name == "GreenBox") {
			Box.gameObject.renderer.material.color = Color.gray;
			Destroy (GreenBox.GetComponent("GrnController"));
			Destroy(GreenBox.GetComponent("GrnMovement"));
		}

		if (col.gameObject.name == "BlueBox") {
			Bbox.gameObject.renderer.material.color = Color.gray;
			Destroy (BlueBox.GetComponent("BlueController"));
			Destroy(BlueBox.GetComponent("BlueMovement"));
		}
	}

	void Start () {
		GreenBox = GameObject.Find ("GreenBoxWrapper");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
