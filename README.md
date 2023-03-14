Решение задачи состоит из нескольких шагов:
1. Ввод массива через бесконечный цикл, окончанием ввода будет слово "end", сохранение слов в заранее выделенный массив по индексу
2. Запоминание количества введеных слов (переменная count)
3. Создание функции, которая принимает на вход введенный массив и количество введенных слов, и возвращает новый массив, содержащий слова, длинной меньше либо равной 3
4. Вывод массива через цикл

Алгоритм функции getFilteredArray:
1. Выделение памяти под новый массив
2. Проход по циклу от 0 до count
3. В теле цикла делаем проверку на длину текущего элемента массива
4. В случае если длина меньше или равна 3 то помешаем элемент в новый массив на первое свободное место (индекс изначально равен 0 и к нему плючуется 1 каждый раз, когда верно условие)
5. Возвращение нового массива