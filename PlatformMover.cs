using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    bool desReached = false;

    private Vector3 StartPos;
    public Transform target;

    public float Speed;

    void Start()
    {
        StartPos = transform.position;
    }

    void Update()
    {
        float step = Speed * Time.deltaTime;

        if(transform.position == target.position)
        {
            desReached = true;
        }
        else if(transform.position == StartPos)
        {
            desReached = false;
        }

        if(desReached == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
        else if(desReached == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, StartPos, step);
        }
    }
}
