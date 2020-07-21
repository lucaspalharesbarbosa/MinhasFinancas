namespace MinhasFinancas.Comum.Extensions {
    public static class IntExtensions {
        public static bool HasValue(this int number) => number != 0;
        public static bool HasValue(this int? number) => number.HasValue && HasValue(number.Value);
        public static bool IsEmpty(this int number) => !HasValue(number);
        public static bool IsEmpty(this int? number) => !HasValue(number);
        public static bool IsEmptyOrNegative(this int? number) => number == null || number.Value <= 0;
    }
}
