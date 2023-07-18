using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour
{
    [SerializeField] private float m_Rotation;

    void Update()
    {
        transform.Rotate(m_Rotation * Time.deltaTime, 0, 0);
    }
}
