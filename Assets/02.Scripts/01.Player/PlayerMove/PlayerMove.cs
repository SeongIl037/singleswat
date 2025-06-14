using System;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [Header("플레이어 기본 스탯")]
    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private float _jumpPower = 10f;
    
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Move();   
        Jump();
    }

    private void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        Vector3 direction = new Vector3(horizontal, 0, vertical);
            
        direction.Normalize();
        
        this.transform.position += direction * (_moveSpeed * Time.deltaTime);
        
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.AddForce(Vector3.up * _jumpPower, ForceMode.Impulse);
        }
    }

}
