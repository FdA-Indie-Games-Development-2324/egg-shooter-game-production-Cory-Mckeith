using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float playerHealth;
      public Slider healthSlider;
      private float maxHealth;
    // Start is called before the first frame update
    
void Start ()
{

this.maxHealth = this.playerHealth;

}
    // Update is called once per frame
    void Update()
    {
        if(playerHealth <= 0)
        {
            GameOver();
        } 
    }

    void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
