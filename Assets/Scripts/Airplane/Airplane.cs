using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Airplane : MonoBehaviour
{

    [SerializeField] private TMP_Text _healthText;
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] public int hp;
    [SerializeField] private int score = 0;
    
    [SerializeField] private AudioSource _musicAudio;
    [SerializeField] private AudioSource _coinsAudio;



    

    //  public int healthValue => hp;

    // public event UnityAction<int> HealthChanged;

    private void Start()
    {
       
        _healthText.text = hp.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        


        if(other.TryGetComponent(out Coin coin))
        {
            _coinsAudio.Play();
            score++;
            Destroy(coin.gameObject);
            _scoreText.text = score.ToString();
        }
        else if(other.TryGetComponent(out Bomb bomb))
        {
            _musicAudio.Play();
            if(hp>0)
            {
                Destroy(bomb.gameObject);
                hp -= bomb.Value;
                if(hp <= 0)
                {
                        Destroy(gameObject);
                }   
            }
            _healthText.text = hp.ToString();
        }
    }
}
