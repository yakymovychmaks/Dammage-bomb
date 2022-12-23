
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float _rotateSpead;
    private void Update()
    {
    transform.RotateAround(transform.position, Vector3.up, _rotateSpead * Time.deltaTime);
    }
}
