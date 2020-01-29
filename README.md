# Trivial.Utility
Nuget package library for utility methods

#### 🚀 Usage sample

``` C#
using Trivial.Utility.Grammar;

public class Test 
{
  static void Main(String[] args) 
    { 
        int errorNumber = 3;
        Console.WriteLine($"There are {errorNumber}" + Pluralize(errorNumber, "Error") + "found in your code");
        //output: There are 3 Errors found in your code
        
        
        //Taking a additional plural parameter to insertyour own plural word
        errorNumber = 1;
        Console.WriteLine($"There " + Pluralize(errorNumber, "is", "are") + $"{errorNumber} in code"); //Take an additional param
        //output: There is 1 error in code
        
        errorNumber = 6;
        Console.WriteLine($"There " + Pluralize(errorNumber, "is", "are") + $"{errorNumber} in code"); //Take an additional param
        //output: There are 6 error in code
        
        //Static Method available
        NumberOfGirls = 4;
        Console.WriteLine($"There " +"is".Pluralize(NumberOfGirls, "are")+ NumberOfGirls.ToString() +" "+ + "girl".Pluralize(NumberOfGirls) + in class"); //Take an additional param
        //output: There are 4 girls in class
        
    } 
}

```

#### ☹️ Limitation

By default Pluralize and singularize are only able to recognize regular plural and singular words
with 's'. For unregular words, consider using optional parameters to supply singular or plural word



