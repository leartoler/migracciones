using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class GameControl : MonoBehaviour
{
    private static GameObject whoWinsTextShadow, player1MoveText;
    private static GameObject player1;
    public static int diceSideThrown = 0;
    public static int player1StartWaypoint = 0;
    public static bool gameOver = false;
    //public AudioSource noise1;
    //public AudioSource noise2;
    //public AudioSource[] sounds;

    void Start()
    {
       // player1StartWaypoint = 0; //se puso este nuevo
        whoWinsTextShadow = GameObject.Find("WhowinsText");   
        player1 = GameObject.Find("Player1");
        player1.GetComponent<FollowThePath>().moveAllowed = false;  
        player1StartWaypoint = 0;
        //AudioSource[] sounds = GetComponents<AudioSource>();
        //noise1 = sounds[0];
        //noise2 = sounds[1];
    }
       
    void Update()
    {
        //noise1.Play();
        //noise2.Play();
        if (player1.GetComponent<FollowThePath>().waypointIndex >
            player1StartWaypoint + diceSideThrown)
        {
            player1.GetComponent<FollowThePath>().moveAllowed = false;            
            player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex - 1;   //aqui va 1, que es donde se detiene pero da 1 porque es de esas madres que tiene menos 1                   
        }        
    }

    public static void MovePlayer(int playerToMove)
    {
        switch (playerToMove)
        {
            case 1:
                player1.GetComponent<FollowThePath>().moveAllowed = true;
                break;
        }
    }   
    }

