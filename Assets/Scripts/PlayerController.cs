using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Sticmac.InputActionListeners;

public class PlayerController : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] Vector2InputActionListener _moveListener;
    [SerializeField] PlayerMovement _playerMovement;
    [SerializeField] PlayerRotation _playerRotation;

    [Header("Parameters")]
    [SerializeField] float _speed = 1f;

    [Space(10)]
    [SerializeField] float _mouseSensitivity = 20f;

    private void OnEnable() {
        _moveListener.Performed += Move;
        _moveListener.Canceled += Move;
    }

    private void OnDisable() {
        _moveListener.Performed -= Move;
        _moveListener.Canceled -= Move;
    }

    private void LateUpdate() {
        RotateByDelta(Mouse.current.delta.ReadValue() * Time.deltaTime * _mouseSensitivity);
    }

    public void Move(Vector2 movement) {
        _playerMovement.HorizontalMovement = _speed * movement;
    }

    public void RotateByDelta(Vector2 delta) {
        _playerRotation.RotateView(delta);
    }
}
