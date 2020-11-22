using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement; 

public class BackGround_FinalMorado : MonoBehaviour
{
    public static int currentSprite = 0;
    public string resourceName = "Final_Morado";
    public Sprite[] backgrounds;
    public GameObject Amarillo;
    public AudioSource noise1;
    public AudioSource[] sounds;


    void Awake()
    {
        if (resourceName != "") //De donde se toman los nombres para las escenas. Va vacío
            backgrounds = Resources.LoadAll<Sprite>(resourceName);
    }

    private void Start()
    {
        Amarillo.SetActive(true);
        AudioSource[] sounds = GetComponents<AudioSource>();// audioañadido en start
        noise1 = sounds[0];
    }

    public void OnClickChangeBackground()
    {

        if (currentSprite == 0)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "La migración centroamericana hacia el norte del continente ha sido constante durante los últimos 30 años. Se calcula que existen más de 4 milloes de centroamericanos residiendo en Norte América: 57,976 en México; 172,020 en Canáda, y 3,998,280 en Estados Unidos.";
            currentSprite++;
            noise1.Play();
        }
        else if (currentSprite == 1)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "";
            Amarillo.SetActive(false);
            currentSprite++;
        }
        else if (currentSprite == 2)
        {
            SceneManager.LoadScene("Creditos");
        }

    }
}
