using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement; //6:03



public class BackGround_Intento : MonoBehaviour
{
    public static int currentSprite = 0;
    public string resourceName = "Intento";
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
            txtMy.text = "Has llegado a la frontera y lo que ves, después del río, son unos enormer barrotes que parecen alzarse hasta el cielo";
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
            txtMy.text = "Miras ahora por la derecha e igualmente, la frontera parece extenderse más allá de lo que alcanzar a percibir.";
            currentSprite++;
        }
        else if (currentSprite == 3)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Observas de nuevo aquellos barrotes y, después de tanto pensar, no te queda más que buscar otra ruta, una más accesible. Continuas con tu viaje, ahora hacia Tijuana.";
            currentSprite++;
        }        
        else if (currentSprite == 5)
        {
            SceneManager.LoadScene("Inicio_Intento");
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
        }

    }
}