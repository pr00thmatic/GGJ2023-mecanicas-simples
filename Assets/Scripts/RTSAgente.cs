using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

public class RTSAgente : MonoBehaviour {
  public static RTSAgente selected;

  [Header("Initialization")]
  public NavMeshAgent agent;
  public GameObject selectionIndicator;

  void OnMouseDown () {
    selected = this;
  }

  void Update () {
    selectionIndicator.SetActive(selected == this);

    if (selected == this && Input.GetMouseButtonDown(0)) {
      RaycastHit hit;
      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

      if (Physics.Raycast(ray, out hit)) {
        agent.SetDestination(hit.point);
      }
    }
  }
}
