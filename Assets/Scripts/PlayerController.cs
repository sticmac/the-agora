using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sticmac.InputActionListeners;

public class PlayerController : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] Vector2InputActionListener _actionListener;
    [SerializeField] PlayerMovement _playerMovement;

    [Header("Parameters")]
    [SerializeField] float _speed = 1f;

    private void OnEnable() {
        _actionListener.Performed += Move;
        _actionListener.Canceled += Move;
    }

    private void OnDisable() {
        _actionListener.Performed -= Move;
        _actionListener.Canceled -= Move;
    }

    public void Move(Vector2 movement) {
        _playerMovement.HorizontalMovement = _speed * movement;
    }
}
