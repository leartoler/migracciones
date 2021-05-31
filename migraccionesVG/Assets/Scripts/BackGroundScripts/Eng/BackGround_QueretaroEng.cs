using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //6:03
using UnityEngine.UI;


public class BackGround_QueretaroEng : MonoBehaviour
{
    public static int currentSprite = 0;
    public string resourceName = "Queretaro";
    public Sprite[] backgrounds;
    public GameObject SanLuisPotosiUI;
    public GameObject IrapuatoUI;
    public AudioSource noise1;
    public AudioSource noise2;

    void Start()
    {
        SanLuisPotosiUI.SetActive(false);
        IrapuatoUI.SetActive(false);
        AudioSource[] sounds = GetComponents<AudioSource>();// audioañadido en start
        noise1 = sounds[0];
        noise2 = sounds[1];
    }

    void Awake()
    {
        if (resourceName != "") //De donde se toman los nombres para las escenas
            backgrounds = Resources.LoadAll<Sprite>(resourceName);
    }


    public void OnClickChangeBackground()
    {

        if (currentSprite == 0)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "You are in Querétaro, and a large field lies ahead of you. You have two options:";
            noise1.Play();
            noise2.Play();
            SanLuisPotosiUI.SetActive(true);
            IrapuatoUI.SetActive(true);
        }
    }
    public void OnClickChangeSanLuisPotosi()
        {
            if (currentSprite == 0)
            {
                //guadalajaraUI.SetActive (true); 
                SceneManager.LoadScene("Inicio_SanLuisPotosiEng");
            currentSprite = 0;
        }
        }

        public void OnClickChangeIrapuato()
        {
            if (currentSprite == 0)
            {

                SceneManager.LoadScene("Inicio_IrapuatoEng");
            currentSprite = 0;
        }
        }
    }
