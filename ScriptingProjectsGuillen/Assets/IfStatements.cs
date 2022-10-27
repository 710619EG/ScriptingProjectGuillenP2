using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    // The 3 lines of code below creates a variable that is the temperature of a cup of coffee(in degrees Fahrenheit). As well as the temperature range I am willing to drink it. Which is any tempurature in-between 40 deg Fahrenheit to 70 deg Fahrenheit.
    float coffeeTempurature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTempurature -= Time.deltaTime * 5f;
    }

    
    void TemperatureTest()
    {
        if (coffeeTempurature > hotLimitTemperature)
        {
            print("Coffee is too hot.");
        }
        else if (coffeeTempurature < coldLimitTemperature)
        {
            print("Coffee is too cold.");
        }
        else
        {
            print("Coffee is just right.");
        }
    }
}