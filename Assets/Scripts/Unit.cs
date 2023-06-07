using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UnitControll
{
    Player,
    Friend,
    Enemy,
}

public class Unit : MonoBehaviour
{
    [SerializeField] private Mover mover;
    [SerializeField] private bool canBoControlled;
    [SerializeField] private UnitControll unitController;
    [SerializeField] private bool selected;

    internal bool CheckIfFriendly()
    {
        throw new NotImplementedException();
    }

  

    private void Start()
    {
        selected = false;
    }
    
    internal bool CheckIfFriendly(UnitControll player)
    {
        if(unitController == UnitControll.Friend || unitController == player) 
        {
        return true;
        }
        else return false;
        return unitController == player;
    }

    public void OnSelected()
    {
        selected= true;
    }

    public void OnDeselected()
    {
        selected = false;
    }
}
