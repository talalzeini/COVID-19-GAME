using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    int i = 0;
    public GameObject [] PrefabsRoad;
    private int nextStep;
    public Transform startPos;

    public void Update()
    {
        while(i < 30){
            i++;
        nextStep += 7;
        Instantiate(PrefabsRoad[Random.Range(0, PrefabsRoad.Length)], new Vector3(startPos.position.x, startPos.position.y + nextStep, startPos.position.z),Quaternion.identity);
        }
    }
}
