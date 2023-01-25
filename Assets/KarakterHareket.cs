using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class KarakterHareket : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        Walk();
        float Xmove = Input.GetAxisRaw("Mouse X");
        //Yukarý aþaðý hareket kontrolü
        //float Ymove = Input.GetAxisRaw("Mouse Y");

        rb.velocity = new Vector3(Xmove, rb.velocity.y, rb.velocity.z * (speed * Time.deltaTime));
        if(transform.position.x >= 16 || transform.position.x <= -16)
        {
            SceneManager.LoadScene(0);
        }
        if(transform.position.y <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
    void Walk()
    {
        transform.position += new Vector3(0, 0, speed * Time.deltaTime);
       
    }
}
