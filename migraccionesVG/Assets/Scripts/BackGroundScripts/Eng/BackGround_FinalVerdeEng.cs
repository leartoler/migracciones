using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement; 

public class BackGround_FinalVerdeEng : MonoBehaviour
{
    public static int currentSprite = 0;
    public string resourceName = "Final_VerdeEng";
    public Sprite[] backgrounds;    
    public GameObject Verde;
    public AudioSource noise1;
    public AudioSource[] sounds;


    void Awake()
    {
        if (resourceName != "") //De donde se toman los nombres para las escenas. Va vacío
            backgrounds = Resources.LoadAll<Sprite>(resourceName);
    }

    private void Start()
    {
        Verde.SetActive(true);
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
            Verde.SetActive(false);
            currentSprite++;
        }
        else if (currentSprite == 2)
        {
            SceneManager.LoadScene("CreditosEng");
            currentSprite = 0;
        }

    }
}
