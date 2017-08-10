using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour 
{
    int _bounceCount;

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            _bounceCount++;
        }
    }

    public int BounceCount
    {
        get
        {
            return _bounceCount;
        }
    }
}
