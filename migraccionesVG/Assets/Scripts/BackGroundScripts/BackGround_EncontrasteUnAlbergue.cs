using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement; 

public class BackGround_EncontrasteUnAlbergue : MonoBehaviour
{
    public static int currentSprite = 0;
    public string resourceName = "BackGround_EncontrasteUnAlbergue";
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
            txtMy.text = "Después de tanto caminar, el cansancio te alcanza.";
            currentSprite++;
        }

        else if (currentSprite == 1)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = " Además del cansancio, el día ya está por terminar y no has probado bocado alguno en todo el día.";
            currentSprite++;
        }
        else if (currentSprite == 2)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Tardaste en notarlo, pero la pared que acababas de pasar era de un albergue. Es en la esquina en donde te das cuenta que estás enfrente de uno.";
            currentSprite++;
        }
        else if (currentSprite == 3)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Tocas, con un poco de duda, y después de un tiempo una persona con voz amable pero seria te abre la puerta. Te pregunta cosas básicas: de dónde vienes, quién eres, a dónde vas. Te invita a pasar para descansar un poco.";
            currentSprite++;
        }
        else if (currentSprite == 4)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Después de un tiempo, y con el cansancio ya venciéndote, dejas tus cosas y te suber a tu litera. Antes de caer de sueño piensas un poco lo agradecido que fuiste de encontrar un albergue.";
            currentSprite++;
        } 
        else if (currentSprite == 5)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Al día siguiente, con las energías ya renovadas, continuas con tu camino";
            currentSprite++;
        }
        else if (currentSprite == 6)
        {
            SceneManager.LoadScene("Inicio_EncontrasteUnAlbergue");
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
        }
    }
}