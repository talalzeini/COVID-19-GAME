using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
  public GameObject PausedPanel;
  public GameObject bg;
  public GameObject losePanel;
  public GameObject muteButton;
  public GameObject unmuteButton;


  public static bool isCalled = false;
  public GameObject muteMusic;
  public GameObject unmuteMusic;

  public AudioSource lose;

  public GameObject adsPanel;
  private playerScript player;

  public GameObject PauseIcon;

  public void Start(){
      adsPanel.SetActive(false);
      losePanel.SetActive(false);
       
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
}
   public void Mute(){
       muteButton.SetActive(false);
       AudioListener.volume = 0f;
       unmuteButton.SetActive(true);
       AudioListener.pause = true;
   }
   public void UnMute(){
       muteButton.SetActive(true);
       AudioListener.volume = 1f;
       unmuteButton.SetActive(false);
       AudioListener.pause = false;
   }


   public void MuteMusic(){
       muteMusic.SetActive(false);
       Destroy(GameObject.Find("Background Music"));
        Destroy(GameObject.Find("Background Music(Clone)"));
       unmuteMusic.SetActive(true);
       isCalled = true;
   }
   public void UnMuteMusic(){
       muteMusic.SetActive(true);
       isCalled = false;
       unmuteMusic.SetActive(false);
       Instantiate(bg, transform.position, Quaternion.identity);
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
   public void ShowingAdvertisements(){
        losePanel.SetActive(false);
        adsPanel.SetActive(true);
    }
    public void NoThanks(){
        losePanel.SetActive(true);
        adsPanel.SetActive(false);
    }
   public void Update(){    
       if(losePanel.activeSelf == true){
            lose.enabled = true;

   }
    if(isCalled){
    Destroy(GameObject.Find("Background Music"));
    }
   }
}
