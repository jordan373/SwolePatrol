using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterController : MonoBehaviour {
    //Darrell Wulff 
    //Basic Top Down Character Controller

    //Set and change movespeed in editor
    public float moveSpeed;

    //the player game object needs a rigidbody2D and this "PlayerCharacterController" components attached to it.
    //store a reference to the rigidbody2D
    Rigidbody2D rigid;

    //Use a vector2 to easily multiply and change the player character's velocity
    Vector2 playerInput;


	// Use this for initialization
	void Start ()
    {

        //Use GetComponent at the start  of the scene since it can get expensive to do every frame!
        rigid = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Store the use input values. The Input class is getting the set Axis from the project input manager.
        //Input.GetAxis will return -1 0 and 1 depending on what is being pressed or not pressed.
        playerInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        //Every frame the velocity of the player with be changes depending on the playerInput and moveSpeed value.
        rigid.velocity = playerInput * moveSpeed;
	}
}
