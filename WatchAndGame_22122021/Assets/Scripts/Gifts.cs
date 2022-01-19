using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gifts : MonoBehaviour
{
    public Rigidbody2D _Rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        
        _Rigidbody2D=this.gameObject.GetComponent<Rigidbody2D>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    private void FixedUpdate()
    {
        
        {
            
        }
    }
    void OnCollisionEnter2D(Collision2D other )
    {       
       
            if (other.gameObject)
            { 
                        Destroy(this.gameObject);
                    
            }
        
        
    }
}
