using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement; 

public class BackGround_DesiertoEng : MonoBehaviour
{
    public static int currentSprite = 0;
    public string resourceName = "YaNoPuedesMasEng";
    public Sprite[] backgrounds;
    public AudioSource noise1;
    public AudioSource noise2;
    public AudioSource[] sounds;
    
    void Awake()
    {
        if (resourceName != "") //De donde se toman los nombres para las escenas. Empty
            backgrounds = Resources.LoadAll<Sprite>(resourceName);       
    }

    private void Start()
    {
        AudioSource[] sounds = GetComponents<AudioSource>();// audioañadido en start
        noise1 = sounds[0];
        noise2 = sounds[1];
    }

    public void OnClickChangeBackground()
    {

        if (currentSprite == 0)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];    
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "After a long way, and with many obstacles overcome, you find yourself already close to the border, walking in the desert, with the sun in front of you.";
            noise1.Play();  
            noise2.Play(); 
            currentSprite++;
        }
        else if (currentSprite == 1)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "The long journey and the heat of the desert are making your body tired. You look for a place to rest, a place to sit for a moment.";
            currentSprite++;
        }
        else if (currentSprite == 2)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "To your right you find the only place that seems to give you some shelter.";
            currentSprite++;
        }
        else if (currentSprite == 3)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "You head towards it, with the heaviness of your luggage and the sand on your feet.";
            currentSprite++;
        }       
          else if (currentSprite == 4)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "You approach the rocks, and the little shade there is.  You stretch your legs and, for a moment, close your eyes...";
            currentSprite++;
        }  
          else if (currentSprite == 5)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Suddenly you fall into a deep sleep and the sun is no longer behind you; instead, the night now covers you.";
            currentSprite++;
        }  
          else if (currentSprite == 6)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "You missed a day, but your body needed it. You get up the next day to continue on your way.";
            currentSprite++;
        }  
        else if (currentSprite == 7)
        {         
            SceneManager.LoadScene("Inicio_TeHanRobadoChihuahuaEng");
            currentSprite = 0;
        }

    }
}
