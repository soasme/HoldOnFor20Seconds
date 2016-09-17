using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	public bool startTimer = true;
	public float time = 0;
	public float interval = 0.1f;
	public TextMesh textMesh;

	void Start () {
		textMesh = GetComponent<TextMesh>();
		Reset ();
	}

	void Reset () {
		time = 0.0f;
	}

	IEnumerator Forward() {
		yield return new WaitForSeconds (interval);
		time += interval;
		startTimer = true;
	}

	// Update is called once per frame
	void Update () {
		if (startTimer) {
			StartCoroutine ("Forward");
			startTimer = false;
		}
		textMesh.text = time.ToString ("0.0");
	}
}
