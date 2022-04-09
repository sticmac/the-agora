using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] Transform _playerTransform;
    [SerializeField] Transform _cameraTransform;

    [Header("Parameters")]
    [SerializeField] float _minimumHorizontalRotation = -360f;
    [SerializeField] float _maximumHorizontalRotation = 360f;
    [SerializeField] float _minimumVerticalRotation = -60f;
    [SerializeField] float _maximumVerticalRotation = 60f;

    private float _horizontalRotation = 0f;
    private float _verticalRotation = 0f;

    public void RotateView(Vector2 delta) {
        _horizontalRotation = Mathf.Clamp(_horizontalRotation + delta.x, _minimumHorizontalRotation, _maximumHorizontalRotation);
        _verticalRotation = Mathf.Clamp(_verticalRotation + delta.y, _minimumVerticalRotation, _maximumVerticalRotation);
        _playerTransform.rotation = Quaternion.Euler(0, _horizontalRotation, 0);
        _cameraTransform.localRotation = Quaternion.Euler(_verticalRotation, 0, 0);
    }
}
