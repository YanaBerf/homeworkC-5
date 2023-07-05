Console.Clear();
int[] arr = getMassiv(8);

int[] getMassiv(int size){
    int[] array = new int[size];
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(1, 29);
    }return array;
}
Console.WriteLine($"{String.Join(", ", arr)}");
