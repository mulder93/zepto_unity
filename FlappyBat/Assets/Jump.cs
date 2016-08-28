using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField]
    private Vector2 force = Vector2.up;

    private Rigidbody2D m_body;

    void Start()
    {
        m_body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            m_body.AddForce(force, ForceMode2D.Impulse);
        }
    }
}
