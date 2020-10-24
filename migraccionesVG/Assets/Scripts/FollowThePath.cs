﻿using UnityEngine;

public class FollowThePath : MonoBehaviour
{

    public Transform[] waypoints;

    [SerializeField]
    private float moveSpeed = 1f;

    [HideInInspector]
    public int waypointIndex = 0;

    public bool moveAllowed = false;

    // Use this for initialization
    private void Start()
    {
        //Debug.Log("Esta Madre no jala");
        transform.position = waypoints[waypointIndex + 3].transform.position; //Se cami a tres en waypoin index


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

            transform.position = Vector2.MoveTowards(transform.position,
            waypoints[waypointIndex].transform.position,
            moveSpeed * Time.deltaTime);

            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;

            }
        }
    }
  
    }

