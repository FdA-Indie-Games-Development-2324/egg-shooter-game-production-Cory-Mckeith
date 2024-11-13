using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // For UI Button
using DG.Tweening;    // Import DOTween namespace
public class EnlargeWithDOTween : MonoBehaviour
{
   public GameObject targetObject;       // The GameObject to enlarge
   public Button enlargeButton;          // The UI button to trigger the enlargement
   public Vector3 targetScale = new Vector3(2f, 2f, 2f); // The scale to enlarge to
   public float duration = 1f;           // Duration of the scaling animation
   void Start()
   {
       // Ensure the button is assigned and add listener
       if (enlargeButton != null)
       {
           enlargeButton.onClick.AddListener(OnButtonPress);
       }
   }
   // This method is called when the button is clicked
   void OnButtonPress()
   {
       // Enlarge the object with DOTween scaling animation
       targetObject.transform.DOScale(targetScale, duration);
   }
}
