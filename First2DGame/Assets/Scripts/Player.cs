using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int _health;
    private int _power;
    private string _name;

    public int Health
    {
        get { return _health; }
        set { _health = value; }
    }

    public int Power
    {
        get { return _power; }
        set { _power = value; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
}
