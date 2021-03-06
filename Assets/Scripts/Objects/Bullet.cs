﻿using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	Rigidbody2D rb;

	public Vector2 force;
	public GameObject bulletPrefab;

	// Use this for initialization
	void Start () {
		int dir = Random.Range (0, 2);
		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		if (!player) {
			force = Vector2.zero;
		} else if (dir == 0) {
			force = new Vector2 (Random.Range (-1, 1f), Random.Range (-1, 1f));
		} else {
			var heading = player.transform.position - transform.position;
			var distance = heading.magnitude;
			force = heading / distance / 2;
		}
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		rb.AddForce (force);
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Bullet") {
			return;
		} else if (other.gameObject.tag == "Player") {
			Destroy (other.gameObject);
			foreach (GameObject bullet in GameObject.FindGameObjectsWithTag("Bullet")) {
				Destroy (bullet);
			}
			//Destroy (other.gameObject);
		}
		// Always destroy old bullet and respawn a new one,
		// If old bullet detected collision.
		Destroy(gameObject);
	}
}
