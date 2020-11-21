using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
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

    public void PlayGame()
    {
        SceneManager.LoadScene("Inicio_Main");
    }

    public void QuitGame()
    {
        Debug.Log("Se quita");
        Application.Quit();
    }

    public void Infografia()
    {
        SceneManager.LoadScene("Infografia");
    }

    public void Informacion()
    {
        SceneManager.LoadScene("Informacion_Raul");
    }
    
    public void MainMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Seleccion()
    {
        SceneManager.LoadScene("Seleccion_de_Personajes");
    }
}

   