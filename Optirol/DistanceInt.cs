// Decompiled with JetBrains decompiler
// Type: Optrol.Theory.DistanceInt
// Assembly: Optirol, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 00BF1D7A-FB0A-4D90-A8E1-A8B009A65C83
// Assembly location: C:\Users\tarab\OneDrive\Desktop\Optirol1.1\Optirol.exe

namespace Optrol.Theory
{
  internal class DistanceInt
  {
    public double dist;
    public int id;

    public DistanceInt(double _dist, int _id)
    {
      this.dist = _dist;
      this.id = _id;
    }

    public static int CompareByDistance(DistanceInt x, DistanceInt y)
    {
      if (x == null)
        return y == null ? 0 : -1;
      if (y == null)
        return 1;
      if (x.dist < y.dist)
        return -1;
      return x.dist > y.dist ? 1 : 0;
    }
  }
}
