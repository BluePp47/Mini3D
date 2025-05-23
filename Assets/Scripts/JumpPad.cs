using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumppad : MonoBehaviour
{
    public float jumpForce = 50f;
    private Rigidbody _rigidbody;
    


    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            Debug.Log("플레이어");
            PlayerController player = other.GetComponent<PlayerController>();
            if (player != null)
            {
                Debug.Log("점프동작");
                _rigidbody = player.GetComponent<Rigidbody>();
                _rigidbody.AddForce(transform.up * jumpForce);
                //_rigidbody.AddForce(Vector2.up * jumpForce, ForceMode.Impulse);
            }
        }
    }
}

//public class ExampleClass : MonoBehaviour
//{
//    Rigidbody m_Rigidbody;
//    float power = 5.0f;

//    void Start()
//    {
//        m_Rigidbody = GetComponent<Rigidbody>();
//    }

//    void AddForceTest()
//    {
//        // 입력을 힘(뉴턴)으로 해석하고, 속도를 '힘 * DT / 질량'의 값으로 변경.        // 효과는 시뮬레이션 단계 길이와 물체의 질량에 따라 달라집니다.
//        m_Rigidbody.AddForce(transform.up * power);

//        // 매개변수를 충격량(뉴턴-초)으로 해석하고, 힘/질량 값으로 속도를 변경.
//        // 효과는 물체의 질량에 따라 달라지지만, 시뮬레이션 단계 길이에는 영향 X
//        m_Rigidbody.AddForce(transform.up * power, ForceMode.Impulse);
//    }
//}


