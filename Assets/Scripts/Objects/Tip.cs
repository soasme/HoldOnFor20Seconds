using UnityEngine;
using System.Collections;

public class Tip : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		if (!player) {
			GetComponent<TextMesh>().text = "Tap [Space] to start";
		} else {
			GetComponent<TextMesh>().text = "";
		}
	}
}
