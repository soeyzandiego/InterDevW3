using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheatCode : MonoBehaviour
{
    // it's proving difficult to get to the end... so just to trigger the win state

    KeyCode[] keys = { KeyCode.W, KeyCode.O, KeyCode.R, KeyCode.M };
    List<KeyCode> keysPressed = new List<KeyCode>();

    bool triggered = false;

    // Update is called once per frame
    void Update()
    {
        if (triggered) { return; }

        foreach (KeyCode key in keys)
        {
            if (Input.GetKeyDown(key)) { keysPressed.Add(key); }
            if (Input.GetKeyUp(key)) { keysPressed.Clear(); }
        }

        if (keysPressed.Count == 4)
        {
            FindObjectOfType<HeadController>().transform.parent.position = transform.position;
            triggered = true;
        }
    }
}
