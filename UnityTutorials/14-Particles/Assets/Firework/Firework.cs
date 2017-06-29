using UnityEngine;
using System.Collections;

public class Firework : MonoBehaviour
{

    [SerializeField]
    ParticleSystem _fireworkBase;

    [SerializeField]
    ParticleSystem _fireworkExplosion;

    [SerializeField]
    float _maxLifespan;

    [SerializeField]
    float startSpeed;

    float _lifespan;
    float _lifeTimer;
    bool _exploded;
    Rigidbody _rigidBody;

    // Use this for initialization
	void Start ()
    {
        //Start the timer.
        _lifeTimer = 0f;
        _exploded = false;

        //Set a random lifespan based on the provided max.
        _lifespan = Random.Range(_maxLifespan / 2, _maxLifespan);

        //Play the firework base until we want it to explode.
        _fireworkBase.Play();

        //Lastly, apply some force and shoot it into the air.
        _rigidBody = this.GetComponent<Rigidbody>();
        _rigidBody.AddForce(new Vector3(0, startSpeed, 0), ForceMode.Impulse);

	}
	
	// Update is called once per frame
	void Update ()
    {
        //If we're not ready to explode yet, update the timer.
        if (!_exploded)
        {
            //Add the time.
            _lifeTimer += Time.deltaTime;

            //Check whether to explode and switch particle systems.
            if (_lifeTimer >= _lifespan)
            {
                //Stop one particle system.
                _fireworkBase.Stop();
                _exploded = true;
                
                //Start the other one.
                _fireworkExplosion.Play();
                _rigidBody.velocity = Vector3.zero;
            }
        }
        else
        {
            //Destroy the object once the explosion is concluded.
            if(_fireworkExplosion.isStopped)
            {
               GameObject.Destroy(this.gameObject);
            }
        }
	}

    //Clean up our references on destroy.
    void OnDestroy()
    {
        _fireworkExplosion = null;
        _fireworkBase = null;
    }
}
