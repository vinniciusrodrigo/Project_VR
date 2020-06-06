using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    private static GameObject Player;
    private static GameObject previousWaypoints;
    void Awake()
    {
        //Executado antes do start
        if(!Player){
            Player = GameObject.FindGameObjectWithTag("Player");

        }
    }

    public void Move()
    {
        Player.transform.position = this.transform.position;

        if(previousWaypoints){
            previousWaypoints.SetActive(true);
        }

        previousWaypoints = this.gameObject;
        this.gameObject.SetActive(false);
      }
}
