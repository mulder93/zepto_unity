using UnityEngine;
using UnityEngine.SceneManagement;

public class Bat : MonoBehaviour
{
    [SerializeField]
    private Vector2 force = Vector2.up;

    private Rigidbody2D m_bat;
    private bool m_isPaused = true;

    private void Start()
    {
        m_bat = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (!m_isPaused && Input.GetMouseButtonDown(0)) {
            m_bat.AddForce(force, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        SceneManager.LoadScene(0);
    }

    public void SetIsPaused(bool isPaused)
    {
        m_isPaused = isPaused;
    }
}
