using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccessModifiers : MonoBehaviour
{
    //Creates a variable and sets a value to that variable that any class/void/script can use or modify.
    public int alpha = 5;
    //Creates a variable and sets a value to that variable. But, only any void in the class the variable is in can use or modify that variable
    private int beta = 0;
    private int gamma = 5;

    private AnotherClass myOtherClass;

    // Start is called before the first frame update
    void Start()
    {
        alpha = 29;
        myOtherClass = new AnotherClass();
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
    }
    void Example (int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }
}
