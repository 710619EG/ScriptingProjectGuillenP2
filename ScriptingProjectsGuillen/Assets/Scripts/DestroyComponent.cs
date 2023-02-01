using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyComponent : MonoBehaviour
{
     void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Destroy(GetComponent<MeshRenderer>());
        }
    }
}
