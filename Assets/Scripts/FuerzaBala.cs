using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FuerzaBala : MonoBehaviour
{
    [SerializeField]
    float spBullet = 10;


    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.forward * spBullet, ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("colison con" + tag);

        if (other.gameObject.CompareTag("Enemigo"))
        {
            Destroy(other.gameObject);

            Destroy(gameObject);
        }
    }

    
}
