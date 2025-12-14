using UnityEngine;

public class CameraPos : MonoBehaviour
{
    public Transform CameraPosition;
    void Update()
    {
        transform.position = CameraPosition.position;
    }
}
