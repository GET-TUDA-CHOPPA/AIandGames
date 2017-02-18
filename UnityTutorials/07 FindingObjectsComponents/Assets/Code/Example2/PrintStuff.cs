using Assets.Code.Example1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Code.Example2
{
    enum Method
    {
        FIND_BY_NAME,
        FIND_BY_TAG,
    };

    class PrintStuff: MonoBehaviour
    {
        [SerializeField]
        Method gameObjectSearchMethod;

        [SerializeField]
        string gameObjectName;

        [SerializeField]
        string gameObjectTag;

        WriteStuff writeStuff;

        // Use this for initialization
        public void Start()
        {
            Debug.Log("PRINT STUFF: Ready to print stuff.");

            /**
            * We need to store a reference to the WriteStuff 
            * instance in the scene but need the GameObject 
            * it is attached to.  
            * 
            * I can do this by using multiple approaches, including:
            * 
            * 1) Finding a specific GameObject by name.
            * 2) Finding a game object by tag.
            * 
            * After that, I can then use GetComponent<T>.
            **/
            GameObject gameObject;

            switch(gameObjectSearchMethod)
            {
                case Method.FIND_BY_NAME:
                    gameObject = GameObject.Find(gameObjectName);
                    break;
                case Method.FIND_BY_TAG:
                    gameObject = GameObject.FindGameObjectWithTag(gameObjectTag);
                    break;
                default:
                    gameObject = null;
                    break;
            }

            if (gameObject != null)
            {
                Debug.Log("PRINT STUFF: Looking to see if WriteStuff is attached to the game object we found.");
                writeStuff = gameObject.GetComponent<WriteStuff>();

                if (writeStuff != null)
                {
                    Debug.Log("PRINT STUFF: Hooray, we found WriteStuff.");
                }
                else
                {
                    Debug.LogError("PRINT STUFF: Uh oh, we didn't find WriteSuff.  Can you check it is attached to the game object please");
                }
            }
            else
            {
                Debug.LogError("PRINT STUFF: We couldn't find the GameObject in the scene.");
            }
        }

        // Update is called once per frame
        public void Update()
        {
            if (writeStuff != null)
            {
                string nextString = writeStuff.GetStuff();
                int calls = writeStuff.NumberCalls;
                Debug.Log("PRINT STUFF: " + calls + " - " + nextString);
            }
        }

    }
}
