using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vertPlayer : MonoBehaviour
{
    
     public AudioSource plusOne;
     public AudioSource jump;
    public GameObject losePanel;
    public GameObject winPanel;
    public GameObject gameTitle;
    public Rigidbody2D rb;
    private SpriteRenderer sr;
    public Transform Cam;
    private gameManager spawnerScript;
    public GameObject tapToStartText;
    public GameObject fight0;
    public GameObject fight1;

    public Sprite mask;
    public Sprite notMask;
    public GameObject explosion;
    private float velocity = 1;
    private VerSpawner spawner;

    public float mapWidth;

    public GameObject spawnerToDestroy;

    public float moveSpeed = 5f;



    public vertPlayer myPlayerScript;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        fight0.SetActive(false);
        fight1.SetActive(true);
        losePanel.SetActive(false);
        winPanel.SetActive(false);
        gameTitle.SetActive(true);
        spawnerToDestroy.SetActive(false);
    }
     public void FixedUpdate()
    {

        float x = Input.GetAxisRaw("Horizontal") * Time.fixedDeltaTime * moveSpeed;

        Vector2 newPosition = rb.position + Vector2.right * x;
        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);

        if(x != 0){
        rb.MovePosition(newPosition);
        tapToStartText.SetActive(false);
        fight0.SetActive(true);
        fight1.SetActive(false);
        spawnerToDestroy.SetActive(true);
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
                Destroy(spawnerToDestroy);
                winPanel.SetActive(false);
                gameTitle.SetActive(false);
                Destroy(col.gameObject);
                myPlayerScript.enabled = false;
                Destroy(gameObject);
        }
    }
}
public void OnTriggerEnter2D(Collider2D coll){
   if(coll.gameObject.CompareTag("Mask")){
                     
            sr.sprite = mask;
            Destroy(coll.gameObject);
    }
      if (coll.gameObject.CompareTag("End")){
        losePanel.SetActive(false);
        gameTitle.SetActive(false);
        winPanel.SetActive(true);
        rb.constraints = RigidbodyConstraints2D.FreezePositionY;
        Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
     if(coll.gameObject.CompareTag("Spawn")){
           
           FindObjectOfType<VerSpawner>().SpawningVert();
           Destroy(coll.gameObject);
           plusOne.Play();
    }
}
}

