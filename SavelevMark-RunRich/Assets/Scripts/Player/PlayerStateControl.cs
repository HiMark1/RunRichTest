using Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateControl : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Rigidbody _rigidbody;
    //[SerializeField] private PlayerMovement _movement;
   //[SerializeField] private PlayerInteraction _interaction;
    //[SerializeField] private GameStarter _gameStarter;

    private readonly string _walkKey = "Walk";
    private readonly string _upsetKey = "Upset";
    private readonly string _danceKey = "Dance";
    private readonly string _idleKey = "Idle";

    private bool _isPlaying;


    private void FixedUpdate()
    {
        if (_isPlaying == false) return;

    }

    public void StartPlaying()
    {
        _animator.SetTrigger(_walkKey);
        _isPlaying = true;
    }

    public void ProcessVictory()
    {
        Stop();
        _animator.SetTrigger(_danceKey);
    }
    public void NewGame()
    {
        Stop();
        _animator.SetTrigger(_idleKey);
    }
    public void ProcessGameOver()
    {
        Stop();
        _animator.SetTrigger(_upsetKey);
    }

    private void Stop()
    {
        _rigidbody.velocity = Vector3.zero;
        _isPlaying = false;
    }
}
