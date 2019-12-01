using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EallFactoryScript : MonoBehaviour {
    public GameObject eall;

    // Use this for initialization
    void Start() {
        InvokeRepeating("SpawnBall", 3f, 5f);
    }

    void SpawnBall()
    {
        Instantiate(eall, new Vector3(Random.Range(-2.5f, -4.5f), transform.position.y, transform.position.z), transform.rotation);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
