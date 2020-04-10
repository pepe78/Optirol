// Decompiled with JetBrains decompiler
// Type: Optrol.Theory.Point
// Assembly: Optirol, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 00BF1D7A-FB0A-4D90-A8E1-A8B009A65C83
// Assembly location: C:\Users\tarab\OneDrive\Desktop\Optirol1.1\Optirol.exe

using System.Collections.Generic;

namespace Optrol.Theory
{
  public class Point
  {
    public double Energy;
    public int id;
    public double[] optCon;
    public List<int> neighbours;
    public double ErrorEstimation;

    public Point(int _id)
    {
      this.Energy = double.PositiveInfinity;
      this.id = _id;
    }
  }
}
