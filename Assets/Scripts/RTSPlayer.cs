using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTSPlayer : MonoBehaviour
{
[SerializeField] private List<Unit> allUnits = new List<Unit>();

    public List<Unit> GetAllUnits() 
    {
        return allUnits;
    
    }
}
