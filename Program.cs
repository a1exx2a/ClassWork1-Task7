namespace Task7;

class Program
{
    static void Main(string[] args)
    {
        int[] x = {1,2,3,4,5,6,7,8,9,10};
        
        for (int i = 0; i < x.Length; i++){
            if (i%2 < 1){
                Console.WriteLine(x[i]);
            }
        }
    }
}
