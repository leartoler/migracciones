using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement; 

public class BackGround_TeCruzasConElNarcoEng : MonoBehaviour
{
    public static int currentSprite = 0;
    public string resourceName = "TeCruzasConElNarco";
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
            txtMy.text = "Moving towards your destination, you find a cross in your path. You don't think much of it, but something in you tells you that there is danger nearby.";
            noise1.Play();
            noise2.Play();
            currentSprite++;
        }
        else if (currentSprite == 1)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Suddenly you come across two intimidating-looking people who start asking you questions, one after the other.";
            currentSprite++;
        }
        else if (currentSprite == 2)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "They are members of a local drug dealers, with intimidating manners but similar in appearance to anyone you've ever seen. Their face revealed it: it wasn't the first time they had done this.";
            currentSprite++;
        }
        else if (currentSprite == 3)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "With menaces, they took away the little money you had and imperatively convinced you not to continue. In the end, they only left you with the basics to return you.";
            currentSprite++;
        }
        else if (currentSprite == 4)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "With nothing but a little food and clothing, you turn back to take another route. Even with fear coursing through your body, nothing will stop you on your way to a better future.";
            currentSprite++;
        }
        else if (currentSprite == 5)
        {         
            SceneManager.LoadScene("Inicio_NoPasaElTrenLaBestiaEng");
            currentSprite = 0;
        }

    }
}
