using Assets.Code.Example1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Code.Example3
{
    class PrintStuff: MonoBehaviour
    {
        [SerializeField]
        GameObject gameObject;

        WriteStuff writeStuff;

        // Use this for initialization
        public void Start()
        {
            Debug.Log("PRINT STUFF: Ready to print stuff.");

            /**
            * We need to store a reference to the WriteStuff 
            * instance in the scene.  
            * 
            * In this example, instead of calling a method in
            * the code, I serialize the field and then attach
            * a GameObject to the variable in the Unity inspector.
            **/

            if (gameObject != null)
            {
                Debug.Log("PRINT STUFF: Looking to see if WriteStuff is attached to this game object.");
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
                Debug.LogError("PRINT STUFF: No GameObject attached in inspector.");
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
