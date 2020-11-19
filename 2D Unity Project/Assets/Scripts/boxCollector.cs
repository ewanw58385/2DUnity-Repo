﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class boxCollector : MonoBehaviour
{ 
public int boxCounter = 0;  
public TextMeshProUGUI boxText;
void OnTriggerEnter2D(Collider2D other)
    
    {
        if (other.transform.tag == "Pickup") //ref. Latosos 
        {
            Destroy(other.gameObject);
            boxCounter = boxCounter + 1;
            //boxCounter++; (same error^)
            boxText.text = "= " + boxCounter.ToString(); 
        }
    }
}