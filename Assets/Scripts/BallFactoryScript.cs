using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFactoryScript : MonoBehaviour {
    public GameObject ball;

	// Use this for initialization
	void Start () {
        //Instantiate(ball, transform.position, transform.rotation);
        InvokeRepeating("SpawnBall", 1f, 3f);
	}

    void SpawnBall()
    {
        Instantiate(ball, new Vector3(Random.Range(4.5f, 2.5f),transform.position.y, transform.position.z), transform.rotation);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
