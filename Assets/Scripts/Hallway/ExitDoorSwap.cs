using UnityEngine;
using System.Collections;

public class ExitDoorSwap : MonoBehaviour
{
    public GameObject FakeDoor; 
    public GameObject RealDoor;

    public float minTime = 1f;
    public float maxTime = 4f;      //The wait time before swapping the doors

    void Start()
    {
      
        FakeDoor.SetActive(true);   
        RealDoor.SetActive(false);

        StartCoroutine(SwitchObjects());
    }

    IEnumerator SwitchObjects()
    {
        while (true)    //Infiate loop
        {
            float waitTime = Random.Range(minTime, maxTime);    //random wait time
            yield return new WaitForSeconds(waitTime);  //Pauses for that random time

            
            bool turnOn = Random.value > 0.5f; //50% chance to turn a door off or on

            FakeDoor.SetActive(turnOn); 
            RealDoor.SetActive(!turnOn);    //Makes sure only 1 door is turned on at a time
        }
    }
}
