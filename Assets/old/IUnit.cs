﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUnit
{
    bool IsIdle();
    void MoveTo(Vector3 position, float stopDistance, Action onArrivedAtPosition);
   // void PlayAnimationfoodGather(Vector3 lookAtPosition, Action onAniamtionCompleted);
}
