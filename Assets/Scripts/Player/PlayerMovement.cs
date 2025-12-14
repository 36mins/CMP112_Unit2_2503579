using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float MovementSpeed;
    public Transform Direction;
    public float GroundDrag;
    public float AirDrag;

    float horizontalInput;
    float verticalInput;

    Vector3 MoveDirection;
    Rigidbody Rigidbody;

    [Header("Ground Check")]
    public float PlayerHeight;
    public LayerMask Ground;
    bool grounded;

    [Header("Jumping")]
    public float JumpPower;
    public float JumpCooldown;
    bool Jump;
    public KeyCode jumpKey = KeyCode.Space;

    [Header("Sprint")]
    public float SprintMultiplier;
    public KeyCode Sprinting = KeyCode.LeftShift;
    private bool IsSprinting;

  


    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        Rigidbody.freezeRotation = true; //Stops rotation of the Player Object

        Jump = true;  //Allows the player to jump for the start
    }

    void Update()
    {
        MyMovement();

    }

    void FixedUpdate()
    {
        CalcMovement();
    }

    private void MyMovement()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal"); //WASD movement keys
        verticalInput = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(jumpKey) && Jump && grounded) //If these are met the player can jump
        {
            Jump = false; //So cant double jump
            Jumping(); //Function for jumping
            Invoke(nameof(canJump), JumpCooldown); //allows the player to jump again after a very small delay

        }

        grounded = Physics.Raycast(transform.position, Vector3.down, PlayerHeight * 0.90f + 0.2f, Ground);  //Uses Raycast to check see if the player is on the ground
        if (grounded)
        {
            Rigidbody.linearDamping = GroundDrag;  //Applys drag when moving on the ground
        }
        else
        {
            Rigidbody.linearDamping = AirDrag; //Less drag while in the air
        }

        IsSprinting = Input.GetKey(Sprinting); //Checks if the player is sprinting

    }

    private void CalcMovement()
    {
        float currentSpeed = MovementSpeed;

        MoveDirection = Direction.forward * verticalInput + Direction.right * horizontalInput; //Calculates movement based of the input and direction facing

        if (Input.GetKey(Sprinting))
        {
            currentSpeed *= SprintMultiplier; //Increase speed for sprinting
        }
        if (grounded)
        {
            Rigidbody.AddForce(MoveDirection.normalized * currentSpeed * 10f, ForceMode.Force); //Adds the force to move while on the ground
        }
        else
        {
            Rigidbody.AddForce(MoveDirection.normalized * currentSpeed * 3f, ForceMode.Force); //Adds less force while in the air
        }
    }


    private void Jumping()
    {
        Rigidbody.linearVelocity = new Vector3(Rigidbody.linearVelocity.x, 0f, Rigidbody.linearVelocity.z); //Resets vertical velocity 
        Rigidbody.AddForce(Vector3.up * JumpPower, ForceMode.Impulse); //Impulse force to jump
    }
    private void canJump()
    {
        Jump = true; //Allows tthe player to jump again
    }

}
