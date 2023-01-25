using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dusman : MonoBehaviour
{
    public GameObject olumEkrani;
    public GameObject kazanmaEkrani;

    public int sayiDusman;
    public TMP_Text sayac;
    public TMP_Text sayacDusman;
    public GameObject dusman;
    public GameObject karakter;

    void Start()
    {
        kazanmaEkrani.SetActive(false);
        olumEkrani.SetActive(false);
        sayiDusman = int.Parse(sayacDusman.text);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("character"))
        {
            sayacDusman.text = (int.Parse(sayacDusman.text) - int.Parse(sayac.text)).ToString();
            
            sayac.text = (int.Parse(sayac.text) - sayiDusman).ToString();
            
        }
        if (int.Parse(sayacDusman.text) <= 0)
        {
            Destroy(dusman);
            Destroy(sayacDusman);
            kazanmaEkrani.SetActive(true);
        }
        else 
        {
            Destroy(karakter);
            Destroy(sayac);
            olumEkrani.SetActive(true);
            SceneManager.LoadScene(0);
        }
    }
    void Quit()
    {
        Application.Quit();
    }
    void Update()
    {
        
    }
}
