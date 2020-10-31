using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    private Sprite[] diceSides;
    private SpriteRenderer rend;
    private int whosTurn = 1;
    private bool coroutineAllowed = true;
    public AudioSource noise1;
    public AudioSource[] sounds;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
        rend.sprite = diceSides[2]; //por los tras lados del dado
        AudioSource[] sounds = GetComponents<AudioSource>();// audioañadido en start
        noise1 = sounds[0];
    }

    // Update is called once per frame


    private void OnMouseDown()
    {
        if (!GameControl.gameOver && coroutineAllowed)
            StartCoroutine("RollTheDice");
        noise1.Play();// aber
    }
    
    private IEnumerator RollTheDice()
    {
        coroutineAllowed = false;
        int randomDiceSide = 0;
        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = Random.Range(0, 3); //anteriormente estaba aqui el 6. Se pone a 1 para ver cada una de las casillas
            rend.sprite = diceSides[randomDiceSide];
            yield return new WaitForSeconds(0.05f);
        }

        GameControl.diceSideThrown = randomDiceSide + 1;
        if (whosTurn == 1)
        {
            GameControl.MovePlayer(1);
        }
        else if (whosTurn == -1)
            whosTurn *= -1;
        coroutineAllowed = true;
    }
}