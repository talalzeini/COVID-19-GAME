using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
  public GameObject PausedPanel;
  public GameObject losePanel;
  public GameObject muteButton;
    public GameObject unmuteButton;
  public AudioSource lose;

  private playerScript player;

  public GameObject PauseIcon;


  public void Start(){
      if(AudioListener.volume == 1f){
          muteButton.SetActive(true);
        unmuteButton.SetActive(false);
      }else if((AudioListener.volume == 0f)){
        unmuteButton.SetActive(true);
        muteButton.SetActive(false);
      }
  }
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
   public void LoadVertical(){
       SceneManager.LoadScene("Vertical");
       Time.timeScale = 1f;
   }
   public void ResetGame(){
       PlayerPrefs.DeleteAll();
       Debug.Log("Deleted Best");
   }
   public void Mute(){
       muteButton.SetActive(false);
       AudioListener.volume = 0f;
       unmuteButton.SetActive(true);
       AudioListener.pause = true;
       Debug.Log("Muted");
   }
   public void UnMute(){
       muteButton.SetActive(true);
       AudioListener.volume = 1f;
       unmuteButton.SetActive(false);
       AudioListener.pause = false;
       Debug.Log("UnMuted");
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
