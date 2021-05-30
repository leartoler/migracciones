using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement; 

public class BackGround_RaiteEng : MonoBehaviour
{
    public static int currentSprite = 0;
    public string resourceName = "TeDanUnAventon";
    public Sprite[] backgrounds;
    public AudioSource noise1;
    public AudioSource noise2;
    public AudioSource[] sounds;

    void Awake()
    {
        if (resourceName != "") //De donde se toman los nombres para las escenas. Va vacío
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
            txtMy.text = "You are in nearby to Puebla, a big city you've heard quite a bit about.";
            noise1.Play();
            noise2.Play();
            currentSprite++;
        }
        else if (currentSprite == 1)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "As you walk down the road you ask for a ride.";
            currentSprite++;
        }
        else if (currentSprite == 2)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "And the hours go by and only a few pass, and those who do, do not stop.";
            currentSprite++;
        }
        else if (currentSprite == 3)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "After a few hours, a van driven by a couple stops. They talk to you a bit.";
            currentSprite++;
        }
        else if (currentSprite == 4)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "And you are invited to board. With your things in hand, you climb into the back of the van.";
            currentSprite++;
        }
        else if (currentSprite == 5)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "The help of your partner makes you rest for a moment. The wind on your face is pleasant.";
            currentSprite++;
        }
        else if (currentSprite == 6)
        {         
            SceneManager.LoadScene("Inicio_RaiteEng");
            currentSprite = 0;
        }

    }
}
