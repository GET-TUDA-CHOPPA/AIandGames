using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class UICounter : MonoBehaviour
{
    [SerializeField]
    bool _bestBounces;

    [SerializeField]
    BounceCounter _bounceCounter;
    
    Text _textUI;
    int _currentBounces;
    int _bestBounceCount;

    void Awake()
    {
        _textUI = this.GetComponent<Text>();
        
        if(_textUI == null)
        {
            Debug.LogWarning("No Text UI instance attached to this GameObject");
        }

        if(_bounceCounter == null)
        {
            Debug.LogError("No BounceCounter instance attached.");
        }

        if(_bestBounces)
        {
            if (PlayerPrefs.HasKey("BestBounces"))
            {
                _bestBounceCount = PlayerPrefs.GetInt("BestBounces");
            }
        }
    }

	void Start ()
    {
        SetBounceCounter();
	}

    private void SetBounceCounter()
    {
        if (_textUI != null && _bounceCounter != null)
        {
            _currentBounces = _bounceCounter.BounceCount;

            if (_bestBounces)
            {
                if(_currentBounces > _bestBounceCount)
                {
                    _bestBounceCount = _currentBounces;

                    PlayerPrefs.SetInt("BestBounces", _bestBounceCount);
                    PlayerPrefs.Save();
                }

                _textUI.text = "Best: " + _bestBounceCount;
            }
            else
            {
                _textUI.text = "Bounces: " + _currentBounces;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        SetBounceCounter();
    }
}
