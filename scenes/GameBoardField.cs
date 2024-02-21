using Godot;
using Godot.Collections;
using System;
using System.Collections.Generic;

public partial class GameBoardField : Node2D, IField
{
    private FieldManager _manager;

    [Export]
    public Array<int> NeighborsNormal;
    [Export]
    public Array<int> NeighborsKnightsOnly;

    public FieldManager Manager { get => _manager; set => _manager = value; }
    public List<Node2D> Pieces { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override void _Ready()
    {
        Manager = GetParent<FieldManager>();
    }

    public void Move(Node2D piece)
    {
        throw new NotImplementedException();
    }

    public Array<int> GetNeighborsNormal()
    {
        throw new NotImplementedException();
    }

    public Array<int> GetNeighborsAll()
    {
        throw new NotImplementedException();
    }
}
