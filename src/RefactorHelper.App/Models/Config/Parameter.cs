﻿namespace RefactorHelper.Models.Config
{
    public class Parameter(string key, string value)
    {
        public string Key { get; private set; } = key;

        public string Value { get; set; } = value;
    }
}
