# GeekFinalHome - I четверть

## Задача

  Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. <br>
  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. <br>
  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. <br>

### 1. Алгоритм

  В самом начале необходимо посчитать количество элементов в введенной строке для формирования массива. <br>
  Так как в примере указано, что элемент может содержать пробел, то будем считать, что каждый элемент разделен запятой " , ". <br>
  Далее проходим по каждому элементу строки как по массиву. При нахождении " , " инкрементим счетчик. <br>
  Создаем искомый массив  
