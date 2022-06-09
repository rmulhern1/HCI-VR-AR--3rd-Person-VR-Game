using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] int cubeProximity = 0;
    [SerializeField] bool stickProximity;
    [SerializeField] bool isDone;
    [SerializeField] bool stickIsDone;
    [SerializeField] int puzzleTracker = 0;

    public int buttonPress = 0;
    public GameObject gameCompelteUI;

    // Update is called once per frame
    void Update()
    {
        if (cubeProximity > 1 && isDone != true)
        {
            cubePositions();
            isDone = true;
        }

        if (stickProximity == true && stickIsDone != true)
        {
            StickPositions();
            stickIsDone = true;
        }

        if (puzzleTracker >= 3) {
            Debug.Log("All puzzles complete");
            gameCompelteUI.SetActive(true);
            StartCoroutine(LoadMenuScene());
        }

    }

    public void addCubeProximity()
    {
        Debug.Log("Added 1 to cubeproximity");
        cubeProximity += 1;
    }

    public void minusCubeProximity()
    {
        Debug.Log("Removed 1 from cubeproximity");
        cubeProximity -= 1;
        isDone = false;
    }

    public void cubePositions() 
    {
        Debug.Log("Cubes are in correct location");
        puzzleTracker += 1;
    }

    public void buttonPresses()
    {
        Debug.Log("Button Press Registered");
        buttonPress += 1;

        if (buttonPress >= 3) {
            puzzleTracker += 1;
        }
    }

    public void StickTrueProximity() 
    {
        Debug.Log("Lever entered position");
        stickProximity = true;
    }

    public void StickFalseProximity() 
    {
        Debug.Log("Lever left position");
        stickProximity = false;
    }

    public void StickPositions() 
    {
        Debug.Log("Lever in correct position");
        puzzleTracker += 1;
    }


    IEnumerator LoadMenuScene() 
    {
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene("Menu_Scene");
    }
}
