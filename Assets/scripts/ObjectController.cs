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
        // forward 파란색 z축 back 파란색 -z;, left x축
        transform.position = transform.position + vector3.forward * speed * Time.deltaTime;
    }
}
