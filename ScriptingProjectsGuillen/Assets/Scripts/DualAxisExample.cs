using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualAxisExample : MonoBehaviour
{
    void Start()
    {
        transform.position = new (-2.24f, 0.5f, 7.11f);
    }
    public float hRange;
    public float vRange;

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float xPos = h * hRange;
        float yPos = v * vRange;
        transform.position = new Vector3(xPos, yPos, 7.11f);
    }
}
