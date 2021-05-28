using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement; //6:03



public class BackGround_NoPasaElTrenLaBestiaEng : MonoBehaviour
{
    public static int currentSprite = 0;
    public string resourceName = "NoPasaElTrenLaBestiaEng";
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
            txtMy.text = "You ever hear that, where you are, a train called "The Beast" pass, which will bring you closer to your destination.";
            noise1.Play();
            noise2.Play();
            currentSprite++;
        }
        else if (currentSprite == 1)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Debug.Log("aber si sí");
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "You look at the horizon and head towards the suggested location.";
            currentSprite++;
        }
        else if (currentSprite == 2)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "After so much walking, you come across the rails that seem to belong to The Beast. You take them as a guide and head wherever they lead you.";
            currentSprite++;
        }
        else if (currentSprite == 3)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "You walk a long way and travel miles of track.";
            currentSprite++;
        }
        else if (currentSprite == 4)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "And you don't see any stops.";
            currentSprite++;
        }
        else if (currentSprite == 5)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Suddenly, you see a bench that is ideal for resting your tired body.";
            currentSprite++;
        }
        else if (currentSprite == 6)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "You fall asleep. By the time you wake up you know that, for the moment, La Bestia will not pass, and you don't know whether to continue on to Puebla or Tampico.";
            tampicoUI.SetActive (true);
            apiazcoUI.SetActive (true);
            
        }       
       
    }
      public void OnClickChangeTampico()
    {        
            if (currentSprite == 6)        
        {
            //guadalajaraUI.SetActive (true); 
            SceneManager.LoadScene("Inicio_TampicoEng");
            currentSprite = 0;
        }
    }

    public void OnClickChangeApiazco()
    {            
            if (currentSprite == 6)
        {
             
            SceneManager.LoadScene("Inicio_NoPasaElTrenLaBestiaEng");
            currentSprite = 0;
        }
    }
}
