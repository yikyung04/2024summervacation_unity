using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("��ŸƮ �Լ����� �ۼ��� �����Դϴ�.")
    }

    // Update is called once per frame
    void Update() //������Ʈ �Լ� : ����ؼ� ����Ǵ� ������ ������ �ȴ�.
    {
        //x,y,z (y ����) x, y �̵�
        //z(����), x(������)
        //-z(�ĸ�), -x(����)

        // -1 ~ 1
        // Input.GetAxis("Horizontal") -> ���������� �Է°��� �ޤ��� �� -1, 1
        // Input.GetAxis("Vertical") -> z���� 1, -z���� -1
        float horizontalInput = horizontalInput.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vecter3 moveVecter = new Vecter3(horizontalInput, 0, verticalInput);

        transform.position = transform.position + moveVecter * Time.deltaTime; // TIme.deltaTime . Frame ����
    }
}
