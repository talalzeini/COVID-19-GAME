using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThemesManager : MonoBehaviour
{
    public GameObject Fall;
    public GameObject Flight;
    public GameObject Fight;
    void Start()
    {
        FlightActive();
    }
    void FlightActive(){
        Fall.SetActive(false);
        Flight.SetActive(true);
        Fight.SetActive(false);
        Invoke("FightActive", 3f);
    }
    void FightActive(){
        Fall.SetActive(false);
        Flight.SetActive(false);
        Fight.SetActive(true);
        Invoke("FallActive", 3f);
    }
    void FallActive(){
        Fall.SetActive(true);
        Flight.SetActive(false);
        Fight.SetActive(false);
        Invoke("FlightActive", 3f);
    }
}
