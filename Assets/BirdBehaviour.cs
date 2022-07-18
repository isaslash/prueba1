using UnityEngine;
using System.Collections;

public class BirdBehaviour : MonoBehaviour {
	public float speed;
	public float rotationSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		move ();
	}
	void move ()
	{
		if (Input.GetKey (KeyCode.A))
			transform.Rotate (-Vector3.forward * speed * Time.deltaTime);
		if (Input.GetKey (KeyCode.D))
			transform.Rotate (Vector3.forward * speed * Time.deltaTime);
		if(Input.GetKey (KeyCode.W))
			transform.position += transform.forward * speed * Time.deltaTime;
			
	}
}
