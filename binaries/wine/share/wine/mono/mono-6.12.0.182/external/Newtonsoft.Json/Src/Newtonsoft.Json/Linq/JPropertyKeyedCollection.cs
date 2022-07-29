﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Newtonsoft.Json.Linq
{
  internal class JPropertyKeyedCollection : Collection<JToken>
  {
    private static readonly IEqualityComparer<string> Comparer = StringComparer.Ordinal;

    private Dictionary<string, JToken> _dictionary;

    private void AddKey(string key, JToken item)
    {
      EnsureDictionary();
      _dictionary[key] = item;
    }

    protected void ChangeItemKey(JToken item, string newKey)
    {
      if (!ContainsItem(item))
        throw new ArgumentException("The specified item does not exist in this KeyedCollection.");

      string keyForItem = GetKeyForItem(item);
      if (!Comparer.Equals(keyForItem, newKey))
      {
        if (newKey != null)
          AddKey(newKey, item);

        if (keyForItem != null)
          RemoveKey(keyForItem);
      }
    }

    protected override void ClearItems()
    {
      base.ClearItems();

      if (_dictionary != null)
        _dictionary.Clear();
    }

    public bool Contains(string key)
    {
      if (key == null)
        throw new ArgumentNullException("key");

      if (_dictionary != null)
        return _dictionary.ContainsKey(key);

      return false;
    }

    private bool ContainsItem(JToken item)
    {
      if (_dictionary == null)
        return false;

      string key = GetKeyForItem(item);
      JToken value;
      return _dictionary.TryGetValue(key, out value);
    }

    private void EnsureDictionary()
    {
      if (_dictionary == null)
        _dictionary = new Dictionary<string, JToken>(Comparer);
    }

    private string GetKeyForItem(JToken item)
    {
      return ((JProperty)item).Name;
    }

    protected override void InsertItem(int index, JToken item)
    {
      AddKey(GetKeyForItem(item), item);
      base.InsertItem(index, item);
    }

    public bool Remove(string key)
    {
      if (key == null)
        throw new ArgumentNullException("key");

      if (_dictionary != null)
        return _dictionary.ContainsKey(key) && Remove(_dictionary[key]);

      return false;
    }

    protected override void RemoveItem(int index)
    {
      string keyForItem = GetKeyForItem(Items[index]);
      RemoveKey(keyForItem);
      base.RemoveItem(index);
    }

    private void RemoveKey(string key)
    {
      if (_dictionary != null)
        _dictionary.Remove(key);
    }

    protected override void SetItem(int index, JToken item)
    {
      string keyForItem = GetKeyForItem(item);
      string keyAtIndex = GetKeyForItem(Items[index]);

      if (Comparer.Equals(keyAtIndex, keyForItem))
      {
        if (_dictionary != null)
          _dictionary[keyForItem] = item;
      }
      else
      {
        AddKey(keyForItem, item);

        if (keyAtIndex != null)
          RemoveKey(keyAtIndex);
      }
      base.SetItem(index, item);
    }

    public JToken this[string key]
    {
      get
      {
        if (key == null)
          throw new ArgumentNullException("key");

        if (_dictionary != null)
          return _dictionary[key];

        throw new KeyNotFoundException();
      }
    }

    public bool TryGetValue(string key, out JToken value)
    {
      if (_dictionary == null)
      {
        value = null;
        return false;
      }

      return _dictionary.TryGetValue(key, out value);
    }

    public ICollection<string> Keys
    {
      get
      {
        EnsureDictionary();
        return _dictionary.Keys;
      }
    }

    public ICollection<JToken> Values
    {
      get
      {
        EnsureDictionary();
        return _dictionary.Values;
      }
    }
  }
}