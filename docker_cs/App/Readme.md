## Создание приложения Докер

- dotnet new console -o App -n NetCore.Docker.

## Публикация приложения .NET Core

- dotnet publish -c Release
  (Эта команда компилирует приложение и помещает результат в папку publish. Путь к папке publish из рабочей папки должен быть таким: .\App\bin\Release\net5.0\publish\)

## Создание образа

- docker build -t counter-image -f Dockerfile .

## Dockerfile

- FROM mcr.microsoft.com/dotnet/sdk:6.0
- COPY bin/Release/net6.0/publish/ App/
- WORKDIR /App
- ENV DOTNET_EnableDiagnostics=0
- ENTRYPOINT ["dotnet", "NetCore.Docker.dll"]

## Просмотр образов

- docker images

## Создание контейнера

- docker create --name core-counter counter-image

## Чтобы просмотреть список всех контейнеров, воспользуйтесь командой :

- docker ps -a

## Запуск

- docker start core-counter
- docker ps (Для запущенных)

## Подключение к контейнеру

- docker attach --sig-proxy=false core-counter

Параметр --sig-proxy=false гарантирует, что команда, вызываемая нажатием клавиш CTRL+C, не остановит процесс в контейнере.

## Остановка контейнера

- docker stop core-counter

## Удаление контейнера

- docker rm core-counter

## Однократный запуск

- docker run

Она исключает необходимость в поочередном выполнении команд docker create и docker start.

- docker run -it --rm

выполняет две операции. Сначала она автоматически подключается к контейнеру с помощью текущего терминала, а потом, после завершения работы контейнера, удаляет его

- docker run -it --rm counter-image 3

Для передачи параметра в контенер
