using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("스타트 함수에서 작성한 내용입니다.")
    }

    // Update is called once per frame
    void Update() //업데이트 함수 : 계속해서 변경되는 사항이 적용이 된다.
    {
        //x,y,z (y 점프) x, y 이동
        //z(정면), x(오른쪽)
        //-z(후면), -x(왼쪽)

        // -1 ~ 1
        // Input.GetAxis("Horizontal") -> 수평적으로 입력값을 받ㅇ르 때 -1, 1
        // Input.GetAxis("Vertical") -> z방향 1, -z방향 -1
        float horizontalInput = horizontalInput.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vecter3 moveVecter = new Vecter3(horizontalInput, 0, verticalInput);

        transform.position = transform.position + moveVecter * Time.deltaTime; // TIme.deltaTime . Frame 역수
    }
}
