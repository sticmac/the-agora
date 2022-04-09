using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureMaterialSwitcher : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] MeshRenderer _meshRenderer;

    [Header("Assets")]
    [SerializeField] Material[] _materials;

    private bool _highlighted = false;

    public bool Highlight {
        get => _highlighted;
        set {
            _highlighted = value;
            HighlightMaterial(value);
        }
    }

    private int _currentIndex = 0;

    public void SwitchMaterial() {
        _currentIndex = (_currentIndex + 1) % _materials.Length;
        _meshRenderer.sharedMaterial = _materials[_currentIndex];
        HighlightMaterial(_highlighted);
    }

    private void HighlightMaterial(bool highlight) {
        _meshRenderer.material.SetFloat("_Highlight", highlight ? 1f : 0f);
    }
}
