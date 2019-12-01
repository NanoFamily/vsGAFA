using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DallFactoryScript : MonoBehaviour {
    public GameObject dall;

	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnBall", 1f, 4f);
	}

    void SpawnBall()
    {
        Instantiate(dall, new Vector3(Random.Range(0.5f, -2.5f), transform.position.y, transform.position.z), transform.rotation);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
