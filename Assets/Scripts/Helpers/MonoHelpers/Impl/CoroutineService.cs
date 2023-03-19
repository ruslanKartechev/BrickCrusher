﻿using System.Collections;
using UnityEngine;

namespace Helpers.Impl
{
    public class CoroutineService : MonoBehaviour, ICoroutineService
    {
        public Coroutine StartCor(IEnumerator enumerator)
        {
            return StartCoroutine(enumerator);
        }

        public void StopCor(Coroutine coroutine)
        {
            if(coroutine != null)
                StopCoroutine(coroutine);
        }
    }
    
}