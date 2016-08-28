using UnityEngine;
using UnityEngine.SceneManagement;

public class Bat : MonoBehaviour
{
    [SerializeField]
    private Vector2 force = Vector2.up;

    private Rigidbody2D m_bat;

    void Start()
    {
        m_bat = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            m_bat.AddForce(force, ForceMode2D.Impulse);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        SceneManager.LoadScene(0);
    }
}
