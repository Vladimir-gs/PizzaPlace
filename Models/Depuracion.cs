namespace PizzaPlace.Models
{
    public static class Depuracion
    {
        private static JsonSerializerOptions options = new
        JsonSerializerOptions
        { WriteIndented = true };
        public static string ToJson(this object obj)
        => JsonSerializer.Serialize(obj, options);
    }
}