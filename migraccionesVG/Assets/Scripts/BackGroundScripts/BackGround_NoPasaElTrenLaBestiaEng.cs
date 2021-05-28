using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement; //6:03



public class BackGround_NoPasaElTrenLaBestia : MonoBehaviour
{
    public static int currentSprite = 0;
    public string resourceName = "NoPasaElTrenLaBestia";
    public Sprite[] backgrounds;
    public GameObject apiazcoUI;
    public GameObject tampicoUI;
    public AudioSource noise1;
    public AudioSource noise2;

    void Start()
    {
        apiazcoUI.SetActive(false);
        tampicoUI.SetActive(false);
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
            txtMy.text = "Escuchaste alguna vez que, por donde estás, pasaba el ferrocaril a la que llaman La Bestia, la cual te acercará a tu destino.";
            noise1.Play();
            noise2.Play();
            currentSprite++;
        }
        else if (currentSprite == 1)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Debug.Log("aber si sí");
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Miras al horizonte y te encaminas hacia el lugar recomendado";
            currentSprite++;
        }
        else if (currentSprite == 2)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Después de tanto caminar, te encuentras con las vías que parecen ser de La Bestia. Las tomas como guía y te diriges hacia donde te lleven.";
            currentSprite++;
        }
        else if (currentSprite == 3)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Caminas un largo camino y recorres kilómetros de vías.";
            currentSprite++;
        }
        else if (currentSprite == 4)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Y no ves parada alguna.";
            currentSprite++;
        }
        else if (currentSprite == 5)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "De pronto, ves una banca que resulta idónea para descansar tu cansado cuerpo.";
            currentSprite++;
        }
        else if (currentSprite == 6)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Te duermes. Para cuando despiertas sabes que, por el momento, no pasará La Bestia, y no sabes si continuar hacia Puebla o Tampico";
            tampicoUI.SetActive (true);
            apiazcoUI.SetActive (true);
            
        }       
       
    }
      public void OnClickChangeTampico()
    {        
            if (currentSprite == 6)        
        {
            //guadalajaraUI.SetActive (true); 
            SceneManager.LoadScene("Inicio_Tampico");
            currentSprite = 0;
        }
    }

    public void OnClickChangeApiazco()
    {            
            if (currentSprite == 6)
        {
             
            SceneManager.LoadScene("Inicio_NoPasaElTrenLaBestia");
            currentSprite = 0;
        }
    }
}
