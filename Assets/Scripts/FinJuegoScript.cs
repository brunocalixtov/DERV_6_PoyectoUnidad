using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinJuegoScript : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI usuar;
    [SerializeField]
    TextMeshProUGUI txt_punt;

    // Start is called before the first frame update
    void Start()
    {
        string usuario =PlayerPrefs.GetString("usua");
        int puntaje = PlayerPrefs.GetInt("score");

        usuar.text = usuario;
        txt_punt.text = puntaje.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
