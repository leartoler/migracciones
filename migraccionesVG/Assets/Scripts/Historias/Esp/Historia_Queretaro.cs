﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Historia_Queretaro : MonoBehaviour
{
	public GameObject player1;
	public float timeLeft = 1f;
	private bool isTiming = false; 
    

    void OnTriggerEnter2D(Collider2D other)
    {
     	isTiming = true; 
    }

    void Update()
    {    	
    	if(isTiming)
    	{
    		timeLeft -= Time.deltaTime;
    		if (timeLeft <= 0)
    		{    			
    			
                SceneManager.LoadScene("Historia_Queretaro"); //Originalmente aquí está "HIstoria_TrenBestia"
    			
    		}    		
    	}
    }

    public void OnTriggerExit2D(Collider2D other)
    {    	
    	isTiming = false;
    	timeLeft = 1f;
    }
}