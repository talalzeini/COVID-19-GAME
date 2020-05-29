using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public GameObject losePanel;
    public GameObject winPanel;
    public GameObject gameTitle;
    public Rigidbody2D rb;
    public Transform Cam;
    private gameManager spawnerScript;
    public GameObject tapToStartText;
    public GameObject fight0;
    public GameObject fight1;

    public float velocity = 1;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        fight0.SetActive(false);
        fight1.SetActive(true);
        losePanel.SetActive(false);
        winPanel.SetActive(false);
        gameTitle.SetActive(true);
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)){
        rb.velocity = Vector2.up * velocity;
        rb.isKinematic = false;
        tapToStartText.SetActive(false);
        fight0.SetActive(true);
        fight1.SetActive(false);
        }
    }
void OnCollisionEnter2D(Collision2D col){
    if(col.gameObject.CompareTag("Corona")){
    Destroy(gameObject);
    losePanel.SetActive(true);
    winPanel.SetActive(false);
    gameTitle.SetActive(false);
    }
}
}
