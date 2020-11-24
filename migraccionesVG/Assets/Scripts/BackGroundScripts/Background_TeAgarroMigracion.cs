using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class BackGround_TeAgarroMigracion : MonoBehaviour
{
    public static int currentSprite = 0;
    public string resourceName = "TeAgarroMigracion";
    public Sprite[] backgrounds;
    public AudioSource noise1;
    public AudioSource noise2;
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
            txtMy.text = "Continuas con tu camino. Con el sol dándote en el rostro y a un lado de las vías del tren, sientes una tranquilidad inusitada.";
            noise1.Play();  
            noise2.Play();          
            currentSprite++;
        }
        else if (currentSprite == 1)
        {
            
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];            
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();          
            txtMy.text = "No tienes idea que detrás de los arbustos que están a tu lado, una camioneta del Instituto Nacional de Migración te ha estado vigilando y está a punto de emboscarte.";
            currentSprite++;
        }
        else if (currentSprite == 2)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Al final, te emboscan y sientes que no hay nada que hacer. El oficial sale y sin resistirte, te subes a la camioneta que arruinará todo tu avance hacia tu destino.";
            currentSprite++;
        }
        else if (currentSprite == 3)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "De regreso a tu país, caes en la cuenta de que tendrás que repetir toda tu travesía.";
            currentSprite++;
        }       
        else if (currentSprite == 4)
        {         
            SceneManager.LoadScene("Inicio_Main");
            currentSprite = 0;
        }
    }
}
