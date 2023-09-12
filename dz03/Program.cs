/*
num_A
num_B
*/

int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
Console.WriteLine($"Натуральная степень = {Degree(A, B)}");
int Degree(int num_A, int num_B)
{
    int result = 0;
    for (int i = 1; num_B > i; i++)
    {
        result = num_A * num_B;
        i++;
    }
    return result;
}
