using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class FizzBuzz : MonoBehaviour
{
    public int numberToAdd;
    public List<int> myNumbers = new List<int>();
    
    // Start is called before the first frame update
    void Start()
    {
        myNumbers.Add(100);

        for (int i = 0; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Debug.Log("Fizz Buzz");
            }
            else if (i % 3 == 0)
            {
                Debug.Log("Fizz");
            }
            else if (i % 5 == 0)
            {
                Debug.Log("Buzz");
            }
            else
            {
                Debug.Log(i);
            }
            
        }
        


    }

    // Update is called once per frame
    void Update()
    {
        


    }
}
