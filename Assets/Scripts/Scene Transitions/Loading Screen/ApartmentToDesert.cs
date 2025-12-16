using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    int currentTimeInt;
    public float StartTime;

    void Start()
    {
        currentTime = StartTime; 
    }
    void Update()
    {
        currentTime = currentTime - Time.deltaTime; //current time counts down
        currentTimeInt = System.Convert.ToInt32(currentTime);

        if (currentTimeInt == 0)  //If the time hits 0 then load the scene
        {
            SceneManager.LoadScene(2);
        }
    }
}