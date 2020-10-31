using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement; 

public class BackGround_Raite : MonoBehaviour
{
    public static int currentSprite = 0;
    public string resourceName = "TeDanUnAventon";
    public Sprite[] backgrounds;
    
    void Awake()
    {
        if (resourceName != "") //De donde se toman los nombres para las escenas. Va vacío
            backgrounds = Resources.LoadAll<Sprite>(resourceName);       
    }


    public void OnClickChangeBackground()
    {

        if (currentSprite == 0)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];    
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Estás en las inmediaciones de la Ciudad de México, una gran ciudad de la que has escuchado bastante.";
            currentSprite++;
        }
        else if (currentSprite == 1)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Conforme caminas por la carretera pides un aventón.";
            currentSprite++;
        }
        else if (currentSprite == 2)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Y pasan las horas y pocos pasan, y quienes lo hacen, no se detienen.";
            currentSprite++;
        }
        else if (currentSprite == 3)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Pasadas unas horas, una camioneta conducida por una pareja, se detiene. Te hacen una pequeña plática.";
            currentSprite++;
        }
        else if (currentSprite == 4)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Y te invitan a subirte. Con tus cosas en la mano, te subes en la parte trasera de la camioneta.";
            currentSprite++;
        }
        else if (currentSprite == 5)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "La ayuda de la pareja te hace descansar por un momento. Te es agradable el viento en tu rostro.";
            currentSprite++;
        }
        else if (currentSprite == 6)
        {         
            SceneManager.LoadScene("Inicio_Raite");
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
        }

    }
}
