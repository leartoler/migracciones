using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement; //6:03



public class BackGround_ComprasMedicamento : MonoBehaviour
{
    public static int currentSprite = 0;
    public string resourceName = "NoPasaElTrenLaBestia";
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
            txtMy.text = "Tras un largo camino recorrido te encuentras por fin en Saltillo. Repentinamente sientes escalofríos.";
            currentSprite++;
        }

        else if (currentSprite == 1)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Comienzas a sentir un malestar en el estómago, y te debilitas más por cada paso que das.";
            currentSprite++;
        }
        else if (currentSprite == 2)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Conforme caminas, ves algo de forma momentánea, una farmacia tal vez.";
            currentSprite++;
        }
        else if (currentSprite == 3)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Te acercas, aún con el dolor a cuestas.";
            currentSprite++;
        }
        else if (currentSprite == 4)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Ves una farmacia con pocos medicamentos y un encargado un poco aburrido";
            currentSprite++;
        }
        else if (currentSprite == 5)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Con paso lento, te acercas a él y le pides algo para el dolor. Lamentablemente no tiene lo que necesitas, por lo que te da sólo algo para el dolor. Apresurado, lo tomas y le pagas con el poco dinero que dispones.";
            currentSprite++;
        }
        else if (currentSprite == 6)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Con pesadez te alejas con tu medicamento que, aunque te ayudará, no es lo que necesitas. Te espera un largo camino, con dolor y cada vez menos recursos.";
            currentSprite++;
        }       
        else if (currentSprite == 9)
        {
            SceneManager.LoadScene("InicioMedicamento");
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
        }

    }
}