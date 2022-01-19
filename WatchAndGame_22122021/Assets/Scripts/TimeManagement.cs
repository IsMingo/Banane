using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeManagement : MonoBehaviour
{
    private float Chrono=10f;
    public GameObject endUI;
    public Button Restart;
    public Player _Player;
    void Start()
    {
        
    }

    private void Update()
    {
        Chrono -= Time.deltaTime;
    }

    
  

    private void FixedUpdate()
    {
        if (Chrono <= 0f)
        {
            Time.timeScale = 0;
            _Player.thisPlayer.SetActive(false);
            endUI.SetActive(true);
        }
    }
    }
