using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Airplane : MonoBehaviour
{

    [SerializeField] private TMP_Text _healthText;
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private int hp = 5;
    [SerializeField] private int score = 0;

     public int healthValue => hp;

    // public event UnityAction<int> HealthChanged;

    private void Start()
    {
       
        _healthText.text = healthValue.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        


        if(other.TryGetComponent(out Coin coin))
        {
            score++;
            Destroy(coin.gameObject);
            _scoreText.text = score.ToString();
        }
        else if(other.TryGetComponent(out Bomb bomb))
        {
            if(healthpoint>0)
            {
                Destroy(bomb.gameObject);
                healthpoint -= bomb.Value;
                if(healthpoint <= 0)
                {
                        Destroy(gameObject);
                }   
            }
            
        }
    }
}
