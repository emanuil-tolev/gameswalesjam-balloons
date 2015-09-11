using UnityEngine;
using System.Collections;

public class SpawnPlatforms : MonoBehaviour
{
	public GameObject spawnable;
	public float spawnInterval = 3;
	private float spawnTimer;


	// Use this for initialization
	void Start ()
	{
		spawnTimer = spawnInterval;
	}
	
	// Update is called once per frame
	void Update ()
	{
		spawnTimer -= Time.deltaTime;

		if (spawnTimer <= 0) {
			spawnTimer = spawnInterval;
			SpawnObject();
		}
	}

	void SpawnObject()
	{
		var obj = GameObject.Instantiate (spawnable);
		obj.transform.localScale = new Vector3( Random.Range (4, 20), 1, 1 );

		Vector3 pos = transform.position;
		pos.x = transform.position.x + Random.Range(-20,20);
		obj.transform.position = pos; 
	}
}
