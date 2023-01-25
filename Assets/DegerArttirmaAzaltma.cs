using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class DegerArttirmaAzaltma : MonoBehaviour
{

    public TMP_Text sayac;
    


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("character"))
        {
            sayac.text = (int.Parse(sayac.text) * 10).ToString();
            
        }
    }
}
