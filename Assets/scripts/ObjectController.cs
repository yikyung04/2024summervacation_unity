using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public float speed;

    public GameObject gameOverPanel;

    // Start is called before the first frame update

    void Start()
    {
        speed = 10;
        originPos = transform.position;

        //gameOverPanel = GameObject.Find("Canvas/GameOverPanel");
        //gameOverPanel.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {

        transform.position = transform.position + transform.forward * speed * Time.deltaTime;
    }


    private Vector3 originPos;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
           
            //Destroy(gameObject);

          
            Destroy(collision.gameObject);

            //gameOverPanel.SetActive(true);
        }
        if (collision.collider.CompareTag("Wall"))
        {
            transform.position = originPos;
        }
    }

}