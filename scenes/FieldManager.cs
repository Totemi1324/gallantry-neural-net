using Godot;

public partial class FieldManager : Node2D
{
    private IField[] _defaultFields;
    private IField[] _safeFields;
    private IField[] _baseFields;

    public override void _Ready()
    {
        _defaultFields = new IField[27];
        for (int i = 1; i <= 27; i++) {
            _defaultFields[i-1] = GetNode<GameBoardField>("%" + i);
        }
        _safeFields = new IField[2];
        _safeFields[0] = GetNode<GameBoardSafeField>("%Safe1");
        _safeFields[1] = GetNode<GameBoardSafeField>("%Safe2");
        _baseFields = new IField[2];
        _baseFields[0] = GetNode<GameBoardBase>("%Base1");
        _baseFields[1] = GetNode<GameBoardBase>("%Base2");
    }

    /*public List<IField> GetNeighbors(string name) {

    }*/
}
