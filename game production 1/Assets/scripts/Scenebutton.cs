using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management
public class Scenebutton : MonoBehaviour
{
   // Method to load the scene by name
   public void LoadScene(string sceneName)
   {
       SceneManager.LoadScene(sceneName);
   }
}
