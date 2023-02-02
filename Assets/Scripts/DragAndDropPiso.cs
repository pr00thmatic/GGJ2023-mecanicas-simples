using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DragAndDropPiso : MonoBehaviour {
  [Header("Information")]
  public bool dragging = false;

  void OnMouseDown () {
    dragging = true;
  }

  void Update () {
    if (dragging) {
      Plane plane = new Plane(Vector3.up, transform.position);
      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
      if (plane.Raycast(ray, out float distance)) {
        transform.position = ray.GetPoint(distance);
      }
    }

    if (Input.GetMouseButtonUp(0)) {
      dragging = false;
    }
  }
}
