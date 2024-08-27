namespace MauiApp1.example1.model
{
    public static class LightRepository
    {
        private static List<Light>? _lights;
        private static readonly List<Light>? Lights =
        [
            new Light { Id = 1, Value = false, Type = "Front" },
            new Light { Id = 2, Value = false, Type = "Front" },
            new Light { Id = 3, Value = false, Type = "Center" },
            new Light { Id = 4, Value = false, Type = "Center" },
            new Light { Id = 5, Value = false, Type = "Rear" },
            new Light { Id = 6, Value = false, Type = "Rear" }
        ];

        public static async Task<List<Light>?> GetLightsAsync()
        {
            if (_lights == null)
            {
                // Simulating an async operation
                _lights = await Task.FromResult(Lights);
            }
            
            // Simulating an async operation
            return _lights;
        }
        
        public static List<Light>? GetLights()
        {
            if (_lights == null)
            {
                // Simulating an async operation
                _lights = Lights;
            }
            
            // Simulating an async operation
            return _lights;

        }

        public static async Task<Light?> GetLightByIdAsync(int pid)
        {
            // Simulating an async operation
            if (_lights == null) return null;
            var light = _lights.FirstOrDefault(x => x.Id == pid);
            return await Task.FromResult(light);

        }

        public static async Task UpdateLightAsync(int id, bool value)
        {
            if (_lights == null) return;
            
            var lightToUpdate = _lights.FirstOrDefault(x => x.Id == id);
            if (lightToUpdate == null) return;

            // Simulating async work
            await Task.Run(() =>
            {
                lightToUpdate.Value = value;
            });
        }
    }

}
