using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class New_Level : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Punto1")
            SceneManager.LoadScene("Punto1");
        if (other.gameObject.tag == "Punto2")
            SceneManager.LoadScene("Punto2");
        if (other.gameObject.tag == "Punto3")
            SceneManager.LoadScene("Punto3");
        Debug.Log("wewewew");
    }
    
}
