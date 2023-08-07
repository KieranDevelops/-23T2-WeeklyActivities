using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamer : MonoBehaviour
{
    private Coroutine startGameRoutine;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        if (startGameRoutine == null)
        {
            startGameRoutine = StartCoroutine(StartGame());
        }
        if(startGameRoutine == null)
        {
            startGameRoutine = StartCoroutine(StartGame());
        }


    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.isGamePaused)
        {
            // stop doing fish things
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(1);
            SceneManager.LoadScene("string");
        }

       
 
    }

    private IEnumerator StartGame()
    {
        Debug.Log("Game is starting in 2 secs");
        yield return new WaitForSeconds(2);
        Debug.Log("Game has started");
        bool gameStarted = false;
        while(gameStarted == false)
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                gameStarted = true;
            }
            yield return  null;
        }
        Debug.Log("Game start");
        yield return null;
    }
}
