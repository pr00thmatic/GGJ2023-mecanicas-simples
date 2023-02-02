using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ThrowTheBall : MonoBehaviour {
  [Header("Configuration")]
  public float strength = 10;

  [Header("Initialization")]
  public Rigidbody ball;
  public Transform direction;
  public Transform player;

  void Update () {
    if (Input.GetKeyDown(KeyCode.Space)) {
      ball.gameObject.SetActive(true);
      ball.transform.position = direction.position;
      ball.velocity = direction.forward * strength;
    }

    if (Input.GetKeyUp(KeyCode.Space)) {
      ball.gameObject.SetActive(false);
      player.transform.position = ball.transform.position;
    }
  }
}
