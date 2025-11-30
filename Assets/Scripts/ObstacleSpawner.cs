using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _obstacle;

    [SerializeField]
    private float _yOffsetMin = -5f, _yOffsetMax = 10f;

    [SerializeField]
    private PlayerController _player;


    private float _spawnFrequency = 3f;

    private float _timeTillNextSpawn = 0f;


    // Update is called once per frame
    void Update()
    {

        if(_timeTillNextSpawn <= 0f && _player.IsAlive)
        {
            Vector3 newPosition = new Vector3(transform.position.x, Random.Range(_yOffsetMin, _yOffsetMax));
            Instantiate(_obstacle,newPosition,transform.rotation);
            _timeTillNextSpawn = _spawnFrequency;
        }
        else
        {
            _timeTillNextSpawn -= Time.deltaTime;
        }
    }
}
