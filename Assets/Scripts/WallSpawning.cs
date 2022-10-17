using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawning : MonoBehaviour
{

    public float maxTime;
    public float maxHeight;
    public float minHeight;
    
    public GameObject wallPrefab;
    GameObject wall;

    private float time;
   
    private void Start()
    {
        time = 1;
    }

    // Update is called once per frame
    private void Update()
    {
         if(time > maxTime){

             wall = Instantiate(wallPrefab);
             wall.transform.position = transform.position + new Vector3(0, Random.Range(minHeight,maxHeight),0);
             time = 0;
         }

         time += Time.deltaTime;
         Destroy(wall,8f);
        
    }
}
