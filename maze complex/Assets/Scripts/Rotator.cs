﻿using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(10, 20 , 30) * Time.deltaTime);
    }
}