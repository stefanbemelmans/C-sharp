using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipeConverter;
using System.Collections;

namespace RecipeConverter {
    class Program {

        public IList Measurements(string M_Ment, double New_Amt)
    {
              
       List<Tuple<string, int>> Vol = new List<Tuple<string, int>>();

            Vol.Add(Tuple.Create("g", 128));
            Vol.Add(Tuple.Create("qt", 32));
            Vol.Add(Tuple.Create("pt", 16));
            Vol.Add(Tuple.Create("C", 8));

            
           List<Tuple<string, int>> New_Recipe = new List<Tuple<string, int>>();

            int i = 0;

            while (New_Amt > 8)
            {
                if (New_Amt%Vol[i].Item2 == New_Amt)
                 {
                     i++;
                 }
                
                New_Recipe.Add(Tuple.Create(Vol[i].Item1, Convert.ToInt32(New_Amt / Vol[i].Item2)));  
                
                New_Amt = New_Amt % Vol[i].Item2;  

            }

            return New_Recipe;
        }

        

        

        //Dictionary<string, double> recipe = new Dictionary<string, double>();
        string z = "z";
        //string t = "t";
        //string T = "T";
        string C = "C";
        string pt = "pt";
        string qt = "qt";
        string G = "G";
        string ea = "ea";
        int q = 32;
        int p = 16;
        int c = 8;
        double T = .5;
        double t = 0.166667;
        int GG = 128;
        double i;
        int hc = 4;
        int qc = 2;
        //recipe.Add(z, 1);
        //recipe.Add(t, 0.166667);
        //recipe.Add(T, .5);
        //recipe.Add(C, 8);
        //recipe.Add(pt, 16);
        //recipe.Add(qt, 32);
        //recipe.Add(G, 128);
        double j;
        //int[] recipe; recipe = new int[7] { 128, 32, 16, 8, 6, 4, 2 };

        

    }

}



