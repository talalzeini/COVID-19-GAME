using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public AudioSource jump;
    public GameObject losePanel;
    public GameObject winPanel;
    public GameObject gameTitle;
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public Transform Cam;
    private gameManager spawnerScript;
    public GameObject tapToStartText;
    public GameObject fight0;
    public GameObject fight1;

    public Sprite mask;
    public Sprite notMask;
    public GameObject explosion;
    public float velocity = 1;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        fight0.SetActive(false);
        fight1.SetActive(true);
        losePanel.SetActive(false);
        winPanel.SetActive(false);
        gameTitle.SetActive(true);
    }
    public void Jump()
    {
        rb.velocity = Vector2.up * velocity;
        rb.isKinematic = false;
        tapToStartText.SetActive(false);
        fight0.SetActive(true);
        fight1.SetActive(false);
        jump.Play();
    }
     public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            rb.velocity = Vector2.up * velocity;
            rb.isKinematic = false;
            tapToStartText.SetActive(false);
            fight0.SetActive(true);
            fight1.SetActive(false);
            jump.Play();
        }
        
    }
void OnCollisionEnter2D(Collision2D col){
        
        if(sr.sprite == mask && col.gameObject.CompareTag("Corona")){
        Destroy(col.gameObject);
        sr.sprite = notMask;

}else if(sr.sprite != mask){
      //  rb.constraints = RigidbodyConstraints2D.None;
            if (col.gameObject.CompareTag("Corona")){
                losePanel.SetActive(true);
                winPanel.SetActive(false);
                gameTitle.SetActive(false);
                Destroy(col.gameObject);
        }
    }

    if (col.gameObject.CompareTag("End")){
        losePanel.SetActive(false);
        gameTitle.SetActive(false);
        winPanel.SetActive(true);
        rb.constraints = RigidbodyConstraints2D.FreezePositionY;
    }

}
void OnTriggerEnter2D(Collider2D coll){
   if(coll.gameObject.CompareTag("Mask")){
                     
            sr.sprite = mask;
            Destroy(coll.gameObject);
    }
}
}
