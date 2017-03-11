using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceMovement : MonoBehaviour
{
    [SerializeField]
    string _movementX;

    [SerializeField]
    string _movementZ;

    [SerializeField]
    float _speed;

    Rigidbody _rigidBody;
    float _moveX;
    float _moveZ;

    void Start()
    {
        _rigidBody = this.GetComponent<Rigidbody>();

        if (_rigidBody == null)
        {
            Debug.LogError("Rigid body could not be found.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        _moveX = Input.GetAxis(_movementX);
        _moveZ = Input.GetAxis(_movementZ);
    }

    void FixedUpdate()
    {
        if (_rigidBody != null)
        {
            Vector3 moveVector = new Vector3(_moveX, 0, _moveZ) * _speed;
            _rigidBody.AddForce(moveVector, ForceMode.Acceleration);
        }
    }

}
