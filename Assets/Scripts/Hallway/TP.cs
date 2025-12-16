using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP : MonoBehaviour
{
    public GameObject TPlocation;   //The location the player is sent to
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.root.position = TPlocation.transform.position; //Moves the player ( and the camera ) to a specific location
        }
    }
}
