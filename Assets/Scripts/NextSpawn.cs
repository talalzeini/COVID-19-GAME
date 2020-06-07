using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextSpawn : MonoBehaviour
{
   public void OnTriggerEnter2D(Collider2D col){
    {
        if (col.CompareTag("Player"))
        {
            FindObjectOfType<Spawner>().Spawning();
            Destroy(gameObject);
        }
    }
}
}
