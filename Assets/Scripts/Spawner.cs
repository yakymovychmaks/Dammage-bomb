
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Coin _coinTemplate;
    [SerializeField] private Bomb _bombTemplate;
    [SerializeField] private Hearts _hearttemplate;
    [SerializeField] private int _objectCount;

    private void Start()
    {
        for(int i = 0; i < _objectCount; i++)
        {
            
            Instantiate(_coinTemplate, RandVector(), Quaternion.identity);
            Instantiate(_bombTemplate, RandVector(), Quaternion.identity);
            // if((i % 5) == 0)
            // {
                Instantiate(_hearttemplate, RandVector(), Quaternion.identity);
           // }
        }
    }
    public Vector3 RandVector()
    {
        Vector3 randomSpawnVector = new Vector3(Random.Range(-200,200),Random.Range(-200,200),Random.Range(-200,200));
        return randomSpawnVector;
    }
}
