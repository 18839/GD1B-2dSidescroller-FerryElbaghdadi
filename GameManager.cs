using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public TextMesh CollectablesText;
	public TextMesh counterText;
	
	public int nrOfTotalCollectables;
	public int nrOfCollectedItems;
	public float seconds, minutes;

	// Use this for initialization
	void Start () {
		GameObject[] objects = GameObject.FindGameObjectsWithTag ("Pickups");
		nrOfTotalCollectables = objects.Length;
		nrOfCollectedItems = 0;
		UpdateUI ();
	}

	void FixedUpdate () 
	{
		CountTime ();
	}

	public void AddCollectable()
	{
		nrOfCollectedItems++;
		UpdateUI ();
	}
	
	void UpdateUI()
	{
		CollectablesText.text = "X " + nrOfCollectedItems + " / " + nrOfTotalCollectables;
	}

	void CountTime()
	{
		minutes = (int)(Time.timeSinceLevelLoad / 60f);
		seconds = (int)(Time.timeSinceLevelLoad % 60f);
		counterText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
	}
}
