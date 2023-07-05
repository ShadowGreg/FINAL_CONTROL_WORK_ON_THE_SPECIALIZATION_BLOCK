# MySQL

6. Нарисовать диаграмму, в которой есть класс родительский класс, домашние

животные и вьючные животные, в составы которых в случае домашних

животных войдут классы: собаки, кошки, хомяки, а в класс вьючные животные

войдут: Лошади, верблюды и ослы).

```sql
Parent Class
|
---------------------------
|                         |
Domestic Animals    Draught Animals
|-Dogs                       |-Horses
|                            |
|-Cats                       |-Camels
|                            |
|-Hamsters                   |-Donkeys
```

7. В подключенном MySQL репозитории создать базу данных “Друзья человека”

```sql
CREATE DATABASE FriendsOfMan;
USE FriendsOfMan;
```

8. Создать таблицы с иерархией из диаграммы в БД

```sql
CREATE TABLE parent ( 
  id INT PRIMARY KEY, 
  name VARCHAR(50), 
  birth_date DATE 
);

CREATE TABLE dogs ( 
  id INT PRIMARY KEY, 
  name VARCHAR(50), 
  command VARCHAR(50), 
  birth_date DATE 
); 
 CREATE TABLE cats ( 
  id INT PRIMARY KEY, 
  name VARCHAR(50), 
  command VARCHAR(50), 
  birth_date DATE 
); 
 CREATE TABLE hamsters ( 
  id INT PRIMARY KEY, 
  name VARCHAR(50), 
  command VARCHAR(50), 
  birth_date DATE 
); 
 CREATE TABLE draft_animals ( 
  id INT PRIMARY KEY, 
  name VARCHAR(50), 
  birth_date DATE 
);

```

9. Заполнить низкоуровневые таблицы именами(животных), командами

которые они выполняют и датами рождения

```sql
INSERT INTO parent (id, name, birth_date) VALUES (1, 'Parent Animal', '2020-01-01'); 
 INSERT INTO dogs (id, name, command, birth_date) VALUES (1, 'Dog 1', 'Sit', '2019-05-10'); 
INSERT INTO dogs (id, name, command, birth_date) VALUES (2, 'Dog 2', 'Fetch', '2020-02-20'); 
 INSERT INTO cats (id, name, command, birth_date) VALUES (1, 'Cat 1', 'Meow', '2018-11-15'); 
INSERT INTO cats (id, name, command, birth_date) VALUES (2, 'Cat 2', 'Purr', '2019-07-25'); 
 INSERT INTO hamsters (id, name, command, birth_date) VALUES (1, 'Hamster 1', 'Run on Wheel', '2020-04-05'); 
INSERT INTO hamsters (id, name, command, birth_date) VALUES (2, 'Hamster 2', 'Eat Seeds', '2020-06-15'); 
 INSERT INTO draft_animals (id, name, birth_date) VALUES (1, 'Horse 1', '2017-09-12'); 
INSERT INTO draft_animals (id, name, birth_date) VALUES (2, 'Camel 1', '2016-03-20'); 
INSERT INTO draft_animals (id, name, birth_date) VALUES (3, 'Donkey 1', '2019-12-03');
```

10. Удалив из таблицы верблюдов, т.к. верблюдов решили перевезти в другой

питомник на зимовку. Объединить таблицы лошади, и ослы в одну таблицу.

```sql
DELETE FROM draft_animals WHERE name = 'Camel 1';

CREATE TABLE horses_and_donkeys AS 
SELECT * FROM draft_animals WHERE name LIKE 'Horse%' OR name LIKE 'Donkey%';
```

11.Создать новую таблицу “молодые животные” в которую попадут все

животные старше 1 года, но младше 3 лет и в отдельном столбце с точностью

до месяца подсчитать возраст животных в новой таблице

```sql
CREATE TABLE young_animals AS 
SELECT * FROM parent WHERE birth_date BETWEEN DATE_SUB(NOW(), INTERVAL 3 YEAR) AND DATE_SUB(NOW(), INTERVAL 1 YEAR);

CREATE TABLE young_animals AS 
SELECT * FROM parent WHERE birth_date BETWEEN DATE_SUB(NOW(), INTERVAL 3 YEAR) AND DATE_SUB(NOW(), INTERVAL 1 YEAR);
```

12. Объединить все таблицы в одну, при этом сохраняя поля, указывающие на

прошлую принадлежность к старым таблицам.

```sql
CREATE TABLE all_animals AS 
SELECT 'parent' AS table_name, id, name, birth_date, NULL AS command FROM parent 
UNION ALL 
SELECT 'dogs' AS table_name, id, name, birth_date, command FROM dogs 
UNION ALL 
SELECT 'cats' AS table_name, id, name, birth_date, command FROM cats 
UNION ALL 
SELECT 'hamsters' AS table_name, id, name, birth_date, command FROM hamsters 
UNION ALL 
SELECT 'horses_and_donkeys' AS table_name, id, name, birth_date, NULL AS command FROM horses_and_donkeys;
```