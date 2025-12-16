using UnityEngine;

public class Ending : MonoBehaviour
{

    public Canvas ending;

    private void Start()
    {
        ending.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        ending.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        ending.enabled = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
