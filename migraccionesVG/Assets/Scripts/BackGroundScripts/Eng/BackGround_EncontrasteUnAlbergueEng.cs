using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement; 

public class BackGround_EncontrasteUnAlbergueEng : MonoBehaviour
{
    public static int currentSprite = 0;
    public string resourceName = "EncontrasteUnAlbergueEng";
    public Sprite[] backgrounds;
    public AudioSource noise1; //Musica 
    public AudioSource noise2;  //Fondo
    public AudioSource[] sounds; 

    void Awake()
    {
        if (resourceName != "") //De donde se toman los nombres para las escenas
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
            txtMy.text = "After so much walking, you're tired.";
            noise1.Play();  
            noise2.Play(); 
            currentSprite++;
        }

        else if (currentSprite == 1)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Besides tiredness, the day is almost over and you haven't eaten.";            
            currentSprite++;
        }
        else if (currentSprite == 2)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "It took you a while to notice, but the house you are passing is a refuge.";
            currentSprite++;
        }
        else if (currentSprite == 3)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "You knock, a bit hesitantly, and after a while, a person with a friendly but serious voice answers you. He invites you in for a little rest.";
            currentSprite++;
        }        
        else if (currentSprite == 4)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "To the next day, with renewed energy, you continue on your way.";
            currentSprite++;
        }
        else if (currentSprite == 5)
        {
            SceneManager.LoadScene("Inicio_EncontrasteUnAlbergueEng");
            currentSprite = 0;
        }
    }
}