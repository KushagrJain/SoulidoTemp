using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Inspector Referenced Objects
    public CharacterController2D controller;

    //Public variables
    public float runSpeed = 40f;

    //Private variables
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    // Update is called once per frame
    void Update()
    {
        //Check value of horizontal input axis
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed * Time.deltaTime;

        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if(Input.GetButtonDown("Crouch"))
        {
            crouch = !crouch;
        }        
    }

    //Fixed Update is called a fixed number of times each second
    private void FixedUpdate()
    {
        UpdateMovement();
    }

    //Update Movement
    void UpdateMovement()
    {
        controller.Move(horizontalMove, crouch, jump);
        jump = false;
    }
}
