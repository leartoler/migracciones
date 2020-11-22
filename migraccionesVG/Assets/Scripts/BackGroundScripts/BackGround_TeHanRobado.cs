using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement; //6:03



public class BackGround_TeHanRobado : MonoBehaviour
{
    public static int currentSprite = 0;
    public string resourceName = "TeHanRobado";
    public Sprite[] backgrounds;
    public GameObject guadalajaraUI;
    public GameObject aguascalientesUI;
    public AudioSource noise1;
    public AudioSource noise2;
    public AudioSource[] sounds;

    void Start()
    {
       guadalajaraUI.SetActive (false); 
       aguascalientesUI.SetActive (false);
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
            txtMy.text = "Cerca de la frontera, y con el cuerpo completamente cansado, te anocheció. Buscas, con las pocas fuerzas que te quedan, un lugar dónde descansar.";
            noise1.Play();
            noise2.Play();
            currentSprite++;
        }
        else if (currentSprite == 1)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Encuentras un lugar para descansar, pero la soledad del lugar no te la confianza necesaria.";
            currentSprite++;
        }
        else if (currentSprite == 2)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Al final, el cansanció ten ganó.Te acuestas y dejas tu mochila a un lado.";
            currentSprite++;
        }
        else if (currentSprite == 3)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Con los ojos cerrados, crees escuchar algo, pero no le das la suficiente importancia. Sigues durmiendo.";
            currentSprite++;
        }
        else if (currentSprite == 4)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Al levantarte, miras a tu alrededor: tus cosas han desaparecido. Con la tristeza e impotencia no te queda más que resignarte, levantarte y continuar con tu trayecto.";
            currentSprite++;
        } 
        else if (currentSprite == 5)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Tienes dos caminos: continuar por Guadalajara o Aguascalientes";
            guadalajaraUI.SetActive (true); 
            aguascalientesUI.SetActive (true);
        }
    }

    public void OnClickChangeGuadalajara()
    {        
            if (currentSprite == 5)        
        {       
            SceneManager.LoadScene("Inicio_Guadalajara");                       
        }
    }

    public void OnClickChangeAguascalientes()
    {            
            if (currentSprite == 5)
        {
             
            SceneManager.LoadScene("Inicio_Aguascalientes");            
        }
    }
}

