using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacebookPage : MonoBehaviour
{
    public User.Categories cat;
    public float percentage;
    public GameObject likeImage;
    public GameObject background;
    private bool liked;

    public void Start()
    {
        background.SetActive(true);
    }

    public void touch()      
    {
        liked = !liked;
        likeImage.SetActive(liked);
        background.SetActive(!liked);
    }

    public void sendResult()
    {
        if(liked) Camera.main.GetComponent<User>().addLike(cat, percentage);
    }
}
