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
    
    void Start()
    {
       // player1StartWaypoint = 0; //se puso este nuevo
        whoWinsTextShadow = GameObject.Find("WhowinsText");   
        player1 = GameObject.Find("Player1");
        player1.GetComponent<FollowThePath>().moveAllowed = false;  
        player1StartWaypoint = 0;
        Debug.Log("Esta madre deberia ser 0");             
    }
       
    void Update()
    {

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

    void reset()
    {
        
        
        Debug.Log("Esta madre deberia resetearse");
    }



    }

