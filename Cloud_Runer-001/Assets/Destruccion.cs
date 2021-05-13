﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruccion : MonoBehaviour
{
    // Start is called before the first frame update

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("DestrucCol"))
        {
            Destroy(collision.gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
        {
        if(other.gameObject.tag.Equals("DestrucTrig"))
        {
            Destroy(other.gameObject);
        }
        }

    }

