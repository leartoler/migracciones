using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
	public GameObject player1;
	public GameObject LoadLevelPollero;
	public GameObject LoadLevelMara;

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
    			SceneManager.LoadScene("Historia_Raite");
    			SceneManager.LoadScene("Historia_ Maras");
    			SceneManager.LoadScene("Historia_Medicinas");
    			SceneManager.LoadScene("Historia_Migracion");
    			SceneManager.LoadScene("Historia_Narcotrafico");
    			SceneManager.LoadScene("Historia_Pollero");
    			SceneManager.LoadScene("Historia_PolleroNL");
    			SceneManager.LoadScene("Historia_Asalto");
    			SceneManager.LoadScene("Historia_Secuestran");
    			SceneManager.LoadScene("Historia_TrenBestia");
    			SceneManager.LoadScene("Historia_Albergue");
    			SceneManager.LoadScene("Historia_Desierto");
    			SceneManager.LoadScene("Historia_Empleo");
    			SceneManager.LoadScene("Historia_Intento");
    		}    		
    	}
    }

    public void OnTriggerExit2D(Collider2D other)
    {
    	
    	isTiming = false;
    	timeLeft = 1f;
    }
}