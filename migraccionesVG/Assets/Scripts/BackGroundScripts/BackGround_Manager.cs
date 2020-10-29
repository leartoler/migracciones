using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement; //6:03



public class BackGround_Manager : MonoBehaviour
{
    public static int currentSprite = 0;
    public string resourceName = "HistoriaPollero";
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
            txtMy.text = "Fue en la noche cuando estaba hablando con su amigo. La plática, entre chismes y chistes, se centraba en cómo podían cruzar la frontera.";
            currentSprite++;
        }
        else if (currentSprite == 1)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Debug.Log("aber si sí");
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Tal vez era por eliluminado lugar o sus caras de preocupación, pero llamaron la atención de una persona que les prometió una fácil solución";
            currentSprite++;
        }
        else if (currentSprite == 2)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Los llevó a un lugar cerca de donde se encontraban, y les señaló su trailer. La oferta que les propuso parecía tentadora: los cruzaría por México por sólo $2,500.";
            currentSprite++;
        }
        else if (currentSprite == 3)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Te asomaste y viste qye estaba vacío. Pensaste en un primer momento en todas las historias que escuchaste y no tuviste mucha confianza.";
            currentSprite++;
        }
        else if (currentSprite == 4)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Te sentaste a orillas del lugar, y esperaste. Pasó bastante tiempo...";
            currentSprite++;
        }
        else if (currentSprite == 5)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Y poco a poco comenzó a subir más gente. Arrancó el trailer y viste a tu alrededor; sólo viste rostros cansados.";
            currentSprite++;
        }
        else if (currentSprite == 6)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Pasó algo de tiempo y la persona que los llevaba los bajó del lugar.";
            currentSprite++;
        }
        else if (currentSprite == 7)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
			Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
			txtMy.text = "Y arrancó. Con dudas por la forma apresurada con la que arrancó, no quedó más que caminar por el único lugar que parecía llegar a un rumbo.";
			      currentSprite++;
        }
        else if (currentSprite == 8)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Y después de tanto caminar, ves que sólo pudiste avanzar hasta Tenosique. ";
            currentSprite++;
        }
        else if (currentSprite == 9)
        {
            SceneManager.LoadScene("InicioTenosique");
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
        }

    }
}