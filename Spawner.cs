using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] _veiculo;

    private float _timeBtwSpawn;
    public float _startTimeBtwSpawn;
    public float _decreaseTime;
    public float _minTime = 0.65f;

    private void Update()
    {
        if (_timeBtwSpawn <= 0)
        {
            int r = Random.Range(0, _veiculo.Length);

            Instantiate(_veiculo[r]);
            _timeBtwSpawn = _startTimeBtwSpawn;
            if (_startTimeBtwSpawn > _minTime)
            {
                _startTimeBtwSpawn -= _decreaseTime;
            }
        }
        else
        {
            _timeBtwSpawn -= Time.deltaTime;
        }
    }
}
