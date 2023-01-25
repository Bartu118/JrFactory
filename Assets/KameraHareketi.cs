using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KameraHareketi : MonoBehaviour
{
    //public GameObject gameObject;
    //public float smoothspeed = 0.125f;
    //public float speed;
    //public Vector3 offset;
    
    public float smoothSpeed = 0.5f;
    public Vector3 offset;
    public Transform karakter;

    void Start()
    {
        
    }

    void Update()
    {

        Vector3 desiredPosition = karakter.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        smoothedPosition.x = transform.position.x;
        smoothedPosition.y = transform.position.y;
        transform.position = smoothedPosition;

        if (transform.position.z >= 200)
        {
            SceneManager.LoadScene(0);
        }
        
    }

    void OlumEkrani()
    {
        //Vector3 desiredPosition = gameObject.transform.position + offset;
        //Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed * Time.deltaTime);
        //transform.position = smoothedPosition;
    }
}
