using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car2Script : MonoBehaviour {
    private float speed;

    // Use this for initialization
    void Start () {
        speed = 3f;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(-1 * speed * Time.deltaTime, 0f, 0f);
        if (transform.position.x < -5.0f)
        {
            Destroy(gameObject);
        }
    }
}
