﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
#if !NETFX_CORE
using NUnit.Framework;
#else
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFixture = Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute;
using Test = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
#endif
using Newtonsoft.Json.Linq;
#if NET20
using Newtonsoft.Json.Utilities.LinqBridge;
#else
using System.Linq;
#endif

namespace Newtonsoft.Json.Tests.Linq
{
  [TestFixture]
  public class JArrayTests : TestFixtureBase
  {
    [Test]
    public void Clear()
    {
      JArray a = new JArray { 1 };
      Assert.AreEqual(1, a.Count);

      a.Clear();
      Assert.AreEqual(0, a.Count);
    }

    [Test]
    public void AddToSelf()
    {
      JArray a = new JArray();
      a.Add(a);

      Assert.IsFalse(ReferenceEquals(a[0], a));
    }

    [Test]
    public void Contains()
    {
      JValue v = new JValue(1);

      JArray a = new JArray { v };

      Assert.AreEqual(false, a.Contains(new JValue(2)));
      Assert.AreEqual(false, a.Contains(new JValue(1)));
      Assert.AreEqual(false, a.Contains(null));
      Assert.AreEqual(true, a.Contains(v));
    }

    [Test]
    public void GenericCollectionCopyTo()
    {
      JArray j = new JArray();
      j.Add(new JValue(1));
      j.Add(new JValue(2));
      j.Add(new JValue(3));
      Assert.AreEqual(3, j.Count);

      JToken[] a = new JToken[5];

      ((ICollection<JToken>)j).CopyTo(a, 1);

      Assert.AreEqual(null, a[0]);

      Assert.AreEqual(1, (int)a[1]);

      Assert.AreEqual(2, (int)a[2]);

      Assert.AreEqual(3, (int)a[3]);

      Assert.AreEqual(null, a[4]);

    }

    [Test]
    [ExpectedException(typeof(ArgumentNullException)
#if !NETFX_CORE
      , ExpectedMessage = @"Value cannot be null.
Parameter name: array"
#endif
      )]
    public void GenericCollectionCopyToNullArrayShouldThrow()
    {
      JArray j = new JArray();
      ((ICollection<JToken>)j).CopyTo(null, 0);
    }

    [Test]
    [ExpectedException(typeof(ArgumentOutOfRangeException)
#if !NETFX_CORE
      , ExpectedMessage = @"arrayIndex is less than 0.
Parameter name: arrayIndex"
#endif
      )]
    public void GenericCollectionCopyToNegativeArrayIndexShouldThrow()
    {
      JArray j = new JArray();
      ((ICollection<JToken>)j).CopyTo(new JToken[1], -1);
    }

    [Test]
    [ExpectedException(typeof(ArgumentException)
#if !NETFX_CORE
      , ExpectedMessage = @"arrayIndex is equal to or greater than the length of array."
#endif
      )]
    public void GenericCollectionCopyToArrayIndexEqualGreaterToArrayLengthShouldThrow()
    {
      JArray j = new JArray();
      ((ICollection<JToken>)j).CopyTo(new JToken[1], 1);
    }

    [Test]
    [ExpectedException(typeof(ArgumentException)
#if !NETFX_CORE
      , ExpectedMessage = @"The number of elements in the source JObject is greater than the available space from arrayIndex to the end of the destination array."
#endif
      )]
    public void GenericCollectionCopyToInsufficientArrayCapacity()
    {
      JArray j = new JArray();
      j.Add(new JValue(1));
      j.Add(new JValue(2));
      j.Add(new JValue(3));

      ((ICollection<JToken>)j).CopyTo(new JToken[3], 1);
    }

    [Test]
    public void Remove()
    {
      JValue v = new JValue(1);
      JArray j = new JArray();
      j.Add(v);

      Assert.AreEqual(1, j.Count);

      Assert.AreEqual(false, j.Remove(new JValue(1)));
      Assert.AreEqual(false, j.Remove(null));
      Assert.AreEqual(true, j.Remove(v));
      Assert.AreEqual(false, j.Remove(v));

      Assert.AreEqual(0, j.Count);
    }

    [Test]
    public void IndexOf()
    {
      JValue v1 = new JValue(1);
      JValue v2 = new JValue(1);
      JValue v3 = new JValue(1);

      JArray j = new JArray();

      j.Add(v1);
      Assert.AreEqual(0, j.IndexOf(v1));

      j.Add(v2);
      Assert.AreEqual(0, j.IndexOf(v1));
      Assert.AreEqual(1, j.IndexOf(v2));

      j.AddFirst(v3);
      Assert.AreEqual(1, j.IndexOf(v1));
      Assert.AreEqual(2, j.IndexOf(v2));
      Assert.AreEqual(0, j.IndexOf(v3));

      v3.Remove();
      Assert.AreEqual(0, j.IndexOf(v1));
      Assert.AreEqual(1, j.IndexOf(v2));
      Assert.AreEqual(-1, j.IndexOf(v3));
    }

    [Test]
    public void RemoveAt()
    {
      JValue v1 = new JValue(1);
      JValue v2 = new JValue(1);
      JValue v3 = new JValue(1);

      JArray j = new JArray();

      j.Add(v1);
      j.Add(v2);
      j.Add(v3);

      Assert.AreEqual(true, j.Contains(v1));
      j.RemoveAt(0);
      Assert.AreEqual(false, j.Contains(v1));

      Assert.AreEqual(true, j.Contains(v3));
      j.RemoveAt(1);
      Assert.AreEqual(false, j.Contains(v3));

      Assert.AreEqual(1, j.Count);
    }

    [Test]
    [ExpectedException(typeof(ArgumentOutOfRangeException)
#if !NETFX_CORE
      , ExpectedMessage = @"Index is equal to or greater than Count.
Parameter name: index"
#endif
      )]
    public void RemoveAtOutOfRangeIndexShouldError()
    {
      JArray j = new JArray();
      j.RemoveAt(0);
    }

    [Test]
    [ExpectedException(typeof(ArgumentOutOfRangeException)
#if !NETFX_CORE
      , ExpectedMessage = @"Index is less than 0.
Parameter name: index"
#endif
      )]
    public void RemoveAtNegativeIndexShouldError()
    {
      JArray j = new JArray();
      j.RemoveAt(-1);
    }

    [Test]
    public void Insert()
    {
      JValue v1 = new JValue(1);
      JValue v2 = new JValue(2);
      JValue v3 = new JValue(3);
      JValue v4 = new JValue(4);

      JArray j = new JArray();

      j.Add(v1);
      j.Add(v2);
      j.Add(v3);
      j.Insert(1, v4);

      Assert.AreEqual(0, j.IndexOf(v1));
      Assert.AreEqual(1, j.IndexOf(v4));
      Assert.AreEqual(2, j.IndexOf(v2));
      Assert.AreEqual(3, j.IndexOf(v3));
    }

    [Test]
    public void AddFirstAddedTokenShouldBeFirst()
    {
      JValue v1 = new JValue(1);
      JValue v2 = new JValue(2);
      JValue v3 = new JValue(3);

      JArray j = new JArray();
      Assert.AreEqual(null, j.First);
      Assert.AreEqual(null, j.Last);

      j.AddFirst(v1);
      Assert.AreEqual(v1, j.First);
      Assert.AreEqual(v1, j.Last);

      j.AddFirst(v2);
      Assert.AreEqual(v2, j.First);
      Assert.AreEqual(v1, j.Last);

      j.AddFirst(v3);
      Assert.AreEqual(v3, j.First);
      Assert.AreEqual(v1, j.Last);
    }

    [Test]
    public void InsertShouldInsertAtZeroIndex()
    {
      JValue v1 = new JValue(1);
      JValue v2 = new JValue(2);

      JArray j = new JArray();

      j.Insert(0, v1);
      Assert.AreEqual(0, j.IndexOf(v1));

      j.Insert(0, v2);
      Assert.AreEqual(1, j.IndexOf(v1));
      Assert.AreEqual(0, j.IndexOf(v2));
    }

    [Test]
    public void InsertNull()
    {
      JArray j = new JArray();
      j.Insert(0, null);

      Assert.AreEqual(null, ((JValue)j[0]).Value);
    }

    [Test]
    [ExpectedException(typeof(ArgumentOutOfRangeException)
#if !NETFX_CORE
      , ExpectedMessage = @"Index was out of range. Must be non-negative and less than the size of the collection.
Parameter name: index"
#endif
      )]
    public void InsertNegativeIndexShouldThrow()
    {
      JArray j = new JArray();
      j.Insert(-1, new JValue(1));
    }

    [Test]
    [ExpectedException(typeof(ArgumentOutOfRangeException)
#if !NETFX_CORE
      , ExpectedMessage = @"Index must be within the bounds of the List.
Parameter name: index"
#endif
      )]
    public void InsertOutOfRangeIndexShouldThrow()
    {
      JArray j = new JArray();
      j.Insert(2, new JValue(1));
    }

    [Test]
    public void Item()
    {
      JValue v1 = new JValue(1);
      JValue v2 = new JValue(2);
      JValue v3 = new JValue(3);
      JValue v4 = new JValue(4);

      JArray j = new JArray();

      j.Add(v1);
      j.Add(v2);
      j.Add(v3);

      j[1] = v4;

      Assert.AreEqual(null, v2.Parent);
      Assert.AreEqual(-1, j.IndexOf(v2));
      Assert.AreEqual(j, v4.Parent);
      Assert.AreEqual(1, j.IndexOf(v4));
    }

    [Test]
    [ExpectedException(typeof(Exception)
#if !NETFX_CORE
      , ExpectedMessage = "Error reading JArray from JsonReader. Current JsonReader item is not an array: StartObject"
#endif
      )]
    public void Parse_ShouldThrowOnUnexpectedToken()
    {
      string json = @"{""prop"":""value""}";
      JArray.Parse(json);
    }

    public class ListItemFields
    {
      public string ListItemText { get; set; }
      public object ListItemValue { get; set; }
    }

    [Test]
    public void ArrayOrder()
    {
      string itemZeroText = "Zero text";

      IEnumerable<ListItemFields> t = new List<ListItemFields>
      {
        new ListItemFields { ListItemText = "First", ListItemValue = 1 },
        new ListItemFields { ListItemText = "Second", ListItemValue = 2 },
        new ListItemFields { ListItemText = "Third", ListItemValue = 3 }
      };

      JObject optionValues =
          new JObject(
              new JProperty("options",
                  new JArray(
                      new JObject(
                          new JProperty("text", itemZeroText),
                          new JProperty("value", "0")),
                          from r in t
                          orderby r.ListItemValue
                          select new JObject(
                              new JProperty("text", r.ListItemText),
                              new JProperty("value", r.ListItemValue.ToString())))));

      string result = "myOptions = " + optionValues.ToString();

      Assert.AreEqual(@"myOptions = {
  ""options"": [
    {
      ""text"": ""Zero text"",
      ""value"": ""0""
    },
    {
      ""text"": ""First"",
      ""value"": ""1""
    },
    {
      ""text"": ""Second"",
      ""value"": ""2""
    },
    {
      ""text"": ""Third"",
      ""value"": ""3""
    }
  ]
}", result);
    }

    [Test]
    public void Iterate()
    {
      JArray a = new JArray(1, 2, 3, 4, 5);

      int i = 1;
      foreach (JToken token in a)
      {
        Assert.AreEqual(i, (int)token);
        i++;
      }
    }

    
#if !SILVERLIGHT && !NETFX_CORE
    [Test]
    public void ITypedListGetItemProperties()
    {
      JProperty p1 = new JProperty("Test1", 1);
      JProperty p2 = new JProperty("Test2", "Two");
      ITypedList a = new JArray(new JObject(p1, p2));

      PropertyDescriptorCollection propertyDescriptors = a.GetItemProperties(null);
      Assert.IsNotNull(propertyDescriptors);
      Assert.AreEqual(2, propertyDescriptors.Count);
      Assert.AreEqual("Test1", propertyDescriptors[0].Name);
      Assert.AreEqual("Test2", propertyDescriptors[1].Name);
    }
#endif

    [Test]
    public void AddArrayToSelf()
    {
      JArray a = new JArray(1, 2);
      a.Add(a);

      Assert.AreEqual(3, a.Count);
      Assert.AreEqual(1, (int)a[0]);
      Assert.AreEqual(2, (int)a[1]);
      Assert.AreNotSame(a, a[2]);
    }

    [Test]
    [ExpectedException(typeof(ArgumentException)
#if !NETFX_CORE
      , ExpectedMessage = @"Set JArray values with invalid key value: ""badvalue"". Array position index expected."
#endif
      )]
    public void SetValueWithInvalidIndex()
    {
      JArray a = new JArray();
      a["badvalue"] = new JValue(3);
    }

    [Test]
    public void SetValue()
    {
      object key = 0;

      JArray a = new JArray((object)null);
      a[key] = new JValue(3);

      Assert.AreEqual(3, (int)a[key]);
    }

    [Test]
    public void ReplaceAll()
    {
      JArray a = new JArray(new [] { 1, 2, 3 });
      Assert.AreEqual(3, a.Count);
      Assert.AreEqual(1, (int)a[0]);
      Assert.AreEqual(2, (int)a[1]);
      Assert.AreEqual(3, (int)a[2]);

      a.ReplaceAll(1);
      Assert.AreEqual(1, a.Count);
      Assert.AreEqual(1, (int)a[0]);
    }

    [Test]
    [ExpectedException(typeof(Exception)
#if !NETFX_CORE
      , ExpectedMessage = "Unexpected end of content while loading JArray."
#endif
      )]
    public void ParseIncomplete()
    {
      JArray.Parse("[1");
    }

    [Test]
    public void InsertAddEnd()
    {
      JArray array = new JArray();
      array.Insert(0, 123);
      array.Insert(1, 456);

      Assert.AreEqual(2, array.Count);
      Assert.AreEqual(123, (int)array[0]);
      Assert.AreEqual(456, (int)array[1]);
    }

    [Test]
    [ExpectedException(typeof(JsonReaderException)
#if !NETFX_CORE
      , ExpectedMessage = "Additional text encountered after finished reading JSON content: ,. Line 5, position 2."
#endif
      )]
    public void ParseAdditionalContent()
    {
      string json = @"[
""Small"",
""Medium"",
""Large""
], 987987";

      JArray.Parse(json);
    }
  }
}