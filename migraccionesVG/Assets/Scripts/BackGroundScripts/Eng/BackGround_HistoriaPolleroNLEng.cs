using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement; //6:03



public class BackGround_HistoriaPolleroNLEng : MonoBehaviour
{
    public static int currentSprite = 0;
    public string resourceName = "PolleroTeHaRobado";
    public Sprite[] backgrounds;
    public AudioSource noise1;
    public AudioSource noise2;
    public AudioSource[] sounds;

    void Awake()
    {
        if (resourceName != "") //De donde se toman los nombres para las escenas
            backgrounds = Resources.LoadAll<Sprite>(resourceName);       
    }

    private void Start()
    {
        AudioSource[] sounds = GetComponents<AudioSource>();// audioañadido en start
        noise1 = sounds[0];
        noise2 = sounds[1];
    }

    public void OnClickChangeBackground()
    {

        if (currentSprite == 0)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];    
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "It was late at night when he was talking to his friend. The talk, between gossip and jokes, centered on how they could cross the border.";
            noise1.Play();
            noise2.Play();
            currentSprite++;
        }
        else if (currentSprite == 1)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Debug.Log("aber si sí");
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Maybe it was the illuminated place or their worried faces, but they caught the attention of a person who promised them an easy solution.";
            currentSprite++;
        }
        else if (currentSprite == 2)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "He took them to a place near where they were staying, and pointed out his trailer. The offer he made seemed tempting: he would cross them through Mexico for only $125.00 dlls.";
            currentSprite++;
        }
        else if (currentSprite == 3)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "You looked out and saw that it was empty. You thought at first of all the stories you heard and didn't have much confidence.";
            currentSprite++;
        }
        else if (currentSprite == 4)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "You sat on the edge of the place, and waited. A long time passed...";
            currentSprite++;
        }
        else if (currentSprite == 5)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "And gradually more and more people started to come up. The trailer started up and you looked around; all you saw were tired faces.";
            currentSprite++;
        }
        else if (currentSprite == 6)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "Some time passed and the person carrying them took them down from the site.";
        }
        else if (currentSprite == 7)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
			Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
			txtMy.text = "And he left. With doubts because of the hasty way in which he started, there was nothing left to do but walk through the only place that seemed to have a direction.";
			      currentSprite++;
        }
        else if (currentSprite == 8)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
            txtMy.text = "And after so much walking in the desert, the night caught up with you. At that moment, you see a sign that confirmed your suspicion: the migrant smuggler scammed them and never crossed the border.";
            currentSprite++;
        }
        else if (currentSprite == 9)
        {
            SceneManager.LoadScene("Inicio_HistoriaPolleroNLEng");
            currentSprite = 0;
        }

    }
}