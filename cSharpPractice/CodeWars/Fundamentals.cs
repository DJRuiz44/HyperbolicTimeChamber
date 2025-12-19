using System;

namespace CodeWars
{
    public static class ReturnNegative
    {
        public static int Run()
        {
            int num = 5;
            //Console.WriteLine(-Math.Abs(num));
            return -Math.Abs(num);
        }
    }
    public static class BooleanToString
    {
        public static string Run(bool b)
        {
            return b.ToString();
        }
    }
    public static class DNAtoRNA
    {
        public static string Run(string dna)
        {
            string rna = "";
            for(int i = 0; i < dna.Length; i++){
               if(dna[i] == 'T'){
                rna += "U";
               }else{
                rna += dna[i];
               } 
            }
            return rna;
        }
    }
}