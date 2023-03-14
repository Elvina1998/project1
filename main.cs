string[] getFilteredArray(string[] array, int count) {
  string[] filteredArray = new string[100];
  int i = 0; 
  for (int j = 0; j < count; j++) {
    if (array[j].Length <= 3) {
      filteredArray[i] = array[j];
      i++;
    }
  }
  return filteredArray;
}

string[] array = new string[100];
int i = 0; 
string test;
int count = 0;

do {
  test = Console.ReadLine();
  if (test == "end") break;
  array[i] = test;
  i++;
  count++;
} while (true);

string[] filteredArray = getFilteredArray(array, count);

Console.WriteLine("Отфильтрованный массив: ");
for (int j = 0; j < count; j++) {
    Console.Write(filteredArray[j] + " ");
}