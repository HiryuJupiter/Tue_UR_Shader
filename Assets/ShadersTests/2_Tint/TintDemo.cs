using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShaderDemoScene
{
    public class TintDemo : MonoBehaviour
    {
        private const string StringName = "_Strength";
        private const float OnWidth = 0.02f;

        private Renderer renderer;

        private IEnumerator Start()
        {
            renderer = GetComponent<Renderer>();
            while (true)
            {
                yield return FadeIn();
                yield return FadeOut();
            }
        }

        private IEnumerator FadeIn()
        {
            float t = 0;
            while (t < 1)
            {
                t += Time.deltaTime;
                SetValue(t);
                yield return null;
            }
        }

        private IEnumerator FadeOut()
        {
            float t = 1;
            while (t > 0)
            {
                t -= Time.deltaTime;
                SetValue(t);
                yield return null;
            }
        }

        void SetValue(float value)
        {
            renderer.material.SetFloat(StringName, value);
        }
    }
}