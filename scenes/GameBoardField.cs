using Godot;
using Godot.Collections;
using System;
using System.Collections.Generic;

public partial class GameBoardField : Node2D, IField
{
    private FieldManager _manager;
    private Array<int> _allNeighbors;

    [Export]
    public Array<int> NeighborsNormal;
    [Export]
    public Array<int> NeighborsKnightsOnly;

    public FieldManager Manager { get => _manager; set => _manager = value; }
    public List<Node2D> Pieces { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override void _Ready()
    {
        Manager = GetParent<FieldManager>();

        _allNeighbors = NeighborsNormal is not null ? new Array<int>(NeighborsNormal) : new Array<int>();
        if (NeighborsKnightsOnly is not null) {
            _allNeighbors.AddRange(NeighborsKnightsOnly);
        }
    }
    
    public Array<int> GetNeighborsNormal()
    {
        return NeighborsNormal is not null ? NeighborsNormal : new Array<int>();
    }

    public Array<int> GetNeighborsAll()
    {
        return _allNeighbors;
    }

    public void Move(IFigure piece)
    {
        throw new NotImplementedException();
    }

}
