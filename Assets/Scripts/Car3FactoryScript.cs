using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car3FactoryScript : MonoBehaviour {
    public GameObject car3;

	// Use this for initialization
	void Start () {
        InvokeRepeating("RollingCar", 3f, 5f);
	}

    void RollingCar()
    {
        Instantiate(car3, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
    }

	
	// Update is called once per frame
	void Update () {
		
	}
}
