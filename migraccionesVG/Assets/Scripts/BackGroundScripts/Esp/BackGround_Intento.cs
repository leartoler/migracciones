using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement; //6:03



public class BackGround_Intento : MonoBehaviour
{
    public static int currentSprite = 0;
    public string resourceName = "Intento";
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
            txtMy.text = "Has llegado a la frontera y lo que ves, después del río, son unos enormes barrotes que parecen alzarse hasta el cielo";
            noise1.Play();
            noise2.Play();
            currentSprite++;
        }

        else if (currentSprite == 1)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Miras por el lado izquierdo y sólo ves la frontera extenderser hacia el infinito.";
            currentSprite++;
        }
        else if (currentSprite == 2)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Miras ahora por la derecha e igualmente, la frontera parece extenderse más allá de lo que alcanzas a percibir.";
            currentSprite++;
        }
        else if (currentSprite == 3)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Observas de nuevo aquellos barrotes y, después de tanto pensar, no te queda mas que buscar otra ruta, una más accesible. Continuas con tu viaje, ahora hacia Tijuana.";
            currentSprite++;
        }        
        else if (currentSprite == 4)
        {
            SceneManager.LoadScene("Inicio_Intento");
            currentSprite = 0;
        }

    }
}