﻿namespace FluentAssertions.Formatting
{
    internal class NumericValueFormatter : IValueFormatter
    {
        public bool CanHandle(object value)
        {
            decimal result;
            return !(value is string) && decimal.TryParse(value.ToString(), out result);
        }

        public string ToString(object value, int nestedPropertyLevel = 0)
        {
            return value.ToString();
        }
    }
}