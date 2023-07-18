using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private Vector3 speed;

    void Update()
    {
        transform.Translate(speed*Time.deltaTime);
    }
}
