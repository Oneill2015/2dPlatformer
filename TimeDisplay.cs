using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour {
	public Text timeDisplay;
	
	int counter = 0;
	// Use this for initialization
	void Start () {
		Debug.Log ("TimeDisplay Start");
		StartCoroutine (OneSecondTimer ());
	}
	
	IEnumerator OneSecondTimer() {
		while (1==1) {
			yield return new WaitForSeconds (1.0f);
			counter++;
			timeDisplay.text = "Time: " + counter.ToString ();
			Debug.Log (counter);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
