using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStart : MonoBehaviour
{
    void Awake()
    //References between scripts, initialization
    {
        Debug.Log("Awake called.");
    }

    void Start()
        // Start is only run once once the script component is enabled.Start is also run before the first frame update
    {
        Debug.Log("Start called");
    }
}
