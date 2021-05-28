using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement; //6:03



public class BackGround_Secuestran : MonoBehaviour
{
    public static int currentSprite = 0;
    public string resourceName = "TeHanSecuestrado";
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
            txtMy.text = "Durante tu camino, te encuentras en una zona desierta, sin nada que ver salvo el horizonte.";
            noise1.Play();
            noise2.Play();
            currentSprite++;
        }

        else if (currentSprite == 1)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Cada paso que das te acerca a tu objetivo y a una vida mejor.";
            currentSprite++;
        }
        else if (currentSprite == 2)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Después de tanto caminar, te encuentras con dos siluetas y un camión. Tu intuición y experiencia te dictan que algo está mal, pero ya no es posible retroceder: te han visto.";
            currentSprite++;
        }
        else if (currentSprite == 3)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Y ahora se acerca uno de los sujetos lentamente hacia ti, con paso lento y seguro. Entre el sol que te alumbra, y el miedo, no alcanzas a ver bien su rostro.";
            currentSprite++;
        }
        else if (currentSprite == 4)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Entre amenazas y gritos, te pide que te arrodilles y pongas las manos detrás de tu cabeza. El miedo, sumado al cansancio, hacen que obedezcas sin dudar.";
            currentSprite++;
        }
        else if (currentSprite == 5)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Te quedas quieto, por miedo a que te hagan algo. En eso escuchas a su otro compañero venir, y entre risas y burlas te dicen que ya todo terminó, que no tienes escapatoria.";
            currentSprite++;
        }
        else if (currentSprite == 6)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Lo próximo que ves es obscuridad. Te suben a su camioneta, y entre golpes y humillaciones, te quitan todo tu dinero y pertenencias.";
            currentSprite++;
        }   
        else if (currentSprite == 7)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Después de un largo tiempo, te dejan a la deriva en un paraje desconocido. Al irse los oyes burlarse aún más. Te dejaron atado, sin nada. Tratas de liberarte de las ataduras...";
            currentSprite++;
        }   
else if (currentSprite == 8)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Pasan las horas y poco a poco te has liberado. Al final, después de un largo tiempo, por fin te quitas las ataduras. No queda más que continuar con tu camino";
            currentSprite++;
        }   
        else if (currentSprite == 9)
        {
            SceneManager.LoadScene("Inicio_Secuestran");
            currentSprite = 0;
        }

    }
}