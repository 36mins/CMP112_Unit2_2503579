using UnityEngine;

public class CameraPos : MonoBehaviour
{
    public Transform CameraPosition;
    void Awake()
    {
        if (FindObjectsOfType<Camera>().Length > 1)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        transform.position = CameraPosition.position;
    }
}
