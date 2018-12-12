--
-- Скрипт сгенерирован Devart dbForge Studio for MySQL, Версия 6.3.358.0
-- Домашняя страница продукта: http://www.devart.com/ru/dbforge/mysql/studio
-- Дата скрипта: 12.12.2018 14:50:28
-- Версия сервера: 5.0.67-community-nt
-- Версия клиента: 4.1
--


-- 
-- Отключение внешних ключей
-- 
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;

-- 
-- Установить режим SQL (SQL mode)
-- 
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- 
-- Установка базы данных по умолчанию
--
USE vrachi;

--
-- Описание для таблицы notes
--
DROP TABLE IF EXISTS notes;
CREATE TABLE notes (
  Id INT(11) NOT NULL AUTO_INCREMENT,
  PacientId INT(11) DEFAULT NULL,
  SotrudnikId INT(11) DEFAULT NULL,
  NoteTime DATETIME DEFAULT NULL,
  PRIMARY KEY (Id)
)
ENGINE = INNODB
AUTO_INCREMENT = 3
AVG_ROW_LENGTH = 8192
CHARACTER SET cp1251
COLLATE cp1251_general_ci;

--
-- Описание для таблицы pacients
--
DROP TABLE IF EXISTS pacients;
CREATE TABLE pacients (
  Id INT(11) NOT NULL DEFAULT 0,
  FullName VARCHAR(50) DEFAULT NULL,
  Address VARCHAR(255) DEFAULT NULL,
  PRIMARY KEY (Id)
)
ENGINE = INNODB
AVG_ROW_LENGTH = 16384
CHARACTER SET cp1251
COLLATE cp1251_general_ci;

--
-- Описание для таблицы sotrudniki
--
DROP TABLE IF EXISTS sotrudniki;
CREATE TABLE sotrudniki (
  Id INT(11) NOT NULL AUTO_INCREMENT,
  FullName VARCHAR(50) DEFAULT NULL,
  Specialization VARCHAR(255) DEFAULT NULL,
  CabNumber VARCHAR(255) DEFAULT NULL,
  WorkStart DATETIME DEFAULT NULL,
  WorkEnd DATETIME DEFAULT NULL,
  PRIMARY KEY (Id)
)
ENGINE = INNODB
AUTO_INCREMENT = 6
AVG_ROW_LENGTH = 8192
CHARACTER SET cp1251
COLLATE cp1251_general_ci;

-- 
-- Вывод данных для таблицы notes
--
INSERT INTO notes VALUES
(1, 0, 4, '2018-12-12 08:00:00'),
(2, 0, 5, '1111-11-11 11:11:00');

-- 
-- Вывод данных для таблицы pacients
--
INSERT INTO pacients VALUES
(0, '444', '4444');

-- 
-- Вывод данных для таблицы sotrudniki
--
INSERT INTO sotrudniki VALUES
(4, 'Степан', 'Хирург', '3-22', '2018-12-12 10:00:00', '2018-12-12 16:00:00'),
(5, 'Иван', 'Трамватолог', '3-23', '2018-12-12 10:00:00', '2018-12-12 16:00:00');

-- 
-- Восстановить предыдущий режим SQL (SQL mode)
-- 
/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;

-- 
-- Включение внешних ключей
-- 
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;