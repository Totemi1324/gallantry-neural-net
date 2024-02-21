using Godot;
using System;
using System.Collections.Generic;

public partial class FieldManager : Node2D
{
    private IField[] _defaultFields;
    private IField[] _safeFields;
    private IField[] _baseFields;

    public override void _Ready()
    {
        _defaultFields = new IField[27];
        for (int i = 1; i <= 27; i++) {
            _defaultFields[i-1] = GetNode<IField>("%" + i);
        }
        _safeFields[0] = GetNode<IField>("%Safe1");
        _safeFields[1] = GetNode<IField>("%Safe2");
        _baseFields[0] = GetNode<IField>("%Base1");
        _baseFields[1] = GetNode<IField>("%Base2");
    }

    /*public List<IField> GetNeighbors(string name) {

    }*/
}
