using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Code.Example1
{
    public class WriteStuff : MonoBehaviour
    {
        int numberCalls;

        /**
         * You may notice that I only have one MonoBehaviour method 
         * in this example.
         * 
         * It's important to realise that we don't NEED to write
         * these MonoBehaviour methods all the time.  
         * When you write that code in your C# class, 
         * then Unity will pay attention to them.
         * 
         * In this instance I only actually need Start. 
         **/
        public void Start()
        {
            Debug.Log("WRITE STUFF: Ready to write stuff.");

            //I don't *need* to do this, but I like to be explicit about it.
            numberCalls = 0;
        }
        
        
        public string GetStuff()
        {
            //Increase the count of the number of calls.
            numberCalls++;

            //Return the string that says "STUFF".
            return "STUFF";
        }

        public int NumberCalls
        {
            get
            {
                return numberCalls;
            }
        }
    }
}
