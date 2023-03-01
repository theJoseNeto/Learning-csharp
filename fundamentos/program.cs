using System; 

class aula05 {
    static void Main(){
        // operadores: 

        int sum = 10 + 5 * 2; // 20
        int sum2 = (10 + 5) * 2; // 30
        
       // operadores relacionais --> "!=", "==", "<", ">", "=>", "=<"
        bool exe1 = 20 > 10; // True
        bool exe2 = 30 < 20; // False
        bool exe3 = 10 == 10; // True
        bool exe4 = 10 != 5; // True

        // operadores de incremento e decremento 
        int num1 = 1;
        int num2 = 1;
        int num3 = 2;
        int incr1 = num++; // num = 2;  
        int decr1 = num2--; // num = 0; 
        int incr2 = num1+=1; // num+=1 = num = num + 1 = num++; 
        int multIncr = num1 *= 10; // 


        // --------------------------------------------------------------

        // E / OU --> && / |

        bool qualquerCoisa = 5 > 10 | 3 < 2; // False 
        bool a = 5 > 3 | 30 < 1234; // true 
        bool b = 5 + 5 == 10 && 3 * 7 == 23; // False
        bool c = 5 + 5 == 10 && 3 * 7 == 21; // True

        

    }
}