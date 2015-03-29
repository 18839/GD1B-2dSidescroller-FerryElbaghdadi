using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public float speed;
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0f, speed * Time.deltaTime);
	}

}
