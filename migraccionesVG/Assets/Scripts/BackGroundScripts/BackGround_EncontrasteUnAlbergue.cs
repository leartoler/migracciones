using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement; 

public class BackGround_EncontrasteUnAlbergue : MonoBehaviour
{
    public static int currentSprite = 0;
    public string resourceName = "EncontrasteUnAlbergue";
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
            txtMy.text = "Después de tanto caminar, el cansancio te alcanza.";
            noise1.Play();  
            noise2.Play(); 
            currentSprite++;
        }

        else if (currentSprite == 1)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = " Además del cansancio, el día ya está por terminar y no has probado bocado alguno en todo el día.";            
            currentSprite++;
        }
        else if (currentSprite == 2)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Tardaste en notarlo, pero la casa por la que estás pasando es un albergue.";
            currentSprite++;
        }
        else if (currentSprite == 3)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Tocas, con un poco de duda, y después de un tiempo una persona con voz amable pero seria te contesta. Te invita a pasar para descansar un poco.";
            currentSprite++;
        }        
        else if (currentSprite == 4)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Al día siguiente, con las energías ya renovadas, continuas con tu camino";
            currentSprite++;
        }
        else if (currentSprite == 5)
        {
            SceneManager.LoadScene("Inicio_EncontrasteUnAlbergue");
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
        }
    }
}