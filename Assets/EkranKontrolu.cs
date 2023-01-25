using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EkranKontrolu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    void Quit()
    {
        Application.Quit();
    }
    public void QuitGame()
    {
        //Invoke("Quit", 0.3f);
        Application.Quit();
    }

}
