using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;

public class KeyboardInput : MonoBehaviour
{
    public int noteNumber;
    //MidiChannel channel;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Started 2");
        Debug.Log(MidiMaster.GetKnobNumbers(MidiChannel.Ch1));
        Debug.Log(MidiMaster.GetKnobNumbers(MidiChannel.Ch2));
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(MidiMaster.GetKeyDown(83));
    }
}
