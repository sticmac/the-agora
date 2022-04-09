using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    public enum DefaultConfig {
        FirstPerson,
        ThirdPerson
    }

    [Header("Cameras")]
    [SerializeField] CinemachineVirtualCamera _firstPersonCamera;
    [SerializeField] CinemachineVirtualCamera _thirdPersonCamera;

    [Header("Parameters")]
    [SerializeField] DefaultConfig _defaultConfig = DefaultConfig.ThirdPerson;

    private void Start() {
        _firstPersonCamera.enabled = _defaultConfig == DefaultConfig.FirstPerson;
        _thirdPersonCamera.enabled = _defaultConfig == DefaultConfig.ThirdPerson;
    }

    public void Toggle() {
        _firstPersonCamera.enabled = !_firstPersonCamera.enabled;
        _thirdPersonCamera.enabled = !_thirdPersonCamera.enabled;
    }
}
