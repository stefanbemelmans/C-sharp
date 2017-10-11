using System;

//namespace RecipeConverter
//{


class Program
{
    //static void PrintRec(newrec)
    //{
    //    for (int i = 0; i < recipe.Length; i++)
    //    {
    //        Console.WriteLine(recipe[i] + "{0}", i < recipe.Length - 1 ? " " : "");
    //    }
    //    System.Console.WriteLine();
    //}

    static void Main(string[] args)

    {

        Console.WriteLine("Enter Number of Ingredients: ");
        int i = Convert.ToInt32(Console.ReadLine());

        Ingredients[] Ing_List = new Ingredients[i];

        for (int j = 0; j < i; j++)
        {
            Measurements.recipe[j] = Get_Ingredients(i);
        }

        Console.WriteLine("Enter Factor: ");
        int f = Convert.ToInt32(Console.ReadLine());

        Factor(Ing_List, f);
        foreach (var Ingredients in Ing_List)
        {
            Console.WriteLine(Ingredients.Ing_Name + " " + Ingredients.New_Amt);
        }

        Measurements(Ing.New_Amt, Ing.M_Ment);

    }

    
        
        //    if (New_Amt < recipe["G"])
        //    {
        //        if(New_Amt >= recipe["qt"])
        //        {
        //            i = New_Amt % recipe["qt"];

        //            q = New_Amt / recipe["qt"];

        //            if(i >= recipe["pt"])
        //            {
        //                p = i / recipe["pt"];

        //                i = i % recipe[pt];

        //                if(i > recipe["C"])
        //                {
        //                    c = i / recipe["C"];

        //                    i = i % recipe["C"];
        //                }

        //            }



        //        }
        //    }


        //}




    

    public static double Factor(Ingredients[] Ing_List, int f)
    {
        foreach(var Ingredients in Ing_List)
                 
      Ingredients.New_Amt = Ingredients.Ing_Amt * f;

        return Ingredients.New_Amt;
 
    }


    public static Ingredients Get_Ingredients(int i)
    {
        Ingredients Ing = new Ingredients();

        Console.WriteLine("Ingredient " + Ingredients.Ing_Num + ": ");
        Ing.Ing_Name = Console.ReadLine();

        Console.WriteLine("Amount: ");
        Ing.Ing_Amt = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter Measurement: ");
        Ing.M_Ment = Console.ReadLine();

        return Ing;
    }

  
public class Ingredients
{
    public string Ing_Name { get; set; }
    public double Ing_Amt { get; set; }
    public string M_Ment { get; set; }

    public static double New_Amt { get; set; }
    public string New_M_Ment { get; set; }
    public static int Ing_Num = 0;


    public Ingredients()
    
    { Ing_Num++;
            New_M_Ment = New_M_Ment;


        }



}

}

//ing_num++;
//Ing_Name = ing_Name;
//Ing_Amt = ing_Amt;
//M_Ment = m_Ment;
//int i = Ingredient.ing_num;












//Console.WriteLine("Enter Factor");
//factor = Convert.ToFloat(Console.ReadLine());

//new_amount = factor * ingr_amount;
//Console.WriteLine(new_amount);












