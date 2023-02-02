using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ClickToThrow : MonoBehaviour {
  [Header("Configuration")]
  public float altura = 1;
  public float fuerza = 10;

  [Header("Information")]
  public bool esperandoDireccion = false;
  public Vector3 direccion = Vector3.zero;

  [Header("Initialization")]
  public Rigidbody ball;

  void OnMouseDown () {
    esperandoDireccion = true;
  }

  void Update () {
    if (!esperandoDireccion) return;

    if (Input.GetMouseButtonUp(0)) {
      Ray rasho = Camera.main.ScreenPointToRay(Input.mousePosition);
      Plane plano = new Plane(Vector3.up, ball.transform.position);
      plano.Raycast(rasho, out float distancia);
      direccion = rasho.GetPoint(distancia) - ball.transform.position;
      direccion.y = 1;

      ball.AddForce(direccion.normalized * fuerza, ForceMode.Impulse);
      esperandoDireccion = false;
    }
  }
}
