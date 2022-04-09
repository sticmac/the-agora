using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFurnitureActivator : MonoBehaviour
{
    private FurnitureMaterialSwitcher _currentFurniture;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Furniture")) {
            _currentFurniture = other.GetComponent<FurnitureMaterialSwitcher>();
        }
    }

    private void OnTriggerExit(Collider other) {
        _currentFurniture = null;
    }

    public void TryActivatingFurniture() {
        if (_currentFurniture) {
            _currentFurniture.SwitchMaterial();
        }
    }
}
