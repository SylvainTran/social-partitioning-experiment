using System;

/// <summary>
/// The tile containers contain information about what's inside a tile, logically.
/// It's not concerned about the display information.
/// </summary>
public class TileContainer
{
    private UInt16 UID;             // Unique identifier
    private bool dirty;             // Consumed or not by the player yet
}