using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointsManager : MonoBehaviour
{
    public Transform[] waypoints;

    public Transform GetRandomWaypoint()
    {
        int index = Random.Range(0, waypoints.Length);
        return waypoints[index];
    }

    public Vector3 GetRandomWaypointPosition()
    {
        return GetRandomWaypoint().position;
    }
}
