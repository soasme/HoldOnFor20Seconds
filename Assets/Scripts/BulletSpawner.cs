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
		GenerateBullets ();
		//bullet = (GameObject)Instantiate (bulletPrefab, new Vector2 (2f, 2f), Quaternion.identity);
	}

	void GenerateBullets() {
		for (int i = 0; i < bulletCount; i++) {
			if (!bullets [i]) {
				Vector2 pos = new Vector2 (Random.Range (-5f, 5f), Random.Range (-5f, 5f));
				bullets[i] = (GameObject)Instantiate (bulletPrefab, pos, Quaternion.identity);
				Debug.Log (bullets [i]);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		GenerateBullets ();
		//Debug.Log (bullet);
	}
}
