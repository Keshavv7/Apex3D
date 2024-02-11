using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed = 10f;
    public float closeRange = 0.2f;

    private Transform target;
    private int waypointIndex = 0;

    private void Start()
    {
        target = Waypoints.points[waypointIndex];
    }


    private void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        float distance = Vector3.Distance(transform.position, target.position);

        

        if (distance < closeRange)
        {
            getNextWaypoint();
        }
    }

    void getNextWaypoint()
    {
        if (waypointIndex >= Waypoints.points.Length - 1)
        {
            Destroy(gameObject);
        }
        else
        {
            waypointIndex++;
            target = Waypoints.points[waypointIndex];
        }
    }
}
