using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car1FactoryScript : MonoBehaviour {
    public GameObject car1;

	// Use this for initialization
	void Start () {
        InvokeRepeating("RollingCar", 0f, 4f);
	}
	
    void RollingCar()
    {
        Instantiate(car1, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
