using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RTSLike : MonoBehaviour {
  [Header("Configuration")]
  public float sensitivity = 3;

  void OnEnable () {
  }

  void Update () {
    if (Input.GetMouseButton(1)) {
      // Cursor.lockState = CursorLockMode.Locked;
      // Cursor.visible = false;
      transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivity, 0);
    } else {
      Cursor.lockState = CursorLockMode.None;
      Cursor.visible = true;
    }
  }
}
