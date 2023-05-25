namespace TemperatureConversorProgram 
{
	public static class TemperatureConversor
	{
		public static float CelciusToFahrenheit(float celcius) 
		{
			return (celcius * 1.8f) + 32;
		}		
		
		public static float FahrenheitsToCelcius(float fahrenheits) 
		{
			return (fahrenheits - 32) / 0.55f;
		}
	}
}