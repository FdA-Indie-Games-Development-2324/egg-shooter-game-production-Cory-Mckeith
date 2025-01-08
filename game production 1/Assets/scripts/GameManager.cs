using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
   // This function will be called when the button is pressed
   public void EndGame()
   {
       Debug.Log("Game Over! Exiting...");
       // Quit the game
       Application.Quit();
       // If running in the Unity editor, stop play mode
       #if UNITY_EDITOR
           UnityEditor.EditorApplication.isPlaying = false;
       #endif
   }
}
