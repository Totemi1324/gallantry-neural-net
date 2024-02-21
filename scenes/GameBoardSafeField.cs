using Godot;
using Godot.Collections;
using System;
using System.Collections.Generic;

public partial class GameBoardSafeField : Node2D, IField
{
    private FieldManager _manager;

    [Export]
    public Array<int> Neighbors;
    
    public FieldManager Manager { get => _manager; set => _manager = value; }
    public List<Node2D> Pieces { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override void _Ready()
    {
        Manager = GetParent<FieldManager>();
    }

    public Array<int> GetNeighborsAll()
    {
        throw new NotImplementedException();
    }

    public Array<int> GetNeighborsNormal()
    {
        throw new NotImplementedException();
    }

    public void Move(Node2D piece)
    {
        throw new NotImplementedException();
    }

}
