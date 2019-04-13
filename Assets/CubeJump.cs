using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;

public class CubeJump : MonoBehaviour
{
    // Start is called before the first frame update
    KeyboardInput keyboardInput;
    int note;

    void Start()
    {
        keyboardInput = new KeyboardInput();
    }

    // Update is called once per frame
    void Update()
    {
        //DEC values of midi notes
        for(int i = 0; i < 83; i++)
        {
            float note = MidiMaster.GetKey(i);
            //check velocity
            if (note > 0 && note <= 1.0)
            {
                transform.Translate(Vector3.up * Time.deltaTime);
            }
        }  
    }
}
