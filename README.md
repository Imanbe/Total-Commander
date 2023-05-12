# Total Commander - Файловый менеджер (аналог)
## Техническое задание:
    1. Окно состоит из двух частей. В каждой части отображается список файлов и каталогов выбранной директории. Навигация по каталогам в каждой половине происходить независимо от другой половины.
    2. Для двух частей есть общая панель инструментов: создать файл, создать директорию, удалить, скопировать, переименовать. В каждой части наверху отображается адресная строка, содержащая полный путь к текущей директории.
    3. При двойном щелчке на имени каталога, происходит открытие содержимого этого каталога. При двойном щелчке на имени файла, происходит открытие этого файла.
    4. Предусмотреть контекстное меню: создать, удалить, переименовать, скопировать, просмотреть свойства файла (дополнительно: сжать файл в архив).
    5. Предусмотреть возможность персональной настройки программы: цветовая схема, размер отображения шрифта, директория по умолчанию.
    6. Для разворачивания программы на компьютере использовать возможность ClickOnce.
## Особенности:
    1. Копирование. Разрешить копировать один файл, группу выделенных файлов. При копировании директории копировать ее вместе со всем содержимым. Копирование происходит в директорию, активную во второй половине окна.
    2. Удаление. При удалении директории удалять все ее содержимое. Перед удалением уточнить, действительно ли надо удалять.
    3. Копирование, удаление и сжатие в архив реализовать в отдельном потоке, чтобы пока идет процесс копирования/удаления/сжатия программа реагировала на действия пользователя.
