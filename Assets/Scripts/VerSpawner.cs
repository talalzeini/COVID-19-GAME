using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VerSpawner : MonoBehaviour
{
    public GameObject[] spawnedObjects;

     private int number = 0;
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

     public GameObject adsArePlaying;
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
              if ((PlayerPrefs.GetInt("score") < highscore) && (!adsArePlaying.activeSelf))
        {
            notBest.SetActive(false);
            best.SetActive(true);
            PlayerPrefs.SetInt("score", highscore);
            highscoretext.text = (int.Parse(highscoretext.text)).ToString();
            highscoretext1.text = PlayerPrefs.GetInt("score").ToString();

            
        }else if (!(PlayerPrefs.GetInt("score") < highscore) && (adsArePlaying.activeSelf)){
        NewScore();
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
    public void NewScore(){
        while(number<1){
            number+=1;
            notBest.SetActive(false);
            best.SetActive(true);
           
            highscoretext.text = (int.Parse(highscoretext.text)+5).ToString(); 
            highscoretext1.text = (int.Parse(highscoretext1.text)+5).ToString();
            PlayerPrefs.SetInt("score", (int.Parse(highscoretext.text)));  
        }
    }
}