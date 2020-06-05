using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
  
    public Rigidbody2D rb;
    public float velocity = -1;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void Jump()
    {
        rb.velocity = Vector2.up * velocity;
        rb.isKinematic = false;
    }
     public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            rb.velocity = Vector2.up * velocity;
            rb.isKinematic = false;
        }  
    }
    
    public void OnTriggerEnter2D(Collider2D col){
    {
        if (col.CompareTag("Corona"))
        {
            Debug.Log("Destroyed");
            Destroy(col.gameObject);
        }
    }
    }
}
