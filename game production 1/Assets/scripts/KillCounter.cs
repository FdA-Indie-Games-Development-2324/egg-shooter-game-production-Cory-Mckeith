using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Required to load scenes

public class KillCounter : MonoBehaviour
{
    private int kills = 0; // Variable to track the number of kills

    // This method is called when a target is destroyed
    public void AddKill()
    {
        kills++;  // Increase the kill count
        Debug.Log("Kills: " + kills);  // Log the kill count to the console

        // If the player has killed 30 targets, load the next scene
        if (kills >= 30)
        {
            LoadNextScene();
        }
    }

    // Method to load the next scene (replace "NextScene" with your scene's name)
    private void LoadNextScene()
    {
        // Replace "NextScene" with the actual scene name you want to load
        SceneManager.LoadScene("beach");
    }
}