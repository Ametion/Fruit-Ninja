using Model;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class FoodComponent : MonoBehaviour
{
    [SerializeField] private float force;

    private GameSession _gameSession;
    
    private void Awake()
    {
        _gameSession = FindObjectOfType<GameSession>();
        
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * force, ForceMode2D.Impulse);
        
        Destroy(gameObject, 10);
    }

    private void Update()
    {
        if (Input.touchCount > 0 && !_gameSession.PauseData.IsPause)
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint((Input.GetTouch(0).position)), Vector2.zero);
            
            if(hit.collider != null && hit.collider.CompareTag("Food"))
            {
                _gameSession.ScoreData.ModifyScore(1);
                Destroy(hit.transform.gameObject);
            }
            else if (hit.collider != null && hit.collider.CompareTag("Bomb"))
            {
                _gameSession.ScoreData.ModifyScore(-1);
                Destroy(hit.transform.gameObject);
            }
        }
    }
}
