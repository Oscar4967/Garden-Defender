using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    // Script for making the "loading screen" last for the duration of the sound byte

    float durationOfSound = 1f;
    int currentSceneIndex;


    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(currentSceneIndex == 0)
        {
            StartCoroutine(WaitForSound());
        }
    }

    IEnumerator WaitForSound()
    {
        yield return new WaitForSeconds(durationOfSound);
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
