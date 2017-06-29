using UnityEngine;
using System.Collections;

/// <summary>
/// Simple script that emits fireworks on a timer.
/// Each firework also controls its own behaviour courtesy of a separate Firework class.
/// </summary>
public class FireworkEmitter : MonoBehaviour {

    [SerializeField]
    Vector3 _spawnStart;

    [SerializeField]
    Vector3 _spawnEnd;

    [SerializeField]
    GameObject _fireworkObj;

    [SerializeField]
    float _timeBetweenFireworks;

    float _currentTime;

    void Start()
    {
        //Set the timer to zero to begin with.
        _currentTime = 0f;
    }

	// Update is called once per frame
	void Update ()
    {
        //Add the delta time, check whether to spawn a firework.
        _currentTime += Time.deltaTime;

        if(_currentTime >= _timeBetweenFireworks)
        {

            //Reset the timer!
            _currentTime = 0.0f;
            ShootFirework();
        }
    }

    /// <summary>
    /// Handles the firing of the individual fireworks.
    /// </summary>
    private void ShootFirework()
    {
        //Spawn a firework.
        GameObject firework = Instantiate(_fireworkObj);

        //Create a random spawn position and set it for the firework.
        Vector3 spawnPosition = new Vector3(Random.Range(_spawnStart.x, _spawnEnd.x), 0.5f, Random.Range(_spawnStart.z, _spawnEnd.z));
        firework.transform.position = spawnPosition;
    }
}
