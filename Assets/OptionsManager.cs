using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsManager : MonoBehaviour
{
    public GameObject ResetButton;
    public GameObject Mutes;

    public GameObject MuteMusic;

    public GameObject mutingMusic;

    public GameObject unmutingMusic;
    public GameObject muteButton;
    public GameObject unmuteButton;

    public GameObject bg;
    void Start()
    {
        if(GameObject.Find("Background Music") != null || GameObject.Find("Background Music(Clone)") != null){
         unmutingMusic.SetActive(false);
         mutingMusic.SetActive(true);
        }else{
         unmutingMusic.SetActive(true);
         mutingMusic.SetActive(false);
        }
        ResetActive();
         if(AudioListener.volume == 1f){
          muteButton.SetActive(true);
          unmuteButton.SetActive(false);
      }else if((AudioListener.volume == 0f)){
        unmuteButton.SetActive(true);
        muteButton.SetActive(false);
      }
    }
     void ResetActive(){
        Mutes.SetActive(false);
        ResetButton.SetActive(true);
        MuteMusic.SetActive(false);
        Invoke("MutesActive", 3f);
    }
    void MutesActive(){
        Mutes.SetActive(true);
        ResetButton.SetActive(false);
        MuteMusic.SetActive(false);
        Invoke("MusicActive", 3f);
    }
     void MusicActive(){
        MuteMusic.SetActive(true);
        Mutes.SetActive(false);
        Invoke("ResetActive", 3f);
    }

}
