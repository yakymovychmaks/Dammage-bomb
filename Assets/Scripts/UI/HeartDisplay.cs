using UnityEngine;
using UnityEngine.UI;

public class HeartDisplay : MonoBehaviour
{
    [SerializeField] private Airplane _airplane;
    // [SerializeField] private Image _heartImage;
    [SerializeField] private Transform _spawnPoint;

    private void Start()
    {
        // Vector3 spawnPosition = _spawnPoint.position;

        // for(int i = 0; i < _airplane.healthValue; i++)
        // {
        //     Instantiate(_heartImage, spawnPosition,Quaternion.identity,transform);
        //     spawnPosition.x +=100;
        // }
    }
}
