using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndRotate : MonoBehaviour 
{
    float speed = 0.25f;
    float scale = 1f;

	// Use this for initialization
	void Start ()
	{
        //Debug.Log(transform);

        Transform myTransform = this.transform;
        Debug.Log(myTransform.position);
	}
	
	// Update is called once per frame
	void Update () 
	{
        speed = Time.deltaTime;
        
        //Move();

        //Rotate();

        Scale();
        
        scale = scale + 0.05f;
    }

    /// <summary>
    /// This method will make the Game Object attached
    /// to this cube move along the x,y,z axis every time
    /// it is called.
    /// </summary>
    public void Move()
    {
        Vector3 movementVector = new Vector3(1.0f, 0.5f, 1.5f) * speed;
        transform.Translate(movementVector);
    }

    /// <summary>
    /// This method will rotate the Game Object attached
    /// to this cube move along the x,y,z axis every time it
    /// is called.
    /// </summary>
    public void Rotate()
    {
        Vector3 rotationVector = new Vector3(1.0f, 0.0f, 0.0f);
        transform.Rotate(rotationVector);
    }

    /// <summary>
    /// This method will set the scale of the object
    /// in the x,y,z axis.
    /// </summary>
    public void Scale()
    {
        transform.localScale = new Vector3(scale, scale, scale);
    }
}
