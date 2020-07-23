namespace MinhasFinancas.Comum.Extensions {
    public static class StringExtensions {
        public static bool IsEmpty(this string value) {
            return string.IsNullOrEmpty(value);
        }

        public static bool HasValue(this string value) {
            return !string.IsNullOrEmpty(value);
        }
    }
}
