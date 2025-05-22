using System;
using System.Collections.Generic;
using System.Linq;

namespace BofEditorGUI {
    public static class DictionaryExtensions {
        public static TKey GetKeyFromValue<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TValue value) { 
            return dictionary.FirstOrDefault(x => ReferenceEquals(x.Value, value)).Key;
        }
    }
}
