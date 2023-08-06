using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float _moveSpeed = 50f;
    int _dir = 1;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _dir = -_dir;
        }
    }

    void FixedUpdate()
    {
        float _rotation = _moveSpeed * Time.deltaTime * _dir;
        transform.Rotate(0, 0, _rotation);
    }
}
