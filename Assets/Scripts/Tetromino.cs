using UnityEngine;
using UnityEngine.Tilemaps;
public enum Tetromino
{
    // Shapes of Tetromino
    I, // The Stick or The Long Skinny One
    O, // The Square
    T, // The T
    J, // The L or The Periscope (Left Isomer)
    L, // The L or The Periscope (Right Isomer)
    S, // The Dog (Left Isomer)
    Z, // The Dog (Right Isomer)
}

[System.Serializable]
public struct TetrominoData
{
    public Tetromino tetromino;
    public Tile tile;
    public Vector2Int[] cells {get; private set; }
    public Vector2Int[,] wallKicks { get; private set; }   

    public void Initialize()
    {
        this.cells = Data.Cells[this.tetromino];
        this.wallKicks = Data.WallKicks[this.tetromino];
    }
}