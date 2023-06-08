using System;
using System.Collections.Generic;

public enum StatusPlayer
{
    Win,
    Lose,
    Pass,
    Playing,
    TimeOut,
    SwapLetter
}

public interface ITiles
{
    // Interface definition goes here
    public void GetLetter() {
        
    }
}

public interface IBoard
{
    // Interface definition goes here
}

public interface IPlayer
{
    // Interface definition goes here
}

public interface ICoordinate
{
    // Interface definition goes here
}

public class GameRunner
{
    private List<IPlayer> _playerList;
    private List<ITiles> _tileOnBoardList;
    private List<ITiles> _tileOnPlayer;
    private int[] _playerScore;
    private IBoard _board;
    private DateTime[] _playerTimer;
    private StatusPlayer[] _statusPlayer;
    private List<int> _tileQuota;

    public void GenerateBoard()
    {
        // Method implementation goes here
    }

    public void AddPlayer(string name)
    {
        // Method implementation goes here
    }

    public void RemovePlayer(int id)
    {
        // Method implementation goes here
    }

    public void StartGame()
    {
        // Method implementation goes here
    }

    public void DrawLetter(IPlayer player)
    {
        // Method implementation goes here
    }

    public void StartTimer()
    {
        // Method implementation goes here
    }

    public void PutLetter(ITiles tile, ICoordinate position)
    {
        // Method implementation goes here
    }

    public string AssembleWord()
    {
        // Method implementation goes here
    }

    public bool CheckDictionary()
    {
        // Method implementation goes here
    }

    public int CalculateScore()
    {
        // Method implementation goes here
    }

    public IPlayer GetHighscore()
    {
        // Method implementation goes here
    }

    public void SwapLetter()
    {
        // Method implementation goes here
    }

    public void GetStatusPlayer(IPlayer player)
    {
        // Method implementation goes here
    }

    public void SwitchTurn()
    {
        // Method implementation goes here
    }

    public bool CheckTimer()
    {
        // Method implementation goes here
    }

    public void DetermineWinner()
    {
        // Method implementation goes here
    }
}
