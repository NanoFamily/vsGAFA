using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallFactoryScript : MonoBehaviour {
    public GameObject call;

	// Use this for initialization
	void Start () {
        //Instantiate(call, transform.position, transform.rotation);
        InvokeRepeating("SpawnBall", 4f, 4f);
	}

    void SpawnBall()
    {
        Instantiate(call, new Vector3(Random.Range(2.5f, 0.5f), transform.position.y, transform.position.z), transform.rotation);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
