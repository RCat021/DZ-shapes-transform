using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YAxisRotator : MonoBehaviour
{
    [SerializeField] private float _speedRotate;

    private void Update()
    {
        transform.RotateAround(transform.position, Vector3.up * Time.deltaTime, _speedRotate * Time.deltaTime);
    }
}
