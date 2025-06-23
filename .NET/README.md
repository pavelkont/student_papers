# Информационная система «Диспетчер»: предложение и поиск строительной техники

## Предварительные требования

✔ .NET SDK (версия 6.0 или выше)  
✔ PostgreSQL (локально или удалённо)  
✔ (Опционально) Visual Studio 2022 или другой IDE для .NET  

## Настройка подключения к базе данных

✔ Откройте файл `appsettings.json`  
✔ Замените строку подключения в разделе `ConnectionStrings:DefaultConnection` на свои данные: database_name, your_user, your_password  

```json
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Port=5432;Database=database_name;Username=your_user;Password=your_password;Pooling=true;Minimum Pool Size=5;Maximum Pool Size=100;"
}
```
## Применение миграций

В терминале выполните:

```bash
cd VKR_Kontorin
dotnet tool install --global dotnet-ef
dotnet ef database update
```

## Запуск приложения

### Через Visual Studio

Откройте решение в Visual Studio и нажмите `F5` (или кнопку ▶️ «Запуск»). Приложение запустится в браузере автоматически.

### Через командную строку

Если используете терминал:

```bash
cd VKR_Kontorin
dotnet run
```

В консоли появится строка с адресом, например:

Now listening on: http://localhost:5058
Откройте этот адрес в браузере.

## Данные

Для примера проект заполнен данными  
Пароли для входа:  
✔ администратор  admin@mail.ru:Qqq!11  
✔ владелец       owner@mail.ru:Qqq!11  
✔ пользователь   user@mail.ru:Qqq!11  

## Руководство пользователя

Инструкция по работе с программой.pdf

