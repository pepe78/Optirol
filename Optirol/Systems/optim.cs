// Decompiled with JetBrains decompiler
// Type: Optrol.Theory.Systems.optim
// Assembly: Optirol, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 00BF1D7A-FB0A-4D90-A8E1-A8B009A65C83
// Assembly location: C:\Users\tarab\OneDrive\Desktop\Optirol1.1\Optirol.exe

using System.Windows.Forms;

namespace Optrol.Theory.Systems
{
  public class optim
  {
    public equation eq;
    public int _line;

    public optim(string txt, int line)
    {
      this._line = line;
      string[] strArray = txt.Split(';');
      if (strArray.Length == 2)
      {
        this.eq = new equation(strArray[1]);
      }
      else
      {
        int num = (int) MessageBox.Show("Error in definition of optim " + txt + " on line " + (line + 1).ToString());
      }
    }
  }
}
