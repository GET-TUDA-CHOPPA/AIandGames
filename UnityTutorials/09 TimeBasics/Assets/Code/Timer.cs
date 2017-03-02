using UnityEngine;
using System.Collections;

/// <summary>
/// This class counts the time of a scene that is running in the game.
/// It pays attention to both the deltaTime on a per frame basis
/// as well as the fixedDeltaTime which is more important when dealing with
/// physics calculations.
/// </summary>
public class Timer : MonoBehaviour
{

    float _frameTimer;
    float _fixedFrameTimer;

    int _frameCount = 0;
    int _fixedFrameCount = 0;

    int _totalSecondsPassed1 = 1;
    int _totalSecondsPassed2 = 1;

	// Use this for initialization
	public void Start ()
    {
        _frameTimer = 0f;
        _fixedFrameTimer = 0f;
	}
	
    /// <summary>
    /// Update is called once per frame.
    /// The frame rate of this game unless it is capped may vary.
    /// However, deltaTime over a period of one second, will always tally up
    /// to exactly one second.
    /// </summary>
	public void Update ()
    {
        _frameTimer += Time.deltaTime;
        _frameCount++;

        //If a whole second has passed, print how many update calls
        //were made.
        if(_frameTimer >= _totalSecondsPassed1 && _frameTimer > 0f)
        {
            Debug.Log(_totalSecondsPassed1 + ": Frames Per Sec: " + _frameCount);
            _totalSecondsPassed1++;
            _frameCount = 0;
        }
    }

    /// <summary>
    /// Meanwhile, FixedUpdate will not be called at the same frame rate
    /// as the regular Update() method.   This will actually maintain
    /// a fairly constant framerate so that physics calculations are more
    /// consistent.
    /// </summary>
    public void FixedUpdate()
    {
        _fixedFrameTimer += Time.fixedDeltaTime;
        _fixedFrameCount++;

        if(_fixedFrameTimer >= _totalSecondsPassed2 && _fixedFrameTimer > 0f)
        {
            Debug.Log(_totalSecondsPassed2 + ": Fixed Frames Per Sec: " + _fixedFrameCount);
            _totalSecondsPassed2++;
            _fixedFrameCount = 0;
        }
    }
}
