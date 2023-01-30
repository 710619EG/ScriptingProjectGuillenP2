using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { //float result is a variable. What "float" is, is that it is like an ID for a variable (Variables can have
      //differernt IDs(For example an int variable has the ID of "int"(
      //which tells the system that the variable is a
      //whole number that is either a zero or a positive number or a negative number and that the system should store
      //it as an integer value variable)
        float result = Mathf.Lerp (2f, 10f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
