using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Oscillator : MonoBehaviour
{
    [SerializeField] private Vector3 _movementVector;
    [Range(0, 1)] [SerializeField] private float _movementFactor;     // Range() add a slider 
    [SerializeField] private float _period = 2f;

    private Vector3 _startingPos;
    private Vector3 _offset;

    void Start()
    {
        _startingPos = transform.position;
    }

    void Update()
    {
        if (_period <= Mathf.Epsilon)       // Epsilon is the samllest float; To avoid DivisionByZero Error
        {
            return;
        }

        // Time.time = time in seconds from the begining of the game
        float _cycles = Time.time / _period;                // Grows continually from 0; if game = 10sec then 10/2 = 5 cycles
        const float _tau = Mathf.PI * 2f;                   // About 6.28f; 1TAU = 2PI
        float _rawSineWave = Mathf.Sin(_cycles * _tau);     // Takes a value in radian and return value between -1 and +1


        /*
         * 1 radian = angle formed when the arc of length of radius is put on circle.
         * A half circle has 3.12 rad i.e PI
         * A complete circle has 6.28 rad == 2PI == TAU (is the radiance in a full circle)
         * Amplitude is the total height of a sine wave
         * Period is the length of 1 complete cycle (amount of time before it repeats itself)
         */

        _movementFactor = _rawSineWave / 2f + 0.5f;     // Since we set _movementFactor between 0 & 1 and  _rawSineWave is between -1 & 1 div by 2 make it between -.5 and +.5 so we add +.5 to make it beween 0 and 1

        _offset = _movementVector * _movementFactor;
        transform.position = _startingPos + _offset;
    }
}
