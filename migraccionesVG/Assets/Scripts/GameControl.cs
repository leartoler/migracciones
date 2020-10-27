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
        whoWinsTextShadow = GameObject.Find("WhowinsText");   
        player1 = GameObject.Find("Player1");
        player1.GetComponent<FollowThePath>().moveAllowed = false;
        whoWinsTextShadow.gameObject.SetActive(false);
        player1MoveText.gameObject.SetActive(true);        
    }
       
    void Update()
    {
        if (player1.GetComponent<FollowThePath>().waypointIndex >
            player1StartWaypoint + diceSideThrown)
        {
            player1.GetComponent<FollowThePath>().moveAllowed = false;            
            player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex - 1;

            if (player1.GetComponent<FollowThePath>().waypointIndex ==
            player1.GetComponent<FollowThePath>().waypoints.Length - 3)
            {
                SceneManager.LoadScene("Tenosique");
            }
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
