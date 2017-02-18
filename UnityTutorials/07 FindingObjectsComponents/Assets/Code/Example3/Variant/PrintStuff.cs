using Assets.Code.Example1;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Code.Example3.Variant
{
    public class PrintStuff : MonoBehaviour
    {
        [SerializeField]
        WriteStuff writeStuff;

        // Use this for initialization
        public void Start()
        {
            Debug.Log("PRINT STUFF: Ready to print stuff.");

            /**
            * We need to store a reference to the WriteStuff 
            * instance in the scene.  
            * 
            * In this example, I have serialized the WriteStuff
            * instance itself, and we simply drag it to 
            * the variable in the Unity inspector.
            **/
            
            if (writeStuff != null)
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
