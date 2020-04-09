// Decompiled with JetBrains decompiler
// Type: Optrol.Theory.Systems.control
// Assembly: Optirol, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 00BF1D7A-FB0A-4D90-A8E1-A8B009A65C83
// Assembly location: C:\Users\tarab\OneDrive\Desktop\Optirol1.1\Optirol.exe

using System.Windows.Forms;

namespace Optrol.Theory.Systems
{
  internal class control
  {
    public double min;
    public double max;
    public int div;
    public string name;

    public control(string txt, int line)
    {
      string[] strArray = txt.Split(';');
      if (strArray.Length == 5)
      {
        this.name = strArray[1];
        this.min = double.Parse(strArray[2]);
        this.max = double.Parse(strArray[3]);
        this.div = int.Parse(strArray[4]);
      }
      else
      {
        int num = (int) MessageBox.Show("Error in definition of control " + txt + " on line " + (line + 1).ToString());
      }
    }
  }
}
