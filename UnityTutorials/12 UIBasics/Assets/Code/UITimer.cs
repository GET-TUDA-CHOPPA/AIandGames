using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class UITimer : MonoBehaviour
{
    Text _textUI;
    float _currentTime;

    void Awake()
    {
        _textUI = this.GetComponent<Text>();
        
        if(_textUI == null)
        {
            Debug.LogWarning("No Text UI instance attached to this GameObject");
        }
    }

	void Start ()
    {
        SetUITimer();
	}

    private void SetUITimer()
    {
        _currentTime += Time.deltaTime;

        int seconds = (int)_currentTime % 60;
        int minutes = (int)_currentTime / 60;
        string time = minutes + ":" + seconds;

        //Formats time into minutes and seconds.
        string formattedTime = String.Format("{0}:{1:00}", minutes, seconds);

        if (_textUI != null)
        {
            _textUI.text = formattedTime;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GameEventManager.GamePlaying)
        {
            SetUITimer();
        }
    }
}
