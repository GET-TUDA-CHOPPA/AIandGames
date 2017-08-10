using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class UIText : MonoBehaviour
{
    Text _textUI;
    
    void Awake()
    {
        _textUI = this.GetComponent<Text>();

        if (_textUI == null)
        {
            Debug.LogWarning("No Text UI instance attached to this GameObject");
        }
    }
}
