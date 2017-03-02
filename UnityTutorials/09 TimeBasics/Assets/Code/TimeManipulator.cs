using UnityEngine;
using System.Collections;

public class TimeManipulator : MonoBehaviour
{
    [SerializeField]
    float _timeScale;
    
	// Use this for initialization
	public void Start ()
    {
        Time.timeScale = _timeScale;
	}

    public void Update()
    {
        /**
         * These if checks are reliant on the fact I decided
         * to make both of these values exposed in the inspector.
         * It means I can now manipulate those variables and 
         * in the event they differ from what was before, it will
         * change the target frame rate and/or time scale accordingly.
         **/

        if(_timeScale != Time.timeScale)
        {
            Time.timeScale = _timeScale;
        }
    }
}
