﻿using System;
using System.Collections.Generic;

namespace DREditor
{
    public static class DREditorUtilityExtenstions
    {
        public static void ForEach<T>(
        this IEnumerable<T> source,
        Action<T> action)
        {
            foreach (T element in source)
                action(element);
        }
    };
}