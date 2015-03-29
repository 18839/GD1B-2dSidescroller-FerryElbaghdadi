using UnityEngine;
using System.Collections;

public class Bounce : MonoBehaviour {

	public GameObject player;

	void OnCollisionEnter2D (Collision2D other)
	{
		player.GetComponent<Rigidbody2D>().velocity = new Vector2 (0f, 10);
	}


}