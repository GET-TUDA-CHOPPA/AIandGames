using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNameLoader: MonoBehaviour
{
    [SerializeField]
    string _sceneName;

    public void LoadScene()
    {
        SceneManager.LoadScene(_sceneName);
    }
}

