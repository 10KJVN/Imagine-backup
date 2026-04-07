using UnityEngine;

/// <summary>
/// Defines a mapping between a weather state and atmosphere preset.
/// Used by the AtmosphereWeatherHandler to translate weather changes
/// To atmosphere effects.
/// </summary>

[System.Serializable]
public struct AtmosphereBinding
{
    // [Tooltip("The weather state this preset corresponds to")]
    // public WeatherState.State weather;
    
    [Tooltip("The atmosphere preset to apply for this weather")]
    public AtmospherePreset preset;
    
    [Tooltip("Transition duration in seconds")]
    [Min(0.1f)]
    public float transitionDuration;
}
