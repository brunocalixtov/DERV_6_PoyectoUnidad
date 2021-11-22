using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Contrl_Escenas : MonoBehaviour
{

    public TextMeshProUGUI usuario;

    void Start()
    {
       
    }

    void Update()
    {
        
    }

    public void IniciarJugeo()
    {
        PlayerPrefs.SetString("usua", usuario.text);


        SceneManager.LoadScene(1);
    }
}
