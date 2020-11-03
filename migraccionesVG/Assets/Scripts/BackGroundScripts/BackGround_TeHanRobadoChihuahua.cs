using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement; //6:03



public class BackGround_TeHanRobadoChihuahua : MonoBehaviour
{
    public static int currentSprite = 0;
    public string resourceName = "RoboEnMexicali";
    public Sprite[] backgrounds;
    
    void Awake()
    {
        if (resourceName != "") //De donde se toman los nombres para las escenas
            backgrounds = Resources.LoadAll<Sprite>(resourceName);       
    }


    public void OnClickChangeBackground()
    {

        if (currentSprite == 0)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];    
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "En el desierto de Chihuahua, y con el cuerpo completamente cansado, te anocheció. Buscas, con las pocas fuerzas que te quedan, un lugar dónde descansar.";
            currentSprite++;
        }

        else if (currentSprite == 1)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Encuentras un lugar para descansar, pero la soledad del lugar no te la confianza necesaria.";
            currentSprite++;
        }
        else if (currentSprite == 2)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Al final el cansanció ten ganó.Te acuestas y dejas tu mochila a un lado.";
            currentSprite++;
        }
        else if (currentSprite == 3)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Con los ojos cerrados, crees escuchar algo, pero no le das la suficiente importancia. Sigues durmiendo.";
            currentSprite++;
        }
        else if (currentSprite == 4)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Al levantarte, miras a tu alrededor: tus cosas han desaparecido. Con la tristeza e impotencia no te queda más que resignarte, levantarte y continuar con tu trayecto.";
            currentSprite++;
        } 
        else if (currentSprite == 5)
        {
            SceneManager.LoadScene("Inicio_TeHanRobadoChihuahua");
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
        }
    }
}