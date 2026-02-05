import math

if __name__ == '__main__':
    listik = [14, 32, 'lol', 'beb', 432, 'hi', '1313dsa', 'hi', 432, 1222]
    listik_unredacted = listik.copy()
    print(f"Текущий список: {listik}\n\nПредпоследний элемент в списке: {listik[-2]}\n")

    for i in range(3):
        a = int(input("Какой элемент списка вывести? "))
        if (len(listik) * -1) < a < len(listik):
            print(f"{a}-й элемент списка: {listik[a]}")
        else:
            print(f"Запрос не в диапозоне от {(len(listik) * -1)} до {len(listik)}")

    b = int(input("\nКакой элемент списка изменить? "))
    if (len(listik) * -1) < b < len(listik):
        c = input("Изменить на что? ")
        listik[b] = c
    else:
        print(f"Запрос не в диапозоне от {(len(listik) * -1)} до {len(listik)}")

    aa = int(input("\nВведите диапозон вывода элементов списка: "))
    bb = int(input())
    print(f"Элементы списка в диапозоне [{min(aa, bb)}, {max(aa, bb)}]")
    for i in range(len(listik)):
        if min(aa, bb) <= i <= max(aa, bb):
            print(listik[i])

    aaa = input("\nЧто добавить в список?? ")
    listik.append(aaa)

    bbb = input("\nЧто добавить в середину списка? ")
    listik.insert(math.floor(len(listik)/2), bbb)

    aaaa = input("\nЧто найти в списке? ")
    count = 0
    for i in range(len(listik)):
        if listik[i] == aaaa or listik[i] == int(aaaa):
            count += 1
    print(f"Количество найденных совпадений: {count}")

    print(f"\nСравнение списков\nНеизменённая версия: {listik_unredacted}\nИзменённая версия: {listik}")