using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement; 

public class BackGround_NarcotraficoMazatlan : MonoBehaviour
{
    public static int currentSprite = 0;
    public string resourceName = "TeCruzasConElNarco";
    public AudioSource noise1;
    public AudioSource noise2;
    public Sprite[] backgrounds;
    
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
            txtMy.text = "Avanzando hacia tu destino, te encuentras con una cruz en tu camino. No le das mayor imporancia, pero algo en ti te indica que hay un peligro cerca.";
            noise1.Play();
            noise2.Play();
            currentSprite++;
        }
        else if (currentSprite == 1)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "De repente te cruzas con dos personas de aspecto intimidante, que comienzan a hacerte preguntas, una tras otra.";
            currentSprite++;
        }
        else if (currentSprite == 2)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Eran miembros de un grupo del narcotráfico local, de modales intimidantes pero de aspecto similar a cualquiera que hayas visto. Su cara lo delataba: no era la primera vez que hacía esto.";
            currentSprite++;
        }
        else if (currentSprite == 3)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Con amenazas, te quitan el poco dinero que tenías e imperativamente te convencieron de no seguir. Al final, sólo te dejaron lo básico para regresarte.";
            currentSprite++;
        }
        else if (currentSprite == 4)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Sin nada mas que un poco de comida y ropa, te regresas para tomar otra ruta. Aún con el miedo recorriendo tu cuerpo, nada detendrá tu camino hacia un mejor futuro.";
            currentSprite++;
        }
        else if (currentSprite == 5)
        {         
            SceneManager.LoadScene("Inicio_Aguascalientes");            
        }

    }
}
