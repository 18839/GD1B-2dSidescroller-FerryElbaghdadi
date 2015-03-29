using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	public TextMesh counterText;

	public float seconds, minutes;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		minutes = (int)(Time.timeSinceLevelLoad / 60f);
		seconds = (int)(Time.timeSinceLevelLoad % 60f);
		counterText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
	}
}
