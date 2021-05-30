using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement; 

public class BackGround_EncuentrasTrabajoTemporalEng : MonoBehaviour
{
    public static int currentSprite = 0;
    public string resourceName = "BackGround_EncuentrasTrabajoTemporal";
    public Sprite[] backgrounds;
    public AudioSource noise1;
    public AudioSource noise2;
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
            txtMy.text = "You've traveled a long road, and you don't have a lot of resources left either.";
            noise1.Play();  
            noise2.Play(); 
            currentSprite++;
        }

        else if (currentSprite == 1)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "After you have been walking, you see a small house in far away. The necessity makes you go and ask for some help.";
            currentSprite++;
        }
        else if (currentSprite == 2)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Fortunately, you were lucky and the people who lived there needed help, so they gave you a temporary job.";
            currentSprite++;
        }
        else if (currentSprite == 3)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "After so much work, you were able to earn some money that will allow you to continue your journey.";
            currentSprite++;
        }
        else if (currentSprite == 4)
        {            
            SceneManager.LoadScene("Inicio_EncuentrasTrabajoTemporalEng");
            currentSprite = 0;
        }
    }
}