namespace MinimalApi.Filters
{
    public static class FilterArgsUtil
    {
        public static int GetArgumentIndex(IList<object?> arguments, Type argumentType)
        {
            if (arguments == null) throw new Exception($"{nameof(arguments)} cannot be null.");

            var argumentIndex = 0;

            foreach (var argument in arguments)
            {
                if (argument != null && argument.GetType() == argumentType) return argumentIndex;
                argumentIndex++;
            }

            throw new Exception($"Index not found for argument type '{nameof(argumentType)}'.");
        }
    }
}
