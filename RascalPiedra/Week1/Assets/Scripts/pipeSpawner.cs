using UnityEngine;

public class pipeSpawner : MonoBehaviour
{

    [SerializeField] private int _maxtime = 1;
    [SerializeField] private int _heightRange = 2;
    [SerializeField] private GameObject _pipe;

    private float _timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        SpawnPipe();
    }

    private void Update()
    {
        if (_timer > _maxtime)
        {
            SpawnPipe();
            _timer = 0;
        }

        _timer += Time.deltaTime;
    }

    private void SpawnPipe(){
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-_heightRange+4, _heightRange+4));
        GameObject pipe = Instantiate(_pipe, spawnPos, Quaternion.identity);

        Destroy(pipe, 15f);
    }

}
