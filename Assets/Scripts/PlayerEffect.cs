using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEffect : MonoBehaviour
{
     public float startTimeBtnSpawn;
     float timeBtnSpawn;
     public GameObject tailPrefab;

     private void Update()
     { 
         if(timeBtnSpawn <= 0){
             
             GameObject tail = Instantiate(tailPrefab , transform.position , Quaternion.identity);
             timeBtnSpawn = startTimeBtnSpawn;
             Destroy(tail, 4f);
         }
         else
         {
            timeBtnSpawn -=Time.deltaTime;
         }

     }
}
