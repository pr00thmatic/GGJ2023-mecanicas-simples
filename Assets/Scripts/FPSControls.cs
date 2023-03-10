using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FPSControls : MonoBehaviour {
  [Header("Configuration")]
  public float speed;
  public Vector2 xRotationRange = new Vector2(-60, 50);
  public Vector2 sensitivity = new Vector2(1, 1);

  [Header("Information")]
  public float xRotation = 0;

  [Header("Initialization")]
  public Transform verticalPivot;
  public Transform horizontalPivot;
  public Rigidbody body;

  void OnEnable () {
    Cursor.lockState = CursorLockMode.Locked;
    Cursor.visible = false;
  }

  void Update () {
    verticalPivot.Rotate(0, Input.GetAxis("Mouse X") * sensitivity.x, 0);
    xRotation = Mathf.Clamp(xRotation + sensitivity.y * Input.GetAxis("Mouse Y"),
                            xRotationRange.x, xRotationRange.y);
    horizontalPivot.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

    Vector3 v = body.velocity;
    float y = v.y;
    v = (Input.GetAxis("Horizontal") * verticalPivot.transform.right +
         Input.GetAxis("Vertical") * verticalPivot.transform.forward) * speed;
    v.y = y;
    body.velocity = v;
  }
}
