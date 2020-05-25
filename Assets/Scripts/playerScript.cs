using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public GameObject losePanel;
    public GameObject winPanel;
    public GameObject gameTitle;
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        losePanel.SetActive(false);
        winPanel.SetActive(false);
        gameTitle.SetActive(true);
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.DownArrow)){
        rb.isKinematic = false;
        }
    }
void OnCollisionEnter2D(Collision2D col){
    if(col.gameObject.CompareTag("Corona")){
    Invoke("DestroyedObject", 0.6f);
    losePanel.SetActive(true);
    winPanel.SetActive(false);
    gameTitle.SetActive(false);
    }else if(col.gameObject.CompareTag("Finish")){
       winPanel.SetActive(true);
       losePanel.SetActive(false);
       gameTitle.SetActive(false);
    }
}
void DestroyedObject(){
    Destroy(gameObject);
}
}
