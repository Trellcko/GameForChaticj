using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering;
using System.Collections;

namespace Trell.ShadowHouse.Player.Visualization
{
	public class HealthVisualization : MonoBehaviour
	{
        [SerializeField] private Health _health;
        [SerializeField] private Volume _volume;

        [Header("Animations")]
        [SerializeField] private float _stepVignette;
        [Space]
        [SerializeField] private float _stepToRed = 0.1f;
        [SerializeField] private float _timeBetweenChangesColorToRed = 0.1f;
        [Space]
        [SerializeField] private float _stepToDark = 0.1f;
        [SerializeField] private float _timeBetweenChangesColorToDark = 0.1f;

        private Vignette _vignette;

        private ColorParameter _colorParameter = new ColorParameter(Color.red);
        private FloatParameter _intensityParameter = new FloatParameter(0);

        private Coroutine _changeColorCorun; 

        private void Awake()
        {
            _volume.profile.TryGet<Vignette>(out _vignette);
        }

        private void OnEnable()
        {
            _health.DamageTaked += DamageTakedHandler;
        }

        private void OnDisable()
        {
            _health.DamageTaked -= DamageTakedHandler;
        }

        private void DamageTakedHandler()
        {
            _intensityParameter.Override(_vignette.intensity.GetValue<float>() + _stepVignette);
            _vignette.intensity.SetValue(_intensityParameter);
            if(_changeColorCorun != null)
            {
                StopCoroutine(_changeColorCorun);
            }
            _changeColorCorun = StartCoroutine(ChangeColorCorun());
        }

        private IEnumerator ChangeColorCorun()
        {
            Color color = _colorParameter.GetValue<Color>();
            while(color.r <= 1)
            {
                color.r += _stepToRed;
                _colorParameter.Override(color);
                _vignette.color.SetValue(_colorParameter);
                yield return new WaitForSeconds(_timeBetweenChangesColorToRed);
            }
            while (color.r > 0)
            {
                color.r -= _stepToDark;
                _colorParameter.Override(color);
                _vignette.color.SetValue(_colorParameter);
                yield return new WaitForSeconds(_timeBetweenChangesColorToDark);
            }


        }
    }
}