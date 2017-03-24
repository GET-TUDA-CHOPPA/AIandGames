using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieAndReturn : MonoBehaviour 
{
    public void OnDestroy()
    {
        SceneIndexLoader indexLoader;
        SceneNameLoader nameLoader;

        indexLoader = GetComponent<SceneIndexLoader>();
        nameLoader = GetComponent<SceneNameLoader>();

        if(indexLoader != null)
        {
            indexLoader.LoadScene();
        }
        else if(nameLoader != null)
        {
            nameLoader.LoadScene();
        }
        else
        {
            Debug.LogError("Attempted to load scene but not scene loading component attached.");
        }
    }
}
