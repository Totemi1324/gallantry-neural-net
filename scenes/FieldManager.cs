using Godot;
using System;
using System.Collections.Generic;

public partial class FieldManager : Node2D
{
    private enum Connection
    {
        Normal,
        KnightOnly,
    }

    private IField[] _defaultFields;
    private IField[] _safeFields;
    private IField[] _baseFields;
    //private Dictionary<string, List<(IField, Connection)>> _neighborMap;

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

        /*_neighborMap = new Dictionary<string, List<(IField, Connection)>>()
        {
            {"1", new List<(IField, Connection)>()
            {
                (_defaultFields[1], Connection.Normal),
                (_defaultFields[2], Connection.Normal),
                (_defaultFields[5], Connection.Normal),
                (_defaultFields[6], Connection.Normal),
                (_defaultFields[8], Connection.Normal),
                }},
            {"2", new List<(IField, Connection)>()
            {
                (_defaultFields[0], Connection.Normal),
                (_defaultFields[5], Connection.Normal),
                (_safeFields[0], Connection.Normal),
                }},
            {"3", new List<(IField, Connection)>()
            {
                (_defaultFields[0], Connection.Normal),
                (_defaultFields[4], Connection.Normal),
                (_defaultFields[6], Connection.KnightOnly),
                (_safeFields[0], Connection.Normal),
                }},
            {"4", new List<(IField, Connection)>()
            {
                (_defaultFields[5], Connection.Normal),
                (_defaultFields[7], Connection.Normal),
                }},
            {"5", new List<(IField, Connection)>()
            {
                (_defaultFields[2], Connection.Normal),
                (_defaultFields[6], Connection.Normal),
                (_defaultFields[9], Connection.Normal),
                }},
            {"6", new List<(IField, Connection)>()
            {
                (_defaultFields[1], Connection.Normal),
                (_defaultFields[0], Connection.Normal),
                (_defaultFields[8], Connection.Normal),
                (_defaultFields[10], Connection.KnightOnly),
                (_defaultFields[7], Connection.Normal),
                (_defaultFields[3], Connection.Normal),
                }},
            {"7", new List<(IField, Connection)>()
            {
                (_defaultFields[2], Connection.KnightOnly),
                (_defaultFields[0], Connection.Normal),
                (_defaultFields[4], Connection.Normal),
                (_defaultFields[9], Connection.Normal),
                (_defaultFields[11], Connection.Normal),
                (_defaultFields[8], Connection.Normal),
                }},
            {"8", new List<(IField, Connection)>()
            {
                (_defaultFields[3], Connection.Normal),
                (_defaultFields[5], Connection.Normal),
                (_defaultFields[10], Connection.Normal),
                (_defaultFields[12], Connection.Normal),
                }},
            {"9", new List<(IField, Connection)>()
            {
                (_defaultFields[0], Connection.Normal),
                (_defaultFields[6], Connection.Normal),
                (_defaultFields[11], Connection.Normal),
                (_defaultFields[13], Connection.Normal),
                (_defaultFields[10], Connection.Normal),
                (_defaultFields[5], Connection.Normal),
                }},
        };*/
    }

    /*public List<IField> GetNeighbors(string name) {

    }*/
}
