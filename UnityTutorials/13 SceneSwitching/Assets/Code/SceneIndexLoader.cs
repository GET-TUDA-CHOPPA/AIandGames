using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneIndexLoader : MonoBehaviour
{
    [SerializeField]
    int _sceneNumber;

    public void LoadScene()
    {
        SceneManager.LoadScene(_sceneNumber);
    }
}
