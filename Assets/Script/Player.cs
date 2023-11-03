using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(CapsuleCollider))]
public class Player : MonoBehaviour
{
    [SerializeField]
    private Rigidbody _rigidbody;
    [SerializeField]
    private Joystick _joystick;
    [SerializeField]
    private Animator _animation;

    [SerializeField]
    private float _speed;
    // Start is called before the first frame update
    void Start()
    {
        
        _joystick = FindObjectOfType<Joystick>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(_joystick.Horizontal * _speed, _rigidbody.velocity.y, _joystick.Vertical * _speed);
        
        if(_joystick.Horizontal !=0 || _joystick.Vertical!=0)
        {
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
        }
    }
}
