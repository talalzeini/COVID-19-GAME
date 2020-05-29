﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
  public GameObject PausedPanel;
  public GameObject PauseIcon;
  public void TryAgain(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       Time.timeScale = 1f;
   }
   public void MenuToGame(){
       SceneManager.LoadScene("Game");
       Time.timeScale = 1f;
   }
    public void GameToMenu(){
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
}
