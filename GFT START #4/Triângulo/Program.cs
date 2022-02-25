using System; 

class Dio {
    static void Main(string[] args) { 
        double a, b, c;
        string[] valor = Console.ReadLine().Split();
        
        a = Convert.ToDouble(valor[0]);
        b = Convert.ToDouble(valor[1]);
        c = Convert.ToDouble(valor[2]);

        if((a<b+c) && (b<a+c) && (c<a+b)) {
            double p = a + b + c;

            Console.WriteLine("Perimetro = {0:0.0}", p);
        } else {
            double area = ((a + b) * c) / 2;

            Console.WriteLine("Area = {0:0.0}", area);
        }
    }
}