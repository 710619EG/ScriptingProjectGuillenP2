using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInputGetButton : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        bool down = Input.GetButtonDown("Jump");
        bool held = Input.GetButton("Jump");
        bool up = Input.GetButtonUp("Jump");
        if(down)
        {
            Debug.Log("Jump is down:" + down);
        }
        else if (held)
        {
            Debug.Log("Jump is held: " + held);
        }
        else if (up)
        {
            Debug.Log("Jump is up: " + up);
        }
        Debug.Log("Jump is down: " + down);
        Debug.Log("Jump is held: " + held);
        Debug.Log("Jump is up: " + up);
    }
}
