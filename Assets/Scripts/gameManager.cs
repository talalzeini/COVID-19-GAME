using System.Collections;
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
   public void Back(){
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
   }
    public void Next(){
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
   public void MenuToGame(){
       SceneManager.LoadScene("Game");
       Time.timeScale = 1f;
   }
    public void MenuToLevels(){
       SceneManager.LoadScene("Levels");
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
   public void Update(){    
       if(losePanel.activeSelf == true){
            lose.enabled = true;
    }
   }
   public void Game1(){
         SceneManager.LoadScene("Game 1");
   }
   public void Game2(){
         SceneManager.LoadScene("Game 2");
   }
   public void Game3(){
         SceneManager.LoadScene("Game 3");
   }
   public void Game4(){
         SceneManager.LoadScene("Game 4");
   }
   public void Game5(){
         SceneManager.LoadScene("Game 5");
   }
   public void Game6(){
         SceneManager.LoadScene("Game 6");
   }
   public void Game7(){
         SceneManager.LoadScene("Game 7");
   }
   public void Game8(){
         SceneManager.LoadScene("Game 8");
   }
   public void Game9(){
         SceneManager.LoadScene("Game 9");
   }
   public void Game10(){
         SceneManager.LoadScene("Game 10");
   }
}
