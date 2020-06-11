using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VerSpawner : MonoBehaviour
{
    public GameObject[] spawnedObjects;

    private float timeBetweenSpawn =1f;
    public float timeToSpawn = 2f;
    public int score;
     public GameObject best;

    public GameObject notBest;

    public Text scoreText;
    public Text scoreText1;
    public int highscore;
    public Text highscoretext;
    public Text highscoretext1;
    public void Start()
    {
        highscoretext.text = PlayerPrefs.GetInt("score", 0).ToString();
         highscoretext1.text = PlayerPrefs.GetInt("score", 0).ToString();
           notBest.SetActive(true);
        best.SetActive(false);
    }

    void Update()
    {   
         highscore = (int)score;
        scoreText.text = highscore.ToString();
        if (PlayerPrefs.GetInt("score") <= highscore)
        {
            notBest.SetActive(false);
            best.SetActive(true);
            PlayerPrefs.SetInt("score", highscore);
            highscoretext.text = PlayerPrefs.GetInt("score").ToString();
            highscoretext1.text = PlayerPrefs.GetInt("score", 0).ToString();
        }
        if (Time.time >= timeToSpawn)
        {
            SpawnBlocks();
            timeToSpawn = Time.time + timeBetweenSpawn;
        }
    }

    void SpawnBlocks()
    {
         Instantiate(spawnedObjects[Random.Range(0, spawnedObjects.Length)], transform.position, Quaternion.identity);
    }
    public void SpawningVert()
    {
            score++;
            scoreText.text = score.ToString();
            scoreText1.text = score.ToString();
    }

}