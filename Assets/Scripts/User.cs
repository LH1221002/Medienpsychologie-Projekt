using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{
    public enum Categories
    {
        Extroversion,
        Openess
    }

    //"Shy"/0% --- "Outgoing"/100%
    //"Conservatice"/0% --- "Liberal"/100%

    private int numberOpenessLikes;
    private Hashtable scores = new Hashtable();
    private Hashtable numbers = new Hashtable();

    private void Start()
    {
        scores.Add(Categories.Extroversion, new float());
        scores.Add(Categories.Openess, new float());

        numbers.Add(Categories.Extroversion, new int());
        numbers.Add(Categories.Openess, new int());
    }

    public Hashtable getResults()
    {
        return scores;
    }

    public void addLike(Categories cat, float percentage)
    {
        scores[cat] = ((float)scores[cat] * (int)numbers[cat] + percentage) / ((int)numbers[cat]+1);
        numbers[cat] = (int)numbers[cat] + 1;
    }
}
