using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement; //6:03



public class BackGround_Manager : MonoBehaviour
{
    public static int currentSprite = 0;
    public string resourceName = "Backgrounds";
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
            currentSprite++;

        }
        else if (currentSprite == 1)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            currentSprite++;
        }
        else if (currentSprite == 2)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            currentSprite++;
        }
        else if (currentSprite == 3)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            currentSprite++;
        }
        else if (currentSprite == 4)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            currentSprite++;
        }
        else if (currentSprite == 5)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            currentSprite++;
        }
        else if (currentSprite == 6)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            currentSprite++;
        }
        else if (currentSprite == 7)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            currentSprite++;
        }
        else if (currentSprite == 8)
        {
            GameObject.Find("Panel").GetComponent<Image>().sprite = backgrounds[currentSprite];
            currentSprite++;
        }
        else if (currentSprite == 9)
        {
            SceneManager.LoadScene("Main2");
        }

    }
}