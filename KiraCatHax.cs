using UnityEngine;

public class KiraCatHax : Mod
{
    public void Start()
    {
        Debug.Log("Mod KiraCatHax has been loaded!");
    }

    public void OnModUnload()
    {
        Debug.Log("Mod KiraCatHax has been unloaded!");
    }
}