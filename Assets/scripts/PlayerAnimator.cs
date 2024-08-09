using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); //:�ڱ� �ڽſ��� ������Ʈ�� �˻��ؼ� �������� ���
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Mathf.abs : ����, �Ʒ����� �Է¹��� ��  Input.GetAxis (���� ���� ��ȯ�մϴ�.) ������ ����� ��ȯ�ϱ� ���� 
        float moveInput = Mathf.Clamp01(Mathf.Abs(horizontal) + Mathf.Abs(vertical)); //Clamp, ù��° ���ڷ� ���� ���� �ּ� �ִ� ���� ������ �������ִ� �Լ�.

        if (moveInput == 0)
        {
            animator.SetBool("Run", false);
        }
        else if (moveInput != 0)
        {
            animator.SetBool("Run", true);
        }

        if(Input.GetKeyDown)
        {
            animator.SetTrigger
        }
    }

}