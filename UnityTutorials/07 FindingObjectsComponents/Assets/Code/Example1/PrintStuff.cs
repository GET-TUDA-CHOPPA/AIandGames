using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Code.Example1
{
    public class PrintStuff : MonoBehaviour
    {
        WriteStuff writeStuff;

        // Use this for initialization
        public void Start()
        {
            Debug.Log("PRINT STUFF: Ready to print stuff.");
            /**
             * We need to store a reference to the WriteStuff instance 
             * that is attached to this game object.  I can do this
             * by using the GetComponent<T> method.
             **/

            Debug.Log("PRINT STUFF: Looking to see if WriteStuff is attached to this game object.");
            writeStuff = this.GetComponent<WriteStuff>();

            if(writeStuff != null)
            {
                Debug.Log("PRINT STUFF: Hooray, we found WriteStuff.");
            }
            else
            {
                Debug.LogError("PRINT STUFF: Uh oh, we didn't find WriteSuff.  Can you check it is attached to the game object please");
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