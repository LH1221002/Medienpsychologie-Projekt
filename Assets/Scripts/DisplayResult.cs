using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.UIElements;

public class DisplayResult : MonoBehaviour
{
    public GameObject Extroversion_Ad;
    public GameObject Openess_Ad;

    public Sprite image_Ad_E0;
    public Sprite image_Ad_E1;
    public Sprite image_Ad_O0;
    public Sprite image_Ad_O1;


    private void OnEnable()
    {
        Hashtable results = Camera.main.GetComponent<User>().getResults();

        float extroversionValue = 0;
        float openessValue = 0;
        //Show matching advertisements

        print("Extroversion: " + results[User.Categories.Extroversion]);
        print("Openess: " + results[User.Categories.Openess]);

        if(results[User.Categories.Extroversion] != null)
            extroversionValue = (float)results[User.Categories.Extroversion];

        if (results[User.Categories.Openess] != null)
            openessValue = (float)results[User.Categories.Openess];

        if (extroversionValue >= 0.5)
            //Set Extroversion E1 Ad
            Extroversion_Ad.GetComponent<Image>().sprite = image_Ad_E1;
        else
            //Set Extroversion E0 Ad
            Extroversion_Ad.GetComponent<Image>().sprite = image_Ad_E0;

        if (openessValue >= 0.5)
            //Set Openess O1 Ad
            Openess_Ad.GetComponent<Image>().sprite = image_Ad_O1;
        else
            //Set Extroversion O0 Ad
            Openess_Ad.GetComponent<Image>().sprite = image_Ad_O0;
            
    }
}
