using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformMovement : MonoBehaviour
{
    [SerializeField]
    string _movementX;

    [SerializeField]
    string _movementZ;

    [SerializeField]
    float _speed;

    float _moveX;
    float _moveZ; 
    
	// Update is called once per frame
	void Update ()
    {
        _moveX = Input.GetAxis(_movementX);
        _moveZ = Input.GetAxis(_movementZ);
	}

    void FixedUpdate()
    {
        Vector3 moveVector = new Vector3(_moveX, 0, _moveZ) * (Time.deltaTime * _speed);
        this.transform.Translate(moveVector, Space.World);
    }
}
