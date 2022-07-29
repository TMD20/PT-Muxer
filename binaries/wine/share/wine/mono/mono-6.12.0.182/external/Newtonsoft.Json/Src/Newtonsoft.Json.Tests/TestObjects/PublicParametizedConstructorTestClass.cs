﻿namespace Newtonsoft.Json.Tests.TestObjects
{
  public class PublicParametizedConstructorTestClass
  {
    private readonly string _name;

    public PublicParametizedConstructorTestClass(string name)
    {
      _name = name;
    }

    public string Name
    {
      get { return _name; }
    }
  }
}
