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
        Cursor.visible = true;                              //allows the player to click the button on the canvas
        Cursor.lockState = CursorLockMode.None;
        ending.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        ending.enabled = false;             //gets rid of the mouse
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
