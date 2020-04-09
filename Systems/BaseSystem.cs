// Decompiled with JetBrains decompiler
// Type: Optrol.Theory.Systems.BaseSystem
// Assembly: Optirol, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 00BF1D7A-FB0A-4D90-A8E1-A8B009A65C83
// Assembly location: C:\Users\tarab\OneDrive\Desktop\Optirol1.1\Optirol.exe

namespace Optrol.Theory.Systems
{
  internal class BaseSystem
  {
    protected double[] mins;
    protected double[] maxs;
    protected int dimension;
    public int[] divPerDim;
    public double[] con_mins;
    public double[] con_maxs;
    protected int con_dimension;
    public int[] divPerDimCon;
    private int numAll;

    public double[] GetConMins()
    {
      return this.con_mins;
    }

    public double[] GetConMaxs()
    {
      return this.con_maxs;
    }

    public void SetAll()
    {
      this.numAll = 1;
      for (int index = 0; index < this.con_dimension; ++index)
        this.numAll *= this.divPerDimCon[index];
    }

    public int GetNumControls()
    {
      return this.numAll;
    }

    public void SetControl(int which, double[] con)
    {
      for (int index = 0; index < this.con_dimension; ++index)
      {
        con[index] = this.con_mins[index] + (double) (which % this.divPerDimCon[index]) * (this.con_maxs[index] - this.con_mins[index]) / ((double) this.divPerDimCon[index] - 1.0);
        which /= this.divPerDimCon[index];
      }
    }

    public int GetConDim()
    {
      return this.con_dimension;
    }

    public double[] GetMins()
    {
      return this.mins;
    }

    public double[] GetMaxs()
    {
      return this.maxs;
    }

    public int GetDimension()
    {
      return this.dimension;
    }

    public virtual void GetDerivative(
      double[] point,
      double[] control,
      double[] pars,
      double[] ret)
    {
    }
  }
}
