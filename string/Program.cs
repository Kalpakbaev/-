
string[] Array(){
Random myRandom = new Random();
string [] array = new string[3];
for(int i = 0; i < array.Length; i++){
    Console.WriteLine("Введите слово");
     array[i] = Convert.ToString(Console.ReadLine());
}
return array;
}
void ShowArray(string[] array){
 for(int i = 0 ; i < array.Length; i++){
    Console.Write($"{array[i]}, ");
 }
}
ShowArray(Array());