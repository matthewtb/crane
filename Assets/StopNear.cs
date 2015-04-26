using UnityEngine;
using System.Collections;

public class StopNear : MonoBehaviour {

	public GameObject CraneTop;
	public GameObject TrackBox;
	public GameObject rope;
	public GameObject ball;

	void OnTriggerEnter(Collider col){
		TrackBox = GameObject.Find ("box");
		rope = GameObject.Find ("crane_rope");
		ball = GameObject.Find ("crane_ball");

		
		while (col.gameObject.name == "box") {

			if(Input.GetKey(KeyCode.DownArrow) == true){
				TrackBox.gameObject.renderer.material.color = Color.gray;
				TrackBox.gameObject.transform.Translate(transform.forward * (Time.deltaTime * 0),Space.World);
				rope.gameObject.transform.Translate(transform.forward * (Time.deltaTime * 0),Space.World);
				ball.gameObject.transform.Translate(transform.forward * (Time.deltaTime * 0),Space.World);

				}
			break;
			}

		}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
