using System.Collections.Generic;
using Godot;

public interface IField {
    public FieldManager Manager {get; set;}

    public List<Node2D> Pieces {get; set;}

    public void Move(IFigure piece);

    public Godot.Collections.Array<int> GetNeighborsNormal();

    public Godot.Collections.Array<int> GetNeighborsAll();
}