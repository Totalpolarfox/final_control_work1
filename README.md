# GeekBrains
## Разработчик. Основной блок.
### Итоговая контрольная работа по основному блоку
---
Программа, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
---
Файл алгоритма **algorithm.pdf**

У пользователя запрашивается количессто элементов будущего массива.</br>
Рeзультат сохраняем в переменной length.</br>

Метод CreateArray (аргументом передается переменная length (длина масссива):</br>
Создаем одномерный строковый массив с длиной массива length.</br>
С помощью цикла for заполняем массив строковыми данными, которые вводит пользователь.</br>

Метод FindElementArray (аргументом передается начальный массив):</br>
С помощью цикла for производим в начальном массиве поиск количества элементов, длина которых меньше, либо равна 3 символам.</br>
Результат записываем в переменную count.</br>
Создаем новый строковый массив newArray с длиной массива count.</br>
С помощью цикла for производим копирование элементов начального массива, длина которых меньше, либо равна 3 символам, в новый массив.</br>

Запускаем действия:</br>
FindElementArray(CreateArray(length))</br>
