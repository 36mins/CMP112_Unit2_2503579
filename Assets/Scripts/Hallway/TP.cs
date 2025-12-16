using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP : MonoBehaviour
{
    public GameObject TPlocation;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.root.position = TPlocation.transform.position;
        }
    }



}
