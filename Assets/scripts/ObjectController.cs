using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        speed = 10;
    }


    // Update is called once per frame
    void Update()
    {
        // forward �Ķ��� z�� back �Ķ��� -z;, left x��
        transform.position = transform.position + vector3.forward * speed * Time.deltaTime;
    }
}
