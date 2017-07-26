using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearPlayerPrefs : MonoBehaviour
{
    [SerializeField]
    bool _deleteKeys;

    [SerializeField]
    string[] _keysToDelete;
    
	// Use this for initialization
	void Start ()
	{
	    if(_deleteKeys)
        {
            for(int i = 0; i < _keysToDelete.Length; i++)
            {
                if(PlayerPrefs.HasKey(_keysToDelete[i]))
                {
                    PlayerPrefs.DeleteKey(_keysToDelete[i]);
                    Debug.Log(_keysToDelete[i] + " deleted successfully.");
                }
                else
                {
                    Debug.Log("Failed to delete player pref key: " + _keysToDelete[i]);
                }
            }
        }		
	}
}
