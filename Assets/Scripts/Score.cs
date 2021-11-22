using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI SCORE;

    int score;
    int i;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("suma con" + tag);
        if (collision.gameObject.tag == "Enemigo")
        {
            score = score + 1;
            SCORE.text = score.ToString();
        }
    }
}
