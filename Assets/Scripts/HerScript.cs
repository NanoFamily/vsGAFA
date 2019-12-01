using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HerScript : MonoBehaviour {
    //パドルのスクリプト
    private GameObject paddle;
    //パドルと彼女の距離
    private float difference;

	// Use this for initialization
	void Start () {
        //パドルのオブジェクトを取得
        this.paddle = GameObject.Find("Paddle");
        //パドルと彼女の距離の差を求める
        this.difference = paddle.transform.position.x - this.transform.position.x;

	}
	// Update is called once per frame
	void Update () {
        //パドルの位置に合わせて彼女を移動
        this.transform.position = new Vector3(this.paddle.transform.position.x - difference, 1.5f, -11.14f);
    }
}
