using UnityEngine;
using System.Collections;

public class IntroMovement : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position += Vector3.right * speed * Time.deltaTime;
	}
}
