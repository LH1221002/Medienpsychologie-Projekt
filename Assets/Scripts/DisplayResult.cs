using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayResult : MonoBehaviour
{
    private void OnEnable()
    {
        Hashtable results = Camera.main.GetComponent<User>().getResults();

        //Show matching advertisements

        print("Extroversion: " + results[User.Categories.Extroversion]);
        print("Openess: " + results[User.Categories.Openess]);
    }
}
