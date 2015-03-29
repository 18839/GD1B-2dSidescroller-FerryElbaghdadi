using UnityEngine;
using System.Collections;

public class MenuCameraTrigger : MonoBehaviour {

	public GameObject camera1;
	public GameObject camera2;

	void OnTriggerEnter2D(Collider2D other)
	{
		
		if (other.transform.root.CompareTag ("MainCamera")) {

			camera1.GetComponent<Camera>().enabled = false;
			camera2.GetComponent<Camera>().enabled = true;

			
		}
	}
}