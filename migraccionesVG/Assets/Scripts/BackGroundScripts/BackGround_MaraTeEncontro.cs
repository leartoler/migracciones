using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement; //6:03



public class BackGround_MaraTeEncontro : MonoBehaviour
{
    public static int currentSprite = 0;
    public string resourceName = "MaraTeEncontro";
    public Sprite[] backgrounds;
    
    void Awake()
    {
        if (resourceName != "")
            backgrounds = Resources.LoadAll<Sprite>(resourceName);       
    }


    public void OnClickChangeBackground()
    {

        if (currentSprite == 0)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];    
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Llegaste a una pequeña ciudad en el atardecer. Ves a tu derecha y observas un grafiti que por un momento te hace temer.";
            currentSprite++;
        }
        else if (currentSprite == 1)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Pero ves a mucha gente a tu alrededor, por lo qu te sientes seguro.";
            currentSprite++;
        }
        else if (currentSprite == 2)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Lo que ignorabas es que desde hace un momento un pequeño grupo de personas te seguía, y la gente que estaba en la calle ya se había dado cuenta.";
            currentSprite++;
        }
        else if (currentSprite == 3)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Sientes la presencia de tres personas, y algo en ti te dice que peligras.";
            currentSprite++;
        }
        else if (currentSprite == 4)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Aceleras el paso y ellos también lo hacen. No hay marcha atrás";
            currentSprite++;
        }
        else if (currentSprite == 5)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Finalmente decides correr. Pero ya es inutil, ya te estaban esperando. Tu intuición tenia razón. Eran los Maras Salvatruchas.";
            currentSprite++;
        }
        else if (currentSprite == 6)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Te golpearon al final de la calle y te quitaron todas tus pertenencias.";
            currentSprite++;
        }
        else if (currentSprite == 7)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
			Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
			txtMy.text = "Al final del día, fue tanto el dolor de los golpes que no pudiste levantarte en todo el día. Continuarás con tu viaje el día siguiente. ";
			      currentSprite++;
        }
        else if (currentSprite == 8)
        {
            SceneManager.LoadScene("InicioMaras");
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
        }
        

    }
}