﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftSide : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.transform.position = new Vector3 (2.8f, other.gameObject.transform.position.y, -.5f);
        }
    }
}
