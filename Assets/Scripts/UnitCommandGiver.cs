using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitCommandGiver : MonoBehaviour
{
    public Mover unit;
    private Camera mainCamera;
    [SerializeField] private LayerMask layerMask;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        ReceiveMouseInput();
    }

    private void ReceiveMouseInput()
    {
        if (!Input.GetMouseButtonDown(0))
        { return; }
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

        if(!Physics.Raycast(ray , out RaycastHit hit, 50, layerMask))
        { return; }

        TryMove(hit.point);
    }

    private void TryMove(Vector3 hitInfoPoint)
    {
        unit.Move(hitInfoPoint);
    }
}
