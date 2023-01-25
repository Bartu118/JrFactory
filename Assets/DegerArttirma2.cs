using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DegerArttirma2 : MonoBehaviour
{
    public TMP_Text sayac;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("character"))
        {
            sayac.text = (int.Parse(sayac.text) + 50).ToString();

        }
    }
}
