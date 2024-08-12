using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public GameObject GameOverPanel;
    public float moveSpeed;

    public MainUI mainUI;

    // Start is called before the first frame update
    void Start()
    {

        //GameOverPanel = GameObject.Find("Canvas/GameOverPanel");
        //GameOverPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            //GameOverPanel.SetActive(true);
        }
    }
}
