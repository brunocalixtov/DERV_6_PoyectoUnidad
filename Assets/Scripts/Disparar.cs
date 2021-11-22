using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    [SerializeField]
    GameObject posSpawn;
    [SerializeField]
    GameObject bullet;

    public TextMeshProUGUI HP;
    //public TextMeshProUGUI SCORE;
    int hp;
    //int score;

    int i;
    // Start is called before the first frame update
    void Start()
    {
        HP.text = 100.ToString();
        //score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject bull = Instantiate(bullet, posSpawn.transform.position, posSpawn.transform.rotation);

            bull.name = "Municion_" + i;
            i++;
            Destroy(bull, 4);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        string nombe = collision.gameObject.name;
        string tag = collision.gameObject.tag;

        Debug.Log("colision con" + tag);

        if (tag.Equals("Enemigo"))
        {
            GameObject gameObj;
            gameObj = GameObject.Find(tag);

            Destroy(gameObj);

        }

    }


}
