using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class nextLevel : MonoBehaviour 
{

public int nextSceneLoad;


void Start(){
    nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
  
}

void OnTriggerEnter2D(Collider2D other){

if(other.gameObject.tag == "Player"){
   SceneManager.LoadScene(nextSceneLoad);

        if(nextSceneLoad > PlayerPrefs.GetInt("levelAt")){
            PlayerPrefs.SetInt("levelAt", nextSceneLoad);
        }
    }
}
}