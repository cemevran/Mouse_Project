using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float _moveSpeed = 5f;
    Rigidbody2D _rb;
    Vector3 _moveDir;
    [SerializeField] bool changeDir = false;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Border" || transform.position.magnitude >= 4)
            changeDir = true;
    }

    void FixedUpdate()
    {        
        if (changeDir)
        {
            _moveSpeed = _moveSpeed * -1;
            changeDir = false;
        }
        else
        {
            _moveSpeed *= 1;
        }

        _moveDir = new Vector3(0, 0, 0) - transform.position;
        Vector3 newPos = transform.position + _moveDir.normalized * _moveSpeed * Time.deltaTime;

        _rb.MovePosition(newPos);
    }
}
