using Godot;
using Godot.Collections;
using System;
using System.Collections.Generic;

public partial class GameBoardBase : Node2D, IField
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
        return Neighbors is not null ? Neighbors : new Array<int>();
    }

    public Array<int> GetNeighborsNormal()
    {
        return Neighbors is not null ? Neighbors : new Array<int>();
    }

    public void Move(IFigure piece)
    {
        throw new NotImplementedException();
    }

}
