using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public AudioSource noise1;
    

    void Start()
    {
        AudioSource[] sounds = GetComponents<AudioSource>();// audioañadido en start
        noise1 = sounds[0];
    }

    private void Musica()
    {
        noise1.Play();
    }

    public void Esp()
    {
        SceneManager.LoadScene("MainMenuEsp");
    }

    public void QuitGame()
    {
        Debug.Log("Se quita");
        Application.Quit();
    }

    public void Eng()
    {
        SceneManager.LoadScene("MainMenuEng");
    }
}

