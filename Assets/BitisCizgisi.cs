using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BitisCizgisi : MonoBehaviour
{
    public GameObject karakter;
    
    void Start()
    {

    }
    void Update()
    {
        // deneme
      
    }
    void Quit()
    {
        Application.Quit();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("character"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
