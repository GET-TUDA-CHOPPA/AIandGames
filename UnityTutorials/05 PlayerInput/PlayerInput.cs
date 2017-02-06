using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour 
{
    MoveAndRotate moveComponent;

	// Use this for initialization
	void Start ()
	{
        /**
         * When we begin, I need to grab a reference 
         * to the MoveAndRotate component so I can call 
         * it when I need to.
         **/
        moveComponent = this.GetComponent<MoveAndRotate>();

        //If we didn't retrieve the MoveAndRotate instance, tell me in the console.
        if(moveComponent == null)
        {
            Debug.LogError("No MoveAndRotate instance found attached to this game object.");
        }

	}
	
	// Update is called once per frame
	void Update () 
	{
        /** 
         * In each frame, we will grab input from the following:
         * - The MovementX and MovementY axis.
         * - The RotateX and RotateY axis.
         * - The Pulse Button.
         * Once acquired, we can then call the appropriate methods.
         **/

        float moveX = Input.GetAxis("MovementX");
        float moveY = Input.GetAxis("MovementY");
        float rotateX = Input.GetAxis("RotateX");
        float rotateY = Input.GetAxis("RotateY");

        moveComponent.Move(moveX, moveY);
        moveComponent.Rotate(rotateX, rotateY);

        bool pressed = Input.GetButtonDown("Pulse");

        if(pressed)
        {
            Pulse();
        }
	}

    private void Pulse()
    {
        Debug.Log("PULSE!");
    }
}
