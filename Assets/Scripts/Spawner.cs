using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    int i = 0;
    public GameObject [] PrefabsRoad;
    private int nextStep;
    public Transform startPos;

    public int score;
    public Text scoreText;
    public Text scoreText1;
    public int highscore;
    public Text highscoretext;

     public void Start()
    {
        highscoretext.text = PlayerPrefs.GetInt("score", 0).ToString();
    }

    void Update(){
         highscore = (int)score;
        scoreText.text = highscore.ToString();
        if (PlayerPrefs.GetInt("score") <= highscore)
        {
            PlayerPrefs.SetInt("score", highscore);
            highscoretext.text = PlayerPrefs.GetInt("score").ToString();
        }
        while(i < 1){
            i++;
        nextStep += 7;
        Instantiate(PrefabsRoad[Random.Range(0, PrefabsRoad.Length)], new Vector3(startPos.position.x, startPos.position.y + nextStep, startPos.position.z),Quaternion.identity);
        }
    }
    public void Spawning()
    {
            i = 0;
            score++;
            Debug.Log("yes");
            scoreText.text = score.ToString();
            scoreText1.text = score.ToString();
    }
}
    
 
