using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DetecColisionBala : MonoBehaviour
{

    public TextMeshProUGUI txt_punt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        string tag = collision.gameObject.tag;

        if (tag.Equals("Municion"))
        {
            int temp = Convert.ToInt32(txt_punt.text) + 5;
            txt_punt.text = temp.ToString();

            string name = collision.gameObject.name;

            GameObject Bullet = GameObject.Find(name);

            Destroy(Bullet);

        }
    }

}
