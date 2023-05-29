using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekOne : MonoBehaviour
{
    public int myAge = 23; //an int only holds whole numbers
    public float myHeight = 185.5f; //a float holds decimal numbers
    public double myFaveNumber = 69.96; // a double holds double of a float
    public string myName = "Kieran"; // a string holds words
    public char myInital = 'K'; // A cahr can only holds a single character
    public bool isWearingWatch = true; // a bool holds true or false


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        Debug.Log("My age is: " + myAge);



        // () = Parentesis = functions
        // {} = Curley braces = scope
        // [] = square brackets = access collections
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
