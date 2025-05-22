using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace BofEditor {
    public class FileFormatController : IDictionary<string, IFileFormatEditor> {
        private IDictionary<string, IFileFormatEditor> _editors;

        public ICollection<string> Keys => _editors.Keys;
        public ICollection<IFileFormatEditor> Values => _editors.Values;

        public int Count => _editors.Count;
        public bool IsReadOnly => _editors.IsReadOnly;

        public IFileFormatEditor this[string key] {
            get => _editors[key];
            set => _editors[key] = value;
        }

        public void Add(string key, IFileFormatEditor value) {
            _editors.Add(key, value);
        }
        public void Add(KeyValuePair<string, IFileFormatEditor> item) {
            _editors.Add(item);
        }

        public bool TryGetValue(string key, [MaybeNullWhen(false)] out IFileFormatEditor value) {
            return _editors.TryGetValue(key, out value);
        }
        public void CopyTo(KeyValuePair<string, IFileFormatEditor>[] array, int arrayIndex) {
            _editors.CopyTo(array, arrayIndex);
        }

        public bool Contains(KeyValuePair<string, IFileFormatEditor> item) {
            return _editors.Contains(item);
        }
        public bool ContainsKey(string key) {
            return _editors.ContainsKey(key);
        }

        public void Clear() {
            _editors.Clear();
        }
        public bool Remove(string key) {
            return _editors.Remove(key);
        }
        public bool Remove(KeyValuePair<string, IFileFormatEditor> item) {
            return _editors.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator() => _editors.GetEnumerator();
        public IEnumerator<KeyValuePair<string, IFileFormatEditor>> GetEnumerator() => _editors.GetEnumerator();
    }
}
