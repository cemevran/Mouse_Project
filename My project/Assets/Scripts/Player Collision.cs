using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public bool newCheese = false;
    int score = 0;
    int tracker = 0;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            Destroy(collision.gameObject);
            score++;
            newCheese = true;
            Debug.Log("Score: " + score);
        }
        else if (collision.gameObject.tag == "Enemy")
        {
            //Destroy(gameObject);
            tracker++;
            Debug.Log("GAME OVER!!!   " + tracker);
        }
    }
}
