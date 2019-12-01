using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EallScript : MonoBehaviour {
    private float speed;

	// Use this for initialization
	void Start () {
        speed = Random.Range(4f, 5f);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(0f, 0f, -1 * speed * Time.deltaTime);
        if (transform.position.z < -12.0f)
        {
            SceneManager.LoadScene("GameOverScene");
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PaddleTag"))
        {
            Destroy(gameObject);
            collision.gameObject.transform.localScale -= new Vector3(Random.Range(0.1f, 0.3f), 0f, 0f);
            if (collision.gameObject.transform.localScale.x < 1.0f)
            {
                collision.gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }
        }
    }
}
