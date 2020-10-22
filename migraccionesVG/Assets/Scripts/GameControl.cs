using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //6:03

public class GameControl : MonoBehaviour
{
    private static GameObject whoWinsTextShadow, player1MoveText;
    private static GameObject player1;
    public static int diceSideThrown = 0;
    public static int player1StartWaypoint = 0;
    public static bool gameOver = false;
    public New_Level newLevel;
    //public BoxCollider2D collider2D;

    // Start is called before the first frame update
    void Start()
    {
        whoWinsTextShadow = GameObject.Find("WhowinsText");
        //player1MoveText = GameObject.Find("player1MoveText");

        player1 = GameObject.Find("Player1");


        player1.GetComponent<FollowThePath>().moveAllowed = false;
        whoWinsTextShadow.gameObject.SetActive(false);
        player1MoveText.gameObject.SetActive(true);
        //collider2D.enabled = false; //7:22
        //SceneManager.LoadScene("Punto3"); // 6:10
    }

    // Update is called once per frame
    void Update()
    {
        if (player1.GetComponent<FollowThePath>().waypointIndex >
            player1StartWaypoint + diceSideThrown)
        {
            player1.GetComponent<FollowThePath>().moveAllowed = false;
            //player1MoveText.gameObject.SetActive(false);
            player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex - 1;
            
                if (player1.GetComponent<FollowThePath>().waypointIndex ==
                player1.GetComponent<FollowThePath>().waypoints.Length - 30)
            {
                SceneManager.LoadScene("Punto1");
            }
            if (player1.GetComponent<FollowThePath>().waypointIndex ==
            player1.GetComponent<FollowThePath>().waypoints.Length - 29)
            {
                SceneManager.LoadScene("Punto2");
            }
            if (player1.GetComponent<FollowThePath>().waypointIndex ==
            player1.GetComponent<FollowThePath>().waypoints.Length - 28)
            {
                SceneManager.LoadScene("Punto3");
            }


            //SceneManager.LoadScene("Punto2");//<--------
            //collider2D.enabled = true; // 7:23
            Debug.Log("wewewew");

            //Se pondr[ia au[i lo del ontriggerenter

        }
        //Esto es para cuando llegue al final
        if (player1.GetComponent<FollowThePath>().waypointIndex ==
            player1.GetComponent<FollowThePath>().waypoints.Length)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            whoWinsTextShadow.GetComponent<Text>().text = "Juagador gana";
            gameOver = true;

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
