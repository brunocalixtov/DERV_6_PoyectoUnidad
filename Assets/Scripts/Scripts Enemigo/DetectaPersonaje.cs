using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectaPersonaje : MonoBehaviour
{
    [SerializeField]
    GameObject Enemigo;

    LogicaEnemigo logicaE;

    // Start is called before the first frame update
    void Start()
    {
        logicaE = Enemigo.GetComponent<LogicaEnemigo>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        string tag = other.gameObject.tag;

        if (tag.Equals("Player"))
        {
            GameObject temp = GameObject.FindGameObjectWithTag(tag) as GameObject;
            logicaE.personaje = temp;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        string tag = other.gameObject.tag;

        if (tag.Equals("Player"))
        {
            logicaE.personaje = null;
        }
    }

}
