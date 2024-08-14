using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public float speed;


    // Start is called before the first frame update

    void Start()
    {        
        originPos = transform.position;

        MainUI.Instance.gameOverPanel.SetActive(false); //MainUI 등록한 UI창을 비활성화를 한다.
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

            MainUI.Instance.gameOverCamera.gameObject.SetActive(true);
            Destroy(collision.gameObject);

            MainUI.Instance.gameOverPanel.SetActive(true);

            //gameOverPanel.SetActive(true);
        }
        if (collision.collider.CompareTag("Wall"))
        {
            transform.position = originPos;
        }
    }

}