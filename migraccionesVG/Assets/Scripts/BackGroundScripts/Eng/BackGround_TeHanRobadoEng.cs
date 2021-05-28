using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement; //6:03



public class BackGround_TeHanRobadoEng : MonoBehaviour
{
    public static int currentSprite = 0;
    public string resourceName = "TeHanRobadoEng";
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
            txtMy.text = "Near the border, and with your body completely tired, it got dark. You search, with the little strength you have left, for a place to rest.";
            noise1.Play();
            noise2.Play();
            currentSprite++;
        }
        else if (currentSprite == 1)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "You find a place to rest, but the lonely place does not give you the necessary confidence.";
            currentSprite++;
        }
        else if (currentSprite == 2)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "In the end, exhaustion won out. You lie down and put your backpack aside.";
            currentSprite++;
        }
        else if (currentSprite == 3)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "With your eyes closed, you think you hear something, but you don't give it enough importance. You continue to sleep.";
            currentSprite++;
        }
        else if (currentSprite == 4)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "When you get up, you look around you: your things are gone. Sad and impotent, you have no choice but to resign yourself, get up and continue your journey.";
            currentSprite++;
        } 
        else if (currentSprite == 5)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "You have two ways: continue through Guadalajara or Aguascalientes.";
            guadalajaraUI.SetActive (true); 
            aguascalientesUI.SetActive (true);
        }
    }

    public void OnClickChangeGuadalajara()
    {        
            if (currentSprite == 5)        
        {       
            SceneManager.LoadScene("Inicio_GuadalajaraEng");
            currentSprite = 0;
        }
    }

    public void OnClickChangeAguascalientes()
    {            
            if (currentSprite == 5)
        {
             
            SceneManager.LoadScene("Inicio_AguascalientesEng");
            currentSprite = 0;
        }
    }
}

