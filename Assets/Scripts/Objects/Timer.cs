using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	public GameObject playerPrefab;
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
		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		if (player) {
			yield return new WaitForSeconds (interval);
			time += interval;
			startTimer = true;
		} else {
			startTimer = false;
			yield return null;
		}
	}

	// Update is called once per frame
	void Update () {
		if (!startTimer && Input.GetKeyDown ("space")) {
			time = 0f;
			startTimer = true;
			Instantiate (playerPrefab, Vector3.zero, Quaternion.identity);

		}
		if (startTimer) {
			StartCoroutine ("Forward");
			startTimer = false;
		}
		textMesh.text = time.ToString ("0.0");
	}
}
