using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); // animator ������ ���� ���� ������Ʈ�� ������Ʈ �߿� Animator�� ã�Ƽ� �־��
    }

    // Update is called once per frame
    void Update()
    {
        //animator.SetBool("IsOpen", true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            animator.SetBool("IsOpen", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            animator.SetBool("IsOpen", false);
        }
    }

}
