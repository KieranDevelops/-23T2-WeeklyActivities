using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoll : MonoBehaviour
{
    #region Variables
    public int myDiceRoll = 0;
    public int myMinDiceRoll = 0;
    public int myMaxDiceRoll = 6;
    [TooltipAttribute("The key used for rolling the dice")]
    public KeyCode rollInputKey; // Te input we use to start rolling the dice. 

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        #region Scope
        //an example of a scope, this variable myCurrentDiceroll
        //Only Exists within these start {} if you try to access
        // it on a different level/ different layer of {} then it wont be accesible
        int myCurrentDiceRoll = 0;
        if (myCurrentDiceRoll > 0)
        {
            myCurrentDiceRoll = 1;
        }
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        #region Dice Roll generator
        //Checks to see if an input key is pressed
        // if it is a random number between 0-6 is generated
        if (Input.GetKeyDown(rollInputKey))
        {
            int myCurrentDiceRoll = Random.Range(myMinDiceRoll, myMaxDiceRoll + 1);
            myDiceRoll = myCurrentDiceRoll;
            Debug.Log("My dice roll is: " + myDiceRoll);

            Debug.Log("The percentage chance of getting this number is: " + (1f / 6f) + "%");

            if(myDiceRoll < 3)
            {
                Debug.Log("Dice rolls less than 3");
            }
            else if(myDiceRoll >= 3 && myDiceRoll <= 5)
            {
                Debug.Log("My dice rolls is greater than 3 and less than 5");
            }
            else
            {
                Debug.Log("Dice roll is 6");
            }
                 
        }
        #endregion

    }
}
