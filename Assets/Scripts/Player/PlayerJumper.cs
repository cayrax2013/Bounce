using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerJumper : MonoBehaviour
{
    [SerializeField] private float _tapForce;
    [SerializeField] private ContactFilter2D _filter;
    [SerializeField] private UnityEvent _jumped;

    private Rigidbody2D _rigidbody2D;
    private readonly RaycastHit2D[] _results = new RaycastHit2D[1];

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void Jump()
    {
        if (IsGrounded())
        {
            _jumped?.Invoke();
            _rigidbody2D.AddForce(Vector2.up * _tapForce, ForceMode2D.Impulse);
        }
    }

    public bool IsGrounded()
    {
        var _hit = _rigidbody2D.Cast(Vector2.down, _results, 0.1f);

        if (_hit != 0)
            return true;

        return false;
    }
}
