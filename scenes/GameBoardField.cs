using Godot;
using System;
using System.Collections.Generic;

public partial class GameBoardField : Node2D, IField
{
    private FieldManager _manager;

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

}
