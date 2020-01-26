using UnityEngine;
using UnityEngine.SceneManagement;

public class MainButton : MonoBehaviour
{
    public GameObject[] Screens;
    private int counter;

    private void Start()
    {
        if (Screens.Length < 2) return;
        Screens[counter].SetActive(true);
        for(int i=1; i<Screens.Length; i++)
        {
            Screens[i].SetActive(false);
        }
    }

    public void next()     
    {
        if (Screens.Length < 2) return;
        foreach (FacebookPage fb in Screens[counter].GetComponentsInChildren<FacebookPage>())
        {
            fb.sendResult();
        }

        if ((counter + 1) == Screens.Length)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            return;
        }

        Screens[counter].SetActive(false);
        Screens[++counter].SetActive(true);

        if ((counter + 1) == Screens.Length)
        {
            foreach (UnityEngine.UI.Text txt in this.GetComponentsInChildren<UnityEngine.UI.Text>())
            {
                txt.text = "Neustart";
            }
        }
    }
}
