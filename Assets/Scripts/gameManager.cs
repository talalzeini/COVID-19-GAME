﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
  public GameObject PausedPanel;
  public GameObject losePanel;
  public AudioSource lose;

  public GameObject PauseIcon;
  public void TryAgain(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       Time.timeScale = 1f;
   }
   public void MenuToGame(){
       SceneManager.LoadScene("Game");
       Time.timeScale = 1f;
   }
    public void MenuToThemes(){
       SceneManager.LoadScene("Themes");
   }
    public void MenuToOptions(){
       SceneManager.LoadScene("Options");
   }
    public void GameToMenu(){
       SceneManager.LoadScene("Menu");
       Time.timeScale = 1f;
   }
    public void ToMenu(){
       SceneManager.LoadScene("Menu");
       Time.timeScale = 1f;
   }
   
   public void PauseGame(){
       Time.timeScale = 0f;
       PausedPanel.SetActive(true);
       PauseIcon.SetActive(false);
   }
    public void ResumeGame(){
       Time.timeScale = 1f;
       PausedPanel.SetActive(false);
       PauseIcon.SetActive(true);
   }
   public void Update(){    
       if(losePanel.activeSelf == true){
            lose.enabled = true;
    }
   }
}
