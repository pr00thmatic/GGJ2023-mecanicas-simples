using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FisicaEnPolvo : MonoBehaviour {
  [Header("Initialization")]
  public Rigidbody kinematico;
  public Rigidbody mio;

  void Update () {
    mio.MovePosition(kinematico.transform.position);
    mio.MoveRotation(kinematico.transform.rotation);
  }
}
