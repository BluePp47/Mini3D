using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBuff : MonoBehaviour
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
                _rigidbody.AddForce(transform.up * jumpForce*50*Time.timeScale *3.0f);
            }
        }
    }
}
