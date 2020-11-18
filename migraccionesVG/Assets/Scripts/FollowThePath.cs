using UnityEngine;

public class FollowThePath : MonoBehaviour
{

    public Transform[] waypoints;

    [SerializeField]
    private float moveSpeed = 1f;

    [HideInInspector]
    public int waypointIndex = 0; // el actual waypoint que está ocupando el jugador

    public bool moveAllowed = false;
    public AudioSource noise1;
    public AudioSource[] sounds;

    // Use this for initialization


    private void Start()
    {
        

        //Debug.Log("Esta Madre no jala");
        transform.position = waypoints[waypointIndex].transform.position; //Se cami a tres en waypoin index
        waypointIndex = 0;
        AudioSource[] sounds = GetComponents<AudioSource>();// audioañadido en start
        noise1 = sounds[0];



    }


    // Update is called once per frame
    private void Update()
    {
        if (moveAllowed)
            Move();
    }

    private void Move()
    {
        if (waypointIndex <= waypoints.Length - 1)
        {
            //Debug.Log("Esta es la otra madre");
            transform.position = Vector2.MoveTowards(transform.position,
            waypoints[waypointIndex].transform.position, // Esta madre es el foquin indice
            moveSpeed * Time.deltaTime);

            if (transform.position == waypoints[waypointIndex].transform.position) //lo que hace esta madre es contar las madres rojas
            {
                waypointIndex += 1;
                noise1.Play();
            }
        }
    }
  
    }

