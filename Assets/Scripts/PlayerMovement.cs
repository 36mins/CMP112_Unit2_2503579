using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

  
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");


        Vector3 moveVector = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(moveVector * speed);
    }
}
