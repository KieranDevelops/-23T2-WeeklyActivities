using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WeekEight : MonoBehaviour
{
    public static UnityEvent pauseGameEvent = new UnityEvent();
    public bool isGamePaused = false;

    //public static UnityEvent scorePointsEvent = new UnityIntEvent();

    public delegate void IntDelegate(int amount);
    public static IntDelegate scorePointsDelEvent;
    public static IntDelegate healtPointsDelEvent; 

    public static int health = 100;
    public int score = 0;

    public bool isMoving = false;

    private void OnEnable()
    {
        //scorePointsEvent.AddListener(ScorePoints);
        //scorePointsEvent.AddListener(PauseGame);

        scorePointsDelEvent += ScorePoints;
        // FindObjectOfType<WeekEight>().pauseGameEvent.AddListener(EnableMovement);

    }

    private void OnDisable()
    {
        //scorePointsEvent.RemoveListener(ScorePoints);
        //scorePointsEvent.RemoveListener(PauseGame);

        scorePointsDelEvent -= ScorePoints;
    }

    private void EnableMovement()
    {
        isMoving = !isMoving;
    }

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(pauseGameEvent !=null)
            {
                pauseGameEvent.Invoke();
            }
        }

        if(isMoving)
        {
            Debug.Log(health + "is moving");
        }


    }

    

    private void PauseGame(int someAmount)
    {
        isGamePaused = !isGamePaused;
    }
    public void ScorePoints(int amount)
       {
        score += amount;

        }

}
