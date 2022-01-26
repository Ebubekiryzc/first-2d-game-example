using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform _player;

    private Vector3 _temporaryPosition;
    private string PLAYER_TAG = "Player";

    [SerializeField]
    private float _minX, _maxX;

    // Start is called before the first frame update
    private void Start()
    {
        _player = GameObject.FindWithTag(PLAYER_TAG).transform;
    }

    // LateUpdate: B�t�n hesaplamalar bittikten sonra �al��t�r�ld��� i�in
    // karakterin g�ncel konumuna ula�mam�zda �nceki hesaplamalar yap�ld�ktan sonra olanak sa�lad��� i�in jittering olmaz.
    private void LateUpdate()
    {
        FollowPlayer();
    }

    private void FollowPlayer()
    {
        if (!_player) return;

        _temporaryPosition = transform.position;
        _temporaryPosition.x = _player.position.x;

        if (_temporaryPosition.x < _minX) _temporaryPosition.x = _minX;
        if (_temporaryPosition.x > _maxX) _temporaryPosition.x = _maxX;

        transform.position = _temporaryPosition;
    }
}
