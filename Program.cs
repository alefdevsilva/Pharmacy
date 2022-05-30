using System.Diagnostics;
namespace Pharmacy
{
    class Program{
        static void Main(string[] args){
               string path = @"C:\Users\DELL\Documents\endereco.txt";
               StreamReader sr = null;
               string line = "";
               try{
                 sr = File.OpenText(path);
                 while(!sr.EndOfStream){
                       line = sr.ReadLine();
                      Console.WriteLine(line);
                 }
               }
               catch(IOException e){
                  System.Console.WriteLine("An Error occured");
                  System.Console.WriteLine(e.Message);
               }
               finally{
                 if(sr != null) sr.Close();
       }
       Process firefox = new Process();
       firefox.StartInfo.FileName = "c:\\Program Files\\Mozilla Firefox\\firefox.exe";
       firefox.StartInfo.Arguments = "google.com/" + "search?q=" + line;
       firefox.Start(); 
    }
 }
}