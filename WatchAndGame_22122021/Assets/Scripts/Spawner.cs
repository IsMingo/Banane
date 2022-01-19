using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public Transform[] PositionSpawner = new Transform[3];
    private int index = 0;
    public float Timer = 0f;
    public GameObject Gift;

    public void Reset()
    {
        
    }

    void Start()
    {
        transform.position = PositionSpawner[index].position;
        
       
      
    }

    // Update is called once per frame
    void Update()
    {  
        Timer += Time.deltaTime;
        index = Random.Range(0,3);
        if (Timer > 2f)
        {
                transform.position = PositionSpawner[index].position;
                Timer = 0f;
                Instantiate(Gift,PositionSpawner[index]);
        }
        
    }

    private void FixedUpdate()
    {
       
        {
            
            
        }
    }
}
