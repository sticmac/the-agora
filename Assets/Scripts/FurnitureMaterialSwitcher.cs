using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureMaterialSwitcher : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] MeshRenderer _meshRenderer;

    [Header("Assets")]
    [SerializeField] Material[] _materials;

    private int _currentIndex = 0;

    public void SwitchMaterial() {
        _currentIndex = (_currentIndex + 1) % _materials.Length;
        _meshRenderer.sharedMaterial = _materials[_currentIndex];
    }
}
