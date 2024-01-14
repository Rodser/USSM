﻿using UnityEngine;

namespace Game.App.Entrypoint
{
    [DefaultExecutionOrder(-1)]
    public class Bootstrapper : MonoBehaviour
    {
        
        private void Awake()
        {
            if (FindObjectOfType<App>() == null)
            {
                new AppFactory().Create();
            }
        }
    }
}
