using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private UIManager UIManagerScript;
    void Start()
    {
        UIManagerScript = GameObject.Find("UI Manager").GetComponent<UIManager>();

    }
    private void OnTriggerEnter(Collider other)
    {
        // Oyunu durduran kod:
        

       //Konsola yazdırmak için:
        Debug.Log("GAME OVER !");
        UIManagerScript.GetComponent<Canvas>().enabled = true;
    }
}
