using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class boxCollector : MonoBehaviour
{ 
public float boxCounter = 0f;  
public TextMeshProUGUI boxText;
void OnTriggerEnter2D(Collider2D other)
    
    {
        if (other.transform.tag == "Pickup") //ref. Latosos 
        {
            Destroy(other.gameObject);
            boxCounter = boxCounter + 1;
            boxText.text = "= " + boxCounter.ToString(); 
        }
    }
}
