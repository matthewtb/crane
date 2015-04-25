using UnityEngine;
using System.Collections;

public class RedStop : MonoBehaviour {

	public GameObject GreenBox;
	public GameObject Box;
	
	void OnTriggerEnter(Collider col){
		GreenBox = GameObject.Find ("GreenBoxWrapper");
		Box = GameObject.Find ("GreenBox");
		
		if (col.gameObject.name == "GreenBox") {
			Box.gameObject.renderer.material.color = Color.gray;
			Destroy (GreenBox.GetComponent("GrnController"));
			Destroy(GreenBox.GetComponent("GrnMovement"));
		}
	}

	void Start () {
		GreenBox = GameObject.Find ("GreenBoxWrapper");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
