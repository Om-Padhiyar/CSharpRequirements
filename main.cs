using System;
using System.Collections.Generic;

class Program{
  
  static void Main(string[] args)
  {
    
//Array
    float[] Array = new float[] {1.3f, 1.4f, 1.5f};
    {
      
      Console.WriteLine (Array[0]);
      Console.WriteLine (Array[1]);
      Console.WriteLine (Array[2]);
    }
    
  //List
    List<string> numbers = new List<string>();
    numbers.Add("10");
    numbers.Add("20");
    numbers.Add("30");
    
    for(int i=0; i<numbers.Count; i++){
      Console.WriteLine(numbers[i]);
    }

    //Function
    bool Bool(int type)
    {
      if (type > 7){
        return true;
      }
      else{
        return false;
      }
    }
    bool Number = Bool(7);
    Console.WriteLine(Number);
  }

}

