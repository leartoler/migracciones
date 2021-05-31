using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement; 

public class BackGround_TeAgarroMigracionTenosiqueEng : MonoBehaviour
{
    public static int currentSprite = 0;
    public string resourceName = "TeAgarroMigracion";
    public Sprite[] backgrounds;
    public AudioSource noise1; //Musica   
    public AudioSource noise2; //Fondo
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
            txtMy.text = "You continue on your way. With the sun shining on your face and next to the train tracks, you feel an unusual tranquility.";
            noise1.Play();
            noise2.Play();
            currentSprite++;
        }
        else if (currentSprite == 1)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "You have no idea that behind the bushes next to you, a van of the National Migration Institute has been watching you and is about to ambush you.";
            currentSprite++;
        }
        else if (currentSprite == 2)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "In the end, you are ambushed and you feel that there is nothing to do. The officer leaves and without resisting, you get into the van that will ruin all your progress towards your destination.";
            currentSprite++;
        }
        else if (currentSprite == 3)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Back home, you realize that you will have to repeat your entire journey.";
            currentSprite++;
        }       
        else if (currentSprite == 4)
        {         
            SceneManager.LoadScene("Inicio_InicioTenosiqueEng");
            currentSprite = 0;
        }

    }
}
