using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hoofdmenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void loadscen()
    {
        SceneManager.LoadScene(4);
    }
    public void loadgoodend()
    {
        SceneManager.LoadScene(6);
    }
    public void Home()
    {
        SceneManager.LoadScene(0);
    }
    public void Credits()
    {
        SceneManager.LoadScene(7);
    }
}
