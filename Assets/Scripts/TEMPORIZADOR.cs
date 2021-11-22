using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TEMPORIZADOR : MonoBehaviour
{

    public TextMeshProUGUI tempor;
    int cont = 60;


    public bool ejecutaCorutina;
    // Start is called before the first frame update
    void Start()
    {
        tempor.text = cont.ToString();
        if (ejecutaCorutina)
        {
            StopAllCoroutines();
            StartCoroutine("auxTest");
        }
    }

    IEnumerator auxTest()
    {
        while (true)
        {
            tempor.text = cont--.ToString();
            if (cont ==0)
            {
                SceneManager.LoadScene(2);
            }

            yield return new WaitForSeconds(1.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
