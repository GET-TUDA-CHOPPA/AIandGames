using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    [SerializeField]
    float _timeBetweenSpawns = 5f;

    [SerializeField]
    GameObject[] _prefabs;

    BoxCollider collider;
    Bounds _spawnBounds;
    float currentTimer = 0f;
    bool _ok;


	// Use this for initialization
	void Start ()
    {
        _ok = true;
        collider = GetComponent<BoxCollider>();

        if(collider == null)
        {
            Debug.LogError("No Box Collider attached to game object.");
            _ok = false;
        }
        else
        {
            _spawnBounds = collider.bounds;
        }

        if(_prefabs == null || _prefabs.Length == 0)
        {
            Debug.LogError("No prefabs attached.");
            _ok = false;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (_ok)
        {
            currentTimer += Time.deltaTime;

            if (currentTimer >= _timeBetweenSpawns)
            {
                currentTimer = 0;

                float spawnX = Random.Range(-_spawnBounds.extents.x, _spawnBounds.extents.x);
                float spawnY = transform.position.y;
                float spawnZ = transform.position.z;

                //SPAWN OBJECT
                GameObject newItem = Object.Instantiate(GetPrefab()) as GameObject;
                newItem.transform.position = new Vector3(spawnX, spawnY, spawnZ);
            }
        }
	}

    private GameObject GetPrefab()
    {
        int index = Random.Range(0, _prefabs.Length);

        return _prefabs[index];
    }
}
