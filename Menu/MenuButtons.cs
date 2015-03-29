using UnityEngine;
using System.Collections;

public class MenuButtons : MonoBehaviour {

	public void Play (string sceneToChangeTo)
	{
		Application.LoadLevel(sceneToChangeTo);
	}
}