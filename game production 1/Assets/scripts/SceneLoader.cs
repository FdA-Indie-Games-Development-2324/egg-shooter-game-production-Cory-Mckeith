using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneLoader : MonoBehaviour
{
    public Slider loadingBar;     // Reference to the Slider (loading bar)
    public Text loadingText;      // Optional: Reference to a Text element for showing the loading percentage
    public string sceneName;      // The name of the scene to load

    // Start is called before the first frame update
    void Start()
    {
        // Start the loading process
        if (loadingBar != null)
        {
            loadingBar.value = 0f; // Initialize the loading bar to 0
        }

        // Start the asynchronous scene loading
        StartCoroutine(LoadSceneAsync());
    }

    // Coroutine to load the scene asynchronously
    IEnumerator LoadSceneAsync()
    {
        // Start the asynchronous scene loading
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

        // Prevent the scene from being activated immediately
        asyncLoad.allowSceneActivation = false;

        // While the scene is loading, update the progress bar
        while (!asyncLoad.isDone)
        {
            // Update the loading bar value based on the progress
            float progress = Mathf.Clamp01(asyncLoad.progress / 0.9f); // `progress` reaches 0.9 when the scene is almost loaded
            loadingBar.value = progress;

            // Optionally, show loading percentage text
            if (loadingText != null)
            {
                loadingText.text = Mathf.RoundToInt(progress * 100f) + "%";
            }

            // When the scene is almost done loading (progress reaches 0.9), allow it to activate
            if (asyncLoad.progress >= 0.9f)
            {
                // Wait until the user presses a key to allow scene activation (or you could auto-activate after delay)
                if (Input.anyKey)
                {
                    asyncLoad.allowSceneActivation = true;
                }
            }

            // Yield to continue the loop in the next frame
            yield return null;
        }
    }
}
