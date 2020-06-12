using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsManager : MonoBehaviour
{
    public GameObject ResetButton;
    public GameObject Mutes;
    void Start()
    {
        ResetActive();
    }
    void MutesActive(){
        Mutes.SetActive(true);
        ResetButton.SetActive(false);
        Invoke("ResetActive", 3f);
    }
    void ResetActive(){
        Mutes.SetActive(false);
        ResetButton.SetActive(true);
        Invoke("MutesActive", 3f);
    }
}
