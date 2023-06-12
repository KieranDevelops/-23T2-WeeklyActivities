using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekThree : MonoBehaviour
{
    public string playerOne = "playerOne";
    public string playerTwo = "playerTwo";
    public int statPoolOne = 30;
    public int playerOneStr = 0;
    public int playerOneAgl = 0;
    public int playerOneIntel = 0;
    public int playerOnePower = 0;

    public int statPoolTwo = 30;
    public int playerTwoStr = 0;
    public int playerTwoAgl = 0;
    public int playerTwoIntel = 0;
    public int playerTwoPower = 0;

    
    
    public int strengthMultiplier = 2;
    public float agilityMultiplier = 1.5f;

    // Start is called before the first frame update
    void Start()
    {

        //Generate some physical stats for two players
        //These should be str, agl, intel
        //These should be randomly generated.
        playerOneStr = Random.Range(0, statPoolOne + 1);
        statPoolOne -= playerOneStr;

        playerOneAgl = Random.Range(0, statPoolOne);
        statPoolOne -= playerOneAgl;

        playerOneIntel = Random.Range(0, statPoolOne);
        statPoolOne -= playerOneIntel;

        playerTwoStr = Random.Range(0, statPoolTwo + 1);
        statPoolTwo -= playerTwoStr;

        playerTwoAgl = Random.Range(0, statPoolTwo);
        statPoolTwo -= playerTwoAgl;

        playerTwoIntel = Random.Range(0, statPoolTwo);
        statPoolTwo -= playerTwoIntel;


        //Create a power level for each player
        //Power level should be my str multiplied by 2
        //Adding my agility multiplied by 1.5
        //then adding my intel
        playerOnePower = (int)((playerOneStr * 2) + (playerOneAgl * 1.5f) + playerOneIntel);
        playerTwoPower = (int)((playerTwoStr * 2) + (playerTwoAgl * 1.5f) + playerTwoIntel);

    }

    // Update is called once per frame
    void Update()
    {
        int overallPower = playerOnePower + playerTwoPower;

        // has the player pressed the space bar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //yes they have
            //we compare the two power levels
            //print which player has won for each power level
            //print out the percentage of power.
            if(playerOnePower > playerTwoPower)
            {
                //Player one has won
                Debug.Log("Player One has won! their power level was: " + playerOnePower);
                Debug.Log("Player Two has lost! their power level was: " + playerTwoPower);
            }
            else if(playerTwoPower > playerOnePower)
            {
                //Player two has won
                Debug.Log("Player Two has won! their power level was: " + playerTwoPower);
                Debug.Log("Player One has lost! their power level was: " + playerOnePower);
            }
            else
            {
                //It was a draw!
                Debug.Log("It was a draw!");
            }
            Debug.Log("Player Ones' Power pecentage was: " + (int) (((float)playerOnePower / (float)overallPower) * 100) + "%");
            Debug.Log("Player Twos' Power pecentage was: " + (int) (((float)playerTwoPower / (float)overallPower) * 100) + "%");
            


        }


    }
}
