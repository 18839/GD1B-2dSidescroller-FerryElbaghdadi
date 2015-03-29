using UnityEngine;
using System.Collections;

public class MenuButtonsTrigger : MonoBehaviour {

	public GameObject buttons;

	void OnCollisionEnter2D(Collision2D other)
	{
		
		if (other.transform.root.CompareTag ("MainCamera")) {

			buttons.GetComponent<Canvas>().enabled = true;
		}
	}
}