-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2025. Sze 19. 12:00
-- Kiszolgáló verziója: 10.4.32-MariaDB
-- PHP verzió: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `library`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `cars`
--

CREATE TABLE `cars` (
  `id` int(11) NOT NULL,
  `brand` varchar(60) DEFAULT NULL,
  `type` varchar(70) DEFAULT NULL,
  `mDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `cars`
--

INSERT INTO `cars` (`id`, `brand`, `type`, `mDate`) VALUES
(1, 'Dodge', 'Caravan', '2025-06-29'),
(2, 'Subaru', 'Alcyone SVX', '2025-07-02'),
(3, 'Chevrolet', 'Malibu', '2025-02-03'),
(4, 'Lamborghini', 'Murciélago', '2025-04-03'),
(5, 'Toyota', 'Prius', '2025-08-22'),
(6, 'Land Rover', 'Range Rover', '2025-09-03'),
(7, 'Lexus', 'ES', '2024-12-05'),
(8, 'Nissan', 'Xterra', '2025-06-06'),
(9, 'Ford', 'E150', '2025-08-09'),
(10, 'GMC', '3500', '2024-12-19'),
(11, 'Ford', 'F-250 Super Duty', '2025-05-29'),
(12, 'Chevrolet', 'Tahoe', '2025-09-14'),
(13, 'Pontiac', 'LeMans', '2024-10-02'),
(14, 'Kia', 'Soul', '2025-02-01'),
(15, 'Geo', 'Prizm', '2025-05-18'),
(16, 'Chrysler', 'Sebring', '2025-06-02'),
(17, 'BMW', '650', '2025-01-03'),
(18, 'GMC', 'Acadia', '2024-10-11'),
(19, 'Volkswagen', 'Eos', '2025-08-14'),
(20, 'Mercury', 'Villager', '2025-01-16');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `cars`
--
ALTER TABLE `cars`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `cars`
--
ALTER TABLE `cars`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
