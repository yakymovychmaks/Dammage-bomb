
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Rigidbody _ridgibody;
    [SerializeField] private float _spead;
    [SerializeField] private float _torqueForce;

    private float _horizontalInput;
    private float _verticalInput;
    private void Update()
    {
        _ridgibody.velocity = transform.forward * _spead * Time.deltaTime;
    
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");

    }

    private void FixedUpdate()
    {
        _ridgibody.AddRelativeTorque(- _verticalInput * _torqueForce, 0f, - _horizontalInput * _torqueForce);

    }
}
