using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass : MonoBehaviour
{
    public int apples;
    public int bananas;
    private int stapler;
    private int stellotape;
    public void FruitMachine(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("friut total: " + answer);
    }
    private void OfficeSort (int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Office Supplies total: " + answer);
    }
}