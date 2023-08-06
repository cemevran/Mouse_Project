using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseRotation : MonoBehaviour
{
    [SerializeField] GameObject _ch;
    void Update()
    {
        transform.up = _ch.transform.up;
    }
}
