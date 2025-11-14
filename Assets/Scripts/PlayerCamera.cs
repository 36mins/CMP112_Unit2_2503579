using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public float sensX;
    public float sensY;
    float xRotation;
    float yRotation;
    public Transform Direction;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;  //Locks the curser in the center of the screen
        Cursor.visible = false;  //Hides the curser
    }

    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * sensX;  //Gets the mouses horizontal movement
        float mouseY = Input.GetAxisRaw("Mouse Y") * sensY;  //Gets the mouses vertical movement

        yRotation += mouseX; //Turn left and right
        xRotation -= mouseY; //inverts looks like a normal person
        xRotation = Mathf.Clamp(xRotation, -85f, 85f); //Stops the camera from flipping

        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f); //Rotates the camera on all axes's
        Direction.rotation = Quaternion.Euler(0f, yRotation, 0f); //Prevents the player from tipping

    }


}
