
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Coin _coinTemplate;
    [SerializeField] private Bomb _bombTemplate;
    [SerializeField] private int _objectCount;

    private void Start()
    {
        for(int i = 0; i < _objectCount; i++)
        {
            Vector3 randomSpawnVector = new Vector3(Random.Range(-100,100),Random.Range(-100,100),Random.Range(-100,100));
            Instantiate(_coinTemplate, randomSpawnVector, Quaternion.identity);
        }
    }
}
