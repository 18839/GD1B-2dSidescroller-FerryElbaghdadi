using UnityEngine;
using System.Collections;

public class Lives : MonoBehaviour {

	public int health;

	GameObject health5;
	GameObject health4;
	GameObject health3;
	GameObject health2;
	GameObject health1;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void onCollisionEnter2D (Collision2D coll) {
		if (coll.gameObject.name == "Enemy") 
		{
			health--;
			if (health <= 0) 
			{
				Destroy (this.gameObject);
			}
		}
	}

}
