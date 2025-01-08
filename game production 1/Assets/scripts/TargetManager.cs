using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetManager : MonoBehaviour
{
    public static TargetManager Instance;

    private int targetsDestroyed = 0;
    private const int targetsToDestroy = 10;
    
    private void Awake()
    {
        // Singleton pattern to ensure there's only one instance
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void TargetDestroyed()
    {
        targetsDestroyed++;

        if (targetsDestroyed >= targetsToDestroy)
        {
            LoadNextScene();
        }
    }

    private void LoadNextScene()
    {
        // Replace "YourSceneName" with the name of the scene you want to load
        SceneManager.LoadScene("YourSceneName");
    }
}