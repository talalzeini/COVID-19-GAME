using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{

    public GameObject Win;
    
    void Start()
    {
        Invoke("Starting", 1f);
        Win.SetActive(false);
    }
    void Starting()
    {
               Win.SetActive(true);
    }

}
