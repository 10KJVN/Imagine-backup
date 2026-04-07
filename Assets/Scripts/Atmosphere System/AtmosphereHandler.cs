using System;
using UnityEngine;
using UnityEngine.Serialization;

/// <summary>
/// This class will act as bridge
/// To link the Atmosphere and Weather systems
///
/// View it like a translator for weather changes
/// And atmosphere effects so, they can sync.
/// </summary>

public class AtmosphereHandler : MonoBehaviour
{
    [Header("References")]
    // [SerializeField] private WeatherState weatherState;
    [SerializeField] private AtmosphereSystem atmosphereSystem;
    
    [Header("Weather Mapping")]
    [SerializeField] private AtmosphereBinding[] weatherBindings;
    
    // private void OnEnable()
    // {
    //     if (weatherState != null)
    //         weatherState.OnWeatherChanged += HandleWeatherChanged;
    // }
    
    // private void OnDisable()
    // {
    //     if (weatherState != null)
    //         weatherState.OnWeatherChanged -= HandleWeatherChanged;
    // }
    
    // TO-DO: Add argument overload for out float defaultDuration.
    // private void HandleWeatherChanged(WeatherState.State state)
    // {
    //     //defaultDuration = 0f; // Default fallback: Snap to next volumeProfile.
    //     
    //     foreach (var binding in weatherBindings)
    //     {
    //         if (binding.weather == state && binding.preset != null)
    //         {
    //             atmosphereSystem.TransitionTo(binding.preset, binding.transitionDuration);
    //             return;
    //         }
    //     }
    //     
    //     Debug.LogWarning($"No binding found for weather state: {state}");
    // }
}