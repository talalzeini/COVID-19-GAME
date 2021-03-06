﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    int i = 0;

    public int number = 0;
    public GameObject [] PrefabsRoad;
    private int nextStep;
    public Transform startPos;

    public GameObject best;

    public GameObject notBest;
    public float score;
    public Text scoreText;
    public Text scoreText1;
    public int highscore;
    public Text highscoretext1;
    public Text highscoretext;


    public GameObject adsArePlaying;

     public void Start()
    {
        highscoretext.text = PlayerPrefs.GetInt("score", 0).ToString();
        highscoretext1.text = PlayerPrefs.GetInt("score", 0).ToString();
        notBest.SetActive(true);
        best.SetActive(false);  
    }

    void Update(){
      
         highscore = (int)score;
        scoreText.text = highscore.ToString();
        scoreText1.text = highscore.ToString();
               
               
        
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
    //    number = (int.Parse(highscoretext.text)+10);
    //    Debug.Log(number);
        
        while(i < 1){
            i++;
        nextStep += 7;
        Instantiate(PrefabsRoad[Random.Range(0, PrefabsRoad.Length)], new Vector3(startPos.position.x, startPos.position.y + nextStep, startPos.position.z),Quaternion.identity);
        }
    }
    public void Spawning()
    {
            i = 0;
            score+=0.5f;
            Debug.Log("yes");
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
    
 
