// Decompiled with JetBrains decompiler
// Type: Optrol.Theory.Systems.parameter
// Assembly: Optirol, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 00BF1D7A-FB0A-4D90-A8E1-A8B009A65C83
// Assembly location: C:\Users\tarab\OneDrive\Desktop\Optirol1.1\Optirol.exe

namespace Optrol.Theory.Systems
{
  internal class parameter
  {
    public double[] pars;
    public string name;

    public parameter(string txt)
    {
      string[] strArray = txt.Split(';');
      this.pars = new double[strArray.Length - 2];
      this.name = strArray[1];
      for (int index = 0; index < this.pars.Length; ++index)
        this.pars[index] = double.Parse(strArray[index + 2]);
    }
  }
}
