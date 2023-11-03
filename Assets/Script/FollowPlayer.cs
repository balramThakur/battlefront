using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField]
    private CinemachineFreeLook vcm;
    [SerializeField]
    private Transform _playerTransform;
    [SerializeField]
    private GameObject _player;
    // Start is called before the first frame update
    void Start()
    {
        vcm = GetComponent<CinemachineFreeLook>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_player == null)
        {
            _player = GameObject.Find("Player Variant(Clone)");
        }
        _playerTransform = _player.transform;
        vcm.LookAt = _playerTransform;
        vcm.Follow = _playerTransform;
    }
}
