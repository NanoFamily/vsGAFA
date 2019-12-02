using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car2FactoryScript : MonoBehaviour {
    public GameObject car2;

	// Use this for initialization
	void Start () {
        InvokeRepeating("RollingCar", 0f, 5f);
	}

    void RollingCar()
    {
        Instantiate(car2, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
