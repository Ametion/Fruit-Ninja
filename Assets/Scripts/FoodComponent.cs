using Model;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class FoodComponent : MonoBehaviour
{
    
    [SerializeField] private float _force;

    private GameSession gameSession;
    
    private void Awake()
    {
        gameSession = FindObjectOfType<GameSession>();
        
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * _force, ForceMode2D.Impulse);
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint((Input.GetTouch(0).position)), Vector2.zero);
            
            if(hit.collider != null && hit.collider.CompareTag("Food"))
            {
                gameSession.ScoreData.ModifyScore(1);
                Destroy(hit.transform.gameObject);
            }
            else if (hit.collider != null && hit.collider.CompareTag("Bomb"))
            {
                gameSession.ScoreData.ModifyScore(-1);
                Destroy(hit.transform.gameObject);
            }
        }
    }
}
