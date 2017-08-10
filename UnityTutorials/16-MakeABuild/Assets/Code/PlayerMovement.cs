using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
    [SerializeField]
    float _playerSpeed = 1f;

    float _moveX, _moveZ;

	// Update is called once per frame
	public void Update () 
	{
        _moveX = Input.GetAxis("Horizontal");
        _moveZ = Input.GetAxis("Vertical");
	}

    public void FixedUpdate()
    {
        transform.Translate(new Vector3(_moveX*_playerSpeed, 0, _moveZ*_playerSpeed));
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Respawn")
        {
            Destroy(this.gameObject);
        }
    }
}
