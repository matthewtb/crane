using UnityEngine;
using System.Collections;

public class elevatorUp : MonoBehaviour {
            
	public int speed = 100;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.up * speed * Time.deltaTime);
	}

	void OnCollisionEnter (Collision col)
	{
		transform.Translate(Vector3.up * 0 * Time.deltaTime);
		speed = 0;
	}

	//when user selects up arrow, cart moves up
		//when moving up, arrow is turned red
		//the stop arrow will still stop the simulation
		//sound of the cart moving
	//upon colliding with the first level
		//the movement will stop
		//the arrow will turn green again
		//cart moving sounds will stop
}
