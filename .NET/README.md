# Информационная система «Диспетчер»: предложение и поиск строительной техники

## Предварительные требования

✔ .NET SDK (версия 6.0 или выше)  
✔ PostgreSQL (локально или удалённо)  
✔ (Опционально) Visual Studio 2022 или другой IDE для .NET  

## Настройка подключения к базе данных

✔ Откройте файл `appsettings.json`.

✔ Замените строку подключения в разделе `ConnectionStrings:DefaultConnection` на свои данные:

```json
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Port=5432;Database=database_name;Username=your_user;Password=your_password;Pooling=true;Minimum Pool Size=5;Maximum Pool Size=100;"
}
```

## Применение миграций

В терминале выполните:

```bash
dotnet tool install --global dotnet-ef
dotnet ef database update
```

## Запуск приложения

В терминале или через IDE выполните:

```bash
dotnet run
```