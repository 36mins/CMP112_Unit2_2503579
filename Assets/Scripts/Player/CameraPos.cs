using UnityEngine;

public class CameraPos : MonoBehaviour
{
    public Transform CameraPosition; 
    void Awake()
    {
        if (FindObjectsOfType<Camera>().Length > 1)     //If more than 1 camera exists in a scene it destroys itself
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);  //camera does not get destroyed when swapping scene
    }

    void Update()
    {
        transform.position = CameraPosition.position; //Moves the camera to a location(The player)
    }
}
