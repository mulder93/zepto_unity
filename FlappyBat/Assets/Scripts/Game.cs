using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField]
    private GameObject m_obstaclePrototype;

    [SerializeField]
    private GameObject m_bat;

    [SerializeField]
    private GameObject m_tutorial;

    [SerializeField]
    private float m_obstacleGenerationInterval;

    private float m_timeToNextGeneration;
    private Vector2 m_startObstaclePosition;
    private bool m_isPaused;

	void Start()
    {
        m_timeToNextGeneration = 0;
        m_startObstaclePosition = m_obstaclePrototype.transform.position;
        m_isPaused = true;
    }
	
	void Update()
    {
        if (m_isPaused) {
            if (Input.GetMouseButtonDown(0)) {
                m_isPaused = false;
                m_bat.SetActive(true);
                m_bat.GetComponent<Bat>().SetIsPaused(false);
                m_tutorial.SetActive(false);
            }
        } else {
            m_timeToNextGeneration -= Time.deltaTime;
            if (m_timeToNextGeneration <= 0) {
                m_timeToNextGeneration = m_obstacleGenerationInterval;
                GenerateObstacle();
            }
        }
    }

    void GenerateObstacle()
    {
        var obstacle = Instantiate(m_obstaclePrototype);
        obstacle.transform.position = new Vector2(m_startObstaclePosition.x, obstacle.transform.position.y);
        obstacle.SetActive(true);
    }
}
