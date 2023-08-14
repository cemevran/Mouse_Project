using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] GameObject _cheesePrefab;
    [SerializeField] Manager _sceneManagerScript;

    int score = 0;
    int tracker = 0;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            Destroy(collision.gameObject);
            score++;
            _sceneManagerScript.WriteScore(score);
            Debug.Log("Score: " + score);
        }
        else if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            tracker++;
            _sceneManagerScript.GameOver();
            Debug.Log("GAME OVER!!!   " + tracker);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Target")
            CreateNewCheese();
    }

    public void CreateNewCheese()
    {
        float randomRot = Random.Range(0f, 360f);
        Instantiate(_cheesePrefab, new Vector3(0f, 0f, 0f), Quaternion.Euler(0, 0, randomRot));
    }
}
