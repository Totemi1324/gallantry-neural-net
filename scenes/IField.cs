using System.Collections.Generic;
using Godot;

public interface IField {
    public FieldManager Manager {get; set;}

    public List<Node2D> Pieces {get; set;}

    public void Move(Node2D piece);
}