using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WeekEight : MonoBehaviour
{
    public static UnityEvent pauseGameEvent = new UnityEvent();
    public bool isGamePaused = false;

    public static int health = 100;

    public bool isMoving = false;

    private void OnEnable()
    {
        pauseGameEvent.AddListener(PauseGame);
       // FindObjectOfType<WeekEight>().pauseGameEvent.AddListener(EnableMovement);

   }

    private void OnDisable()
    {
        pauseGameEvent.RemoveListener(PauseGame);
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
    private void PauseGame()
    {
        isGamePaused = !isGamePaused;
    }


}
