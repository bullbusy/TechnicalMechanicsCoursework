// Decompiled with JetBrains decompiler
// Type: OutToFile
// Assembly: kursach_calculate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42F045E3-CB35-4D03-BA75-CC6F9C6E6008
// Assembly location: C:\Users\Nazar\Documents\TelegramDownloads\kursach_calculate.exe

using System;
using System.IO;

public class OutToFile : IDisposable
{
  private StreamWriter fileOutput;
  private TextWriter oldOutput;

  public OutToFile(string outFileName)
  {
    this.oldOutput = Console.Out;
    this.fileOutput = new StreamWriter((Stream) new FileStream(outFileName, FileMode.Create));
    this.fileOutput.AutoFlush = true;
    Console.SetOut((TextWriter) this.fileOutput);
  }

  public void Dispose()
  {
    Console.SetOut(this.oldOutput);
    this.fileOutput.Close();
  }
}
