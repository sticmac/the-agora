using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] CharacterController _controller;

    public Vector2 HorizontalMovement {
        get => new Vector2(_velocity.x, _velocity.z);
        set => _velocity = new Vector3(value.x, _velocity.y, value.y);
    }

    private Vector3 _velocity = Vector3.zero;

    private void Update() {
        Vector3 move = _velocity.x * _controller.transform.right
            + _velocity.y * _controller.transform.up
            + _velocity.z * _controller.transform.forward;
        _controller.Move(move * Time.deltaTime);
    }
}