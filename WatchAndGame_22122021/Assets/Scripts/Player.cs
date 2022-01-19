using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector2 = System.Numerics.Vector2;

public class Player : MonoBehaviour

{
    public Transform[] positionPlayer = new Transform[3];
    private int index = 0;
    public GameObject Gift;
    public Animator catchAnimation;
    public GameObject thisPlayer;
    public GameObject giftCatched;
    private int score=0;
    public GameObject box
        ;
    public GameObject GiftHanded;
    private bool playerCanCatch;
    void Start()
    {
        transform.position = positionPlayer[index].position;
        catchAnimation=GetComponent<Animator>();
        giftCatched.SetActive(true);
        
    }


    void Update()
    {   
       
        if (index > 0)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                index--;
                transform.position = positionPlayer[index].position;
            }

        }

        if (index <2)
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                index++;
                transform.position = positionPlayer[index].position;
                
            }
        }
        

    }

    private void FixedUpdate()
    {
       
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Cadeau"))
        {  
            GiftHanded.SetActive(true);
            catchAnimation.SetTrigger("CatchTrigger");
            Destroy(other.gameObject);
            playerCanCatch=false;

        }

        if (other.gameObject.CompareTag("box"))
        {
            score++;
            GiftHanded.SetActive(false);
            playerCanCatch = true;
            Debug.Log("marche");

        }
        
        
        
    }

    
}   
    