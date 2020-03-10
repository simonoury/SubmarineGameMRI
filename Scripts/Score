using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    public int lives;
    public int level;
    public GameObject explosion;
    public GameObject coin1;
    public GameObject chestopened;
    public Text ScoreText;
    public Text LivesText;
    public GameObject fogUI;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        lives = 3;
    }

    void OnTriggerEnter2D(Collider2D col){
      if (col.tag == "Coin"){
        col.gameObject.SetActive(false);
        AddScore();
        fogUI.SetActive(true);
        //level = SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex)*2;
        if (score == 10)
        {
          FindObjectOfType<GameManager>().ChangeLevel();
        }
      }
      else if (col.tag == "Shark"){
        GameObject e = Instantiate(explosion) as GameObject;
        e.transform.position = transform.position;
        SubstractLives();
        Destroy(col.gameObject);
        if (lives == 0){
          FindObjectOfType<GameManager>().EndGame();
        }
      }
      else if (col.tag == "Heart"){
        col.gameObject.SetActive(false);
        FindObjectOfType<GameManager>().addFog();
        if (lives < 3){
          AddLife();
        }

      }
      else if (col.tag == "Chest"){
        GameObject chopened = Instantiate(chestopened) as GameObject;
        chopened.transform.position = col.transform.position;
        GameObject co1 = Instantiate(coin1) as GameObject;
        GameObject co2 = Instantiate(coin1) as GameObject;
        co1.transform.position = new Vector2(col.transform.position.x + 2, col.transform.position.y+1);
        co2.transform.position = new Vector2(col.transform.position.x + 2, col.transform.position.y);
      }
    }


    void AddScore () {
      score = score + 1;
      ScoreText.text = score.ToString();
    }
    void SubstractLives () {
      lives = lives-1;
      LivesText.text = lives.ToString();
    }
    void AddLife(){
      lives = lives + 1;
      LivesText.text = lives.ToString();
    }
  }
