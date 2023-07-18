using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] private float speed;

    void Update()
    {
        transform.localScale += new Vector3(speed, speed, speed)*Time.deltaTime;
    }
}
