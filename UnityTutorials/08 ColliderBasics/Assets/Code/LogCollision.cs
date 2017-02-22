using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogCollision : MonoBehaviour 
{
    public void OnCollisionEnter(Collision collision)
    {
        string otherObject = collision.gameObject.name;

        Debug.Log("I just collided with " + otherObject);
    }
}
