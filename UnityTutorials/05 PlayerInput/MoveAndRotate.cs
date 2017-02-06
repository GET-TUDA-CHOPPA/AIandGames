using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndRotate : MonoBehaviour 
{
    [SerializeField]
    float speed = 1f;

    [SerializeField]
    bool scaleToTime = false;
   
	// Update is called once per frame
	void Update () 
	{
        if(scaleToTime)
        {
            speed = Time.deltaTime;
        }
    }

    /// <summary>
    /// This method will make the Game Object attached
    /// to this cube move along the x,y,z axis every time
    /// it is called.
    /// </summary>
    public void Move(float moveX, float moveY)
    {
        //Derive movement from the incoming values on X and Y axis.
        Vector3 movingVector = new Vector3(moveX, moveY, 0.0f);
        //Now multiply the vector by the speed
        movingVector *= speed;

        transform.Translate(movingVector);
    }

    /// <summary>
    /// This method will rotate the Game Object attached
    /// to this cube move along the x,y,z axis every time it
    /// is called.
    /// </summary>
    public void Rotate(float rotateX, float rotateY)
    {
        transform.Rotate(new Vector3(rotateX, rotateY, 0f));
    }
}
