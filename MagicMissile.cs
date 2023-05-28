using System;
using Timers;
using UnityEngine;
using UnityEngine.Events;


public class MagicMissile : MonoBehaviour
{
    [SerializeField] private MissileCreator creator;
    [SerializeField] private UnityEvent missileLaunch;

    private void LaunchMissile()
    {
        creator.CreateMissile();
        missileLaunch.Invoke();
    }

    private void Awake()
    {
        TimersManager.SetLoopableTimer(this, 1, LaunchMissile);
    }
}