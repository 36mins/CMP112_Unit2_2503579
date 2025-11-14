using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public Transform PlayerDirection;
    Vector3 MoveDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

  
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");


        MoveDirection = PlayerDirection.forward * moveVertical + PlayerDirection.right * moveHorizontal;
        rb.AddForce(MoveDirection.normalized * 10f, ForceMode.Force);
    }
}
