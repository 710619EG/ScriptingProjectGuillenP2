using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualAxisExample : MonoBehaviour
{
    public float hRange;
    public float vRange;
    void Start()
    {
        transform.position = new (-2.24f, 1, 7.11f);
      
    }    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float xPos = h * hRange;
        float yPos = v * vRange;
        transform.position = new Vector3(xPos, yPos, 7.11f);
        Debug.Log(h.ToString("F2"));
        Debug.Log(v.ToString("F2"));
    }
}
