using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField]
    private float m_speed;

    [SerializeField]
    private float m_minYOffset;

    [SerializeField]
    private float m_maxYOffset;

    private void Start()
    {
        transform.Translate(new Vector2(0, Random.Range(m_minYOffset, m_maxYOffset)));
    }

    private void Update()
    {
        transform.Translate(Vector2.left * m_speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Left Limit") {
            Destroy(this.gameObject);
        }
    }
}
