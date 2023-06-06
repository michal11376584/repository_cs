CREATE DATABASE `hurtownia`;
USE `hurtownia`;

CREATE TABLE `klienci` (
  `id` int(10) UNSIGNED NOT NULL,
  `Typy_id` int(10) UNSIGNED NOT NULL,
  `imie` text DEFAULT NULL,
  `nazwisko` text DEFAULT NULL,
  `zdjecie` varchar(20) DEFAULT NULL,
  `punkty` int(10) UNSIGNED DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

INSERT INTO `klienci` (`id`, `Typy_id`, `imie`, `nazwisko`, `zdjecie`, `punkty`) VALUES
(1, 2, 'Anna', 'Kowalska', 'anna.jpg', 2000),
(2, 2, 'Ewa', 'Nowakowska', 'ewa.jpg', 2045),
(3, 1, 'Krystyna', 'Nowakowska', 'krycha.jpg', 100),
(4, 3, 'Jan', 'Nowak', 'janek.jpg', 3305),
(5, 2, 'John', 'Smith', 'john.jpg', 2005),
(6, 3, 'Judy', 'Beck', 'judy.jpg', 3055),
(7, 1, 'Marcin', 'Kowalski', 'marcin.jpg', 1045),
(8, 1, 'Kris', 'Smith', 'Kris.jpg', 0),
(9, 1, 'Jacek', 'Jackowski', 'jacek.jpg', 45);

ALTER TABLE `klienci`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `klienci`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;