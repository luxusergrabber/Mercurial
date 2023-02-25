// Decompiled with JetBrains decompiler
// Type: Mercurial.Program
// Assembly: Mercurial, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CE55527C-E5C8-48E5-83A1-C6805BBF517B
// Assembly location: C:\Users\thele\Downloads\Mercurial-Grabber-master\Mercurial-Grabber-master\Mercurial\Mercurial.exe

using System;
using System.Windows.Forms;

namespace Mercurial
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}
