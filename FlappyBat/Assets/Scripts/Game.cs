using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField]
    private GameObject m_obstaclePrototype;

    [SerializeField]
    private float m_obstacleGenerationInterval;

    private float m_timeToNextGeneration;
    private Vector2 m_startObstaclePosition;

	void Start()
    {
        m_timeToNextGeneration = m_obstacleGenerationInterval;
        m_startObstaclePosition = m_obstaclePrototype.transform.position;
	}
	
	void Update()
    {
        m_timeToNextGeneration -= Time.deltaTime;
        if (m_timeToNextGeneration <= 0) {
            m_timeToNextGeneration = m_obstacleGenerationInterval;
            GenerateObstacle();
        }
    }

    void GenerateObstacle()
    {
        var obstacle = Instantiate(m_obstaclePrototype);
        obstacle.transform.position = new Vector2(m_startObstaclePosition.x, obstacle.transform.position.y);
        obstacle.SetActive(true);
    }
}
