using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement; 

public class BackGround_EncuentrasTrabajoTemporal : MonoBehaviour
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
            txtMy.text = "Has recorrido un largo camino, y no te quedan tampoco muchos recursos.";
            noise1.Play();  
            noise2.Play(); 
            currentSprite++;
        }

        else if (currentSprite == 1)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Después de estar caminando, ves a lo lejos una pequeña casa. La necesidad te hace ir y pedir un poco de ayuda.";
            currentSprite++;
        }
        else if (currentSprite == 2)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Afortunadamente, tuviste suerte y la gente que vivía ahí necesitaba ayuda, por lo que te dieron un trabajo temporal.";
            currentSprite++;
        }
        else if (currentSprite == 3)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Después de tanto trabajo, pudiste ganar algo de dinero que te permitirá continuar con tu viaje.";
            currentSprite++;
        }
        else if (currentSprite == 4)
        {            
            SceneManager.LoadScene("Inicio_EncuentrasTrabajoTemporal");
            currentSprite = 0;
        }
    }
}