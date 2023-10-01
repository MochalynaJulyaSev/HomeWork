


def update_contact(data):
    user_input = input("Введите ФИО контакта для изменения данных: ")
    if user_input in data:
        new_number = input("Введите новый номер телефона: ")
        if new_number.isdigit():
            data[user_input] = new_number
            print("Данные обновленны.")
        else:
            print("Неверный формат номера!")
    else:
        print("Данные не найдены!")            


def delete_contact(data):
    user_input = input("Введите ФИО контакта для удаления данных: ")
    if user_input in data:
        del data[user_input]
        print("Данные удалены.")
    else:
        print("Данные не найдены!")



        
