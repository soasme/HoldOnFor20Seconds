using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed = 0.1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float x = gameObject.transform.position.x + Input.GetAxis ("Horizontal") * speed;
		float y = gameObject.transform.position.y +Input.GetAxis ("Vertical") * speed;
		x = Mathf.Clamp (x, -6.15f, 6.15f);
		y = Mathf.Clamp (y, -4.5f, 4.5f);
		Vector2 pos = new Vector2 (x, y);
		gameObject.transform.position = pos;
	}
}
