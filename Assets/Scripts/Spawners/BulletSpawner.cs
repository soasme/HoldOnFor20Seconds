using UnityEngine;
using System.Collections;

public class BulletSpawner : MonoBehaviour {

	public GameObject bulletPrefab;
	public int bulletCount = 20;
	public GameObject[] bullets;
	//public GameObject bullet;

	// Use this for initialization
	void Start () {
		bullets = new GameObject[bulletCount];
		//GenerateBullets ();
		//bullet = (GameObject)Instantiate (bulletPrefab, new Vector2 (2f, 2f), Quaternion.identity);
	}

	public void GenerateBullets() {
		for (int i = 0; i < bulletCount; i++) {
			if (!bullets [i]) {
				int dir = Random.Range (0, 4);
				Vector2 pos = Vector2.zero;
				if (dir == 0) {
					pos.x = -6.65f;
					pos.y = Random.Range (-4.9f, 4.9f);
				} else if (dir == 1) {
					pos.x = 6.65f;
					pos.y = Random.Range (-4.9f, 4.9f);
				} else if (dir == 2) {
					pos.x = Random.Range (-6.65f, 6.65f);
					pos.y = 4.9f;
				} else if (dir == 3) {
					pos.x = Random.Range (-6.65f, 6.65f);
					pos.y = -4.9f;
				}
				//Vector2 pos = new Vector2 (Random.Range (-5f, 5f), Random.Range (-5f, 5f));
				bullets[i] = (GameObject)Instantiate (bulletPrefab, pos, Quaternion.identity);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		if (player) {
			GenerateBullets ();
		}
	}
}
