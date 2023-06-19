using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WeekFour : MonoBehaviour
{
    public TextMeshProUGUI uiText;

    public float temperatureInFarenheight = 100f;

    // Start is called before the first frame update
    void Start()
    {
        PrintMyName("Kieran", "Nap");

        IsLeapYear(2000);
        IsLeapYear(2001);


        
    }

    public void DisplayOnAScreen()
    {
        float tempInCels = FarenheightToCelcius(temperatureInFarenheight);
        Debug.Log(tempInCels);
        uiText.text = tempInCels + "c";
        PrintTempResult(tempInCels);

    }

    public void PrintTempResult(float temperature)
    {
        /*Temp less than 0 then Freezing weather
        Temp 0-10 then Very Cold weather
        Temp 10-20
        If it’s below 13 or it’s exactly 14 debug it’s a bit cool.
        Otherwise it’s cold weather.
        Temp 20-30 then Normal in Temp
        Temp 30-40
        If it is below 35 debug out nice qld day
        Else if it’s below 37 but more than 35 debug out getting warmer.
        Else it’s hot.
        Temp greater than or equal 40 then Its Very Hot
        */
        if (temperature < 0)
        {
            Debug.Log("Freezing Water");

        }
        else if (temperature > 0 && temperature < 10)
        {
            Debug.Log("Very Cold Weather");

        }
       else if (temperature < 13 && temperature == 14)
        {
            Debug.Log("its a bit cold weather");
        }
       
        if (temperature > 20 && temperature < 30)
        {
            Debug.Log("Normal weather");
        }

        if (temperature > 30 && temperature < 40)
        {
            if(temperature < 35)
            {
                Debug.Log("Nice qld day");
            }
            else if (temperature > 35 && temperature < 37)
            {
                Debug.Log("Its hot");
            }
            else
            {
                Debug.Log("Its very hot");
            }
        }
            Debug.Log(temperature);
    }

    public float FarenheightToCelcius(float temperature)
    {
        //(100°F − 32) × 5/9 = 37.778°C
        float convertedTemp = ((temperature - 32 ) * (5f/9f));
       
        Debug.Log(temperature);
        return convertedTemp;

    }

    
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void PrintMyName(string firstName, string lastName)
    {
        Debug.Log(firstName + " " + lastName);
        Debug.Log("Kieran Nap'Bleidick");
        PrintMyAge();
    }

    public void PrintMyAge()
    {
        Debug.Log("22");
    }

    public void IsLeapYear(int year)
    {
        if(year % 4 == 0)
        {
            Debug.Log("The year " + year + " is a leap year");
        }
        else
        {
            Debug.Log("The year " + year + " is not a leap year");
        }

    }


   
}
