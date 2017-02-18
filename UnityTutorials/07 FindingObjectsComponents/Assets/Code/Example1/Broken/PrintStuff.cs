using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Code.Example1.Broken
{
    public class PrintStuff : MonoBehaviour
    {
        WriteStuff writeStuff;

        // Use this for initialization
        public void Start()
        {
            Debug.Log("PRINT STUFF: Ready to print stuff.");

            /**
             * I'm using the GetComponent<T> method as before, but in
             * my Example1Broken scene, the WriteStuff component simply
             * isn't there, so this value will store null.
             **/

            Debug.Log("PRINT STUFF: Looking to see if WriteStuff is attached to this game object.");
            writeStuff = this.GetComponent<WriteStuff>();
        }

        // Update is called once per frame
        public void Update()
        {
            /** 
             * I have removed the code that checked whether writeStuff is null.
             * If that component is not attached to the game object, then
             * this code will crash at run time.  
             * 
             * It will crash because writeStuff is null and we're trying
             * to call a method on a variable that is empty.  This means
             * that it will cause a Null Reference Exception which will
             * be printed in the Unity console.
             **/
            string nextString = writeStuff.GetStuff();
            int calls = writeStuff.NumberCalls;
            Debug.Log("PRINT STUFF: " + calls+ " - " +nextString);
        }
    }
}
