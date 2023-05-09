using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public GameObject[] waypoints;
    int currentWP = 0;

    public float speed = 5.0f;
   
    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(this.transform.position, waypoints[currentWP].transform.position) < 1)
            currentWP++;

        if (currentWP >= waypoints.Length)
            currentWP = 0;
        // immediate turn without rotation, no need for rotSpeed variable
        this.transform.LookAt(waypoints[currentWP].transform);

        this.transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
