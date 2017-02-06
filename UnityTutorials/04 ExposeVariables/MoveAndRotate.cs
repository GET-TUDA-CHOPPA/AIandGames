using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndRotate : MonoBehaviour 
{
    [SerializeField]
    Vector3 movementVector = new Vector3(0.01f, 0.0f, 0.0f);

    [SerializeField]
    float rotateX = 0.2f;

    [SerializeField]
    float rotateY = 1f;

    [SerializeField]
    float rotateZ = 2.5f;

    //I decided not to expose this to the inspector.
    float currentScale = 1f;

    [SerializeField]
    float scaleChangePerFrame = 0.001f;

    [SerializeField]
    float speed = 1f;

    [SerializeField]
    bool useSpeed = false;

    [SerializeField]
    Space transformSpace = Space.World;

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
        speed = Time.deltaTime;
        
        Move();

        Rotate();

        Scale();
        
        currentScale = currentScale + scaleChangePerFrame;
    }

    /// <summary>
    /// This method will make the Game Object attached
    /// to this cube move along the x,y,z axis every time
    /// it is called.
    /// </summary>
    public void Move()
    {
        Vector3 movingVector = movementVector;

        if (useSpeed == true)
        {
            movingVector = movingVector * speed;
        }
        
        transform.Translate(movingVector, Space.World);
    }

    /// <summary>
    /// This method will rotate the Game Object attached
    /// to this cube move along the x,y,z axis every time it
    /// is called.
    /// </summary>
    public void Rotate()
    {
        Vector3 rotationVector = new Vector3(rotateX, rotateY, rotateZ);
        transform.Rotate(rotationVector, Space.World);
    }

    /// <summary>
    /// This method will set the scale of the object
    /// in the x,y,z axis.
    /// </summary>
    public void Scale()
    {
        transform.localScale = new Vector3(currentScale, currentScale, currentScale);
    }
}
