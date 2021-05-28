using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement; //6:03



public class BackGround_SecuestranEng : MonoBehaviour
{
    public static int currentSprite = 0;
    public string resourceName = "TeHanSecuestradoEng";
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
            txtMy.text = "On your way, you find yourself in a deserted area, with nothing to see but the horizon.";
            noise1.Play();
            noise2.Play();
            currentSprite++;
        }

        else if (currentSprite == 1)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Every step you take brings you closer to your goal and a better life.";
            currentSprite++;
        }
        else if (currentSprite == 2)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "After so much walking, you come across two silhouettes and a truck. Your intuition and experience tell you that something is wrong, but it is no longer possible to turn back: they have seen you.";
            currentSprite++;
        }
        else if (currentSprite == 3)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "And now one of the subjects slowly approaches you, with a slow and sure step. Between the sun shining on you, and the fear, you can't see his face well.";
            currentSprite++;
        }
        else if (currentSprite == 4)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Between menaces and shouts, he asks you to kneel down and put your hands behind your head. Fear, added to fatigue, makes you obey without hesitation.";
            currentSprite++;
        }
        else if (currentSprite == 5)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "You stay still, for fear that they will do something to you. At that moment you hear their other companion coming, and between laughter and jokes they tell you that it's all over, that you have no way out.";
            currentSprite++;
        }
        else if (currentSprite == 6)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "The next thing you see is darkness. They put you in their van, and between beatings and humiliation, they take all your money and belongings.";
            currentSprite++;
        }   
        else if (currentSprite == 7)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "After a long time, they set you adrift in an unknown place. As they leave you hear them mock you even more. They leave you tied up, with nothing. You try to free yourself from the bonds...";
            currentSprite++;
        }   
else if (currentSprite == 8)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "The hours go by and little by little you have freed yourself. Finally, after a long time, you finally get rid of your ties. There is nothing left to do but to continue on your way.";
            currentSprite++;
        }   
        else if (currentSprite == 9)
        {
            SceneManager.LoadScene("Inicio_SecuestranEng");
            currentSprite = 0;
        }

    }
}