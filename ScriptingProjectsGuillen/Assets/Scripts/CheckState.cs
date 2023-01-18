using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckState : MonoBehaviour
{
    public GameObject myObject;
    // Checking if the Object that this script is attached to is active or unactive
    void Start()
    {
        Debug.Log("Active Self: " + myObject.activeSelf);
        Debug.Log("Active in Hierarchy" + myObject.activeInHierarchy);
    }
}