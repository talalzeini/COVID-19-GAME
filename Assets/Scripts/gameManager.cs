using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
  public void TryAgain(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
   public void MenuToGame(){
       SceneManager.LoadScene("Game");
   }
    public void GameToMenu(){
       SceneManager.LoadScene("Menu");
   }
}
