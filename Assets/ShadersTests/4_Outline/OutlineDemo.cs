using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShaderDemoScene
{
    public class OutlineDemo : MonoBehaviour
    {
        private const string StringName = "_Width";
        private const float OnWidth = 0.02f;

        private Renderer renderer;

        IEnumerator Start()
        {
            renderer = GetComponent<Renderer>();
            bool on = false;
            while(true)
            {
                yield return new WaitForSeconds(0.5f);
                on = !on;
                TurnOn(on);
            }    
        }

        void TurnOn (bool value)
        {
            SetValue(value ? OnWidth : 0f);
        }

        void SetValue(float value)
        {
            renderer.material.SetFloat(StringName, value);
        }
    }
}