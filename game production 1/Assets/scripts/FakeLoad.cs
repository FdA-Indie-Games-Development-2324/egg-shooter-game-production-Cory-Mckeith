using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class FakeLoad : MonoBehaviour
{
    public TMP_Text percentage;
    public Slider loadSlider;
    public int number;
    // Start is called before the first frame update
     void Start()
    {
        InvokeRepeating("Load", 0.1f, Random.Range(0f,3f));
    }

    void Load()
    {
        number += Random.Range(0,10);
        loadSlider.value = number;
    }

    // Update is called once per frame
    void Update()
    {
        if (number >= loadSlider.maxValue)
        {
            SceneManager.LoadScene("ff");
        }

        percentage.text = number.ToString("0") + "%";
    }
}
