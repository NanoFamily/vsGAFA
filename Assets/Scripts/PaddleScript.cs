using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PaddleScript : MonoBehaviour
{

    //private float speed;
    public float speed;

    //スコアを表示するテキスト（追加）
    private GameObject scoreText;

    //得点（追加）
    private int score = 0;

    //左ボタン押下の判定（追加）
    private bool isLButtonDown = false;
    //右ボタン押下の判定（追加）
    private bool isRButtonDown = false;

    // Start is called before the first frame update
    void Start()
    {
        //speed = 5f;

        //シーン中のscoreTextオブジェクトを取得（追加）
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0f, 0f);


        //Debug.Log(transform.position.x);

        //追加
        //パドルをボタンに応じて左右に移動させる（追加）
        if (this.isLButtonDown) 
        {
            //左に移動
            transform.Translate(0.2f, 0, 0);
        }
        else if (this.isRButtonDown)
        {
            //右に移動
            transform.Translate(-0.2f, 0, 0);
        }
        //追加
    }
    //他のオブジェクトと接触した場合の処理
    void OnCollisionEnter(Collision other)
    {
        //Googleに衝突した場合
        if (other.gameObject.tag == "GoogleTag")
        {
            // スコアを加算(追加)
            this.score += 5;
        }
        //Appleに衝突した場合
        if (other.gameObject.tag == "AppleTag")
        {
            // スコアを加算(追加)
            this.score += 7;
        }
        //Facebookに衝突した場合
        if (other.gameObject.tag == "FacebookTag")
        {
            // スコアを加算(追加)
            this.score += 3;
        }
        //Amazonに衝突した場合
        if (other.gameObject.tag == "AmazonTag")
        {
            // スコアを加算(追加)
            this.score += 5;
        }
        //ScoreText獲得した点数を表示
        this.scoreText.GetComponent<Text>().text = "Score " + this.score + "pt";

        if (this.score > 400)
        {
            SceneManager.LoadScene("ClearScene");
        }
    }
    

        //【以下追加】
        //左ボタンを押し続けた場合の処理
        public void GetMyLeftButtonDown()
        {
            this.isLButtonDown = true;
        }
        //左ボタンを離した場合の処理
        public void GetMyLeftButtonUp()
        {
            this.isLButtonDown = false;
        }

        //右ボタンを押し続けた場合の処理
        public void GetMyRightButtonDown()
        {
            this.isRButtonDown = true;
        }
        //右ボタンを離した場合の処理
        public void GetMyRightButtonUp()
        {
            this.isRButtonDown = false;
        }
    }



