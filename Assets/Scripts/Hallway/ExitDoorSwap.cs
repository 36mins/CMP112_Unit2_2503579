using UnityEngine;
using System.Collections;

public class ExitDoorSwap : MonoBehaviour
{
    public GameObject FakeDoor;
    public GameObject RealDoor;

    public float minTime = 1f;
    public float maxTime = 4f;

    void Start()
    {
      
        FakeDoor.SetActive(true);
        RealDoor.SetActive(false);

        StartCoroutine(SwitchObjects());
    }

    IEnumerator SwitchObjects()
    {
        while (true)
        {
            float waitTime = Random.Range(minTime, maxTime);
            yield return new WaitForSeconds(waitTime);

            
            bool turnOn = Random.value > 0.5f;

            FakeDoor.SetActive(turnOn);
            RealDoor.SetActive(!turnOn);
        }
    }
}
