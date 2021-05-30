using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement; 

public class BackGround_FinalAmarilloEng : MonoBehaviour
{
    public static int currentSprite = 0;
    public string resourceName = "Final_Amarillo";
    public Sprite[] backgrounds;
    public GameObject Amarillo;
    public AudioSource noise1;
    public AudioSource[] sounds;


    void Awake()
    {
        if (resourceName != "") //De donde se toman los nombres para las escenas. Va vacío
            backgrounds = Resources.LoadAll<Sprite>(resourceName);       
    }

    private void Start()
    {
        Amarillo.SetActive(true);
        Debug.Log("Se queda en true");
        AudioSource[] sounds = GetComponents<AudioSource>();// audioañadido en start
        noise1 = sounds[0];        
    }

    public void OnClickChangeBackground()
    {

        if (currentSprite == 0)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];    
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Migration of Central Americans to the north of the continent has been constant during the last 30 years. It is estimated that there are more than 4 million Central Americans residing in North America: 57,976 in Mexico; 172,020 in Canada, and 3,998,280 in the United States.";
            currentSprite++; 
            noise1.Play();         
        }
        else if (currentSprite == 1)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "";
            Amarillo.SetActive(false);
            Debug.Log("Se queda en false");
            Debug.Log("que pasa aqui");
            currentSprite++;
        }
        else if (currentSprite == 2)
        {
            Amarillo.SetActive(true);
            SceneManager.LoadScene("Creditos");
            Debug.Log("Se queda en true");
            Debug.Log("demonios");
            currentSprite = 0;
        }  

    }
}
