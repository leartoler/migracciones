using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement; 

public class BackGround_Desierto : MonoBehaviour
{
    public static int currentSprite = 0;
    public string resourceName = "YaNoPuedesMas";
    public Sprite[] backgrounds;
    
    void Awake()
    {
        if (resourceName != "") //De donde se toman los nombres para las escenas. Empty
            backgrounds = Resources.LoadAll<Sprite>(resourceName);       
    }


    public void OnClickChangeBackground()
    {

        if (currentSprite == 0)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];    
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Después de un largo camino, y con muchos obstáculos vencidos, te encuentras ya cerca de la frontera: caminando en el desierto, con el sol de frente.";
            currentSprite++;
        }
        else if (currentSprite == 1)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "El largo camino y el calor del desierto hacen que tu cuerpo se canse. Miras dónde descansar, dónde poder sentarte un momento.";
            currentSprite++;
        }
        else if (currentSprite == 2)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "A tu derecha encuentras el único lugar qe parece darte un poco de cobijo.";
            currentSprite++;
        }
        else if (currentSprite == 3)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Te dirijes hacia él, con la pesadez de tu equipaje y la arena de tus pies.";
            currentSprite++;
        }       
          else if (currentSprite == 4)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Te acercas a las rocas y la poca sombra que proyectan detrás del sol. Estiras tus piernas y por un momento, cierras los ojos.";
            currentSprite++;
        }  
          else if (currentSprite == 5)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "De repente caes en un profundo sueño y el sol ya no se encuentra detrás de ti; en cambio, la noche ahora te cobija.";
            currentSprite++;
        }  
          else if (currentSprite == 6)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Perdiste un día, pero tu cuerpo lo necesitaba. Te levantas al dia siguiente a continuar con tu camino.";
            currentSprite++;
        }  
        else if (currentSprite == 7)
        {         
            SceneManager.LoadScene("Inicio_Desierto");
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
        }

    }
}
