﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Tenemos que mover el vehiculo hacia delante
        transform.Translate(40 * Time.deltaTime * Vector3.forward);
        //tarea terminada

    }
}
