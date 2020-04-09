// Decompiled with JetBrains decompiler
// Type: Optrol.Theory.Systems.variable
// Assembly: Optirol, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 00BF1D7A-FB0A-4D90-A8E1-A8B009A65C83
// Assembly location: C:\Users\tarab\OneDrive\Desktop\Optirol1.1\Optirol.exe

using System.Windows.Forms;

namespace Optrol.Theory.Systems
{
  internal class variable
  {
    public int line;
    public double min;
    public double max;
    public double controlTo;
    public bool anything;
    public int div;
    public string name;
    public equation eq;

    public string GetMatlabFunction(double[] pars)
    {
      return this.eq.GetMatlabFunction(pars);
    }

    public variable(string txt, int line)
    {
      string[] strArray = txt.Split(';');
      if (strArray.Length == 7)
      {
        this.name = strArray[1];
        if (strArray[2].CompareTo("*") == 0)
        {
          this.anything = true;
        }
        else
        {
          this.anything = false;
          this.controlTo = double.Parse(strArray[2]);
        }
        this.min = double.Parse(strArray[3]);
        this.max = double.Parse(strArray[4]);
        this.div = int.Parse(strArray[5]);
        this.eq = new equation(strArray[6]);
      }
      else
      {
        int num = (int) MessageBox.Show("Error in definition of variable " + txt + " on line " + (line + 1).ToString());
      }
    }
  }
}
