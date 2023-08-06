using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseSpawner : MonoBehaviour
{
    //[SerializeField] PlayerCollision _cheeseCheck;
    [SerializeField] GameObject _cheesePrefab;
    //[SerializeField] PolygonCollider2D _cheeseTrigger;
    float cheeseCD = 5f;
    float timer = 0f;
    //bool newCheese = false;
    int deneme = 0;

    void Start()
    {
        //_cheeseTrigger = GetComponent<PolygonCollider2D>();    
    }

    void Update()
    {
        timer += Time.deltaTime;
        //_cheeseCheck = GetComponent<PlayerCollision>();
        if (timer >= cheeseCD)
        {
            Instantiate(_cheesePrefab, new Vector3(0, 2.5f, 0), Quaternion.identity);
            float newRotation = Random.Range(0f, 360f);
            transform.rotation = Quaternion.Euler(0, 0, 90);
            timer = 0;
            deneme++;
            Debug.Log("Instantiate " + deneme);
        }
    }
}