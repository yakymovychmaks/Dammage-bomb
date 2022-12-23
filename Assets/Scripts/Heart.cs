// using UnityEngine.UI;  
// using UnityEngine;
// using System.Collections.Generic;

// public class Heart : MonoBehaviour
// {
//     [SerializeField] private Airplane  _airplane;
//     [SerializeField] private Image _heartImage;
//     [SerializeField] private Transform _spawnPoint;

//     private List<Image> _imagen = new List<Image>();

//     private void Start()
//     {
//         Vector3 spawnPoint = _spawnPoint.position;

//         for(int i = 0; i< _airplane.HelthValue; i++ )
//         {
//             Instantiate(_heartImage, spawnPoint, Quaternion.identity, transform);
//             _imagen.Add(image);
//             spawnPoint.x +=100;
//         }
//     }

//     private void OnEnable() => _airplane.HealthChanged += OnHealthChanged;
//     private void OnDisable() => _airplane.HealthChanged -= OnHealthChanged;

//     private void OnHealthChanged(int healthValue)
//     {
//         var deletedHeart = _imagen[^1];
//         _imagen.Remove(deletedHeart);
//         deletedHeart.gameObject.SetActive(false);
//     }
// }
