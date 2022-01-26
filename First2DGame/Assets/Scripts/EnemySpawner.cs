using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _monsterReferences;

    [SerializeField]
    private Transform _leftPosition, _rightPosition;

    private GameObject _spawnedMonster;
    private int _randomIndex, _randomSide;

    private void Start()
    {
        StartCoroutine(SpawnMonsters());
    }

    IEnumerator SpawnMonsters()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 5));
            _randomIndex = Random.Range(0, _monsterReferences.Length);
            _randomSide = Random.Range(0, 2);

            _spawnedMonster = Instantiate(_monsterReferences[_randomIndex]);

            if (_randomSide == 0) // sol taraf
            {
                _spawnedMonster.transform.position = _leftPosition.position;
                _spawnedMonster.GetComponent<Enemy>().speed = Random.Range(4, 10);
                _spawnedMonster.GetComponent<SpriteRenderer>().flipX = false;
            }
            else // sað taraf
            {
                _spawnedMonster.transform.position = _rightPosition.position;
                _spawnedMonster.GetComponent<Enemy>().speed = -Random.Range(4, 10);
                _spawnedMonster.GetComponent<SpriteRenderer>().flipX = true;
            }
        } //eowhile
    }
}
