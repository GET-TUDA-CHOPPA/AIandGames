using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogTrigger : MonoBehaviour 
{
    public void OnTriggerEnter(Collider other)
    {
        string name = other.gameObject.name;

        Debug.Log(name + " just entered the trigger volume.");
    }

    public void OnTriggerExit(Collider other)
    {
        string name = other.gameObject.name;

        Debug.Log(name + " just left the trigger volume.");
    }
}
