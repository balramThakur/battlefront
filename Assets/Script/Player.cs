using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

[RequireComponent(typeof(Rigidbody), typeof(CapsuleCollider))]
public class Player : NetworkBehaviour
{
    [SerializeField]
    private Rigidbody _rigidbody;
    [SerializeField]
    private Joystick _joystick;
    [SerializeField]
    private Animator _animation;
    [SerializeField]
    private Transform _gunPosition;
    [SerializeField]
    private GameObject _gun;

    [SerializeField]
    private float _speed;
    // Start is called before the first frame update
    void Start()
    {
        
        _joystick = FindObjectOfType<Joystick>();
        Debug.Log(IsOwner);
    }

    // Update is called once per frame
    void Update()
    {        
        _rigidbody.velocity = new Vector3(_joystick.Horizontal * _speed, _rigidbody.velocity.y, _joystick.Vertical * _speed);
        if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity*_speed*Time.deltaTime);
            _animation.SetBool("isRunning", true);
            _gun.transform.position = new Vector3(_gunPosition.transform.position.x, _gunPosition.transform.position.y, _gunPosition.transform.position.z);
            _gun.transform.eulerAngles = new Vector3(_gunPosition.eulerAngles.x, _gunPosition.eulerAngles.y, _gunPosition.eulerAngles.z);
            _animation.SetBool("isIdle", false);
        }
        else
        {
            _animation.SetBool("isRunning", false);
            _animation.SetBool("isIdle", true);
        }
    }
}
