using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class percentageCalculation : MonoBehaviour
{
    public enum State
    {
        Extrovert,
        Introvert
    } // Add more if necessary

    public enum LikeType
    {
        ExtrovertLike,
        IntrovertLike
    }

    public float scoreExtrovert { get; set; }
    public float scoreIntrovert { get; set; }
    public int maxScore { get; set; }
    public int pointsPerLike { get; set; }
    public float percentageExtrovert { get; set; }
    public float percentageIntrovert { get; set; }

    public State state;

    public void setState()
    {
        if (percentageExtrovert > percentageIntrovert) state = State.Extrovert;
        else state = State.Introvert;
    }

    public void calculateStuff() {
        //TODO: Score calculations

        percentageExtrovert = scoreExtrovert / maxScore;
        percentageIntrovert = scoreIntrovert / maxScore;
        setState();
    }

    public void showAd() { 
        //TODO: show corresponding ad
    }

    public void incrementScore(LikeType likeType)
    {
        switch (likeType)
        {
            case LikeType.ExtrovertLike:
                scoreExtrovert += pointsPerLike;
                break;
            case LikeType.IntrovertLike:
                scoreIntrovert += pointsPerLike;
                break;
            default:
                break;
        }
    }

}
